
using MediaFileManager.Utilities;
using MediaFileManager.Properties;

namespace MediaFileManager.Reporting
{
    public partial class DuplicatedFiles : Form
    {
        private Response response;
        static ImageList _imageList;

        public DuplicatedFiles(Response response)
        {
            this.response = response;
            InitializeComponent();
            treeView1.ImageList = ImageList;
            treeView1.NodeMouseDoubleClick += (sender, args) => { Helper.OpenFile(treeView1.SelectedNode.Text); };
            treeView1.ShowNodeToolTips = true;

        }

        public static ImageList ImageList
        {
            get
            {
                if (_imageList == null)
                {
                    _imageList = new ImageList();
                    _imageList.Images.Add("Picture", Resources.Image_16x16);
                    _imageList.Images.Add("Video", Resources.Video_16x16);
                }

                return _imageList;
            }
        }

        public void LoadDataTreeView()
        {
            PopulateTreeView(response.ListOfDuplicatedFiles);
        }

        private void PopulateTreeView(Dictionary<string, List<MediaFile>> list)
        {
            foreach (var item in list)
            {
                var parentText = item.Key + " from " + item.Value[0].TimeStamp.ToShortDateString() + " (Total of " + item.Value.Count + ")";
                var p = treeView1.Nodes.Add(item.Key, parentText, item.Value[0].FileType.ToString());
                p.SelectedImageKey = item.Value[0].FileType.ToString();
                foreach (var mediaFile in item.Value)
                {
                    var c = p.Nodes.Add(mediaFile.FilePath, mediaFile.FilePath, mediaFile.FileType.ToString());
                    c.SelectedImageKey = mediaFile.FileType.ToString();

                    c.ToolTipText = "Click twice to peview file";
                }
            }
        }

        public void LoadDataGrid()
        {
            dataGridViewReport.AutoGenerateColumns = false;
            dataGridViewReport.AllowUserToAddRows = false;
            var df = response.ListOfDuplicatedFiles.Values.SelectMany(x => x);
            dataGridViewReport.DataSource = df.Select(x => new
            {
                FileName = x.FileName,
                FilePath = x.FilePath,
                FileSize = Helper.FormatBytes(x.FileSize),
                x.FileType,
                TimeStamp = x.TimeStamp.ToShortDateString()
            }).ToList();

            var listColumns = "File Name,File Path,File Size,Time Stamp,Time Stamp";

            foreach (var item in listColumns.Split(','))
            {
                var name = item.Trim();
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
                {
                    Name = name.Replace(" ", ""),
                    HeaderText = name,
                    DataPropertyName = name.Replace(" ", ""),
                };
                dataGridViewReport.Columns.Add(column);
            }

        }

        private void btnOpenInFolder_Click(object sender, EventArgs e)
        {

            if (treeView1.SelectedNode == null) return; 

            Helper.SelectFileInFolder(treeView1.SelectedNode.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null) return; 

            Helper.OpenFile(treeView1.SelectedNode.Text);
        }

      
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var filter = response.ListOfDuplicatedFiles;
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                filter = response.ListOfDuplicatedFiles.Where(x => x.Key.ToUpper().Contains(txtSearch.Text.ToUpper())).ToDictionary(i => i.Key, i => i.Value);
            }

            treeView1.Nodes.Clear();
            PopulateTreeView(filter);
        }

      
    }
}
