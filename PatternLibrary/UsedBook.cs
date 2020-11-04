using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary
{
    public class UsedBook : Book
    {
        public override string GetInfoPageText()
        {
            string phrase = "Владушбелиге";
            var rnd = new Random();
            return "Владелец: " +
                phrase.Substring(rnd.Next(0, 3), rnd.Next(5, phrase.Length - 1));
        }
    }
}
