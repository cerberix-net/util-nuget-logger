using System;

namespace Cerberix.Logging
{
    public interface ILogSink
    {
        void Log(LogSeverity severity, string message, Exception exception = null);
    }
}
