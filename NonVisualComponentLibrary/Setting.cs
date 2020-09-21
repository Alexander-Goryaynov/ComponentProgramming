using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NonVisualComponentLibrary
{
    public class Setting
    {
        public int Value { get; set; }
        public string Legend { get; set; }
        public Setting()
        {
            string rand_string = "sergayivannalex";
            Thread.Sleep(100);
            Random rand = new Random();
            Value = rand.Next(50, 100);
            Legend = rand_string.Substring(rand.Next(15));
        }
    }
}
