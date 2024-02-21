namespace MediaFileManager.Lib
{
    public partial class Progress : Form
    {
        private int total;
        private int current = 0;
        public Progress()
        {
            InitializeComponent();
        }

        public void AddLine(string line)
        {
            txtConsole.Text += Environment.NewLine + line;
            txtConsole.SelectionStart = txtConsole.Text.Length;
            txtConsole.ScrollToCaret();
        }

        public void TotalFiles(int totalFiles)
        {
            total = totalFiles;
        }

        public void UpdateProgress()
        {
            //total is 100% 
            current++;
            progressBar1.Value = current * 100 / total;
            progressBar1.Text = current * 100 / total + " %";

        }
    }
}
