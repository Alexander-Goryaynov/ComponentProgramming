using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary.AdapterPattern
{
    public class Adapter : IBook
    {
        private IJournal journal;

        public Adapter(IJournal journal)
        {
            this.journal = journal;
        }

        public string GetAnnotation()
        {
            return journal.GetDescription();
        }
    }
}
