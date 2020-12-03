using iTextSharp.text;
using iTextSharp.text.pdf;
using LibraryDatabase;
using LibraryDatabase.DbModels;
using LibraryDatabase.Implementations;
using LibraryDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginReportPdf
{
    public partial class FormReport : Form
    {
        private readonly BookServiceDB service = new BookServiceDB(new LibraryDbContext());
        public int? Id { set { id = value; } }
        private int? id; 
        public FormReport()
        {
            InitializeComponent();
        }

        private void ReportBuild<T>(int idbook)
        {
            BookModel view = service.GetElement(id.Value);
            if (view != null)
            {                
                MakePdf(view.Title, view.Date.Value.ToShortDateString(), GenerateNumber());
            }            
        }

        public void MakePdf(string strOne, string strTwo, string strThree)
        {
            using (FileStream fs = new FileStream(@"C:\temp\text.pdf", FileMode.OpenOrCreate, FileAccess.Write))
            {
                //создаем документ, задаем границы, связываем документ и поток
                iTextSharp.text.Document doc = new iTextSharp.text.Document();
                try
                {
                    //открываем файл для работы                
                    doc.SetMargins(0.5f, 0.5f, 0.5f, 0.5f);
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);

                    doc.Open();
                    BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\times.ttf",
                        BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                    //вставляем заголовок
                    var phraseTitle = new Phrase("Артикул книги",
                    new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD));
                    iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph(phraseTitle)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 12
                    };
                    doc.Add(paragraph);

                    var phraseName = new Phrase(strOne,
                    new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD));
                    paragraph = new iTextSharp.text.Paragraph(phraseName)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 12
                    };
                    doc.Add(paragraph);

                    var phraseDate = new Phrase(strTwo,
                                                  new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD));

                    paragraph = new iTextSharp.text.Paragraph(phraseDate)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 12
                    };
                    doc.Add(paragraph);
                    var phraseNumber = new Phrase(strThree,
                                                  new iTextSharp.text.Font(baseFont, 14, iTextSharp.text.Font.BOLD));

                    paragraph = new iTextSharp.text.Paragraph(phraseNumber)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 12
                    };
                    doc.Add(paragraph);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
                finally
                {
                    doc.Close();
                    Thread.Sleep(5);
                }
            }

        }
        private void FormReport_Load(object sender, EventArgs e)
        {
            try
            {
                if (id.HasValue)
                {
                    ReportBuild<Book>(id.Value);
                    pdfView.src = @"C:\temp\text.pdf";
                }
                else
                {
                    throw new Exception("Книга не выбрана");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateNumber()
        {
            string result = "";
            var rnd = new Random();
            for (var i = 0; i < 16; i++)
            {
                if (i % 2 == 0)
                {
                    result += (char)rnd.Next(65, 89);
                } 
                else
                {
                    result += rnd.Next(0, 10);
                }
                if ((i + 1) % 4 == 0 && i > 0 && i < 15)
                {
                    result += '-';
                }
            }
            return result;
        }
    }
}
