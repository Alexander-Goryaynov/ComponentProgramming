using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonVisualComponentLibrary
{
    public partial class ComponentPdfReport : Component
    {
        public ComponentPdfReport()
        {
            InitializeComponent();
        }

        public ComponentPdfReport(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public void CreatePDFReport<T>(List<T> list, string header, string path)
        {

            var fieldInfoes = typeof(T).GetFields();

            //открываем файл для работы
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

            //создаем документ, задаем границы, связываем документ и поток
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            doc.SetMargins(0.5f, 0.5f, 0.5f, 0.5f);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\times.ttf",
                BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            //вставляем таблицу, задаем количество столбцов, и ширину колонок
            PdfPTable table = new PdfPTable(fieldInfoes.Count())
            {
                TotalWidth = 800F
            };

            //вставляем шапку
            var fontForCellBold = new iTextSharp.text.Font(baseFont, 10, iTextSharp.text.Font.BOLD);

            PdfPCell cell = new PdfPCell(new Phrase(header, fontForCellBold));
            cell.Colspan = fieldInfoes.Length;
            cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            table.AddCell(cell);

            foreach (var elem in fieldInfoes)
            {
                table.AddCell(new PdfPCell(new Phrase(elem.Name, fontForCellBold))
                {
                    HorizontalAlignment = Element.ALIGN_CENTER
                });
            }

            //заполняем таблицу
            var fontForCells = new iTextSharp.text.Font(baseFont, 10);
            for (int i = 0; i < list.Count; i++)
            {
                foreach (var elem in fieldInfoes)
                {
                    cell = new PdfPCell(new Phrase(list[i]
                        .GetType()
                        .GetField(elem.Name)
                        .GetValue(list[i])
                        .ToString(),
                        fontForCells));
                    table.AddCell(cell);
                }
            }

            //вставляем таблицу
            doc.Add(table);
            doc.Close();
        }

    }
}
