using System.Diagnostics;

namespace MediaFileManager
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            //MessageBox.Show(Assembly.GetExecutingAssembly().Location);
            var path = Application.ExecutablePath;
            var buildTime       = File.GetLastWriteTime(path).ToString("MMM dd yyyy - HH:mm:ss");
            var versionInfo     = FileVersionInfo.GetVersionInfo(path);

            lblVersion.Text = $"Version:           {versionInfo.FileVersion}";
            lblBuildDate.Text = $"Build Date:      {buildTime}";
            lblAuthor.Text = $"Author:            Valeriy Safanov";
            //lblCompany.Text   = $"Company: {Application.CompanyName}";
            txtDescription.Text = $"{versionInfo.Comments}";

        }
    }
}
