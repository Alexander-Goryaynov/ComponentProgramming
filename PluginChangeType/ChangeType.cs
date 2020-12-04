using LibraryDatabase;
using LibraryDatabase.DbModels;
using PluginInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginChangeType
{
    [Export(typeof(IChange))]
    public class ChangeType : IChange
    {
        public string ITitle => "Change type";
        /// <typeparam name="T"></typeparam>
        /// <param name="id">Id книги</param>
        /// <param name="list">Список выбранных новых типов</param>
        public void Change<T>(int id, List<T> list)
        {
            var form = new FormChangeType(id);
            form.ShowDialog();
        }
    }
}
