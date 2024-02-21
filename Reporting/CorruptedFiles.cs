

using MediaFileManager.Lib;

namespace MediaFileManager.Reporting
{
    public partial class CorruptedFiles : Form
    {
        public CorruptedFiles()
        {
            InitializeComponent();
        }

        public void LoadData(Response response)
        {
            dataGridViewReport.AutoGenerateColumns = false;
            dataGridViewReport.AllowUserToAddRows = false;
            dataGridViewReport.DataSource = response.CorruptedFilesList.Select(x => new { File = x }).ToList();


            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
            {
                Name = "File",
                HeaderText = "File Path",
                DataPropertyName = "File",
            };
            dataGridViewReport.Columns.Add(column);
        }

        private void btnOpenInFolder_Click(object sender, EventArgs e)
        {
            if (dataGridViewReport.CurrentCell == null)
            {
                return;
            }
            var filePath = dataGridViewReport.CurrentCell.Value.ToString();
            //var folder = path.Substring(0, path.LastIndexOf(@"\"));

            if (!File.Exists(filePath))
            {
                return;
            }

            // combine the arguments together
            // it doesn't matter if there is a space after ','
            string argument = "/select, \"" + filePath + "\"";

            System.Diagnostics.Process.Start("explorer.exe", argument);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
