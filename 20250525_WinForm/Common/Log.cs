using log4net;

namespace _20250525_WinForm
{
    /// <summary>
    ///     ログ制御クラス
    /// </summary>
    static public class Log
    {
        /// <summary>ロガー</summary>
        static public ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name);
    }
}