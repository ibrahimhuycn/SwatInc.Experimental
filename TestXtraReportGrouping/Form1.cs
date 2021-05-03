using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestXtraReportGrouping
{
    public partial class Form1 : Form
    {
        public List<ReportDataModel> ReportData { get; set; }
        public string Path { get; set; } = "C:\\Logs\\TestingReportGrouping.pdf";
        public Form1()
        {
            InitializeComponent();
            InitializeReportData();
            GenerateReport();
            MessageBox.Show("Report ganerated and exported to path: " + Path);
            Environment.Exit(0);
        }

        private void GenerateReport()
        {
            var report = new XtraReport1() { DataSource = ReportData };
            report.ExportToPdf(Path);
        }

        private void InitializeReportData()
        {
            ReportData = new List<ReportDataModel>()
            {
                new ReportDataModel()
                {
                    PrimaryGroupName = "Urine Routine Examination",
                    SecondaryGroupName = "1. Macroscopic Examination",
                    DetailName = "Colour",
                    DetailValue = "Light Yellow"
                },
                new ReportDataModel()
                {
                    PrimaryGroupName = "Urine Routine Examination",
                    SecondaryGroupName = "1. Macroscopic Examination",
                    DetailName = "Appearance",
                    DetailValue = "Clear"
                },
                new ReportDataModel()
                {
                    PrimaryGroupName = "Urine Routine Examination",
                    SecondaryGroupName = "2. Chemical Examination",
                    DetailName = "Urobilinogen",
                    DetailValue = "Negative"
                },
                new ReportDataModel()
                {
                    PrimaryGroupName = "Urine Routine Examination",
                    SecondaryGroupName = "2. Chemical Examination",
                    DetailName = "Protein",
                    DetailValue = "Negative"
                },
                new ReportDataModel()
                {
                    PrimaryGroupName = "Urine Routine Examination",
                    SecondaryGroupName = "2. Chemical Examination",
                    DetailName = "Glucose",
                    DetailValue = "Negative"
                },
                new ReportDataModel()
                {
                    PrimaryGroupName = "Urine Routine Examination",
                    SecondaryGroupName = "2. Chemical Examination",
                    DetailName = "Ketones",
                    DetailValue = "Negative"
                },
                new ReportDataModel()
                {
                    PrimaryGroupName = "Urine Routine Examination",
                    SecondaryGroupName = "2. Chemical Examination",
                    DetailName = "Nitrite",
                    DetailValue = "Negative"
                },
                new ReportDataModel()
                {
                    PrimaryGroupName = "Urine Routine Examination",
                    SecondaryGroupName = "3. Microscopic Examination",
                    DetailName = "Pus Cells",
                    DetailValue = "2-3"
                },
                new ReportDataModel()
                {
                    PrimaryGroupName = "Urine Routine Examination",
                    SecondaryGroupName = "3. Microscopic Examination",
                    DetailName = "Epithellial cells",
                    DetailValue = "5-7"
                },
                new ReportDataModel()
                {
                    PrimaryGroupName = "Urine Routine Examination",
                    SecondaryGroupName = "3. Microscopic Examination",
                    DetailName = "Red cells",
                    DetailValue = "nil"
                },
                new ReportDataModel()
                {
                    //PrimaryGroupName = "_",
                    //SecondaryGroupName = "_",
                    DetailName = "Urine Protein (Quantitative)",
                    DetailValue = "234.76"  
                },
                new ReportDataModel()
                {
                    //PrimaryGroupName = "_",
                    //SecondaryGroupName = "_",
                    DetailName = "Urine Creatinine (Quantitative)",
                    DetailValue = "23453.76"
                }


            };

            foreach (var item in ReportData)
            {
                item.SectionName = "CLINICAL PATHOLOGY";
            }
        }
    }
}
