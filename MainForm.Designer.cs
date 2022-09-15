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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMediaFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDuplicatedMediaFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findCorruptedMediaFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNewMediaFilesInSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOpenDestFld = new System.Windows.Forms.Button();
            this.txtTargetFolderPath = new System.Windows.Forms.TextBox();
            this.btnTargetFolder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpenSourceFld = new System.Windows.Forms.Button();
            this.txtSourceFolderPath = new System.Windows.Forms.TextBox();
            this.btnSourceFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTipFolder = new System.Windows.Forms.ToolTip(this.components);
            this.btnFindDuplicates = new System.Windows.Forms.Button();
            this.btnFindCorrupted = new System.Windows.Forms.Button();
            this.btnFindNew = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menu.Size = new System.Drawing.Size(1061, 30);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyMediaFilesToolStripMenuItem,
            this.findDuplicatedMediaFilesToolStripMenuItem,
            this.findCorruptedMediaFilesToolStripMenuItem,
            this.findNewMediaFilesInSourceToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 24);
            this.toolStripMenuItem1.Text = "Main";
            // 
            // copyMediaFilesToolStripMenuItem
            // 
            this.copyMediaFilesToolStripMenuItem.Name = "copyMediaFilesToolStripMenuItem";
            this.copyMediaFilesToolStripMenuItem.Size = new System.Drawing.Size(344, 26);
            this.copyMediaFilesToolStripMenuItem.Text = "Copy Media Files";
            this.copyMediaFilesToolStripMenuItem.Click += new System.EventHandler(this.copyMediaFilesToolStripMenuItem_Click);
            // 
            // findDuplicatedMediaFilesToolStripMenuItem
            // 
            this.findDuplicatedMediaFilesToolStripMenuItem.Name = "findDuplicatedMediaFilesToolStripMenuItem";
            this.findDuplicatedMediaFilesToolStripMenuItem.Size = new System.Drawing.Size(344, 26);
            this.findDuplicatedMediaFilesToolStripMenuItem.Text = "Find Duplicated Media Files";
            this.findDuplicatedMediaFilesToolStripMenuItem.Click += new System.EventHandler(this.findDuplicatedMediaFilesToolStripMenuItem_Click);
            // 
            // findCorruptedMediaFilesToolStripMenuItem
            // 
            this.findCorruptedMediaFilesToolStripMenuItem.Name = "findCorruptedMediaFilesToolStripMenuItem";
            this.findCorruptedMediaFilesToolStripMenuItem.Size = new System.Drawing.Size(344, 26);
            this.findCorruptedMediaFilesToolStripMenuItem.Text = "Find Corrupted Media Files";
            this.findCorruptedMediaFilesToolStripMenuItem.Click += new System.EventHandler(this.findCorruptedMediaFilesToolStripMenuItem_Click);
            // 
            // findNewMediaFilesInSourceToolStripMenuItem
            // 
            this.findNewMediaFilesInSourceToolStripMenuItem.Name = "findNewMediaFilesInSourceToolStripMenuItem";
            this.findNewMediaFilesInSourceToolStripMenuItem.Size = new System.Drawing.Size(344, 26);
            this.findNewMediaFilesInSourceToolStripMenuItem.Text = "Find New Media Files in Source Folder";
            this.findNewMediaFilesInSourceToolStripMenuItem.Click += new System.EventHandler(this.findNewMediaFilesInSourceToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(344, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnOpenDestFld);
            this.groupBox3.Controls.Add(this.txtTargetFolderPath);
            this.groupBox3.Controls.Add(this.btnTargetFolder);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(41, 217);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(961, 103);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Destination Folder: ";
            // 
            // btnOpenDestFld
            // 
            this.btnOpenDestFld.AutoSize = true;
            this.btnOpenDestFld.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenDestFld.Image = global::MediaFileManager.Properties.Resources.folder_24x24;
            this.btnOpenDestFld.Location = new System.Drawing.Point(12, 41);
            this.btnOpenDestFld.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenDestFld.Name = "btnOpenDestFld";
            this.btnOpenDestFld.Size = new System.Drawing.Size(30, 30);
            this.btnOpenDestFld.TabIndex = 8;
            this.toolTipFolder.SetToolTip(this.btnOpenDestFld, "Open Destination Folder");
            this.btnOpenDestFld.UseVisualStyleBackColor = true;
            this.btnOpenDestFld.Click += new System.EventHandler(this.btnOpenDestFld_Click);
            // 
            // txtTargetFolderPath
            // 
            this.txtTargetFolderPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTargetFolderPath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTargetFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTargetFolderPath.Location = new System.Drawing.Point(58, 42);
            this.txtTargetFolderPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTargetFolderPath.Name = "txtTargetFolderPath";
            this.txtTargetFolderPath.ReadOnly = true;
            this.txtTargetFolderPath.Size = new System.Drawing.Size(745, 27);
            this.txtTargetFolderPath.TabIndex = 7;
            // 
            // btnTargetFolder
            // 
            this.btnTargetFolder.AutoSize = true;
            this.btnTargetFolder.BackColor = System.Drawing.SystemColors.Control;
            this.btnTargetFolder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTargetFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTargetFolder.Location = new System.Drawing.Point(809, 41);
            this.btnTargetFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTargetFolder.Name = "btnTargetFolder";
            this.btnTargetFolder.Size = new System.Drawing.Size(133, 30);
            this.btnTargetFolder.TabIndex = 6;
            this.btnTargetFolder.Text = "Browse...";
            this.btnTargetFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTargetFolder.UseVisualStyleBackColor = false;
            this.btnTargetFolder.Click += new System.EventHandler(this.btnTargetFolder_Click);
            this.btnTargetFolder.MouseHover += new System.EventHandler(this.ShowTooltipFolder);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpenSourceFld);
            this.groupBox2.Controls.Add(this.txtSourceFolderPath);
            this.groupBox2.Controls.Add(this.btnSourceFolder);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(41, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(961, 103);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Source Folder: ";
            // 
            // btnOpenSourceFld
            // 
            this.btnOpenSourceFld.AutoSize = true;
            this.btnOpenSourceFld.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenSourceFld.Image = global::MediaFileManager.Properties.Resources.folder_24x24;
            this.btnOpenSourceFld.Location = new System.Drawing.Point(12, 43);
            this.btnOpenSourceFld.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenSourceFld.Name = "btnOpenSourceFld";
            this.btnOpenSourceFld.Size = new System.Drawing.Size(30, 30);
            this.btnOpenSourceFld.TabIndex = 3;
            this.toolTipFolder.SetToolTip(this.btnOpenSourceFld, "Open Source Folder");
            this.btnOpenSourceFld.UseVisualStyleBackColor = true;
            this.btnOpenSourceFld.Click += new System.EventHandler(this.btnOpenSourceFld_Click);
            // 
            // txtSourceFolderPath
            // 
            this.txtSourceFolderPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSourceFolderPath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSourceFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSourceFolderPath.Location = new System.Drawing.Point(55, 46);
            this.txtSourceFolderPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSourceFolderPath.Name = "txtSourceFolderPath";
            this.txtSourceFolderPath.ReadOnly = true;
            this.txtSourceFolderPath.Size = new System.Drawing.Size(745, 27);
            this.txtSourceFolderPath.TabIndex = 2;
            // 
            // btnSourceFolder
            // 
            this.btnSourceFolder.AutoSize = true;
            this.btnSourceFolder.BackColor = System.Drawing.SystemColors.Control;
            this.btnSourceFolder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSourceFolder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSourceFolder.Location = new System.Drawing.Point(808, 45);
            this.btnSourceFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSourceFolder.Name = "btnSourceFolder";
            this.btnSourceFolder.Size = new System.Drawing.Size(133, 30);
            this.btnSourceFolder.TabIndex = 1;
            this.btnSourceFolder.Text = "Browse...";
            this.btnSourceFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSourceFolder.UseVisualStyleBackColor = false;
            this.btnSourceFolder.Click += new System.EventHandler(this.btnSourceFolder_Click);
            this.btnSourceFolder.MouseHover += new System.EventHandler(this.ShowTooltipFolder);
            // 
            // toolTipFolder
            // 
            this.toolTipFolder.AutomaticDelay = 10;
            this.toolTipFolder.AutoPopDelay = 0;
            this.toolTipFolder.InitialDelay = 10;
            this.toolTipFolder.IsBalloon = true;
            this.toolTipFolder.ReshowDelay = 2;
            this.toolTipFolder.ShowAlways = true;
            this.toolTipFolder.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnFindDuplicates
            // 
            this.btnFindDuplicates.AutoSize = true;
            this.btnFindDuplicates.BackColor = System.Drawing.SystemColors.Control;
            this.btnFindDuplicates.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFindDuplicates.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFindDuplicates.Location = new System.Drawing.Point(855, 358);
            this.btnFindDuplicates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFindDuplicates.Name = "btnFindDuplicates";
            this.btnFindDuplicates.Size = new System.Drawing.Size(148, 46);
            this.btnFindDuplicates.TabIndex = 19;
            this.btnFindDuplicates.Text = "Find Duplicates";
            this.btnFindDuplicates.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFindDuplicates.UseVisualStyleBackColor = false;
            this.btnFindDuplicates.Visible = false;
            this.btnFindDuplicates.Click += new System.EventHandler(this.btnFindDuplicated_Click);
            // 
            // btnFindCorrupted
            // 
            this.btnFindCorrupted.AutoSize = true;
            this.btnFindCorrupted.BackColor = System.Drawing.SystemColors.Control;
            this.btnFindCorrupted.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFindCorrupted.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFindCorrupted.Location = new System.Drawing.Point(855, 358);
            this.btnFindCorrupted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFindCorrupted.Name = "btnFindCorrupted";
            this.btnFindCorrupted.Size = new System.Drawing.Size(148, 46);
            this.btnFindCorrupted.TabIndex = 20;
            this.btnFindCorrupted.Text = "Find Corrupted";
            this.btnFindCorrupted.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFindCorrupted.UseVisualStyleBackColor = false;
            this.btnFindCorrupted.Visible = false;
            this.btnFindCorrupted.Click += new System.EventHandler(this.btnFindCorrupted_Click);
            // 
            // btnFindNew
            // 
            this.btnFindNew.AutoSize = true;
            this.btnFindNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnFindNew.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFindNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFindNew.Location = new System.Drawing.Point(849, 358);
            this.btnFindNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFindNew.Name = "btnFindNew";
            this.btnFindNew.Size = new System.Drawing.Size(153, 46);
            this.btnFindNew.TabIndex = 21;
            this.btnFindNew.Text = "Find New In Source";
            this.btnFindNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFindNew.UseVisualStyleBackColor = false;
            this.btnFindNew.Visible = false;
            this.btnFindNew.Click += new System.EventHandler(this.btnFindNew_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1061, 438);
            this.Controls.Add(this.btnFindNew);
            this.Controls.Add(this.btnFindCorrupted);
            this.Controls.Add(this.btnFindDuplicates);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Media File Manager";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}