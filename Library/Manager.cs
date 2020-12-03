using LibraryDatabase.Models;
using PluginChangeDate;
using PluginChangeType;
using PluginInterfaces;
using PluginReportPdf;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;

namespace Library
{
    public class Manager
    {
        [ImportMany(typeof(IChange))]
        IEnumerable<IChange> Plugin_1 { get; set; }

        [ImportMany(typeof(IUpdate))]
        IEnumerable<IUpdate> Plugin_2 { get; set; }

        [ImportMany(typeof(IReport))]
        IEnumerable<IReport> Plugin_3 { get; set; }

        public Action<int, List<BookTypeModel>> p_1;

        public Action<int, object> p_2;

        public Action<int> p_3;

        public string[] Headers { get; private set; }

        public Manager()
        {
            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory));
            catalog.Catalogs.Add(new DirectoryCatalog(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins")));
            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(this);
            if (Plugin_1.Count() != 0)
            {
                Plugin_1.ToList().ForEach(p => p_1 = (i, j) => p.Change(i, j));
            }
            if (Plugin_2.Count() != 0)
            {
                Plugin_2.ToList().ForEach(p => p_2 = (i, j) => p.Update(i, j));
            }
            if (Plugin_3.Count() != 0)
            {
                Plugin_3.ToList().ForEach(p => p_3 = (i) => p.ReportBuild(i));
            }
            string[] hs = new string[3];
            hs[0] = ((ChangeType)(Plugin_1.FirstOrDefault())).ITitle;
            hs[1] = ((ChangeDate)(Plugin_2.FirstOrDefault())).ITitle;
            hs[2] = ((Report)(Plugin_3.FirstOrDefault())).ITitle;
            Headers = hs;
        }
    }
}
