namespace MediaFileManager
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menu = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            copyMediaFilesToolStripMenuItem = new ToolStripMenuItem();
            findDuplicatedMediaFilesToolStripMenuItem = new ToolStripMenuItem();
            findCorruptedMediaFilesToolStripMenuItem = new ToolStripMenuItem();
            findNewMediaFilesInSourceToolStripMenuItem = new ToolStripMenuItem();
            findMediaFilesBySizeToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            groupBox3 = new GroupBox();
            btnOpenDestFld = new Button();
            txtTargetFolderPath = new TextBox();
            btnTargetFolder = new Button();
            groupBox2 = new GroupBox();
            btnOpenSourceFld = new Button();
            txtSourceFolderPath = new TextBox();
            btnSourceFolder = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            toolTipFolder = new ToolTip(components);
            btnFindDuplicates = new Button();
            btnFindCorrupted = new Button();
            btnFindNew = new Button();
            toolTipOpenFolder = new ToolTip(components);
            menu.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(18, 18);
            menu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, settingsToolStripMenuItem1, aboutToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(8, 3, 0, 3);
            menu.Size = new Size(1061, 30);
            menu.TabIndex = 0;
            menu.Text = "menu";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { copyMediaFilesToolStripMenuItem, findDuplicatedMediaFilesToolStripMenuItem, findCorruptedMediaFilesToolStripMenuItem, findNewMediaFilesInSourceToolStripMenuItem, findMediaFilesBySizeToolStripMenuItem, exitToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(56, 24);
            toolStripMenuItem1.Text = "Main";
            // 
            // copyMediaFilesToolStripMenuItem
            // 
            copyMediaFilesToolStripMenuItem.Name = "copyMediaFilesToolStripMenuItem";
            copyMediaFilesToolStripMenuItem.Size = new Size(344, 26);
            copyMediaFilesToolStripMenuItem.Text = "Copy Media Files";
            copyMediaFilesToolStripMenuItem.Click += copyMediaFilesToolStripMenuItem_Click;
            // 
            // findDuplicatedMediaFilesToolStripMenuItem
            // 
            findDuplicatedMediaFilesToolStripMenuItem.Name = "findDuplicatedMediaFilesToolStripMenuItem";
            findDuplicatedMediaFilesToolStripMenuItem.Size = new Size(344, 26);
            findDuplicatedMediaFilesToolStripMenuItem.Text = "Find Duplicated Media Files";
            findDuplicatedMediaFilesToolStripMenuItem.Click += findDuplicatedMediaFilesToolStripMenuItem_Click;
            // 
            // findCorruptedMediaFilesToolStripMenuItem
            // 
            findCorruptedMediaFilesToolStripMenuItem.Name = "findCorruptedMediaFilesToolStripMenuItem";
            findCorruptedMediaFilesToolStripMenuItem.Size = new Size(344, 26);
            findCorruptedMediaFilesToolStripMenuItem.Text = "Find Corrupted Media Files";
            findCorruptedMediaFilesToolStripMenuItem.Click += findCorruptedMediaFilesToolStripMenuItem_Click;
            // 
            // findNewMediaFilesInSourceToolStripMenuItem
            // 
            findNewMediaFilesInSourceToolStripMenuItem.Name = "findNewMediaFilesInSourceToolStripMenuItem";
            findNewMediaFilesInSourceToolStripMenuItem.Size = new Size(344, 26);
            findNewMediaFilesInSourceToolStripMenuItem.Text = "Find New Media Files in Source Folder";
            findNewMediaFilesInSourceToolStripMenuItem.Click += findNewMediaFilesInSourceToolStripMenuItem_Click;
            // 
            // findMediaFilesBySizeToolStripMenuItem
            // 
            findMediaFilesBySizeToolStripMenuItem.Name = "findMediaFilesBySizeToolStripMenuItem";
            findMediaFilesBySizeToolStripMenuItem.Size = new Size(344, 26);
            findMediaFilesBySizeToolStripMenuItem.Text = "Find Media Files by Size";
            findMediaFilesBySizeToolStripMenuItem.MouseUp += findMediaFilesBysizeToolStripMenuItem_MouseUp;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(344, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem1
            // 
            settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            settingsToolStripMenuItem1.Size = new Size(76, 24);
            settingsToolStripMenuItem1.Text = "Settings";
            settingsToolStripMenuItem1.Click += settingsToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnOpenDestFld);
            groupBox3.Controls.Add(txtTargetFolderPath);
            groupBox3.Controls.Add(btnTargetFolder);
            groupBox3.Font = new Font("Microsoft Sans Serif", 8F);
            groupBox3.Location = new Point(41, 217);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(961, 103);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Destination Folder: ";
            // 
            // btnOpenDestFld
            // 
            btnOpenDestFld.AutoSize = true;
            btnOpenDestFld.FlatStyle = FlatStyle.Popup;
            btnOpenDestFld.Image = Properties.Resources.folder_24x24;
            btnOpenDestFld.Location = new Point(11, 41);
            btnOpenDestFld.Margin = new Padding(5);
            btnOpenDestFld.Name = "btnOpenDestFld";
            btnOpenDestFld.Size = new Size(34, 40);
            btnOpenDestFld.TabIndex = 8;
            toolTipOpenFolder.SetToolTip(btnOpenDestFld, "Open Destination Folder");
            btnOpenDestFld.UseVisualStyleBackColor = true;
            btnOpenDestFld.Click += btnOpenDestFld_Click;
            // 
            // txtTargetFolderPath
            // 
            txtTargetFolderPath.Anchor = AnchorStyles.Left;
            txtTargetFolderPath.BackColor = SystemColors.ControlLightLight;
            txtTargetFolderPath.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtTargetFolderPath.Location = new Point(58, 43);
            txtTargetFolderPath.Margin = new Padding(5);
            txtTargetFolderPath.Name = "txtTargetFolderPath";
            txtTargetFolderPath.ReadOnly = true;
            txtTargetFolderPath.Size = new Size(745, 27);
            txtTargetFolderPath.TabIndex = 7;
            // 
            // btnTargetFolder
            // 
            btnTargetFolder.AutoSize = true;
            btnTargetFolder.BackColor = SystemColors.Control;
            btnTargetFolder.FlatAppearance.BorderColor = Color.White;
            btnTargetFolder.Font = new Font("Segoe UI", 9F);
            btnTargetFolder.Location = new Point(809, 41);
            btnTargetFolder.Margin = new Padding(5);
            btnTargetFolder.Name = "btnTargetFolder";
            btnTargetFolder.Size = new Size(133, 40);
            btnTargetFolder.TabIndex = 6;
            btnTargetFolder.Text = "Browse...";
            btnTargetFolder.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnTargetFolder.UseVisualStyleBackColor = false;
            btnTargetFolder.Click += btnTargetFolder_Click;
            btnTargetFolder.MouseHover += ShowTooltipFolder;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOpenSourceFld);
            groupBox2.Controls.Add(txtSourceFolderPath);
            groupBox2.Controls.Add(btnSourceFolder);
            groupBox2.Font = new Font("Microsoft Sans Serif", 8F);
            groupBox2.Location = new Point(41, 83);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(961, 103);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Source Folder: ";
            // 
            // btnOpenSourceFld
            // 
            btnOpenSourceFld.AutoSize = true;
            btnOpenSourceFld.FlatStyle = FlatStyle.Popup;
            btnOpenSourceFld.Image = Properties.Resources.folder_24x24;
            btnOpenSourceFld.Location = new Point(11, 43);
            btnOpenSourceFld.Margin = new Padding(5);
            btnOpenSourceFld.Name = "btnOpenSourceFld";
            btnOpenSourceFld.Size = new Size(34, 40);
            btnOpenSourceFld.TabIndex = 3;
            toolTipOpenFolder.SetToolTip(btnOpenSourceFld, "Open Source Folder");
            btnOpenSourceFld.UseVisualStyleBackColor = true;
            btnOpenSourceFld.Click += btnOpenSourceFld_Click;
            // 
            // txtSourceFolderPath
            // 
            txtSourceFolderPath.Anchor = AnchorStyles.Left;
            txtSourceFolderPath.BackColor = SystemColors.ControlLightLight;
            txtSourceFolderPath.Font = new Font("Microsoft Sans Serif", 10.2F);
            txtSourceFolderPath.Location = new Point(55, 45);
            txtSourceFolderPath.Margin = new Padding(5);
            txtSourceFolderPath.Name = "txtSourceFolderPath";
            txtSourceFolderPath.ReadOnly = true;
            txtSourceFolderPath.Size = new Size(745, 27);
            txtSourceFolderPath.TabIndex = 2;
            // 
            // btnSourceFolder
            // 
            btnSourceFolder.AutoSize = true;
            btnSourceFolder.BackColor = SystemColors.Control;
            btnSourceFolder.FlatAppearance.BorderColor = Color.White;
            btnSourceFolder.Font = new Font("Segoe UI", 9F);
            btnSourceFolder.Location = new Point(808, 45);
            btnSourceFolder.Margin = new Padding(5);
            btnSourceFolder.Name = "btnSourceFolder";
            btnSourceFolder.Size = new Size(133, 40);
            btnSourceFolder.TabIndex = 1;
            btnSourceFolder.Text = "Browse...";
            btnSourceFolder.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSourceFolder.UseVisualStyleBackColor = false;
            btnSourceFolder.Click += btnSourceFolder_Click;
            btnSourceFolder.MouseHover += ShowTooltipFolder;
            // 
            // toolTipFolder
            // 
            toolTipFolder.AutomaticDelay = 10;
            toolTipFolder.AutoPopDelay = 0;
            toolTipFolder.InitialDelay = 10;
            toolTipFolder.IsBalloon = true;
            toolTipFolder.ReshowDelay = 2;
            toolTipFolder.ShowAlways = true;
            toolTipFolder.ToolTipIcon = ToolTipIcon.Info;
            // 
            // btnFindDuplicates
            // 
            btnFindDuplicates.AutoSize = true;
            btnFindDuplicates.BackColor = SystemColors.Control;
            btnFindDuplicates.FlatAppearance.BorderColor = Color.White;
            btnFindDuplicates.Font = new Font("Segoe UI", 9F);
            btnFindDuplicates.Location = new Point(855, 357);
            btnFindDuplicates.Margin = new Padding(5);
            btnFindDuplicates.Name = "btnFindDuplicates";
            btnFindDuplicates.Size = new Size(149, 45);
            btnFindDuplicates.TabIndex = 19;
            btnFindDuplicates.Text = "Find Duplicates";
            btnFindDuplicates.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnFindDuplicates.UseVisualStyleBackColor = false;
            btnFindDuplicates.Visible = false;
            btnFindDuplicates.Click += btnFindDuplicated_Click;
            // 
            // btnFindCorrupted
            // 
            btnFindCorrupted.AutoSize = true;
            btnFindCorrupted.BackColor = SystemColors.Control;
            btnFindCorrupted.FlatAppearance.BorderColor = Color.White;
            btnFindCorrupted.Font = new Font("Segoe UI", 9F);
            btnFindCorrupted.Location = new Point(855, 357);
            btnFindCorrupted.Margin = new Padding(5);
            btnFindCorrupted.Name = "btnFindCorrupted";
            btnFindCorrupted.Size = new Size(149, 45);
            btnFindCorrupted.TabIndex = 20;
            btnFindCorrupted.Text = "Find Corrupted";
            btnFindCorrupted.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnFindCorrupted.UseVisualStyleBackColor = false;
            btnFindCorrupted.Visible = false;
            btnFindCorrupted.Click += btnFindCorrupted_Click;
            // 
            // btnFindNew
            // 
            btnFindNew.AutoSize = true;
            btnFindNew.BackColor = SystemColors.Control;
            btnFindNew.FlatAppearance.BorderColor = Color.White;
            btnFindNew.Font = new Font("Segoe UI", 9F);
            btnFindNew.Location = new Point(849, 357);
            btnFindNew.Margin = new Padding(5);
            btnFindNew.Name = "btnFindNew";
            btnFindNew.Size = new Size(153, 45);
            btnFindNew.TabIndex = 21;
            btnFindNew.Text = "Find New In Source";
            btnFindNew.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnFindNew.UseVisualStyleBackColor = false;
            btnFindNew.Visible = false;
            btnFindNew.Click += btnFindNew_Click;
            // 
            // toolTipOpenFolder
            // 
            toolTipOpenFolder.AutomaticDelay = 10;
            toolTipOpenFolder.AutoPopDelay = 0;
            toolTipOpenFolder.InitialDelay = 10;
            toolTipOpenFolder.ReshowDelay = 2;
            toolTipOpenFolder.ShowAlways = true;
            toolTipOpenFolder.ToolTipIcon = ToolTipIcon.Info;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1061, 437);
            Controls.Add(btnFindNew);
            Controls.Add(btnFindCorrupted);
            Controls.Add(btnFindDuplicates);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Media File Manager";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMediaFilesToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTargetFolderPath;
        private System.Windows.Forms.Button btnTargetFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSourceFolderPath;
        private System.Windows.Forms.Button btnSourceFolder;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolTip toolTipFolder;
        private System.Windows.Forms.ToolStripMenuItem findDuplicatedMediaFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findCorruptedMediaFilesToolStripMenuItem;
        private System.Windows.Forms.Button btnFindDuplicates;
        private System.Windows.Forms.Button btnFindCorrupted;
        private System.Windows.Forms.Button btnOpenDestFld;
        private System.Windows.Forms.Button btnOpenSourceFld;
        private System.Windows.Forms.ToolStripMenuItem findNewMediaFilesInSourceToolStripMenuItem;
        private System.Windows.Forms.Button btnFindNew;
        private ToolTip toolTipOpenFolder;
        private ToolStripMenuItem findMediaFilesBySizeToolStripMenuItem;
    }
}