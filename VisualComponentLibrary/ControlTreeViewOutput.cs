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
    public partial class ControlTreeViewOutput : UserControl
    {
        /// <summary>
        /// Индекс выбранной ветки
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Текст выбранной ветки
        /// </summary>
        private string _selectedText;

        /// <summary>
        /// Ключ выбранной ветки
        /// </summary>
        private string _selectedKey;

        /// <summary>
        /// Событие клика по ветке
        /// </summary>
        private event EventHandler _treeViewNodeMouseClick;

        /// <summary>
        /// Индекс выбранной ветки
        /// </summary>
        [Category("Спецификация"), Description("Индекс выбранной ветки")]
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set { _selectedIndex = value; }
        }

        /// <summary>
        /// Ключ выбранной ветки
        /// </summary>
        [Category("Спецификация"), Description("Ключ выбранной ветки")]
        public string SelectedKey
        {
            get { return _selectedKey; }
            set { _selectedKey = value; }
        }

        /// <summary>
        /// Текст выбранной ветки
        /// </summary>
        [Category("Спецификация"), Description("Текст выбранной ветки")]
        public string SelectedText
        {
            get { return _selectedText; }
            set { _selectedText = value; }
        }

        /// <summary>
        /// Событие клика по ветке
        /// </summary>
        [Category("Спецификация"), Description("Событие клика по ветке")]
        public event EventHandler TreeViewNodeMouseClick
        {
            add { _treeViewNodeMouseClick += value; }
            remove { _treeViewNodeMouseClick -= value; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public ControlTreeViewOutput()
        {
            InitializeComponent();
            treeView.NodeMouseClick += (sender, e) =>
            {
                treeView_NodeMouseClick(sender, e);
                _treeViewNodeMouseClick?.Invoke(sender, e);
            };
        }

        public void FillTreeView<T>(List<T> data, string[] propertyNames)
        {
            Clear();
            treeView.BeginUpdate();
            treeView.Nodes.Add("Данные");
            var reflectionData = new List<(string, string)>();
            foreach (var obj in data)
            {
                TreeNode currNode = treeView.Nodes[0];
                for (int j = 0; j < propertyNames.Length; j++)
                {
                    var prop = obj.GetType().GetFields().First(x => x.Name.Equals(propertyNames[j]));
                    var propValue = prop?.GetValue(obj);
                    TreeNode nodeSearchResult;
                    if ((nodeSearchResult = currNode.Nodes
                                            .OfType<TreeNode>()
                                            .FirstOrDefault(x => x.Text.Equals(propValue))) != null)
                    {
                        currNode = nodeSearchResult;
                    }
                    else
                    {
                        var addedNode = currNode.Nodes.Add(propValue.ToString());
                        currNode = addedNode;
                    }
                }
            }
            treeView.EndUpdate();
            treeView.ExpandAll();
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SelectedIndex = e.Node.Index;
            SelectedText = e.Node.Text;
            SelectedKey = e.Node.Name;
        }

        public void Clear()
        {
            treeView.BeginUpdate();
            treeView.Nodes.Clear();
            treeView.EndUpdate();
        }
    }
}
