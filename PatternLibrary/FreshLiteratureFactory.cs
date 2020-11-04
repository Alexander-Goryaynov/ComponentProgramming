using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary
{
    public class FreshLiteratureFactory : LiteratureFactory
    {
        public override Book CreateBook() => new FreshBook();

        public override Journal CreateJournal() => new FreshJournal();

        public override string GetName() => "Fresh";
    }
}
