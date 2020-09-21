using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestingForms
{
    [Serializable]
    class Human
    {
        public int weight;
        public string name;
        public Human()
        {
            string template = "abcdefghijklmno";
            Thread.Sleep(10);
            Random rand = new Random();
            weight = rand.Next(50, 90);
            name = template.Substring(rand.Next(14));
        }
    }
}
