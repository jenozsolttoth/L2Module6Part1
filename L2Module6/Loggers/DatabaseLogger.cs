using System;
using LiteDB;

namespace L2Module6.Loggers
{
    //public class DatabaseLogger : ILogger
    //{
    //    private static string _dbConnectionString;
    //    private DatabaseLogger()
    //    {

    //    }

    //    public static void SetConnection(string dbConnectionString)
    //    {
    //        _dbConnectionString = dbConnectionString;
    //    }

    //    public static DatabaseLogger Instance => NestedDatabaseLogger.Instance;

    //    public void Log(LogLevel level, Exception exception = null, string method = null, string message = null)
    //    {
    //        using (var db = new LiteDatabase(_dbConnectionString))
    //        {
    //            var logdb = db.GetCollection<LiteLog>("logs");
    //            var logEntity = new LiteLog() { Level = level, Method = method, Message = message, Exception = exception.ToString(), Date = DateTime.Now };
    //            logdb.Insert(logEntity);
    //            logdb.EnsureIndex(x => x.Level);
    //            var test = logdb.Find(x => x.Level == LogLevel.Critical);
    //        }
    //    }
    //    private class NestedDatabaseLogger
    //    {
    //        static NestedDatabaseLogger()
    //        {
    //            if (_dbConnectionString == null)
    //            {
    //                _dbConnectionString = "logger.db";
    //            }
    //        }
    //        internal static readonly DatabaseLogger Instance = new DatabaseLogger();
    //    }
    //}
    //class LiteLog
    //{
    //    public Guid Id { get; set; }
    //    public LogLevel Level { get; set; }
    //    public string Method { get; set; }
    //    public string Message { get; set; }
    //    public string Exception { get; set; }
    //    public DateTime Date { get; set; }
    //}
}
