using LibraryDatabase.DbModels;
using LibraryDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Type = LibraryDatabase.DbModels.Type;

namespace LibraryDatabase.Implementations
{
    public class TypeServiceDB
    {
        private LibraryDbContext context;

        public TypeServiceDB(LibraryDbContext context)
        {
            this.context = context;
        }

        public List<TypeModel> GetList()
        {
            List<TypeModel> result = context.Types.Select(rec => new TypeModel
            {
                Id = rec.Id,
                Title = rec.Title
            })
            .ToList();
            return result;
        }

        public TypeModel GetElement(int id)
        {
            Type element = context.Types.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new TypeModel
                {
                    Id = element.Id,
                    Title = element.Title
                };
            }
            throw new Exception("Элемент не найден");
        }

        public void AddElement(TypeModel model)
        {
            Type element = context.Types.FirstOrDefault(rec => rec.Title == model.Title);
            if (element != null)
            {
                throw new Exception("Уже есть такая форма");
            }
            context.Types.Add(new Type
            {
                Title = model.Title
            });
            context.SaveChanges();
        }

        public void UpdElement(TypeModel model)
        {
            Type element = context.Types.FirstOrDefault(rec => rec.Title ==
            model.Title && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть такая форма");
            }
            element = context.Types.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Title = model.Title;
            context.SaveChanges();
        }

        public void DelElement(int id)
        {
            Type element = context.Types.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.BookTypes.RemoveRange(context.BookTypes.Where(rec => rec.TypeId == id));
                context.Types.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public int GetId(string title)
        {
            Type element = context.Types.FirstOrDefault(rec => rec.Title == title);
            if (element != null)
            {
                return element.Id;
            }
            throw new Exception("Форма не найдена");
        }

        public void DelBookType(int id)
        {
            BookType bookType = context.BookTypes.FirstOrDefault(rec => rec.Id == id);
            if (bookType != null)
            {
                context.BookTypes.Remove(bookType);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
    }

}
