using LibraryDatabase;
using LibraryDatabase.DbModels;
using LibraryDatabase.Implementations;
using LibraryDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginChangeType
{
    public partial class FormChangeType : Form
    {
        private readonly BookServiceDB serviceB = new BookServiceDB(new LibraryDbContext());
        private readonly TypeServiceDB serviceT = new TypeServiceDB(new LibraryDbContext());
        private Dictionary<string, bool> types = new Dictionary<string, bool>();
        private List<BookTypeModel> bookTypes = new List<BookTypeModel>();
        private int bookId;
        public FormChangeType(int bookId)
        {
            this.bookId = bookId;
            InitializeComponent();
            LoadListBox();
        }
        private void LoadListBox()
        {
            var listT = serviceT.GetList();
            if (listT != null)
            {
                foreach (var type in listT)
                {
                    bool check = false;
                    if (bookTypes.FirstOrDefault(rec => rec.TypeId == type.Id) != null)
                    {
                        check = true;
                    }
                    types.Add(type.Title, check);
                }
                controlCheckedListType.LoadList(types);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var listBookTypes = new List<BookTypeModel>();
            foreach (var checkedValue in controlCheckedListType.GetCheckedValues())
            {
                var typeId = serviceT.GetId(checkedValue);
                listBookTypes.Add(new BookTypeModel
                {
                    TypeId = typeId,
                    TypeTitle = serviceT.GetElement(typeId).Title
                });
            }
            using (LibraryDbContext context = new LibraryDbContext())
            {
                var propertyInfos = typeof(BookTypeModel).GetProperties();
                var types = new List<BookType>();
                // книга, у которой будем менять список типов
                var book = context.Books.FirstOrDefault(rec => rec.Id == bookId);
                // простое копирование в новый список
                foreach (var el in listBookTypes)
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
                context.BookTypes.RemoveRange(context.BookTypes.Where(rec => rec.BookId == bookId && !typeIds.Contains(rec.TypeId)));
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
                    var firstBookType = context.BookTypes.FirstOrDefault(rec => rec.BookId == bookId && rec.TypeId == grouppedType.TypeId);
                    // (?) если заголовка нет, генерим новый
                    if (firstBookType == null)
                    {
                        context.BookTypes.Add(new BookType
                        {
                            TypeId = grouppedType.TypeId,
                            BookId = bookId,
                            TypeTitle = context.Types.FirstOrDefault(rec => rec.Id == grouppedType.TypeId).Title
                        });
                        context.SaveChanges();
                    }
                }
            }
            MessageBox.Show("Выполнено успешно", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
