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
            numericUpDownFileSize = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFileSize).BeginInit();
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
            lblFileSize.Location = new Point(313, 70);
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
            btnSearch.Location = new Point(306, 121);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(116, 30);
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
            btnClose.Location = new Point(431, 121);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(116, 30);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // numericUpDownFileSize
            // 
            numericUpDownFileSize.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownFileSize.Location = new Point(433, 68);
            numericUpDownFileSize.Margin = new Padding(3, 2, 3, 2);
            numericUpDownFileSize.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownFileSize.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownFileSize.Name = "numericUpDownFileSize";
            numericUpDownFileSize.Size = new Size(108, 23);
            numericUpDownFileSize.TabIndex = 14;
            numericUpDownFileSize.ThousandsSeparator = true;
            numericUpDownFileSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownFileSize.KeyPress += numericUpDownFileSize_ValueChanged;
            // 
            // FindFileBySizeConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(571, 161);
            Controls.Add(numericUpDownFileSize);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDownFileSize).EndInit();
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
        private NumericUpDown numericUpDownFileSize;
    }
}