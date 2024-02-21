
using MediaFileManager.Lib;
using MediaFileManager.Reporting;
using Serilog;

namespace MediaFileManager
{
    public partial class Templates : Form
    {
        private readonly ILogger _logger;
        public Templates(ILogger logger)
        {
            _logger = logger;
            InitializeComponent();
        }

        public string SourceFolderPath { get; set; }
        public string TargetFolderPath { get; set; }

        private void btnCopyFiles_Click(object sender, EventArgs e)
        {
            //DialogForm.StartProgress(this);
            var checkedTemplate = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedTemplate == null)
            {
                MessageBox.Show("Please select a template!", "Template is no  selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Enum.TryParse(checkedTemplate.Tag.ToString(), true, out CreationTemplate result);
            var configuration = new Configuration
            {
                MediaFileExtensions = Properties.Settings.Default.SelectedMediaFilesExtension,
                MinFileSizeToCopy   = Properties.Settings.Default.MinFileSizeToCopy,
                SourceFolder        = SourceFolderPath,
                TargetFolder        = TargetFolderPath,
                CreationTemplate    = result,
                OverwriteFiles      = Properties.Settings.Default.SelectedOverwriteFiles
            };

            var manager = new MediaManager(_logger, configuration);
            var response = manager.CopyFiles();

            //DialogForm.CloseProgress();

            var report = new CopiedFiles();
            report.PopulateResponse(response);
            report.StartPosition = FormStartPosition.CenterParent;
            report.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowTooltip(object sender, EventArgs e)
        {
            var radioBtn = sender as RadioButton;
            toolTipTemplate.IsBalloon = true;

            if (radioBtn != null)
                toolTipTemplate.Show(radioBtn.Text, radioBtn);
        }

        private void Templates_Load(object sender, EventArgs e)
        {
            var structure = new TargetFolderStructure();
            var currentStructure = structure.GetExistingTemplate(TargetFolderPath);

            btnCopyFiles.Enabled = true;

            lblWarning.ForeColor = Color.Green;
            var warning = "The current Destination folder has the structure as in selected template.\n If you want to chose a different template, please select an empty folder or delete the existing content.";

            switch (currentStructure)
            {
                case CreationTemplate.YearMixedMedia:
                    radioBtnYearMix.Checked = true;
                    break;
                case CreationTemplate.YearMonthMixedMedia:
                    radioBtnYearMonthMix.Checked = true;
                    break;
                case CreationTemplate.YearPicturesAndVideos:
                    radioBtnYearPicVideo.Checked = true;
                    break;
                case CreationTemplate.YearMonthPicturesAndVideos:
                    radioBtnYearMonthPicVideo.Checked = true;
                    break;
                default:
                    if (Directory.GetDirectories(TargetFolderPath).Any())
                    {
                        warning = "The Destination folder is not empty and does not fit to any available template structure.\n Please select an empty folder or delete it content.";
                        lblWarning.ForeColor = Color.Brown;
                        btnCopyFiles.Enabled = false;
                        break;
                    }
                    radioBtnYearMix.Enabled = true;
                    radioBtnYearMonthMix.Enabled = true;
                    radioBtnYearPicVideo.Enabled = true;
                    radioBtnYearMonthPicVideo.Enabled = true;
                    warning = String.Empty;
                    break;
            }

            lblWarning.Text = warning;
        }
    }
}
