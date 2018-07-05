
using System;

namespace L2Module6.Loggers
{
    public class LogObject
    {
        public LogLevel Level { get; set; }
        public Exception Exception { get; set; }
        public string Method { get; set; }
        public string Message { get; set; }
    }
}
