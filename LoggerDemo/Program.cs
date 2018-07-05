using System;
using System.Configuration;
using L2Module6;
using L2Module6.Factories;
using L2Module6.Loggers;
using L2Module6.Strategies;

namespace LoggerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = Logger.Instance;
            Logger.PersistenceStrategy = new MultipleStrategy();
            logger.Log(new LogObject(){Exception = new TimeoutException("sajtreszelo"), Level = LogLevel.Critical, Message = "No message", Method = "Method"});
        }
    }
}
