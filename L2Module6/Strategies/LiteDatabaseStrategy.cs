
using System;
using System.Linq.Expressions;
using L2Module6.Builders;
using L2Module6.Loggers;
using LiteDB;

namespace L2Module6.Strategies
{
    public class LiteDatabaseStrategy : IPersistenceStrategy
    {
        private readonly string _dbConnectionString;
        public LiteDatabaseStrategy(string dbConnectionString)
        {
            _dbConnectionString = dbConnectionString;
        }
        public void Store(LogObject storable)
        {
            using ( var db = new LiteDatabase(_dbConnectionString) )
            {
                var collection = GetLiteDbCollection<LiteLog>(db, "logs");
                var logEntity = CreateLiteLogEntity(storable);
                InsertEntity(collection, logEntity);
                EnsureIndex(x=>x.Level, collection);
            }
        }

        private LiteCollection<T> GetLiteDbCollection<T>(LiteDatabase db, string collectionName)
        {
            return db.GetCollection<T>(collectionName); 
        }

        private void InsertEntity<T>(LiteCollection<T> dbCollection, T entity)
        {
            dbCollection.Insert(entity);
        }

        private void EnsureIndex<T,TK>(Expression<Func<T,TK>> expr, LiteCollection<T> collection)
        {
            collection.EnsureIndex(expr);
        }
        private LiteLog CreateLiteLogEntity(LogObject obj)
        {
            var builder = Activator.CreateInstance<LiteLogBuilder>();
            builder.AddException(obj.Exception?.ToString());
            builder.AddLevel(obj.Level);
            builder.AddMessage(obj.Message);
            builder.AddMethod(obj.Method);
            builder.SetDate();
            return builder.GetObject();
        }
    }
    public class LiteLog
    {
        public Guid Id { get; set; }
        public LogLevel Level { get; set; }
        public string Method { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public DateTime Date { get; set; }
    }
}
