using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace NonVisualComponentLibrary
{
    public partial class ComponentWordHistogram : Component
    {
        public ComponentWordHistogram()
        {
            InitializeComponent();
        }

        public ComponentWordHistogram(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CreateDiagram(List<Setting> list, string seriesname, string path)
        {
            DocX document = DocX.Create(path);
            Series series = GetSeries(list, seriesname);
            document.InsertChart(CreateBarChart(series));
            document.Save();
        }

        private static Chart CreateBarChart(Series series)
        {
            BarChart pieChart = new BarChart();
            pieChart.AddLegend(ChartLegendPosition.Left, false);
            pieChart.AddSeries(series);
            return pieChart;
        }

        private static Series GetSeries(List<Setting> list, string name)
        {
            Series series = new Series(name);
            series.Bind(list, "Legend", "Value");
            return series;
        }
    }

}