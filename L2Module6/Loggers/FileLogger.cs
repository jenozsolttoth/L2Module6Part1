using System;
using System.Configuration;
using System.IO;
using System.Text;

namespace L2Module6.Loggers
{
    //public class FileLogger : ILogger
    //{
    //    private FileLogger()
    //    {

    //    }
    //    public static FileLogger Instance { get { return NestedLogger.instance; } }

    //    private object lockobject = new object();
    //    public void Log(LogLevel level, Exception exception = null, string method = null, string message = null)
    //    {
    //        var logstring = $"{level.ToString()}|{method}|{message}|{exception} \r\n ";
    //        var buffer = Encoding.Unicode.GetBytes(logstring);
    //        var path = ConfigurationManager.AppSettings["LogFileName"];
    //        var bufferSize = 4096;
    //        lock (lockobject)
    //        {
    //            using (FileStream loggerStream = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.None, bufferSize: bufferSize, useAsync: false))
    //            {
    //                loggerStream.Write(buffer, 0, buffer.Length);
    //            }
    //        }
    //    }
    //    private class NestedLogger
    //    {
    //        static NestedLogger()
    //        {

    //        }
    //        internal static readonly FileLogger instance = new FileLogger();
    //    }
    //}
}
