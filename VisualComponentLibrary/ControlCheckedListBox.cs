using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualComponentLibrary
{
    public partial class ControlCheckedListBox : UserControl
    {
        private int selectedIndex;
        
        [Category("Спецификация"), Description("Порядковый номер выбранного элемента")]
        public int SelectedIndex
        {
            get
            {
                return selectedIndex;
            }
            set
            {
                if (value >= -1 && value < checkedListBox.Items.Count)
                {
                    selectedIndex = value;
                    checkedListBox.SetItemChecked(selectedIndex, true);
                }

            }
        }

        [Category("Спецификация"), Description("Текст выбранного элемента")]
        public string SelectedText
        {
            get
            {
                return checkedListBox.Text;
            }
        }

        private event EventHandler checkedListBoxSelectedElementChanged;

        [Category("Спецификация"), Description("Событие выбора элемента из списка")]
        public event EventHandler CheckedListBoxSelectedElementChanged
        {
            add { checkedListBoxSelectedElementChanged += value; }
            remove { checkedListBoxSelectedElementChanged -= value; }
        }

        public ControlCheckedListBox()
        {
            InitializeComponent();
            checkedListBox.SelectedIndexChanged += (sender, e) =>
            {
                CheckedListBoxSelectedIndexChanged(sender, e);
                checkedListBoxSelectedElementChanged?.Invoke(sender, e);
            };
        }

        public void LoadList(Dictionary<string, bool> list)
        {
            int i = 0;
            foreach (var el in list)
            {
                checkedListBox.Items.Add(el.Key);
                checkedListBox.SetItemChecked(i, el.Value);
                i++;
            }
        }

        public void UncheckAll()
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }

        private void CheckedListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.Items[i].ToString() == SelectedText)
                {
                    SelectedIndex = i;
                }
            }
        }

        public List<string> GetCheckedValues()
        {
            var list = new List<string>();
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    list.Add(checkedListBox.Items[i].ToString());
                }
            }
            return list;
        }

        public List<int> GetCheckedIndices()
        {
            var list = new List<int>();
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
