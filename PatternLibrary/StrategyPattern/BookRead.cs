using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary.StrategyPattern
{
    class BookRead : IReadable
    {
        public string Read()
        {
            return "Читаем книгу";
        }
    }
}
