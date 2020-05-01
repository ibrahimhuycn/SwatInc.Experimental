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

namespace CheckboxesInAListBox
{
    public partial class Form1 : Form
    {
        private readonly Form1ViewModel viewModel;

        public Form1(Form1ViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            InitializeDataBinding();
            this.simpleButton1.Click += viewModel.ShowData;
        }
        private void InitializeDataBinding()
        {
            this.gridControl1.DataSource = viewModel.Fruits;
        }
    }


    public class Form1ViewModel
    {
        public Form1ViewModel()
        {
            this.Fruits = new List<FruitModel>();
            InitDemoData();
        }

        private void InitDemoData()
        {
            var f1 = new FruitModel() { Name = "Papaya" };
            var f2 = new FruitModel() { Name = "Banana" };
            var f3 = new FruitModel() { Name = "Mango" };
            var f4 = new FruitModel() { Name = "Date" };
            var f5 = new FruitModel() { Name = "Oragne" };

            Fruits.Add(f1);
            Fruits.Add(f2);
            Fruits.Add(f3);
            Fruits.Add(f4);
            Fruits.Add(f5);

        }

        internal void ShowData(object sender, EventArgs e)
        {
            MessageBox.Show(JsonConvert.SerializeObject(Fruits, Formatting.Indented));
        }

        public List<FruitModel> Fruits {get; set; }
    }

    public class FruitModel
    {
        public bool IsSelected { get; set; }
        public string Name { get; set; }
    }
}
