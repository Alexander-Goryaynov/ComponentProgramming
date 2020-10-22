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
    public partial class FormTypes : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly TypeServiceDB serviceT;

        public FormTypes(TypeServiceDB service)
        {
            InitializeComponent();
            serviceT = service;
        }

        private void FormTypes_Load(object sender, EventArgs e)
        {
            SetDataGrid();
            LoadData();
        }

        private void SetDataGrid()
        {
            List<ClassLibraryControlSelected.Column> col = new List<ClassLibraryControlSelected.Column>();
            foreach (var p in typeof(TypeModel).GetProperties())
            {
                int i = controlDataGridViewOutput.Width;
                if (p.Name == "Id")
                {
                    col.Add(new ClassLibraryControlSelected.Column(p.Name, true, i));
                }
                else
                {
                    col.Add(new ClassLibraryControlSelected.Column (p.Name, true, i));
                }
            }
            controlDataGridViewOutput.SetHeaders(col);
        }

        private void LoadData()
        {
            try
            {
                List<TypeModel> list = serviceT.GetList();
                if (list != null)
                {
                    controlDataGridViewOutput.FillDataGrid(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormType>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                controlDataGridViewOutput.Clear();
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (controlDataGridViewOutput.CountSelectedRows() == 1)
            {
                var form = Container.Resolve<FormType>();
                form.Id = Convert.ToInt32(controlDataGridViewOutput.getId());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    controlDataGridViewOutput.Clear();
                    LoadData();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (controlDataGridViewOutput.CountSelectedRows() == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(controlDataGridViewOutput.getId());
                    try
                    {
                        serviceT.DelElement(id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    controlDataGridViewOutput.Clear();
                    LoadData();
                }
            }
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            controlDataGridViewOutput.Clear();
            LoadData();
        }

    }
}
