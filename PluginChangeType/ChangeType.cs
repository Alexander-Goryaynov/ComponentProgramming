using LibraryDatabase;
using LibraryDatabase.DbModels;
using PluginInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginChangeType
{
    [Export(typeof(IChange))]
    public class ChangeType : IChange
    {
        public string ITitle => "Change type";
        /// <typeparam name="T"></typeparam>
        /// <param name="id">Id книги</param>
        /// <param name="list">Список выбранных новых типов</param>
        public void Change<T>(int id, List<T> list)
        {
            using (LibraryDbContext context = new LibraryDbContext())
            {
                var propertyInfos = typeof(T).GetProperties();
                var types = new List<BookType>();
                // книга, у которой будем менять список типов
                var book = context.Books.FirstOrDefault(rec => rec.Id == id);
                // простое копирование в новый список
                foreach (var el in list)
                {
                    var element = new BookType();
                    foreach (var property in propertyInfos)
                    {
                        var value = el.GetType().GetProperty(property.Name).GetValue(el);
                        element.GetType().GetProperty(property.Name).SetValue(element, value);
                    }
                    types.Add(element);
                }
                // список уникальных id типов
                var typeIds = types.Select(rec => rec.TypeId).Distinct();
                // удаляем лишние записи (книготипы, которых нет в обновлённой версии)
                context.BookTypes.RemoveRange(context.BookTypes.Where(rec => rec.BookId == id && !typeIds.Contains(rec.TypeId)));
                context.SaveChanges();
                // лол, это ж distinct новых типов? или нет?
                var grouppedTypes = types
                                   .GroupBy(rec => rec.TypeId)
                                   .Select(rec => new
                                   {
                                       TypeId = rec.Key
                                   });

                foreach (var grouppedType in grouppedTypes)
                {
                    // вроде как заголовок типа (заголовком является первый попавшийся тип для этой книги)
                    var firstBookType = context.BookTypes.FirstOrDefault(rec => rec.BookId == id && rec.TypeId == grouppedType.TypeId);
                    // (?) если заголовка нет, генерим новый
                    if (firstBookType == null)
                    {
                        context.BookTypes.Add(new BookType
                        {
                            TypeId = grouppedType.TypeId,
                            BookId = id,
                            TypeTitle = context.Types.FirstOrDefault(rec => rec.Id == grouppedType.TypeId).Title
                        });
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
