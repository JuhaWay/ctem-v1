using log4net;

namespace ChiTonPrivateEnterpriseManagement.Classes.Global
{
    public class Logger
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(Logger));

        public static void WriteLog(LogLevel logLevel, string content)
        {
            switch (logLevel)
            {
                case LogLevel.DEBUG:
                    {
                        _logger.Debug(content);
                        break;
                    }
                case LogLevel.ERROR:
                    {
                        _logger.Error(content);
                        break;
                    }
                case LogLevel.FATAL:
                    {
                        _logger.Fatal(content);
                        break;
                    }
                case LogLevel.INFO:
                    {
                        _logger.Info(content);
                        break;
                    }
                case LogLevel.WARN:
                    {
                        _logger.Warn(content);
                        break;
                    }
                default:
                    _logger.Debug(content);
                    break;

            }
            return;
        }
    }

    public enum LogLevel
    {
        DEBUG = 0,
        ERROR = 1,
        FATAL = 2,
        INFO = 3,
        WARN = 4
    }
}
