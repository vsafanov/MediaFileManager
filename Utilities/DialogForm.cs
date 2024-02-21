namespace MediaFileManager.Utilities
{
    public class DialogForm
    {
        private static Form frm;
        private static Form frmScreen;

        public static void StartProgress(Form parentForm)
        {
            frm = parentForm;
            frmScreen = new SplashScreen
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(frm.Location.X + frm.ClientSize.Width / 2 - 140, frm.Location.Y + frm.ClientSize.Height / 2 - 50)

            };
            ShowProgress();
        }
        public static void CloseProgress()
        {
            Thread.Sleep(200);
            frmScreen.Invoke(new Action(frmScreen.Close));
        }
        private static void ShowProgress()
        {
            try
            {
                if (frm.InvokeRequired)
                {
                    try
                    {
                        frmScreen.ShowDialog();
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {
                    Thread th = new Thread(ShowProgress)
                    {
                        IsBackground = false
                    };
                    th.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
