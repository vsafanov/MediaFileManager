using System.Diagnostics;
using System.Reflection;

namespace MediaFileManager
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            var buildTime       = File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location).ToString("MMM dd yyyy - HH:mm:ss");
            var versionInfo     = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);

            lblVersion.Text = $"Version:           {versionInfo.FileVersion}";
            lblBuildDate.Text = $"Build Date:      {buildTime}";
            lblAuthor.Text = $"Author:            Valeriy Safanov";
            //lblCompany.Text   = $"Company: {Application.CompanyName}";
            txtDescription.Text = $"{versionInfo.Comments}";

        }
    }
}
