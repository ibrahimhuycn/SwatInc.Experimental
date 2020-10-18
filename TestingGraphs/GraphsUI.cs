using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestingGraphs
{
    public partial class GraphsUI : Form
    {
        public GraphsUI()
        {
            InitializeComponent();

            var data = new List<TestHistory>()
            {
                new TestHistory() {TestName = "ALKP", Number=1, Result=35.67d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=2, Result=40.6d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=3, Result=26.8d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=4, Result=35.67d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=5, Result=40.6d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=6, Result=26.8d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=7, Result=35.67d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=8, Result=40.6d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=9, Result=26.8d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=10, Result=35.67d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=11, Result=40.6d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=12, Result=26.8d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=13, Result=35.67d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=14, Result=40.6d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=15, Result=26.8d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=16, Result=35.67d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=17, Result=40.6d, ResultDate = DateTime.Now},
                new TestHistory() {TestName = "ALKP", Number=18, Result=26.8d, ResultDate = DateTime.Now}
            };

            Series series = new Series("ALKP", ViewType.Line)
            {
                DataSource = data,
                ArgumentDataMember = nameof(TestHistory.Number),
            };
            series.ValueDataMembers.AddRange(new string[] { nameof(TestHistory.Result) });
            series.ValueScaleType = ScaleType.Numerical;
            series.ArgumentScaleType = ScaleType.Qualitative;
            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series.Label.ResolveOverlappingMode = ResolveOverlappingMode.HideOverlapped;
            series.Label.TextPattern = "{ResultDate}\r\n{Result}";
            series.CrosshairLabelPattern = "{ResultDate}\r\n{Result}";
            chartControl1.Series.Add(series);
            ((LineSeriesView)series.View).MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            ((LineSeriesView)series.View).LineMarkerOptions.Kind = MarkerKind.Cross;

        }
    }

    public class TestHistory
    {
        public string TestName { get; set; }
        public int Number { get; set; }
        public double Result { get; set; }
        public DateTime ResultDate { get; set; }
    }
}
