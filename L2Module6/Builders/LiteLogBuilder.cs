
using System;
using L2Module6.Strategies;

namespace L2Module6.Builders
{
    internal class LiteLogBuilder : ILogBuilder<LiteLog>
    {
        private LiteLog _liteLog = new LiteLog();

        public void AddLevel(LogLevel level)
        {
            _liteLog.Level = level;
        }

        public void AddMethod(string method)
        {
            _liteLog.Method = method;
        }

        public void AddMessage(string message)
        {
            _liteLog.Message = message;
        }

        public void AddException(string exception)
        {
            _liteLog.Exception = exception;
        }

        public void SetDate()
        {
            _liteLog.Date = DateTime.UtcNow;
        }

        public LiteLog GetObject()
        {
            return _liteLog;
        }
    }
}
