using MediaFileManager.Lib;

namespace MediaFileManager
{
    public partial class FindFileBySizeConfig : Form
    {
        public string SelectedFolder { get; set; }
        public string SelectedFileType { get; set; }
        public int MaxFileSize { get; set; }
        private readonly Configuration settings;
        public FindFileBySizeConfig(Configuration settings)
        {
            InitializeComponent();
            this.settings = settings;
            cmbFolders.SelectedIndex = 0;
            cmbFileType.SelectedIndex = 0;
            lblselectedFolderPath.Text = settings.SourceFolder;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SelectedFolder = lblselectedFolderPath.Text;
            SelectedFileType = cmbFileType.SelectedItem.ToString();
            MaxFileSize = (int)numericUpDownFileSize.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblselectedFolderPath.Text = cmbFolders.SelectedIndex == 0 ? settings.SourceFolder : settings.TargetFolder;
        }

        private void numericUpDownFileSize_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownFileSize.Value > 1000000)
            {
                numericUpDownFileSize.Value = 1000000;
            }
        }

        private void numericUpDownFileSize_ValueChanged(object sender, KeyPressEventArgs e)
        {
            if (numericUpDownFileSize.Value >= 1000000)
            {
                numericUpDownFileSize.Value = 1000000;
            }
        }
    }
}
