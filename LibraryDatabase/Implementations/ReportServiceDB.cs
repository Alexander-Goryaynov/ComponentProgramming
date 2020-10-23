using LibraryDatabase.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LibraryDatabase.Implementations
{
    public class ReportServiceDB
    {
        private LibraryDbContext context;

        public ReportServiceDB(LibraryDbContext context)
        {
            this.context = context;
        }

        public List<ReportModel> GetBooksWithDate()
        {
            var cultureEng = CultureInfo.CreateSpecificCulture("en-US");
            List<ReportModel> result = context.Books.Select(rec => new ReportModel
            {
                Title = rec.Title,
                Date = rec.Date.Value.ToString("dd mm yyyy", cultureEng)
            })
            .ToList();
            return result;
        }

        public List<DiagramModel> GetCountOfBooksByForm()
        {
            List<DiagramModel> result = context.Types.Select(rec => new DiagramModel
            {
                Title = rec.Title,
                Count = context.BookTypes.Where(fr => fr.TypeId == rec.Id).Count()
            })
            .ToList();
            return result;
        }

    }
}
