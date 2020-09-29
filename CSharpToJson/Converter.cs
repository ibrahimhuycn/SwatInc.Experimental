using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpToJson
{
    public partial class Converter : Form
    {
        private Controls _control = new Controls();

        public Converter()
        {
            InitializeComponent();
            InitializeDemoColumns();
            this.button1.Click += OnConvertClicked;
        }

        private void InitializeDemoColumns()
        {

            var column1 = new GridColumn() 
            {
                Caption = "Column", 
                FieldName = "Column", 
                AllowEdit = false, 
                Name = "GridColumnName", 
                Visible = true, 
                VisibleIndex = 1, Width = 100 
            };

            var column2 = new GridColumn()
            {
                Caption = "Column",
                FieldName = "Column",
                AllowEdit = false,
                Name = "GridColumnName",
                Visible = true,
                VisibleIndex = 1,
                Width = 100
            };

            _control.Columns.Add(column1);
            _control.Columns.Add(column2);

        }

        private void OnConvertClicked(object sender, EventArgs e)
        {
            this.textBox1.Text = JsonConvert.SerializeObject(_control.Columns);
        }
    }

    public class Controls
    {
        public Controls()
        {
            this.Columns = new List<GridColumn>();
        }
        public List<GridColumn> Columns { get; set; }
    }

    public class GridColumn
    {
        public string Caption { get; set; }
        public string FieldName { get; set; }
        public bool AllowEdit { get; set; }
        public string Name { get; set; }
        public bool Visible { get; set; }
        public int VisibleIndex { get; set; }
        public int Width { get; set; }
    }
}
