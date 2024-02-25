namespace MediaFileManager
{
    partial class About
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
            lblVersion = new Label();
            lblBuildDate = new Label();
            lblAuthor = new Label();
            lblDescription = new Label();
            txtDescription = new TextBox();
            SuspendLayout();
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(19, 12);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(45, 15);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "Version";
            // 
            // lblBuildDate
            // 
            lblBuildDate.AutoSize = true;
            lblBuildDate.Location = new Point(19, 37);
            lblBuildDate.Name = "lblBuildDate";
            lblBuildDate.Size = new Size(61, 15);
            lblBuildDate.TabIndex = 1;
            lblBuildDate.Text = "Build Date";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(19, 61);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(44, 15);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Author";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(19, 85);
            lblDescription.MaximumSize = new Size(100, 30);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.AccessibleRole = AccessibleRole.None;
            txtDescription.BackColor = SystemColors.Control;
            txtDescription.BorderStyle = BorderStyle.None;
            txtDescription.Enabled = false;
            txtDescription.Location = new Point(95, 85);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(308, 38);
            txtDescription.TabIndex = 5;
            txtDescription.Text = "Media File Manager helps you to organize photo, video and other media files by specified template";
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 139);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblAuthor);
            Controls.Add(lblBuildDate);
            Controls.Add(lblVersion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            StartPosition = FormStartPosition.CenterParent;
            Text = "About Media File Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVersion;
        private Label lblBuildDate;
        private Label lblAuthor;
        private Label lblDescription;
        private TextBox txtDescription;
    }
}