using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDatabase.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? Date { get; set; }
        public List<BookTypeModel> BookTypes { get; set; }
    }
}
