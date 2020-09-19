using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingForms
{
    class Customer : Human
    {
        public int cash;
        public Customer() : base()
        {
            var rand = new Random();
            cash = rand.Next(10_000, 100_000);
        }
    }
}
