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

        public void FillTreeView<T>(List<T> data)
        {
            Clear();
            treeView.BeginUpdate();
            treeView.Nodes.Add("Данные");
            var reflectionData = new List<(string, string)>();
            foreach (var obj in data)
            {
                foreach(var prop in obj.GetType().GetFields())
                {
                    var propName = prop.Name;
                    var propValue = prop.GetValue(obj);
                    reflectionData.Add((propName, propValue.ToString()));
                }
            }
            foreach (var objData in reflectionData)
            {
                var propName = objData.Item1;
                var propValue = objData.Item2;
                if (treeView.Nodes[0].Nodes
                    .OfType<TreeNode>()
                    .FirstOrDefault(x => x.Text.Equals(propName)) != null)
                {
                    treeView.Nodes[0].Nodes
                        .OfType<TreeNode>()
                        .First(x => x.Text.Equals(propName))
                        .Nodes.Add(propValue);
                }
                else
                {
                    treeView.Nodes[0].Nodes.Add(new TreeNode(propName));
                    treeView.Nodes[0].Nodes
                        .OfType<TreeNode>()
                        .First(x => x.Text.Equals(propName))
                        .Nodes.Add(propValue);
                }
            }

            /*foreach (Component component in components)
            {

                int index = treeView.Nodes.Add(new TreeNode(component.text));
                if (component.children != null)
                {
                    foreach (Component comp in component.children)
                    {
                        int i = treeView.Nodes[index].Nodes.Add(new TreeNode(comp.text));
                        if (comp.children != null)
                        {
                            foreach (Component c in comp.children)
                            {
                                treeView.Nodes[index].Nodes[i].Nodes.Add(new TreeNode(c.text));
                            }
                        }
                    }
                }
            }*/

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
