using System;
using Cerberix.Logging.Core;

namespace Cerberix.Logging.NLogSink
{
    public class NLogSinkFactory
    {
        public static class NLoggerFactory
        {
            public static ILogSink NewInstance(Type logSinkType)
            {
                return new NLogSink(NLog.LogManager.GetCurrentClassLogger(loggerType: logSinkType));
            }
        }
    }
}
