using L2Module6.Loggers;
namespace L2Module6.Factories
{
    public class FileLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return FileLogger.Instance;
        }
    }
}
