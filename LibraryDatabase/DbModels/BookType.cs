using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.DbModels
{
    public class BookType
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int TypeId { get; set; }
        public string TypeTitle { get; set; }
        public virtual Book Book { get; set; }
        public virtual Type Type { get; set; }
    }
}
