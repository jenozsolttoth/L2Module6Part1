
using L2Module6.Strategies;

namespace L2Module6.Loggers
{
    public class Logger : ILogger
    {
        public static IPersistenceStrategy PersistenceStrategy;
        private Logger()
        {
            PersistenceStrategy =
                PersistenceStrategy ?? new FileStrategy("logfilestrategy.txt", ';');
        }
        public static Logger Instance => NestedLogger.instance;

        public void Log(LogObject obj)
        {
            PersistenceStrategy.Store(obj);
        }
        private class NestedLogger
        {
            static NestedLogger()
            {

            }
            
            internal static readonly Logger instance = new Logger();
        }
        
    }
}
