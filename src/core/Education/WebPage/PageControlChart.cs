using System.Collections.Generic;
using WebExpress.UI.WebControl;
using WebExpress.WebAttribute;
using WebExpress.WebResource;

namespace Education.WebPage
{
    [ID("Chart")]
    [Title("education:page.control.chart.name")]
    [Segment("chart", "education:page.control.chart.name")]
    [Path("/Control")]
    [Module("edu")]
    [Context("control")]
    public sealed class PageControlChart : PageControlBase
    {


        /// <summary>
        /// Konstruktor
        /// </summary>
        public PageControlChart()
        {
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);
            var data = new List<ControlChartDataset>
            {
                new ControlChartDataset()
                {
                    Title = "My First dataset",
                    BackgroundColor = new List<PropertyColorChart>{ new PropertyColorChart(TypeColorChart.Danger) },
                    BorderColor = new List<PropertyColorChart>{ new PropertyColorChart(TypeColorChart.Danger) },
                    Data = new float[] { 47, -30, -99, -8, 74, 41, -47 }
                },
                new ControlChartDataset()
                {
                    Title = "My Second dataset",
                    Data = new float[] { 89, -82, 14, 98, 18, 58, -16 },
                    Fill = TypeFillChart.Start,
                    Point = TypePointChart.Rhombus
                }
            };

            var data_doughnut = new List<ControlChartDataset>
            {
                new ControlChartDataset()
                {
                    Title = "dataset",
                    BackgroundColor = new List<PropertyColorChart>
                    {
                        new PropertyColorChart(TypeColorChart.Primary),
                        new PropertyColorChart(TypeColorChart.Info),
                        new PropertyColorChart(TypeColorChart.Dark),
                        new PropertyColorChart(TypeColorChart.Success),
                        new PropertyColorChart(TypeColorChart.Warning),
                        new PropertyColorChart(TypeColorChart.Danger)
                    },
                    BorderColor = new List<PropertyColorChart>
                    {
                        new PropertyColorChart(TypeColorChart.Primary),
                        new PropertyColorChart(TypeColorChart.Info),
                        new PropertyColorChart(TypeColorChart.Dark),
                        new PropertyColorChart(TypeColorChart.Success),
                        new PropertyColorChart(TypeColorChart.Warning),
                        new PropertyColorChart(TypeColorChart.Danger)
                    },
                    Data = new float[] { 70, 73, 80, 49, 5 }
                },
            };

            Description = "Das ControlChart kann zum Anzeigen eines Diagrammes.";
            Code = @"new ControlChart() { Title = ""ControlChart"" }";

            AddExample
            (
                new ControlChart("chart1")
                {
                    Title = "ControlChart",
                    Labels = new List<string> { "January", "February", "March", "April", "May", "June", "July" },
                    Data = data,
                    Width = 250,
                    Height = 125
                }
            );

            // Eigenschaften
            AddProperty
            (
                "Type",
                "Setzt den Diagrammtyp.",
                "Type = TypeChart.Bar",
                new ControlChart("chart_line")
                {
                    Type = TypeChart.Line,
                    Title = "Line",
                    Labels = new List<string> { "January", "February", "March", "April", "May", "June", "July" },
                    Data = data,
                    Width = 250,
                    Height = 125
                },
                new ControlChart("chart_bar")
                {
                    Type = TypeChart.Bar,
                    Title = "Bar",
                    Labels = new List<string> { "January", "February", "March", "April", "May", "June", "July" },
                    Data = data,
                    Width = 250,
                    Height = 125
                },
                new ControlChart("chart_pie")
                {
                    Type = TypeChart.Pie,
                    Title = "Pie",
                    Labels = new List<string> { "Primary", "Info", "Dark", "Success", "Warning", "Danger" },
                    Data = data_doughnut,
                    Width = 250,
                    Height = 125
                },
                new ControlChart("chart_doughnut")
                {
                    Type = TypeChart.Doughnut,
                    Title = "Doughnut",
                    Labels = new List<string> { "Primary", "Info", "Dark", "Success", "Warning", "Danger" },
                    Data = data_doughnut,
                    Width = 250,
                    Height = 125
                },
                //new ControlPanel(new ControlChart("chart_polar")
                //{
                //    Type = TypeChart.Polar,
                //    Title = "Polar",
                //    Labels = new List<string> { "Primary", "Info", "Dark", "Success", "Warning", "Danger" },
                //    Data = data_doughnut
                //}),
                new ControlChart("chart_radar")
                {
                    Type = TypeChart.Radar,
                    Title = "Radar",
                    Labels = new List<string> { "Primary", "Info", "Dark", "Success", "Warning", "Danger" },
                    Data = data_doughnut,
                    Width = 250,
                    Height = 125
                }
            );
        }
    }
}
