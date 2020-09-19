using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualComponentLibrary
{
    public class Component
    {
        public Component(string text, List<Component> children)
        {
            this.text = text;
            this.children = children;
        }

        public string text;

        public List<Component> children;
    }
}
