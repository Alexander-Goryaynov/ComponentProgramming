using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VisualComponentLibrary;

namespace TestingForms
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            var list = new List<Human>();
            for(int i = 0; i < 5; i++)
            {
                list.Add(new Human());
            }
            for(int i = 0; i < 3; i++)
            {
                list.Add(new Customer());
            }
            controlTreeViewOutput.FillTreeView<Human>(list);
        }

        private void controlTextBoxInput_TextInputHappened(object sender, EventArgs e)
        {
            textBoxResult.Text = controlTextBoxInput.InputText;
        }

        private void FormTest_Load(object sender, System.EventArgs e)
        {
            controlCheckedListBox.LoadList(new Dictionary<string, bool>()
            {
                {"Zero", true },
                {"One", false },
                {"Two", true }
            });
        }

        private void controlCheckedListBox_CheckedListBoxSelectedElementChanged(object sender, EventArgs e)
        {
            textBoxSelectedIndex.Text = controlCheckedListBox.SelectedIndex.ToString();
            textBoxSelectedValue.Text = controlCheckedListBox.SelectedText;
            textBoxCheckedIndices.Text = GetStringOfList(controlCheckedListBox.GetCheckedIndices());
            textBoxCheckedValues.Text = GetStringOfList(controlCheckedListBox.GetCheckedValues());
        }

        private string GetStringOfList<T>(List<T> list)
        {
            string result = "";
            foreach(var elem in list)
            {
                result += elem.ToString();
            }
            return result;
        }

        private void controlTreeViewOutput_TreeViewNodeMouseClick(object sender, EventArgs e)
        {
            textBoxSelectedNode.Text = controlTreeViewOutput.SelectedText;
        }
    }
}
