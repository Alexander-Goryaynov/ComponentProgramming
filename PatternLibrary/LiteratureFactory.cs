using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary
{
    abstract public class LiteratureFactory
    {
        abstract public string GetName();
        abstract public Book CreateBook();
        abstract public Journal CreateJournal();
    }
}
