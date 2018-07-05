
using System;

namespace L2Module6.Builders
{
    public interface ILogBuilder<T>
    {
        void AddLevel(LogLevel level);

        void AddMethod(string method);

        void AddMessage(string message);

        void AddException(string exception);

        void SetDate();

        T GetObject();
    }
}
