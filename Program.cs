using Serilog;


namespace MediaFileManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ///Generate Host Builder and Register the Services for DI
            ///
            ///                     //Add Serilog
            var logFile = "MediaFileManager.log";

            var template = "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] {Message}{NewLine}{Exception}";
            var logger = new LoggerConfiguration()
                .WriteTo.File(logFile, outputTemplate: template)
                .CreateLogger();

            Application.Run(new MainForm(logger));
        }
    }
}