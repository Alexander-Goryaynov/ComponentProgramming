using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestingForms
{
    class Human
    {
        public int weight;
        public string name;
        public Human()
        {
            string template = "abcdefghijklmno";
            Thread.Sleep(10);
            Random rand = new Random();
            weight = rand.Next(20, 60);
            name = template.Substring(rand.Next(14));
        }
    }
}
