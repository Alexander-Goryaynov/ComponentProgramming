using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary
{
    public class FreshJournal : Journal
    {
        public override string GetPrice()
        {
            var rnd = new Random();
            return rnd.Next(100, 500).ToString();
        }
    }
}
