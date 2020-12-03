using PluginInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginReportPdf
{
    [Export(typeof(IReport))]
    public class Report : IReport
    {
        public string ITitle => "Report";
        public void ReportBuild(int id)
        {
            FormReport form = new FormReport();
            form.Id = id;
            form.Show();
        }
    }
}
