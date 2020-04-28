namespace Alien_Isolation_Mod_Manager
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lst_mods = new System.Windows.Forms.DataGridView();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_revert = new System.Windows.Forms.Button();
            this.tabs_configs = new System.Windows.Forms.TabControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMD5TreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txt_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.bar_progress = new System.Windows.Forms.ToolStripProgressBar();
            this.steamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.lst_mods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_mods
            // 
            this.lst_mods.AllowUserToAddRows = false;
            this.lst_mods.AllowUserToDeleteRows = false;
            this.lst_mods.AllowUserToResizeColumns = false;
            this.lst_mods.AllowUserToResizeRows = false;
            this.lst_mods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lst_mods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_mods.ColumnHeadersVisible = false;
            this.lst_mods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_mods.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.lst_mods.Location = new System.Drawing.Point(0, 0);
            this.lst_mods.MultiSelect = false;
            this.lst_mods.Name = "lst_mods";
            this.lst_mods.ReadOnly = true;
            this.lst_mods.RowHeadersVisible = false;
            this.lst_mods.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.lst_mods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lst_mods.Size = new System.Drawing.Size(315, 489);
            this.lst_mods.TabIndex = 0;
            this.lst_mods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_mods_CellClick);
            // 
            // txt_description
            // 
            this.txt_description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_description.Location = new System.Drawing.Point(12, 40);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(596, 392);
            this.txt_description.TabIndex = 1;
            this.txt_description.Text = "";
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.Location = new System.Drawing.Point(540, 454);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 2;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(433, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_revert
            // 
            this.btn_revert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_revert.Location = new System.Drawing.Point(12, 454);
            this.btn_revert.Name = "btn_revert";
            this.btn_revert.Size = new System.Drawing.Size(75, 23);
            this.btn_revert.TabIndex = 4;
            this.btn_revert.Text = "Revert";
            this.btn_revert.UseVisualStyleBackColor = true;
            this.btn_revert.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabs_configs
            // 
            this.tabs_configs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs_configs.Location = new System.Drawing.Point(12, 12);
            this.tabs_configs.Multiline = true;
            this.tabs_configs.Name = "tabs_configs";
            this.tabs_configs.SelectedIndex = 0;
            this.tabs_configs.Size = new System.Drawing.Size(603, 22);
            this.tabs_configs.TabIndex = 5;
            this.tabs_configs.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabs_configs_Selected);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lst_mods);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txt_description);
            this.splitContainer1.Panel2.Controls.Add(this.tabs_configs);
            this.splitContainer1.Panel2.Controls.Add(this.btn_revert);
            this.splitContainer1.Panel2.Controls.Add(this.btn_apply);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Size = new System.Drawing.Size(946, 489);
            this.splitContainer1.SplitterDistance = 315;
            this.splitContainer1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.steamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMD5TreeToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // createMD5TreeToolStripMenuItem
            // 
            this.createMD5TreeToolStripMenuItem.Name = "createMD5TreeToolStripMenuItem";
            this.createMD5TreeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.createMD5TreeToolStripMenuItem.Text = "Create MD5 tree";
            this.createMD5TreeToolStripMenuItem.Click += new System.EventHandler(this.createMD5TreeToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_status,
            this.bar_progress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 519);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(946, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txt_status
            // 
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(0, 17);
            // 
            // bar_progress
            // 
            this.bar_progress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bar_progress.Name = "bar_progress";
            this.bar_progress.Size = new System.Drawing.Size(100, 16);
            // 
            // steamToolStripMenuItem
            // 
            this.steamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem,
            this.resetGameToolStripMenuItem});
            this.steamToolStripMenuItem.Name = "steamToolStripMenuItem";
            this.steamToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.steamToolStripMenuItem.Text = "Steam";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startGameToolStripMenuItem.Text = "Start Game";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
            // 
            // resetGameToolStripMenuItem
            // 
            this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetGameToolStripMenuItem.Text = "Validate Game";
            this.resetGameToolStripMenuItem.Click += new System.EventHandler(this.resetGameToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 541);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Alien: Isolation Mod Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lst_mods)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lst_mods;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_revert;
        private System.Windows.Forms.TabControl tabs_configs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMD5TreeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar bar_progress;
        private System.Windows.Forms.ToolStripStatusLabel txt_status;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetGameToolStripMenuItem;
    }
}

