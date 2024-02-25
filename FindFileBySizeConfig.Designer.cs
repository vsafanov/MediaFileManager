namespace MediaFileManager
{
    partial class FindFileBySizeConfig
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
            lblFindIn = new Label();
            cmbFolders = new ComboBox();
            lblselectedFolderPath = new Label();
            lblFileType = new Label();
            cmbFileType = new ComboBox();
            lblFileSize = new Label();
            btnSearch = new Button();
            btnClose = new Button();
            txtFileSize = new TextBox();
            txtMinFileSize = new TextBox();
            lblMinFileSize = new Label();
            SuspendLayout();
            // 
            // lblFindIn
            // 
            lblFindIn.AutoSize = true;
            lblFindIn.Location = new Point(24, 28);
            lblFindIn.Name = "lblFindIn";
            lblFindIn.Size = new Size(55, 15);
            lblFindIn.TabIndex = 0;
            lblFindIn.Text = "Search in";
            // 
            // cmbFolders
            // 
            cmbFolders.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFolders.FormattingEnabled = true;
            cmbFolders.Items.AddRange(new object[] { "Source Folder", "Target Folder" });
            cmbFolders.Location = new Point(94, 26);
            cmbFolders.Margin = new Padding(3, 2, 3, 2);
            cmbFolders.Name = "cmbFolders";
            cmbFolders.Size = new Size(110, 23);
            cmbFolders.TabIndex = 1;
            cmbFolders.SelectedIndexChanged += cmbFolders_SelectedIndexChanged;
            // 
            // lblselectedFolderPath
            // 
            lblselectedFolderPath.AutoSize = true;
            lblselectedFolderPath.ForeColor = SystemColors.Highlight;
            lblselectedFolderPath.Location = new Point(213, 29);
            lblselectedFolderPath.Name = "lblselectedFolderPath";
            lblselectedFolderPath.Size = new Size(16, 15);
            lblselectedFolderPath.TabIndex = 5;
            lblselectedFolderPath.Text = "...";
            // 
            // lblFileType
            // 
            lblFileType.AutoSize = true;
            lblFileType.Location = new Point(24, 70);
            lblFileType.Name = "lblFileType";
            lblFileType.Size = new Size(52, 15);
            lblFileType.TabIndex = 6;
            lblFileType.Text = "File Type";
            // 
            // cmbFileType
            // 
            cmbFileType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFileType.FormattingEnabled = true;
            cmbFileType.Items.AddRange(new object[] { "Photo", "Video" });
            cmbFileType.Location = new Point(94, 68);
            cmbFileType.Margin = new Padding(3, 2, 3, 2);
            cmbFileType.Name = "cmbFileType";
            cmbFileType.Size = new Size(110, 23);
            cmbFileType.TabIndex = 7;
            // 
            // lblFileSize
            // 
            lblFileSize.AutoSize = true;
            lblFileSize.Location = new Point(313, 89);
            lblFileSize.Name = "lblFileSize";
            lblFileSize.Size = new Size(99, 15);
            lblFileSize.TabIndex = 8;
            lblFileSize.Text = "Max File Size (KB)";
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = SystemColors.Control;
            btnSearch.FlatAppearance.BorderColor = Color.White;
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.Location = new Point(332, 130);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(91, 30);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackColor = SystemColors.Control;
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.Location = new Point(431, 130);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(101, 30);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtFileSize
            // 
            txtFileSize.Location = new Point(431, 87);
            txtFileSize.MaxLength = 9;
            txtFileSize.Name = "txtFileSize";
            txtFileSize.Size = new Size(100, 23);
            txtFileSize.TabIndex = 15;
            txtFileSize.Text = "100";
            txtFileSize.TextChanged += txtFileSize_TextChanged;
            txtFileSize.KeyPress += txtFileSize_KeyPress;
            // 
            // txtMinFileSize
            // 
            txtMinFileSize.Location = new Point(431, 58);
            txtMinFileSize.MaxLength = 9;
            txtMinFileSize.Name = "txtMinFileSize";
            txtMinFileSize.Size = new Size(100, 23);
            txtMinFileSize.TabIndex = 17;
            txtMinFileSize.Text = "10";
            txtMinFileSize.TextChanged += txtFileSize_TextChanged;
            txtMinFileSize.KeyPress += txtFileSize_KeyPress;
            // 
            // lblMinFileSize
            // 
            lblMinFileSize.AutoSize = true;
            lblMinFileSize.Location = new Point(313, 60);
            lblMinFileSize.Name = "lblMinFileSize";
            lblMinFileSize.Size = new Size(97, 15);
            lblMinFileSize.TabIndex = 16;
            lblMinFileSize.Text = "Min File Size (KB)";
            // 
            // FindFileBySizeConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(559, 169);
            Controls.Add(txtMinFileSize);
            Controls.Add(lblMinFileSize);
            Controls.Add(txtFileSize);
            Controls.Add(btnClose);
            Controls.Add(btnSearch);
            Controls.Add(lblFileSize);
            Controls.Add(cmbFileType);
            Controls.Add(lblFileType);
            Controls.Add(lblselectedFolderPath);
            Controls.Add(cmbFolders);
            Controls.Add(lblFindIn);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FindFileBySizeConfig";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Find Media Files By Size";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFindIn;
        private ComboBox cmbFolders;
        private Button btnSearch1;
        private Label lblselectedFolderPath;
        private Label lblFileType;
        private ComboBox cmbFileType;
        private Label lblFileSize;
        private Button btnSearch;
        private Button btnClose;
        private TextBox txtFileSize;
        private TextBox txtMinFileSize;
        private Label lblMinFileSize;
    }
}