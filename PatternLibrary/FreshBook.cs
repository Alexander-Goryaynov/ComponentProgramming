using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary
{
    public class FreshBook : Book
    {
        public override string GetInfoPageText()
        {
            var rnd = new Random();
            return "ISBN: " + rnd.Next(100_000, 999_999);
        }
    }
}
