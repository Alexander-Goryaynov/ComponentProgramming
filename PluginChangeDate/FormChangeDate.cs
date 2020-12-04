using LibraryDatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginChangeDate
{
    public partial class FormChangeDate : Form
    {
        private int id;
        public FormChangeDate(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            using (var context = new LibraryDbContext())
            {
                DateTime newDatetime;
                if (controlTextBoxDate.InputText.HasValue)
                {
                    newDatetime = controlTextBoxDate.InputText.Value;
                }
                try
                {
                    newDatetime = (DateTime)controlTextBoxDate.InputText;
                }
                catch
                {
                    newDatetime = new DateTime(1999, 05, 12);
                }                
                var book = context.Books.FirstOrDefault(rec => rec.Id == id);
                if (book == null)
                {
                    throw new Exception("Элемент не найден");
                }
                book.Date = newDatetime;
                context.SaveChanges();
            }
            MessageBox.Show("Выполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
