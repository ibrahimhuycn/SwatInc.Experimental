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
                new TestHistory() {TestName = "ALKP", Number=9, Result=2.8d, ResultDate = DateTime.Now},
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

           graphsUserControl1.InitializeChart(data, GraphsUserControl.ResultType.Numeric);
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
