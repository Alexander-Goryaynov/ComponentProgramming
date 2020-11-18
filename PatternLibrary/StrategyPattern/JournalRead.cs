using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary.StrategyPattern
{
    class JournalRead : IReadable
    {
        public string Read()
        {
            return "Листаем журнал";
        }
    }
}
