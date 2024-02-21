namespace MediaFileManager.Reporting
{
    partial class DuplicatedFiles
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuplicatedFiles));
            splitContainer1 = new SplitContainer();
            treeView1 = new TreeView();
            dataGridViewReport = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnPreview = new Button();
            btnClose = new Button();
            btnOpenInFolder = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Font = new Font("Microsoft Sans Serif", 8F);
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeView1);
            splitContainer1.Panel1.Controls.Add(dataGridViewReport);
            splitContainer1.Panel1.Padding = new Padding(12, 12, 12, 12);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnSearch);
            splitContainer1.Panel2.Controls.Add(txtSearch);
            splitContainer1.Panel2.Controls.Add(btnPreview);
            splitContainer1.Panel2.Controls.Add(btnClose);
            splitContainer1.Panel2.Controls.Add(btnOpenInFolder);
            splitContainer1.Panel2.Margin = new Padding(23, 23, 23, 23);
            splitContainer1.Panel2.Padding = new Padding(12, 12, 12, 12);
            splitContainer1.Size = new Size(719, 743);
            splitContainer1.SplitterDistance = 683;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            treeView1.BorderStyle = BorderStyle.None;
            treeView1.Dock = DockStyle.Fill;
            treeView1.Font = new Font("Microsoft Sans Serif", 9F);
            treeView1.ForeColor = Color.DimGray;
            treeView1.Indent = 20;
            treeView1.Location = new Point(12, 12);
            treeView1.Margin = new Padding(4, 3, 4, 3);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(695, 659);
            treeView1.TabIndex = 1;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewReport.BackgroundColor = SystemColors.Control;
            dataGridViewReport.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.EnableHeadersVisualStyles = false;
            dataGridViewReport.Location = new Point(1422, 30);
            dataGridViewReport.Margin = new Padding(4, 3, 4, 3);
            dataGridViewReport.MultiSelect = false;
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.ReadOnly = true;
            dataGridViewReport.Size = new Size(20, 615);
            dataGridViewReport.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(169, 11);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(84, 35);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 9F);
            txtSearch.Location = new Point(15, 15);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.MaxLength = 50;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(151, 21);
            txtSearch.TabIndex = 3;
            // 
            // btnPreview
            // 
            btnPreview.Location = new Point(390, 10);
            btnPreview.Margin = new Padding(4, 3, 4, 3);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(89, 35);
            btnPreview.TabIndex = 2;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = true;
            btnPreview.Click += btnPreview_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(623, 10);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(71, 35);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnOpenInFolder
            // 
            btnOpenInFolder.Location = new Point(486, 10);
            btnOpenInFolder.Margin = new Padding(4, 3, 4, 3);
            btnOpenInFolder.Name = "btnOpenInFolder";
            btnOpenInFolder.Size = new Size(130, 35);
            btnOpenInFolder.TabIndex = 0;
            btnOpenInFolder.Text = "Open In Folder";
            btnOpenInFolder.UseVisualStyleBackColor = true;
            btnOpenInFolder.Click += btnOpenInFolder_Click;
            // 
            // DuplicatedFiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 743);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DuplicatedFiles";
            Text = "Duplicated Files";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Button btnOpenInFolder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}