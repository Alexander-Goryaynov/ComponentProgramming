using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary.AdapterPattern
{
    public class Literature
    {
        public string Create(IBook book)
        {
            return book.GetAnnotation();
        }
    }
}
