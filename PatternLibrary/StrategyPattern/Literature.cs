using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary.StrategyPattern
{
    class Literature
    {
        public IReadable ReadStrategy { get; set; }
        public Literature(IReadable readStrategy)
        {
            ReadStrategy = readStrategy;
        }
        public string Read()
        {
            return ReadStrategy.Read();
        }
    }
}
