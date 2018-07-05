
using System;
using System.Configuration;
using System.IO;
using System.Text;
using L2Module6.Builders;
using L2Module6.Loggers;

namespace L2Module6.Strategies
{
    public class FileStrategy : IPersistenceStrategy
    {
        private readonly string _path;
        private readonly char _delimeter;
        private readonly object _lockobject = new object();

        public FileStrategy(string path, char delimeter)
        {
            _path = path;
            _delimeter = delimeter;
        }

        private string GetLogString(LogLevel level, Exception exception, string method, string message)
        {
            var builder = GetStringLogBuilder();
            builder.Delimeter = _delimeter;

            builder.AddLevel(level);
            builder.AddDelimeter();
            builder.AddMethod(method);
            builder.AddDelimeter();
            builder.AddMessage(message);
            builder.AddDelimeter();
            builder.AddException(exception?.ToString());
            builder.AddDelimeter();
            builder.SetDate();
            builder.CloseLogRecord();

            return builder.GetObject();
        }

        private StringLogBuilder GetStringLogBuilder()
        {
            return Activator.CreateInstance<StringLogBuilder>();
        }
        public void Store(LogObject storable)
        {
            var logstring = GetLogString(storable.Level, storable.Exception, storable.Method, storable.Message);

            var buffer = Encoding.Unicode.GetBytes(logstring);
            var bufferSize = 4096;
            lock ( _lockobject )
            {
                using ( FileStream loggerStream = new FileStream(_path, FileMode.Append, FileAccess.Write, FileShare.None, bufferSize: bufferSize, useAsync: false) )
                {
                    loggerStream.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
