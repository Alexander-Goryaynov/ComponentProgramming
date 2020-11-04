using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternLibrary
{
    public partial class LiteratureClient : Component
    {
        private string name;
        private Book book;
        private Journal journal;
        public LiteratureClient()
        {
            InitializeComponent();
        }

        public LiteratureClient(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public LiteratureClient(LiteratureFactory factory)
        {
            name = factory.GetName();
            book = factory.CreateBook();
            journal = factory.CreateJournal();
        }
        public string GetName()
        {
            return name;
        }
        public string GetBookInfoPageText()
        {
            return book.GetInfoPageText();
        }
        public string GetJournalPrice()
        {
            return journal.GetPrice();
        }
    }
}
