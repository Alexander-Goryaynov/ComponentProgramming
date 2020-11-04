using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary
{
    public class UsedLiteratureFactory : LiteratureFactory
    {
        override public string GetName() => "Used";
        override public Book CreateBook() => new UsedBook();
        override public Journal CreateJournal() => new UsedJournal();
    }
}
