using System;
using LiteDB;
using System.Configuration;

namespace L2Module6.Loggers
{
    public class DatabaseLogger : ILogger
    {
        private DatabaseLogger()
        {

        }
        public static DatabaseLogger Instance { get { return NestedDatabaseLogger.instance; } }

        public void Log(LogLevel Level, string Method, string Message, Exception Exception)
        {
            string logdbstring = ConfigurationManager.AppSettings["DatabaseConnectionString"];
            using (var db = new LiteDatabase(logdbstring))
            {
                var logdb = db.GetCollection<LiteLog>("logs");
                var logEntity = new LiteLog() { Level = Level, Method = Method, Message = Message, Exception = Exception.ToString(), Date = DateTime.Now };
                logdb.Insert(logEntity);
                logdb.EnsureIndex(x => x.Level);
                var test = logdb.Find(x => x.Level == LogLevel.CRITICAL);
            }
        }
        private class NestedDatabaseLogger
        {
            static NestedDatabaseLogger()
            {

            }
            internal static readonly DatabaseLogger instance = new DatabaseLogger();
        }
    }
    class LiteLog
    {
        public Guid Id { get; set; }
        public LogLevel Level { get; set; }
        public string Method { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public DateTime Date { get; set; }
    }
}
