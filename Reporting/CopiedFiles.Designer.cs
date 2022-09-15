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
            this.gridNotCopied = new System.Windows.Forms.DataGridView();
            this.gridErrors = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalFiles = new System.Windows.Forms.Label();
            this.lblSkipped = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCopied = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listViewCorrupted = new System.Windows.Forms.ListView();
            this.btnShowErrors = new System.Windows.Forms.Button();
            this.btnShowCorrupted = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotCopied)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridNotCopied
            // 
            this.gridNotCopied.AllowUserToAddRows = false;
            this.gridNotCopied.AllowUserToDeleteRows = false;
            this.gridNotCopied.AllowUserToOrderColumns = true;
            this.gridNotCopied.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridNotCopied.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridNotCopied.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridNotCopied.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNotCopied.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNotCopied.Location = new System.Drawing.Point(0, 0);
            this.gridNotCopied.MultiSelect = false;
            this.gridNotCopied.Name = "gridNotCopied";
            this.gridNotCopied.ReadOnly = true;
            this.gridNotCopied.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNotCopied.Size = new System.Drawing.Size(978, 573);
            this.gridNotCopied.TabIndex = 0;
            this.gridNotCopied.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNotCopied_CellContentClick);
            this.gridNotCopied.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridNotCopied_CellMouseDoubleClick);
            // 
            // gridErrors
            // 
            this.gridErrors.AllowUserToAddRows = false;
            this.gridErrors.AllowUserToDeleteRows = false;
            this.gridErrors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridErrors.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridErrors.Location = new System.Drawing.Point(0, 324);
            this.gridErrors.Name = "gridErrors";
            this.gridErrors.ReadOnly = true;
            this.gridErrors.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridErrors.Size = new System.Drawing.Size(808, 246);
            this.gridErrors.TabIndex = 2;
            this.gridErrors.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Files: ";
            // 
            // lblTotalFiles
            // 
            this.lblTotalFiles.AutoSize = true;
            this.lblTotalFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTotalFiles.Location = new System.Drawing.Point(117, 17);
            this.lblTotalFiles.Name = "lblTotalFiles";
            this.lblTotalFiles.Size = new System.Drawing.Size(56, 17);
            this.lblTotalFiles.TabIndex = 4;
            this.lblTotalFiles.Text = "number";
            // 
            // lblSkipped
            // 
            this.lblSkipped.AutoSize = true;
            this.lblSkipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSkipped.Location = new System.Drawing.Point(117, 40);
            this.lblSkipped.Name = "lblSkipped";
            this.lblSkipped.Size = new System.Drawing.Size(56, 17);
            this.lblSkipped.TabIndex = 6;
            this.lblSkipped.Text = "number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(13, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Files Skipped:";
            // 
            // lblCopied
            // 
            this.lblCopied.AutoSize = true;
            this.lblCopied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCopied.Location = new System.Drawing.Point(117, 66);
            this.lblCopied.Name = "lblCopied";
            this.lblCopied.Size = new System.Drawing.Size(56, 17);
            this.lblCopied.TabIndex = 8;
            this.lblCopied.Text = "number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(13, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Files Copied:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDuration.Location = new System.Drawing.Point(117, 90);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(34, 17);
            this.lblDuration.TabIndex = 10;
            this.lblDuration.Text = "time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(13, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Duration:";
            // 
            // listViewCorrupted
            // 
            this.listViewCorrupted.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewCorrupted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listViewCorrupted.GridLines = true;
            this.listViewCorrupted.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCorrupted.Location = new System.Drawing.Point(0, 380);
            this.listViewCorrupted.MultiSelect = false;
            this.listViewCorrupted.Name = "listViewCorrupted";
            this.listViewCorrupted.ShowItemToolTips = true;
            this.listViewCorrupted.Size = new System.Drawing.Size(576, 190);
            this.listViewCorrupted.TabIndex = 11;
            this.listViewCorrupted.UseCompatibleStateImageBehavior = false;
            this.listViewCorrupted.View = System.Windows.Forms.View.List;
            this.listViewCorrupted.Visible = false;
            this.listViewCorrupted.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewCorruptedOnMouseDoubleClick);
            // 
            // btnShowErrors
            // 
            this.btnShowErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnShowErrors.Location = new System.Drawing.Point(33, 763);
            this.btnShowErrors.Name = "btnShowErrors";
            this.btnShowErrors.Size = new System.Drawing.Size(100, 30);
            this.btnShowErrors.TabIndex = 12;
            this.btnShowErrors.Text = "Show Errors";
            this.btnShowErrors.UseVisualStyleBackColor = true;
            this.btnShowErrors.Click += new System.EventHandler(this.btnShowErrors_Click);
            // 
            // btnShowCorrupted
            // 
            this.btnShowCorrupted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnShowCorrupted.Location = new System.Drawing.Point(154, 763);
            this.btnShowCorrupted.Name = "btnShowCorrupted";
            this.btnShowCorrupted.Size = new System.Drawing.Size(126, 30);
            this.btnShowCorrupted.TabIndex = 13;
            this.btnShowCorrupted.Text = "Show Corrupted";
            this.btnShowCorrupted.UseVisualStyleBackColor = true;
            this.btnShowCorrupted.Click += new System.EventHandler(this.btnShowCorrupted_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(890, 763);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Duplicated Media Files ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(185, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "(Below files has not been copied)";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 20);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblCopied);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalFiles);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lblSkipped);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.lblDuration);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridNotCopied);
            this.splitContainer1.Panel2.Controls.Add(this.gridErrors);
            this.splitContainer1.Panel2.Controls.Add(this.listViewCorrupted);
            this.splitContainer1.Size = new System.Drawing.Size(978, 725);
            this.splitContainer1.SplitterDistance = 148;
            this.splitContainer1.TabIndex = 17;
            // 
            // CopiedFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1000, 807);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowCorrupted);
            this.Controls.Add(this.btnShowErrors);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CopiedFiles";
            this.Text = "Report for Copied Files";
            ((System.ComponentModel.ISupportInitialize)(this.gridNotCopied)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridErrors)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}