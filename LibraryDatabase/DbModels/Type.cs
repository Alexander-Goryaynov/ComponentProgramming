using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryDatabase.DbModels
{
    [Serializable]
    public class Type
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [ForeignKey("TypeId")]
        public virtual List<BookType> BookTypes { get; set; }
    }
}
