using MediaFileManager.Lib;

namespace MediaFileManager
{
    public partial class FindFileBySizeConfig : Form
    {
        public string SelectedFolder { get; set; }
        public string SelectedFileType { get; set; }
        public int MaxFileSize { get; set; }
        public int MinFileSize { get; set; }
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
            MaxFileSize = int.Parse(txtFileSize.Text);
            MinFileSize = int.Parse(txtMinFileSize.Text);
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


        private void txtFileSize_TextChanged(object sender, EventArgs e)
        {
            var control = sender as TextBox;
            var result = control == txtFileSize ? 10 : 100;
            if (!int.TryParse(txtFileSize.Text, out result))
            {
                control.Text = result.ToString();
            }
        }

        private void txtFileSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {

                e.Handled = true;
            }
        }
    }
}
