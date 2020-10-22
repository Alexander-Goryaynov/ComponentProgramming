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
using Unity;

namespace Library
{
    public partial class FormBook : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly BookServiceDB serviceB;

        private readonly TypeServiceDB serviceT;

        private Dictionary<string, bool> types = new Dictionary<string, bool>();

        public int Id { set { id = value; } }

        private int? id;

        private List<BookTypeModel> bookTypes;

        public FormBook(BookServiceDB service, TypeServiceDB serviceT)
        {
            InitializeComponent();
            serviceB = service;
            this.serviceT = serviceT;
        }
        private void FormBook_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    BookModel view = serviceB.GetElement(id.Value);
                    if (view != null)
                    {
                        textBoxTitle.Text = view.Title;
                        controlTextBoxInput.InputText = view.Date;
                        bookTypes = view.BookTypes;
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                bookTypes = new List<BookTypeModel>();
                LoadData();
            }
        }

        private void LoadData()
        {
            try
            {
                List<TypeModel> list = serviceT.GetList();
                if (list != null)
                {
                    foreach (var type in list)
                    {
                        bool check = false;
                        if (bookTypes.FirstOrDefault(rec => rec.TypeId == type.Id) != null)
                        {
                            check = true;
                        }
                        types.Add(type.Title, check);
                    }
                    controlCheckedListBox.LoadList(types);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTitle.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(controlTextBoxInput.InputText.ToString()))
            {
                MessageBox.Show("Заполните дату", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var list = new List<BookTypeModel>();
                foreach (var el in controlCheckedListBox.GetCheckedValues())
                {
                    var typeId = serviceT.GetId(el);
                    list.Add(new BookTypeModel
                    {
                        TypeId = typeId,
                        TypeTitle = serviceT.GetElement(typeId).Title
                    });
                }
                if (id.HasValue)
                {
                    serviceB.UpdElement(new BookModel
                    {
                        Id = id.Value,
                        Title = textBoxTitle.Text,
                        Date = controlTextBoxInput.InputText,
                        BookTypes = list
                    });
                }
                else
                {
                    serviceB.AddElement(new BookModel
                    {
                        Title = textBoxTitle.Text,
                        Date = controlTextBoxInput.InputText,
                        BookTypes = list
                    });
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

