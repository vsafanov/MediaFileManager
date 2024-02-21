namespace MediaFileManager
{
    partial class Templates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Templates));
            groupBox1 = new GroupBox();
            radioBtnYearPicVideo = new RadioButton();
            radioBtnYearMonthPicVideo = new RadioButton();
            radioBtnYearMonthMix = new RadioButton();
            radioBtnYearMix = new RadioButton();
            btnCopyFiles = new Button();
            btnCancel = new Button();
            toolTipTemplate = new ToolTip(components);
            lblWarning = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioBtnYearPicVideo);
            groupBox1.Controls.Add(radioBtnYearMonthPicVideo);
            groupBox1.Controls.Add(radioBtnYearMonthMix);
            groupBox1.Controls.Add(radioBtnYearMix);
            groupBox1.Font = new Font("Microsoft Sans Serif", 8F);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(535, 485);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select a Template: ";
            // 
            // radioBtnYearPicVideo
            // 
            radioBtnYearPicVideo.Appearance = Appearance.Button;
            radioBtnYearPicVideo.CheckAlign = ContentAlignment.TopLeft;
            radioBtnYearPicVideo.Cursor = Cursors.Hand;
            radioBtnYearPicVideo.Enabled = false;
            radioBtnYearPicVideo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnYearPicVideo.Image = Properties.Resources.YearPicsVideos;
            radioBtnYearPicVideo.Location = new Point(275, 39);
            radioBtnYearPicVideo.Name = "radioBtnYearPicVideo";
            radioBtnYearPicVideo.Size = new Size(242, 192);
            radioBtnYearPicVideo.TabIndex = 13;
            radioBtnYearPicVideo.Tag = "YearPicturesAndVideos";
            radioBtnYearPicVideo.Text = "  Year \\ Pics and Videos  ";
            radioBtnYearPicVideo.TextAlign = ContentAlignment.TopCenter;
            radioBtnYearPicVideo.TextImageRelation = TextImageRelation.TextAboveImage;
            radioBtnYearPicVideo.UseVisualStyleBackColor = true;
            radioBtnYearPicVideo.MouseHover += ShowTooltip;
            // 
            // radioBtnYearMonthPicVideo
            // 
            radioBtnYearMonthPicVideo.Appearance = Appearance.Button;
            radioBtnYearMonthPicVideo.AutoSize = true;
            radioBtnYearMonthPicVideo.CheckAlign = ContentAlignment.TopLeft;
            radioBtnYearMonthPicVideo.Cursor = Cursors.Hand;
            radioBtnYearMonthPicVideo.Enabled = false;
            radioBtnYearMonthPicVideo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnYearMonthPicVideo.Image = Properties.Resources.YearMonthPicsVideos;
            radioBtnYearMonthPicVideo.ImageAlign = ContentAlignment.BottomCenter;
            radioBtnYearMonthPicVideo.Location = new Point(16, 247);
            radioBtnYearMonthPicVideo.Name = "radioBtnYearMonthPicVideo";
            radioBtnYearMonthPicVideo.Size = new Size(212, 190);
            radioBtnYearMonthPicVideo.TabIndex = 12;
            radioBtnYearMonthPicVideo.Tag = "YearMonthPicturesAndVideos";
            radioBtnYearMonthPicVideo.Text = "Year \\ Month \\ Pics and Videos";
            radioBtnYearMonthPicVideo.TextAlign = ContentAlignment.TopCenter;
            radioBtnYearMonthPicVideo.TextImageRelation = TextImageRelation.TextAboveImage;
            radioBtnYearMonthPicVideo.UseVisualStyleBackColor = true;
            radioBtnYearMonthPicVideo.MouseHover += ShowTooltip;
            // 
            // radioBtnYearMonthMix
            // 
            radioBtnYearMonthMix.Appearance = Appearance.Button;
            radioBtnYearMonthMix.CheckAlign = ContentAlignment.TopLeft;
            radioBtnYearMonthMix.Cursor = Cursors.Hand;
            radioBtnYearMonthMix.Enabled = false;
            radioBtnYearMonthMix.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnYearMonthMix.Image = Properties.Resources.YearMonthMix;
            radioBtnYearMonthMix.Location = new Point(275, 247);
            radioBtnYearMonthMix.Name = "radioBtnYearMonthMix";
            radioBtnYearMonthMix.Size = new Size(242, 192);
            radioBtnYearMonthMix.TabIndex = 11;
            radioBtnYearMonthMix.Tag = "YearMonthMixedMedia";
            radioBtnYearMonthMix.Text = "Year \\ Month \\ Mix Media";
            radioBtnYearMonthMix.TextAlign = ContentAlignment.TopCenter;
            radioBtnYearMonthMix.TextImageRelation = TextImageRelation.TextAboveImage;
            radioBtnYearMonthMix.UseVisualStyleBackColor = true;
            radioBtnYearMonthMix.MouseHover += ShowTooltip;
            // 
            // radioBtnYearMix
            // 
            radioBtnYearMix.Appearance = Appearance.Button;
            radioBtnYearMix.CheckAlign = ContentAlignment.TopLeft;
            radioBtnYearMix.Cursor = Cursors.Hand;
            radioBtnYearMix.Enabled = false;
            radioBtnYearMix.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnYearMix.Image = Properties.Resources.YearMix;
            radioBtnYearMix.Location = new Point(16, 39);
            radioBtnYearMix.Name = "radioBtnYearMix";
            radioBtnYearMix.Size = new Size(242, 192);
            radioBtnYearMix.TabIndex = 10;
            radioBtnYearMix.Tag = "YearMixedMedia";
            radioBtnYearMix.Text = "Year \\ Mix Media";
            radioBtnYearMix.TextAlign = ContentAlignment.TopCenter;
            radioBtnYearMix.TextImageRelation = TextImageRelation.TextAboveImage;
            radioBtnYearMix.UseVisualStyleBackColor = true;
            radioBtnYearMix.MouseHover += ShowTooltip;
            // 
            // btnCopyFiles
            // 
            btnCopyFiles.BackColor = SystemColors.Control;
            btnCopyFiles.Font = new Font("Microsoft Sans Serif", 8F);
            btnCopyFiles.Location = new Point(307, 562);
            btnCopyFiles.Name = "btnCopyFiles";
            btnCopyFiles.Size = new Size(107, 35);
            btnCopyFiles.TabIndex = 17;
            btnCopyFiles.Text = "Copy Files";
            btnCopyFiles.UseVisualStyleBackColor = false;
            btnCopyFiles.Click += btnCopyFiles_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Font = new Font("Microsoft Sans Serif", 8F);
            btnCancel.Location = new Point(440, 562);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 35);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Close";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // toolTipTemplate
            // 
            toolTipTemplate.ToolTipIcon = ToolTipIcon.Info;
            toolTipTemplate.ToolTipTitle = "Template Description";
            // 
            // lblWarning
            // 
            lblWarning.ForeColor = Color.Firebrick;
            lblWarning.Location = new Point(12, 11);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(535, 57);
            lblWarning.TabIndex = 19;
            // 
            // Templates
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(563, 609);
            Controls.Add(lblWarning);
            Controls.Add(btnCancel);
            Controls.Add(btnCopyFiles);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 8F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Templates";
            Text = "Templates";
            Load += Templates_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnYearPicVideo;
        private System.Windows.Forms.RadioButton radioBtnYearMonthPicVideo;
        private System.Windows.Forms.RadioButton radioBtnYearMonthMix;
        private System.Windows.Forms.RadioButton radioBtnYearMix;
        private System.Windows.Forms.Button btnCopyFiles;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTipTemplate;
        private System.Windows.Forms.Label lblWarning;
    }
}