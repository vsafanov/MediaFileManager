namespace MediaFileManager.Reporting
{
    partial class CopiedFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopiedFiles));
            gridNotCopied = new DataGridView();
            gridErrors = new DataGridView();
            label1 = new Label();
            lblTotalFiles = new Label();
            lblSkipped = new Label();
            label4 = new Label();
            lblCopied = new Label();
            label6 = new Label();
            lblDuration = new Label();
            label7 = new Label();
            listViewCorrupted = new ListView();
            btnShowErrors = new Button();
            btnShowCorrupted = new Button();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            splitContainer1 = new SplitContainer();
            lblUndated = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridNotCopied).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridErrors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // gridNotCopied
            // 
            gridNotCopied.AllowUserToAddRows = false;
            gridNotCopied.AllowUserToDeleteRows = false;
            gridNotCopied.AllowUserToOrderColumns = true;
            gridNotCopied.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            gridNotCopied.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridNotCopied.BackgroundColor = SystemColors.ControlLightLight;
            gridNotCopied.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridNotCopied.Dock = DockStyle.Fill;
            gridNotCopied.Location = new Point(0, 0);
            gridNotCopied.MultiSelect = false;
            gridNotCopied.Name = "gridNotCopied";
            gridNotCopied.ReadOnly = true;
            gridNotCopied.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridNotCopied.Size = new Size(978, 573);
            gridNotCopied.TabIndex = 0;
            gridNotCopied.CellContentClick += gridNotCopied_CellContentClick;
            gridNotCopied.CellMouseDoubleClick += gridNotCopied_CellMouseDoubleClick;
            // 
            // gridErrors
            // 
            gridErrors.AllowUserToAddRows = false;
            gridErrors.AllowUserToDeleteRows = false;
            gridErrors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridErrors.BackgroundColor = SystemColors.ControlLightLight;
            gridErrors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridErrors.Location = new Point(0, 324);
            gridErrors.Name = "gridErrors";
            gridErrors.ReadOnly = true;
            gridErrors.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            gridErrors.Size = new Size(808, 246);
            gridErrors.TabIndex = 2;
            gridErrors.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.Location = new Point(13, 17);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 3;
            label1.Text = "Total Files: ";
            // 
            // lblTotalFiles
            // 
            lblTotalFiles.AutoSize = true;
            lblTotalFiles.Font = new Font("Microsoft Sans Serif", 9F);
            lblTotalFiles.Location = new Point(117, 17);
            lblTotalFiles.Name = "lblTotalFiles";
            lblTotalFiles.Size = new Size(50, 15);
            lblTotalFiles.TabIndex = 4;
            lblTotalFiles.Text = "number";
            // 
            // lblSkipped
            // 
            lblSkipped.AutoSize = true;
            lblSkipped.Font = new Font("Microsoft Sans Serif", 9F);
            lblSkipped.Location = new Point(117, 40);
            lblSkipped.Name = "lblSkipped";
            lblSkipped.Size = new Size(50, 15);
            lblSkipped.TabIndex = 6;
            lblSkipped.Text = "number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(13, 40);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 5;
            label4.Text = "Files Skipped:";
            // 
            // lblCopied
            // 
            lblCopied.AutoSize = true;
            lblCopied.Font = new Font("Microsoft Sans Serif", 9F);
            lblCopied.Location = new Point(117, 63);
            lblCopied.Name = "lblCopied";
            lblCopied.Size = new Size(50, 15);
            lblCopied.TabIndex = 8;
            lblCopied.Text = "number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F);
            label6.Location = new Point(13, 63);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 7;
            label6.Text = "Files Copied:";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Microsoft Sans Serif", 9F);
            lblDuration.Location = new Point(866, 17);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(31, 15);
            lblDuration.TabIndex = 10;
            lblDuration.Text = "time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F);
            label7.Location = new Point(762, 17);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 9;
            label7.Text = "Duration:";
            // 
            // listViewCorrupted
            // 
            listViewCorrupted.Alignment = ListViewAlignment.Left;
            listViewCorrupted.Font = new Font("Microsoft Sans Serif", 9F);
            listViewCorrupted.GridLines = true;
            listViewCorrupted.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewCorrupted.Location = new Point(0, 380);
            listViewCorrupted.MultiSelect = false;
            listViewCorrupted.Name = "listViewCorrupted";
            listViewCorrupted.ShowItemToolTips = true;
            listViewCorrupted.Size = new Size(576, 190);
            listViewCorrupted.TabIndex = 11;
            listViewCorrupted.UseCompatibleStateImageBehavior = false;
            listViewCorrupted.View = View.List;
            listViewCorrupted.Visible = false;
            listViewCorrupted.MouseDoubleClick += ListViewCorruptedOnMouseDoubleClick;
            // 
            // btnShowErrors
            // 
            btnShowErrors.Font = new Font("Microsoft Sans Serif", 9F);
            btnShowErrors.Location = new Point(33, 763);
            btnShowErrors.Name = "btnShowErrors";
            btnShowErrors.Size = new Size(100, 30);
            btnShowErrors.TabIndex = 12;
            btnShowErrors.Text = "Show Errors";
            btnShowErrors.UseVisualStyleBackColor = true;
            btnShowErrors.Click += btnShowErrors_Click;
            // 
            // btnShowCorrupted
            // 
            btnShowCorrupted.Font = new Font("Microsoft Sans Serif", 9F);
            btnShowCorrupted.Location = new Point(154, 763);
            btnShowCorrupted.Name = "btnShowCorrupted";
            btnShowCorrupted.Size = new Size(126, 30);
            btnShowCorrupted.TabIndex = 13;
            btnShowCorrupted.Text = "Show Corrupted";
            btnShowCorrupted.UseVisualStyleBackColor = true;
            btnShowCorrupted.Click += btnShowCorrupted_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9F);
            button1.Location = new Point(890, 763);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 14;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label2.Location = new Point(13, 122);
            label2.Name = "label2";
            label2.Size = new Size(159, 15);
            label2.TabIndex = 15;
            label2.Text = "Duplicated Media Files ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(185, 122);
            label3.Name = "label3";
            label3.Size = new Size(188, 15);
            label3.TabIndex = 16;
            label3.Text = "(Below files has not been copied)";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 20);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblUndated);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(lblCopied);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(lblTotalFiles);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(lblSkipped);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(lblDuration);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(gridNotCopied);
            splitContainer1.Panel2.Controls.Add(gridErrors);
            splitContainer1.Panel2.Controls.Add(listViewCorrupted);
            splitContainer1.Size = new Size(978, 725);
            splitContainer1.SplitterDistance = 148;
            splitContainer1.TabIndex = 17;
            // 
            // lblUndated
            // 
            lblUndated.AutoSize = true;
            lblUndated.Font = new Font("Microsoft Sans Serif", 9F);
            lblUndated.Location = new Point(117, 87);
            lblUndated.Name = "lblUndated";
            lblUndated.Size = new Size(50, 15);
            lblUndated.TabIndex = 18;
            lblUndated.Text = "number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F);
            label8.Location = new Point(13, 87);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 17;
            label8.Text = "Undated Photos:";
            // 
            // CopiedFiles
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(1000, 807);
            Controls.Add(splitContainer1);
            Controls.Add(button1);
            Controls.Add(btnShowCorrupted);
            Controls.Add(btnShowErrors);
            Font = new Font("Microsoft Sans Serif", 8F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CopiedFiles";
            Text = "Report for Copied Files";
            ((System.ComponentModel.ISupportInitialize)gridNotCopied).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridErrors).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView gridNotCopied;
        private System.Windows.Forms.DataGridView gridErrors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalFiles;
        private System.Windows.Forms.Label lblSkipped;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCopied;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listViewCorrupted;
        private System.Windows.Forms.Button btnShowErrors;
        private System.Windows.Forms.Button btnShowCorrupted;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Label label5;
        private Label label8;
        private Label lblUndated;
    }
}