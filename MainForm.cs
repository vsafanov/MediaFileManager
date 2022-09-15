
using MediaFileManager.Reporting;
using MediaFileManager.Utilities;
// using Microsoft.Extensions.Logging;
// using log4net;

using Serilog;

// ReSharper disable LocalizableElement

namespace MediaFileManager
{ 
    public partial class MainForm : Form
    {
        // private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);
        private readonly ILogger _logger;

        public MainForm(ILogger logger)
        {
            _logger = logger;
            _logger.Information("Main Form Started");
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyMediaFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSourceFolderPath.Text))
            {
                MessageBox.Show($@"Please select 'Source Folder'!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTargetFolderPath.Text))
            {
                MessageBox.Show($@"Please select 'Target Folder'!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            new Templates(_logger)
            {
                SourceFolderPath = txtSourceFolderPath.Text,
                TargetFolderPath = txtTargetFolderPath.Text
            }.ShowDialog();
        }

       

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Settings()).ShowDialog();
        }

        private void btnSourceFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = txtSourceFolderPath.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtSourceFolderPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnTargetFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = txtTargetFolderPath.Text;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.*", SearchOption.AllDirectories).Any())
                {
                    txtTargetFolderPath.Text = MessageBox.Show("Selected Target Directory is not empty, do you want to use it to copy files to?", "Target Directory: " + folderBrowserDialog.SelectedPath, MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes
                        ? folderBrowserDialog.SelectedPath
                        :"";
                }
                else
                {
                    txtTargetFolderPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void ShowTooltipFolder(object sender, EventArgs e)
        {
            var btn = sender as Button;

            toolTipFolder.ToolTipTitle = "Destination Folder";
            var text = "Please select Destination Folder to copy media files to";
            if (btn?.Name == nameof(btnSourceFolder))
            {
                text = "Please select Source Folder to copy media files from";
                toolTipFolder.ToolTipTitle = "Source Folder";
            }

            toolTipFolder.Show(text, btn);
        }

        private void findDuplicatedMediaFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFindCorrupted.Visible = false;
            btnFindNew.Visible = false;
            btnFindDuplicates.Visible = true;
        }

        private void findCorruptedMediaFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFindCorrupted.Visible = true;
            btnFindDuplicates.Visible = false;
            btnFindNew.Visible = false;
        }

        private void findNewMediaFilesInSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFindCorrupted.Visible  = false;
            btnFindDuplicates.Visible = false;
            btnFindNew.Visible        = true;

        }

        private void btnFindCorrupted_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSourceFolderPath.Text))
            {
                MessageBox.Show($@"Please select 'Source Folder'!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            DialogForm.StartProgress(this);

            var configuration = new Configuration
            {
                MediaFileExtensions = Properties.Settings.Default.SelectedMediaFilesExtension,
                MinFileSizeToCopy   = Properties.Settings.Default.SelectedMinFileSizeToCopy,
                SourceFolder        = txtSourceFolderPath.Text
            };

            var manager = new MediaManager(_logger, configuration);
            var response = manager.FindCorruptedFiles();
            var corruptedFiles = response.CorruptedFilesList;
            var timeElapsed = response.OperationDuration;
            var totalFilesProcessed = response.TotalFiles;

            DialogForm.CloseProgress();

            if (response.CorruptedFilesList.Count > 0)
            {
                var report = new CorruptedFiles();
                report.LoadData(response);
                report.StartPosition = FormStartPosition.CenterParent;
                report.ShowDialog();
            }
            else
            {
                MessageBox.Show("No corrupted media files found", "Information", MessageBoxButtons.OK);
            }
        }

        private void btnFindDuplicated_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSourceFolderPath.Text))
            {
                MessageBox.Show($@"Please select 'Source Folder'!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            DialogForm.StartProgress(this);

            var configuration = new Configuration
            {
                MediaFileExtensions = Properties.Settings.Default.SelectedMediaFilesExtension,
                MinFileSizeToCopy = Properties.Settings.Default.SelectedMinFileSizeToCopy,
                SourceFolder = txtSourceFolderPath.Text
            };

            var manager = new MediaManager(_logger, configuration);
            var response = manager.FindDuplicatedFiles();

            DialogForm.CloseProgress();
            if (response.ListOfDuplicatedFiles.Count > 0)
            {
                var report = new DuplicatedFiles(response);
                report.LoadDataTreeView();
                report.StartPosition = FormStartPosition.CenterParent;
                report.ShowDialog();
            }
            else
            {
                MessageBox.Show("No duplicated media files found!", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnOpenSourceFld_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSourceFolderPath.Text))
            {
                return;
            }
            Helper.OpenFolder(txtSourceFolderPath.Text);
        }

        private void btnOpenDestFld_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTargetFolderPath.Text))
            {
                return;
            }
            Helper.OpenFolder(txtTargetFolderPath.Text);
        }

        private void btnFindNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSourceFolderPath.Text))
            {
                MessageBox.Show($@"Please select 'Source Folder'!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTargetFolderPath.Text))
            {
                MessageBox.Show($@"Please select 'Target Folder'!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogForm.StartProgress(this);

            var configuration = new Configuration

            {
                MediaFileExtensions = Properties.Settings.Default.SelectedMediaFilesExtension,
                MinFileSizeToCopy   = Properties.Settings.Default.SelectedMinFileSizeToCopy,
                SourceFolder        = txtSourceFolderPath.Text,
                TargetFolder        = txtTargetFolderPath.Text
            };

            var manager = new MediaManager(_logger, configuration);
            var response = manager.FindNewFiles();

            DialogForm.CloseProgress();
            if (response.ListOfNewFiles.Count > 0)
            {
                var report = new NewFilesInSource();
                report.LoadDataGrid(response);
                report.StartPosition = FormStartPosition.CenterParent;
                report.ShowDialog();
            }
            else
            {
                MessageBox.Show("No new media files found in Source Directory!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
