using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using Alien_Isolation_Mod_Manager;

public class Example
{
    public class Node
    {
    }

    public class Dto
    {
        public Dto(string filePath, byte[] data, /*FileInfo file = null,*/ string relativePath = null, string md5 = null)
        {
            FilePath = filePath;
            //if (file is null) File = new FileInfo(filePath);
            //else File = file;
            if (relativePath != null) RelativePath = relativePath;
            else RelativePath = filePath.Substring(Environment.CurrentDirectory.Length + 1);
            if (md5 != null) MD5 = md5;
            Data = data;
        }
        public string FilePath { get; }
        public byte[] Data { get; }

        // public FileInfo File { get; set; }
        public string RelativePath { get; set; }

        public string MD5 { get; set; }
    }

    public async Task ProcessFiles(string path, IProgress<ProgressReport> progress, RichTextBox txt_description)
    {
        int totalFilesFound = 0;
        int totalFilesRead = 0;
        int totalFilesHashed = 0;
        int totalFilesUploaded = 0;

        DateTime lastReported = DateTime.UtcNow;

        void ReportProgress()
        {
            if (DateTime.UtcNow - lastReported < TimeSpan.FromSeconds(1)) //Try to fire only once a second, but this code is not perfect so you may get a few rapid fire.
            {
                return;
            }
            lastReported = DateTime.UtcNow;
            var report = new ProgressReport(totalFilesFound, totalFilesRead, totalFilesHashed, totalFilesUploaded);
            progress.Report(report);
        }

        var getFilesBlock = new TransformBlock<string, Dto>(filePath =>
        {
            var dto = new Dto(filePath, File.ReadAllBytes(filePath));
            totalFilesRead++; //safe because single threaded.
            return dto;
        });

        var hashFilesBlock = new TransformBlock<Dto, Dto>(inDto =>
            {
                using (var md5 = System.Security.Cryptography.MD5.Create())
                {
                    var hash = md5.ComputeHash(inDto.Data);
                    var outDto = new Dto(inDto.FilePath, hash, inDto.RelativePath, BitConverter.ToString(hash).Replace("-", ""));
                    Interlocked.Increment(ref totalFilesHashed); //Need the interlocked due to multithreaded.
                    ReportProgress();
                    return outDto;
                }
            },
            new ExecutionDataflowBlockOptions { MaxDegreeOfParallelism = Environment.ProcessorCount, BoundedCapacity = 50 });
        var writeToDatabaseBlock = new ActionBlock<Dto>(arg =>
            {
                //Write to database here.
                txt_description.AppendLine($"{arg.RelativePath} ({arg.MD5})");
                // Main.AppendText(arg.FilePath);
                totalFilesUploaded++;
                ReportProgress();
            },
            new ExecutionDataflowBlockOptions { BoundedCapacity = 50 });

        getFilesBlock.LinkTo(hashFilesBlock, new DataflowLinkOptions { PropagateCompletion = true });
        hashFilesBlock.LinkTo(writeToDatabaseBlock, new DataflowLinkOptions { PropagateCompletion = true });

        foreach (var filePath in Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories))
        {
            await getFilesBlock.SendAsync(filePath).ConfigureAwait(false);
            totalFilesFound++;
            ReportProgress();
        }

        getFilesBlock.Complete();

        await writeToDatabaseBlock.Completion.ConfigureAwait(false);
        ReportProgress();
    }
}

public class ProgressReport
{
    public ProgressReport(int totalFilesFound, int totalFilesRead, int totalFilesHashed, int totalFilesUploaded)
    {
        TotalFilesFound = totalFilesFound;
        TotalFilesRead = totalFilesRead;
        TotalFilesHashed = totalFilesHashed;
        TotalFilesUploaded = totalFilesUploaded;
    }

    public int TotalFilesFound { get; }
    public int TotalFilesRead { get; }
    public int TotalFilesHashed { get; }
    public int TotalFilesUploaded { get; }
}