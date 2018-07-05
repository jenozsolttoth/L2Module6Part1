
using System;
using System.Text;

namespace L2Module6.Builders
{
    public class StringLogBuilder : ILogBuilder<string>
    {
        StringBuilder logBuilder = new StringBuilder();
        public char Delimeter { get; set; }

        public StringLogBuilder()
        {
            Delimeter = '|';
        }
        public void AddLevel(LogLevel level)
        {
            logBuilder.Append(level);
        }

        public void AddMethod(string method)
        {
            logBuilder.Append(method);
        }

        public void AddMessage(string message)
        {
            logBuilder.Append(message);
        }

        public void AddException(string exception)
        {
            logBuilder.Append(exception);
        }

        public void SetDate()
        {
            logBuilder.Append(DateTime.UtcNow);
        }

        public string GetObject()
        {
            return logBuilder.ToString();
        }
        public void AddDelimeter()
        {
            logBuilder.Append(Delimeter);
        }

        public void CloseLogRecord()
        {
            logBuilder.Append("\r\n");
        }
    }
}
