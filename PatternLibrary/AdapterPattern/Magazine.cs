using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary.AdapterPattern
{
    public class Magazine : IJournal
    {
        public string GetDescription()
        {
            return "тонкий журнал";
        }
    }
}
