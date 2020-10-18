using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;

namespace TestingGraphs
{
    public partial class GraphsUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly List<TestHistory> _testHistories;
        private readonly ResultType _resultType;

        public GraphsUserControl(List<TestHistory> testHistories, ResultType resultType)
        {
            InitializeComponent();
            _testHistories = testHistories;
            _resultType = resultType;
            PlotData();
        }

        private void PlotData()
        {
            //prepare data
            var seriesName = GetSeriesName();
            //select view type
            var viewType = GetSeriesViewType();

        }

        private ViewType GetSeriesViewType()
        {
            switch (_resultType)
            {
                case ResultType.Numeric:
                    return ViewType.Line;
                case ResultType.Textual:
                    throw new Exception("Cannot plot historical graphs for ")
                case ResultType.Codified:
                    return ViewType.Point;
            }
        }

        private string GetSeriesName()
        {
            return _testHistories.FirstOrDefault().TestName;
        }

        public enum ResultType
        {
            Numeric,
            Textual,
            Codified
        }
    }
}
