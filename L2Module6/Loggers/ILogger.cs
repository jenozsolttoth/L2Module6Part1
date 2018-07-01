
using System;

namespace L2Module6.Loggers
{
    public interface ILogger
    {
        void Log(LogLevel Level, string Method, string Message, Exception Exception);
    }
}
