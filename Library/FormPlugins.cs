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
    public partial class FormPlugins : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly BookServiceDB serviceB;
        private readonly Manager manager;
        public FormPlugins(BookServiceDB serviceB, TypeServiceDB serviceT)
        {
            InitializeComponent();
            this.serviceB = serviceB;
            manager = new Manager();
        }

        private void FormPlugins_Load(object sender, EventArgs e)
        {
            try
            {
                List<BookModel> listBooks = serviceB.GetList();
                if (listBooks != null)
                {
                    comboBoxBook.DisplayMember = "Title";
                    comboBoxBook.ValueMember = "Id";
                    comboBoxBook.DataSource = listBooks;
                    comboBoxBook.SelectedItem = null;
                }
                if (manager.Headers != null && manager.Headers.Length != 0)
                {
                    comboBoxPlugin.Items.AddRange(manager.Headers);
                    comboBoxPlugin.Text = null;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (comboBoxBook.SelectedValue == null)
            {
                MessageBox.Show("Выберите книгу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxPlugin.Text == null)
            {
                MessageBox.Show("Выберите плагин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {                
                if (comboBoxPlugin.Text == manager.Headers[0])
                {
                    manager.p_1(Convert.ToInt32(comboBoxBook.SelectedValue), null);
                }
                if (comboBoxPlugin.Text == manager.Headers[1])
                {
                    manager.p_2(Convert.ToInt32(comboBoxBook.SelectedValue), null);
                }
                if (comboBoxPlugin.Text == manager.Headers[2])
                {
                    manager.p_3(Convert.ToInt32(comboBoxBook.SelectedValue));
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
