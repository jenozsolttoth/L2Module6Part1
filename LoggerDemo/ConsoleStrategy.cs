using System;
using L2Module6.Loggers;
using L2Module6.Strategies;

namespace LoggerDemo
{
    public class ConsoleStrategy : IPersistenceStrategy
    {
        public void Store(LogObject storable)
        {
            Console.WriteLine(storable.Exception.ToString() + "|" + storable.Level.ToString() + "|" + storable.Message.ToString() + "|" + storable.Method.ToString());
        }
    }
}
