using System;

namespace Cerberix.Logging.Core
{
    public interface ILogSink
    {
        void Log(LogSeverity severity, string message, Exception exception = null);
    }
}
