
using L2Module6.Loggers;

namespace L2Module6.Strategies
{
    public interface IPersistenceStrategy
    {
        void Store(LogObject storable);
    }
}
