using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils.Internal;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GridControlDynamicCellControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeBinding();

        }

        private void InitializeBinding()
        {
            repositoryItemLookUpEdit1.DataSource = null;

            var datasource = new List<Test>()
            {
                new Test() {TestName = "Test1",Result=""},
                new Test() {TestName = "Test3",Result=""},
                new Test() {TestName = "Test4",Result=""},
                
                };

            this.gridControl1.DataSource = datasource;

        }
    }

    public class Test
    {
        public string TestName { get; set; }
        public string Result { get; set; }
    }
}
