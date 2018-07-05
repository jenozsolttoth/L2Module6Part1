using System;
using L2Module6.Loggers;

namespace L2Module6.Factories
{
    public class DatabaseLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            //return DatabaseLogger.Instance;
            return null;
        }
    }
}
