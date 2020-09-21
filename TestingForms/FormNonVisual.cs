using NonVisualComponentLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingForms
{
    public partial class FormNonVisual : Form
    {
        public FormNonVisual()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var list = componentBinaryRestore.RecoveryBackUp<Human>(@"C:\tmp\Human.zip");
            controlTreeViewOutput.FillTreeView<Human>(list);
        }

        private void buttonHistogram_Click(object sender, EventArgs e)
        {
            try
            {
                var list = new List<Setting>();
                for (int i = 0; i < 12; i++)
                {
                    list.Add(new Setting());
                }
                componentWordHistogram.CreateDiagram(list, "Вес", @"C:\tmp\fileGraph.docx");
                MessageBox.Show("Всё хорошо");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMakePdf_Click(object sender, EventArgs e)
        {
            try
            {
                var list = new List<Human>();
                for (int i = 0; i < 12; i++)
                {
                    list.Add(new Human());
                }
                componentPdfReport.CreatePDFReport<Human>(list, "Клиенты", @"C:\tmp\CopReport.pdf");
                MessageBox.Show("Всё хорошо");
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
