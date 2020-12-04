using LibraryDatabase;
using PluginInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginChangeDate 
{
    [Export(typeof(IUpdate))]
    public class ChangeDate : IUpdate
    {
        public string ITitle => "Change date";
        /// <param name="id">id обновляемой книги</param>
        /// <param name="element">новая дата</param>
        public void Update(int id, object element)
        {
            var form = new FormChangeDate(id);
            form.ShowDialog();
        }
    }
}
