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
            Settings();
            LoadData();
        }

        private void Settings()
        {
            List<ClassLibraryControlOutput.Column> col = new List<ClassLibraryControlOutput.Column>();
            foreach (var p in typeof(TypeModel).GetProperties())
            {
                int i = controlDataGridViewOutput.Width;
                if (p.Name == "Id")
                {
                    col.Add(new ClassLibraryControlOutput.Column { Name = p.Name, Visibility = false, Width = i });
                }
                else
                {
                    col.Add(new ClassLibraryControlOutput.Column { Name = p.Name, Visibility = true, Width = i });
                }
            }
            controlDataGridViewOutput.Settings(col);
        }

        private void LoadData()
        {
            try
            {
                List<TypeModel> list = serviceT.GetList();
                if (list != null)
                {
                    foreach (var el in list)
                    {
                        controlDataGridViewOutput.AddRow<FormModel>(el);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
