using System;
using NLog;

namespace Cerberix.Logging.NLogSink
{
    public class NLogSinkFactory
    {
        public static class NLoggerFactory
        {
            public static ILogSink NewInstance(Type loggerType)
            {
                return new NLogSink(LogManager.GetCurrentClassLogger(loggerType: loggerType));
            }
        }

        private class NLogSink : ILogSink
        {
            private readonly Logger _logger;
            public NLogSink(Logger logger)
            {
                _logger = logger;
            }

            public void Log(LogSeverity severity, string message, Exception exception = null)
            {
                switch (severity)
                {
                    case LogSeverity.Debug:
                        _logger.Debug(exception, message);
                        break;
                    case LogSeverity.Info:
                        _logger.Info(exception, message);
                        break;
                    case LogSeverity.Warn:
                        _logger.Warn(exception, message);
                        break;
                    case LogSeverity.Error:
                        _logger.Error(exception, message);
                        break;
                    case LogSeverity.Fatal:
                        _logger.Fatal(exception, message);
                        break;
                    default:
                        throw new NotImplementedException($"Unsupported log severity: {severity.ToString()}");
                }
            }
        }
    }
}
