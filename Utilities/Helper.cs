using System.Diagnostics;

namespace MediaFileManager.Utilities
{
    public class Helper
    {
        public static string FormatBytes(long bytes)
        {
            string[] suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }
            return $"{dblSByte:0.##} {suffix[i]}";
        }

        public static void OpenFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return;
            }

            try
            {
                // System.Diagnostics.Process.Start(filePath);
                ProcessStartInfo startInfo = new ProcessStartInfo(filePath)
                {
                    UseShellExecute = true
                };


                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public static void SelectFileInFolder(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return;
            }

            var argument = "/select, \"" + filePath + "\"";
            System.Diagnostics.Process.Start("explorer.exe", argument);
        }

        public static void OpenFolder(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                return;
            }

            try
            {
                // System.Diagnostics.Process.Start(folderPath);
                ProcessStartInfo startInfo = new ProcessStartInfo(folderPath)
                {
                    UseShellExecute = true
                };


                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
