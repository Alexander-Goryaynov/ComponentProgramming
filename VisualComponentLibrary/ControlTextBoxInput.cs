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
    public partial class ControlTextBoxInput : UserControl
    {
        private string text;

        private event EventHandler textInputHappened;

        [Category("Спецификация"), Description("Событие ввода текста")]
        public event EventHandler TextInputHappened
        {
            add 
            { 
                textInputHappened += value; 
            }
            remove
            {
                textInputHappened -= value;
            }
        }

        [Category("Спецификация"), Description("Введенный текст")]
        public string InputText
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                textBox.Text = text;
            }
        }

        public ControlTextBoxInput()
        {
            InitializeComponent();
            textBox.Leave += (sender, e) =>
            {
                Check();
                textInputHappened?.Invoke(sender, e);
            };
        }

        private bool Check()
        {
            if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrWhiteSpace(textBox.Text))
            {
                label.Text = "Поле обязательно для заполнения";
                return false;
            }
            else
            {
                InputText = textBox.Text;
                label.Text = string.Empty;
                return true;
            }
        }
    }

}
