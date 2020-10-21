using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Models
{
    public class BookTypeModel
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int TypeId { get; set; }
        public string TypeTitle { get; set; }
    }
}
