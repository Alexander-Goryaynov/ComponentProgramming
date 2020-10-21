using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryDatabase.DbModels
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? Date { get; set; }
        [ForeignKey("BookId")]
        public virtual List<BookType> BookTypes { get; set; }
    }
}
