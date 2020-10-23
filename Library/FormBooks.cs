using ClassLibraryControlInvisible;
using LibraryDatabase;
using LibraryDatabase.DbModels;
using LibraryDatabase.Implementations;
using LibraryDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Unity;
using Type = LibraryDatabase.DbModels.Type;

namespace Library
{
    public partial class FormBooks : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly BookServiceDB serviceB;

        private readonly TypeServiceDB serviceT;

        private readonly ReportServiceDB serviceR;

        public FormBooks(BookServiceDB serviceB, TypeServiceDB serviceT, ReportServiceDB serviceR)
        {
            InitializeComponent();
            this.serviceB = serviceB;
            this.serviceT = serviceT;
            this.serviceR = serviceR;
        }

        private void FormBooks_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SetDataGrid()
        {
            List<ClassLibraryControlSelected.Column> col = new List<ClassLibraryControlSelected.Column>();
            foreach (var prop in typeof(TypeModel).GetProperties())
            {
                int i = controlDataGridViewOutput.Width / 3;
                if (prop.Name.Equals("Id"))
                {
                    col.Add(new ClassLibraryControlSelected.Column(prop.Name, false, i));
                }
                else
                {
                    col.Add(new ClassLibraryControlSelected.Column(prop.Name, true, i));
                }
            }
            controlDataGridViewOutput.SetHeaders(col);
        }

        private void LoadData()
        {
            SetDataGrid();
            try
            {
                List<BookModel> list = serviceB.GetList();
                if (list != null)
                {
                    foreach (var el in list)
                    {
                        controlDataGridViewOutput.AddRow(el);
                    }
                }
                controlDataGridViewOutput.FillDataGrid(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormBook>();
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
                var form = Container.Resolve<FormBook>();
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
                        serviceB.DelElement(id);
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormTypes>();
            form.ShowDialog();
        }

        private void recoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var list = serviceB.GetList();
                    for (int i = 0; i < list.Count; i++)
                    {
                        serviceB.DelElement(list[i].Id);
                    }
                    var restoredList = componentBinaryRestore.RecoveryBackUp<BookModel>(sfd.FileName);
                    foreach (var el in restoredList)
                    {
                        serviceB.AddElement(el);
                    }
                    controlDataGridViewOutput.Clear();
                    LoadData();
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var context = new LibraryDbContext();
            List<BookModel> books = new List<BookModel>
            {
                serviceB.GetElement(5),
                serviceB.GetElement(6)
            };
            List<Type> types = context.Types.ToList();
            List<BookType> btypes = context.BookTypes.ToList();
            var paths = new string[] { @"C:\tmp\backup\back1.dat",
                @"C:\tmp\backup\back2.dat", @"C:\tmp\backup\back3.dat" };
            componentBinaryArchive.SetData<BookModel>(books, paths[0]);
        }

        private void diagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "xlsx|*.xlsx",
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Setting> settings = new List<Setting>();
                    foreach (var el in serviceR.GetCountOfBooksByForm())
                    {
                        settings.Add(new Setting
                        {
                            legend = el.Title,
                            value = el.Count
                        });
                    }
                    componentExcelDiagram.BuiltChart(settings, sfd.FileName);
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "xlsx|*.xlsx",
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    componentReportExcel.DisplayInExcel<ReportModel>(serviceR.GetBooksWithDate(), sfd.FileName, "Books", new Dictionary<string, string> { });
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
