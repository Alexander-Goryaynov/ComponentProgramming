using LibraryDatabase;
using PluginInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginChangeDate 
{
    [Export(typeof(IUpdate))]
    public class ChangeDate : IUpdate
    {
        public string ITitle => "Change date";
        /// <param name="id">id обновляемой книги</param>
        /// <param name="element">новая дата</param>
        public void Update(int id, object element)
        {
            using (var context = new LibraryDbContext())
            {
                var newDatetime = (DateTime)element;
                var book = context.Books.FirstOrDefault(rec => rec.Id == id);
                if (book == null)
                {
                    throw new Exception("Элемент не найден");
                }
                book.Date = newDatetime;
                context.SaveChanges();
            }
        }
    }
}
