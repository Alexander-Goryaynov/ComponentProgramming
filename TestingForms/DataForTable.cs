using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestingForms
{
    public class DataForTable
    {
        public int s;
        public int x;
        public int y;
        public int z;
        public string id;

        public DataForTable()
        {
            string randString = "adfjskasfasfdojadpof";
            Thread.Sleep(10);
            Random rand = new Random();
            x = rand.Next(90, 201);
            y = rand.Next(9, 19);
            z = rand.Next(19, 56);
            s = x + y + z;
            id = randString.Substring(rand.Next(11));
        }
    }
}
