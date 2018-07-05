using System;
using System.Collections.Generic;
using System.Text;
using L2Module6.Loggers;
using L2Module6.Strategies;

namespace LoggerDemo
{
    class MultipleStrategy : IPersistenceStrategy
    {
        FileStrategy fileStrategy = new FileStrategy("testmulti.txt",'^');
        LiteDatabaseStrategy dbStrategy = new LiteDatabaseStrategy("testmulti");
        ConsoleStrategy consoleStrategy = new ConsoleStrategy();
        public void Store(LogObject storable)
        {
            fileStrategy.Store(storable);
            dbStrategy.Store(storable);
            consoleStrategy.Store(storable);
        }
    }
}
