namespace MediaFileManager
{
    public partial class Settings : Form
    {
        private bool checkAll = true;

        public Settings()
        {
            InitializeComponent();
        }

        private void LoadDefaultSettings()
        {
            numericUpDownMinFileSize.Value = Properties.Settings.Default.SelectedMinFileSizeToCopy;
            chkOverwrite.Checked           = Properties.Settings.Default.SelectedOverwriteFiles;
            var selectedMediaFilesExt      = Properties.Settings.Default.SelectedMediaFilesExtension.Split(',').Select(t => t.Trim()).ToList();

            var mediaFilesExt              = Properties.Settings.Default.DefaultMediaFilesExtension.Split(',').Select(t => t.Trim()).ToList();
            var allMediaExt                = mediaFilesExt.Union(selectedMediaFilesExt, StringComparer.CurrentCultureIgnoreCase).Distinct();
            checkedListBoxPictureTypes.Items.Clear();
            foreach (var ext in allMediaExt)
            {
                checkedListBoxPictureTypes.Items.Add(ext.ToUpper(), selectedMediaFilesExt.Contains(ext, StringComparer.CurrentCultureIgnoreCase));
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            LoadDefaultSettings();
        }

        private void btnToggleAll_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < checkedListBoxPictureTypes.Items.Count; i++)
            {
                checkedListBoxPictureTypes.SetItemChecked(i, checkAll);
            }

            checkAll = !checkAll;
        }

        private void btnAddExt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtExt.Text))
            {
                foreach (var item in checkedListBoxPictureTypes.Items)
                {
                    if (item?.ToString()?.ToUpper() == txtExt.Text.ToUpper())
                    {
                        MessageBox.Show($@"The extension '{txtExt.Text}' is already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
                checkedListBoxPictureTypes.Items.Add(txtExt.Text.ToUpper(), true);
                txtExt.Text = string.Empty;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SelectedOverwriteFiles = Properties.Settings.Default.OverwriteFiles;
            Properties.Settings.Default.SelectedMediaFilesExtension = Properties.Settings.Default.DefaultMediaFilesExtension;
            Properties.Settings.Default.SelectedMinFileSizeToCopy = Properties.Settings.Default.MinFileSizeToCopy;
            Properties.Settings.Default.Save();
            LoadDefaultSettings();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var ext = "";
            foreach (var item in checkedListBoxPictureTypes.CheckedItems)
            {
                if (!string.IsNullOrEmpty(ext)) ext += ",";
                ext += item.ToString();
            }

            Properties.Settings.Default.SelectedOverwriteFiles = chkOverwrite.Checked;
            Properties.Settings.Default.SelectedMediaFilesExtension = ext;
            Properties.Settings.Default.SelectedMinFileSizeToCopy = long.Parse(numericUpDownMinFileSize.Text);
            Properties.Settings.Default.Save();
        }

        private void txtExt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
