using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace LevyJenningsCharts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setData();
        }

        private void setData()
        {
            
            var a = new BindingList<QcData>()
            {
                new QcData()
                {
                     RunDate = 1, 
                    Value = 36.25F,
                     ThreeSD = 48.3F
                },
                new QcData()
                {
                     RunDate = 2, 
                    Value = 75.3F,
                     ThreeSD = 48.3F
                },
                new QcData()
                {
                     RunDate = 3, 
                    Value = 20.3F,
                     ThreeSD = 48.3F
                }
            };

            


            chartControl1.DataSource = a;
            var QcDataSeries = new Series(nameof(QcData), ViewType.Line);
            var QcLimitSeries = new Series("+3 SD", ViewType.Line);
            chartControl1.Series.Add(QcDataSeries);
            chartControl1.Series.Add(QcLimitSeries);

            QcDataSeries.ArgumentDataMember = "RunDate";
            QcDataSeries.ValueDataMembers.AddRange(new string[] { "Value" });

            QcLimitSeries.ArgumentDataMember = "RunDate";
            QcLimitSeries.ValueDataMembers.AddRange(new string[] { nameof(QcData.ThreeSD) });

            //PointSeriesView myView1 = (PointSeriesView)QcLimitSeries.View;
            //myView1.PointMarkerOptions.Kind = MarkerKind.Star;
            //myView1.PointMarkerOptions.StarPointCount = 5;
            //myView1.PointMarkerOptions.Size = 2;
            //myView1.PointMarkerOptions.FillStyle.FillMode = FillMode.Solid;
            
        }
    }

    public class QcData
    {
        public int RunDate { get; set; }
        public float Value { get; set; }

        public float ThreeSD { get; set; }


    }

    public class Limits
    {
        public float ThreeSD { get; set; }
        public float TwoSD { get; set; }

    }
}
