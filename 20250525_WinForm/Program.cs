using log4net;
[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]

namespace _20250525_WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new ORDER());
        }
    }
}

/// <summary>
/// ログ出力用クラス
/// </summary>
public class Log()
{
    static public ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().Name);
}
