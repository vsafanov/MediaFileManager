namespace MediaFileManager
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.btnAddExt = new System.Windows.Forms.Button();
            this.btnToggleAll = new System.Windows.Forms.Button();
            this.checkedListBoxPictureTypes = new System.Windows.Forms.CheckedListBox();
            this.numericUpDownMinFileSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkOverwrite = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinFileSize)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExt);
            this.groupBox1.Controls.Add(this.btnAddExt);
            this.groupBox1.Controls.Add(this.btnToggleAll);
            this.groupBox1.Controls.Add(this.checkedListBoxPictureTypes);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(47, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20, 23, 20, 23);
            this.groupBox1.Size = new System.Drawing.Size(389, 408);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picture File Types:";
            // 
            // txtExt
            // 
            this.txtExt.AcceptsReturn = true;
            this.txtExt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExt.Location = new System.Drawing.Point(16, 351);
            this.txtExt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExt.MaxLength = 10;
            this.txtExt.Name = "txtExt";
            this.txtExt.Size = new System.Drawing.Size(71, 27);
            this.txtExt.TabIndex = 16;
            this.txtExt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExt_KeyPress);
            // 
            // btnAddExt
            // 
            this.btnAddExt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddExt.Location = new System.Drawing.Point(95, 349);
            this.btnAddExt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddExt.Name = "btnAddExt";
            this.btnAddExt.Size = new System.Drawing.Size(130, 32);
            this.btnAddExt.TabIndex = 9;
            this.btnAddExt.Text = "Add Extension";
            this.btnAddExt.UseVisualStyleBackColor = true;
            this.btnAddExt.Click += new System.EventHandler(this.btnAddExt_Click);
            // 
            // btnToggleAll
            // 
            this.btnToggleAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnToggleAll.Location = new System.Drawing.Point(243, 349);
            this.btnToggleAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToggleAll.Name = "btnToggleAll";
            this.btnToggleAll.Size = new System.Drawing.Size(104, 32);
            this.btnToggleAll.TabIndex = 8;
            this.btnToggleAll.Text = "Toggle All";
            this.btnToggleAll.UseVisualStyleBackColor = true;
            this.btnToggleAll.Click += new System.EventHandler(this.btnToggleAll_Click);
            // 
            // checkedListBoxPictureTypes
            // 
            this.checkedListBoxPictureTypes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkedListBoxPictureTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxPictureTypes.CheckOnClick = true;
            this.checkedListBoxPictureTypes.ColumnWidth = 70;
            this.checkedListBoxPictureTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBoxPictureTypes.FormattingEnabled = true;
            this.checkedListBoxPictureTypes.Location = new System.Drawing.Point(20, 39);
            this.checkedListBoxPictureTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBoxPictureTypes.MultiColumn = true;
            this.checkedListBoxPictureTypes.Name = "checkedListBoxPictureTypes";
            this.checkedListBoxPictureTypes.Size = new System.Drawing.Size(349, 288);
            this.checkedListBoxPictureTypes.TabIndex = 7;
            // 
            // numericUpDownMinFileSize
            // 
            this.numericUpDownMinFileSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownMinFileSize.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMinFileSize.Location = new System.Drawing.Point(24, 39);
            this.numericUpDownMinFileSize.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.numericUpDownMinFileSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownMinFileSize.Name = "numericUpDownMinFileSize";
            this.numericUpDownMinFileSize.Size = new System.Drawing.Size(213, 27);
            this.numericUpDownMinFileSize.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDownMinFileSize);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(473, 54);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(311, 98);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Min File Size To Copy (KB):";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(142, 14);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 32);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset To Default";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(680, 12);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 32);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Close";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(555, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 32);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkOverwrite
            // 
            this.chkOverwrite.AutoSize = true;
            this.chkOverwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkOverwrite.Location = new System.Drawing.Point(497, 188);
            this.chkOverwrite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkOverwrite.Name = "chkOverwrite";
            this.chkOverwrite.Size = new System.Drawing.Size(123, 21);
            this.chkOverwrite.TabIndex = 19;
            this.chkOverwrite.Text = "Overwrite Files";
            this.chkOverwrite.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(7, 8);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.chkOverwrite);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.btnReset);
            this.splitContainer1.Panel2.Controls.Add(this.btnNext);
            this.splitContainer1.Size = new System.Drawing.Size(803, 549);
            this.splitContainer1.SplitterDistance = 485;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 20;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(817, 565);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinFileSize)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBoxPictureTypes;
        private System.Windows.Forms.Button btnToggleAll;
        private System.Windows.Forms.NumericUpDown numericUpDownMinFileSize;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddExt;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkOverwrite;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}