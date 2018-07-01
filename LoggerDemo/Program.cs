using System;
using System.Configuration;
using L2Module6.Factories;
namespace LoggerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = GetFactory();
            var logger = factory.CreateLogger();
            logger.Log(L2Module6.LogLevel.CRITICAL, "MostImportantMethod","Such error, many critical, very issues.", new TimeoutException("issue"));
        }
        static ILoggerFactory GetFactory()
        {
            string factoryName = ConfigurationManager.AppSettings["LoggerFactory"];
            return typeof(ILoggerFactory).Assembly.CreateInstance(factoryName) as ILoggerFactory;
        }
    }
}
