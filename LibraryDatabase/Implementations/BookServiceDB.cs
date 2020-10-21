using LibraryDatabase.DbModels;
using LibraryDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryDatabase.Implementations
{
    public class BookServiceDB
    {
        private LibraryDbContext context;

        public BookServiceDB(LibraryDbContext context)
        {
            this.context = context;
        }

        public List<BookModel> GetList()
        {
            List<BookModel> result = context.Books.Select(rec => new BookModel
            {
                Id = rec.Id,
                Title = rec.Title,
                Date = rec.Date,
                BookTypes = context.BookTypes
                    .Where(recPC => recPC.BookId == rec.Id)
                    .Select(recPC => new BookTypeModel
                    {
                        Id = recPC.Id,
                        BookId = recPC.BookId,
                        TypeId = recPC.TypeId,
                        TypeTitle = recPC.TypeTitle
                    }).ToList()
            }).ToList();
            return result;
        }

        public BookModel GetElement(int id)
        {
            Book element = context.Books.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new BookModel
                {
                    Id = element.Id,
                    Title = element.Title,
                    Date = element.Date,
                    BookTypes = context.BookTypes
                    .Where(recPC => recPC.BookId == element.Id)
                    .Select(recPC => new BookTypeModel
                    {
                        Id = recPC.Id,
                        BookId = recPC.BookId,
                        TypeId = recPC.TypeId,
                        TypeTitle = recPC.TypeTitle
                    }).ToList()
                };
            }
            throw new Exception("Элемент не найден");
        }

        public void AddElement(BookModel model)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    Book element = context.Books.FirstOrDefault(rec => rec.Title == model.Title);
                    if (element != null)
                    {
                        throw new Exception("Уже есть книга с таким названием");
                    }
                    element = new Book
                    {
                        Title = model.Title,
                        Date = model.Date
                    };
                    context.Books.Add(element);
                    context.SaveChanges();

                    var groupTypes = model.BookTypes
                        .GroupBy(rec => rec.TypeId)
                        .Select(rec => new
                        {
                            TypeId = rec.Key
                        });

                    foreach (var groupType in groupTypes)
                    {
                        context.BookTypes.Add(new BookType
                        {
                            BookId = element.Id,
                            TypeId = groupType.TypeId,
                            TypeTitle = context.Types.FirstOrDefault(rec => rec.Id == groupType.TypeId).Title
                        });
                        context.SaveChanges();
                    }
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }

        }
    }
}
