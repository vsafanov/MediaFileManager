
using MediaFileManager.Lib;
using MediaFileManager.Utilities;

namespace MediaFileManager.Reporting
{
    public partial class NewFilesInSource : Form
    {
        public NewFilesInSource(string title = null)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(title))
            {
                this.Text = title;
            }
        }

        public void LoadDataGrid(Response response)
        {
            dataGridViewReport.AutoGenerateColumns = false;
            dataGridViewReport.AllowUserToAddRows = false;
            lblTotal.Text = response.ListOfNewFiles.Count.ToString();

            var source = response.ListOfNewFiles.Select(x => new GridObject
            {
                FileName = x.FileName,
                FilePath = x.FilePath,
                FileSize = Helper.FormatBytes(x.FileSize),
                FileType = x.FileType.ToString(),
                TimeStamp = x.TimeStamp?.ToShortDateString(),
                FileSizeBytes = x.FileSize
            }).ToList();

            var list = new SortableBindingList<GridObject>(source);

            dataGridViewReport.DataSource = list;

            DataGridViewButtonColumn btnColumnPreview = new DataGridViewButtonColumn()
            {
                Name = "OpenFolder",
                //Image       = Properties.Resources.Open_16x16,
                ToolTipText = "Open Containing Folder",
                Text = "Open Folder",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.System
            };
            dataGridViewReport.Columns.Add(btnColumnPreview);
            DataGridViewButtonColumn btnColumnFolder = new DataGridViewButtonColumn()
            {
                Name = "Preview",
                //Image       = Properties.Resources.Open_16x16,
                ToolTipText = "Preview Media File",
                Text = "Preview",
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.System

            };
            dataGridViewReport.Columns.Add(btnColumnFolder);

            var p = new Padding(3);
            btnColumnPreview.DefaultCellStyle.Padding = p;
            btnColumnFolder.DefaultCellStyle.Padding = p;

            var listColumns = "File Path,File Size,Time Stamp, File Size Bytes";


            foreach (var item in listColumns.Split(','))
            {
                var name = item.Trim();
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
                {
                    Name = name.Replace(" ", ""),
                    HeaderText = name,
                    DataPropertyName = name.Replace(" ", "")
                };

                dataGridViewReport.Columns.Add(column);
            }
        }

        private void dataGridViewReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var path = dataGridViewReport.SelectedRows[0].Cells["FilePath"].Value?.ToString();
                switch (senderGrid.Columns[e.ColumnIndex].Name)
                {
                    case "OpenFolder":
                        Helper.SelectFileInFolder(path);
                        break;
                    case "Preview":
                        Helper.OpenFile(path);
                        break;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
