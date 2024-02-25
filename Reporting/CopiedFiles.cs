using System.ComponentModel;
using MediaFileManager.Lib;
using MediaFileManager.Utilities;

// ReSharper disable LocalizableElement

namespace MediaFileManager.Reporting
{
    public partial class CopiedFiles : Form
    {
        public CopiedFiles()
        {
            InitializeComponent();
        }

        public void PopulateResponse(Response response)
        {

            listViewCorrupted.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            listViewCorrupted.Clear();

            listViewCorrupted.View = View.Details;
            listViewCorrupted.Columns.Add("Corrupted Media Files", "Corrupted Media Files");
            listViewCorrupted.Columns[0].Width = listViewCorrupted.Width;

            foreach (var item in response.CorruptedFilesList)
            {
                var i = listViewCorrupted.Items.Add(item);
                i.ToolTipText = "Double click to open file location";
            }

            btnShowCorrupted.Visible = response.CorruptedFilesList.Any();

            gridErrors.DataSource = response.ExceptionList.Select(x => new { Error = x }).ToList();
            btnShowErrors.Visible = response.ExceptionList.Any();

            //gridErrors.Visible = btnShowErrors.Visible;

            lblCopied.Text = response.FilesCopied.ToString();
            lblSkipped.Text = response.FilesNotCopied.ToString();
            lblTotalFiles.Text = response.TotalFiles.ToString();
            lblDuration.Text = response.OperationDuration.ToString(@"hh\:mm\:ss");
            lblUndated.Text = response.UndatedFiles.ToString();

            LoadDataGrid(response);
        }

        private void ListViewCorruptedOnMouseDoubleClick(object sender, MouseEventArgs mouseEventArgs)
        {
            var filePath = listViewCorrupted.SelectedItems[0].Text;
            Helper.SelectFileInFolder(filePath);
        }

        public void LoadDataGrid(Response response)
        {
            gridNotCopied.SendToBack();
            gridNotCopied.AutoGenerateColumns = false;
            gridNotCopied.AllowUserToAddRows = false;

            var source = response.ListOfFilesNotCopied.Select(x => new GridObject
            {
                FileName  = x.FileName,
                FilePath  = x.FilePath,
                FileSize  = Helper.FormatBytes(x.FileSize),
                FileType  = x.FileType.ToString(),
                TimeStamp = x.TimeStamp?.ToShortDateString(),
                FileSizeBytes = x.FileSize
            }).ToList();

            var list = new SortableBindingList<GridObject>(source);

            gridNotCopied.DataSource = list;

            DataGridViewButtonColumn btnColumnPreview = new DataGridViewButtonColumn()
            {
                Name = "OpenFolder",
                //Image       = Properties.Resources.Open_16x16,
                ToolTipText                 = "Open Containing Folder",
                Text                        = "Open Folder",
                UseColumnTextForButtonValue = true,
                FlatStyle                   = FlatStyle.System
            };
            gridNotCopied.Columns.Add(btnColumnPreview);
            DataGridViewButtonColumn btnColumnFolder = new DataGridViewButtonColumn()
            {
                Name = "Preview",
                //Image       = Properties.Resources.Open_16x16,
                ToolTipText                 = "Preview Media File",
                Text                        = "Preview",
                UseColumnTextForButtonValue = true,
                FlatStyle                   = FlatStyle.System

            };
            gridNotCopied.Columns.Add(btnColumnFolder);

            var p = new Padding(3);
            btnColumnPreview.DefaultCellStyle.Padding = p;
            btnColumnFolder.DefaultCellStyle.Padding = p;

            var listColumns = "File Path,File Size,Time Stamp,File Size Bytes";

            //DataGridViewImageColumn imgColumn = new DataGridViewImageColumn()
            //{
            //    Name             = "Preview",
            //    Image            = Properties.Resources.Image_16x16,
            //    ToolTipText = "Click to Preview File"

            //};
            //gridNotCopied.Columns.Add(imgColumn);

            foreach (var item in listColumns.Split(','))
            {
                var name = item.Trim();
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
                {
                    Name             = name.Replace(" ", ""),
                    HeaderText       = name,
                    DataPropertyName = name.Replace(" ", "")
                };

                gridNotCopied.Columns.Add(column);
            }
        }

        private void gridNotCopied_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var path = gridNotCopied.SelectedRows[0].Cells["FilePath"].Value?.ToString();
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

        private void btnShowErrors_Click(object sender, EventArgs e)
        {
            if (gridErrors.Visible)
            {
                gridErrors.Visible = false;
                btnShowErrors.Text = "Show Errors";
            }
            else
            {
                gridErrors.Visible = true;
                btnShowErrors.Text = "Hide Errors";
            }
        }

        private void gridNotCopied_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var path = gridNotCopied.SelectedRows[0].Cells["FilePath"].Value?.ToString();
            if (e.ColumnIndex != gridNotCopied.Columns["OpenFolder"]?.Index)
            {
                Helper.OpenFile(path);
            }
            if (e.ColumnIndex != gridNotCopied.Columns["Preview"]?.Index)
            {
                Helper.SelectFileInFolder(path);
            }
        }

        //this method is not being used
        [Obsolete]
        private void gridNotCopied_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = gridNotCopied.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = gridNotCopied.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    gridNotCopied.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            gridNotCopied.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending;
        }

        private void btnShowCorrupted_Click(object sender, EventArgs e)
        {
            if (listViewCorrupted.Visible)
            {
                listViewCorrupted.Visible = false;
                btnShowCorrupted.Text = "Show Corrupted";
            }
            else
            {
                listViewCorrupted.Visible = true;
                btnShowCorrupted.Text = "Hide Corrupted";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class GridObject
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileSize { get; set; }
        public string FileType { get; set; }
        public string TimeStamp { get; set; }

        public long FileSizeBytes { get; set; }
    }
}
