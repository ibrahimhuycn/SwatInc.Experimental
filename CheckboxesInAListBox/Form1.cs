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
            this.gridControl1.DataSource = viewModel.FruitsForGridView;

            this.checkedListBoxControl1.DataSource = viewModel.FruitsForCheckedList;
            checkedListBoxControl1.DisplayMember = nameof(FruitModel.Name);
            checkedListBoxControl1.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            checkedListBoxControl1.DataBindings.Add(new Binding("CheckedItems", viewModel, nameof(viewModel.CheckedList_CheckedModel)));
        }
    }


    public class Form1ViewModel
    {
        public Form1ViewModel()
        {
            this.FruitsForGridView = new List<FruitModel>();
            this.FruitsForCheckedList = new List<FruitModel>();
            InitDemoData();
        }

        private void InitDemoData()
        {
            var f1 = new FruitModel() { Name = "Papaya" };
            var f2 = new FruitModel() { Name = "Banana" };
            var f3 = new FruitModel() { Name = "Mango" };
            var f4 = new FruitModel() { Name = "Date" };
            var f5 = new FruitModel() { Name = "Oragne" };

            FruitsForGridView.Add(f1);
            FruitsForGridView.Add(f2);
            FruitsForGridView.Add(f3);
            FruitsForGridView.Add(f4);
            FruitsForGridView.Add(f5);

            FruitsForCheckedList.Add(f1);
            FruitsForCheckedList.Add(f2);
            FruitsForCheckedList.Add(f3);
            FruitsForCheckedList.Add(f4);
            FruitsForCheckedList.Add(f5);
        }

        internal void ShowData(object sender, EventArgs e)
        {
            MessageBox.Show(JsonConvert.SerializeObject(FruitsForGridView, Formatting.Indented));
        }

        public List<FruitModel> FruitsForGridView {get; set; }
        public List<FruitModel> FruitsForCheckedList {get; set; }
        public List<FruitModel> CheckedList_CheckedModel { get; set; }

    }

    public class FruitModel
    {
        public bool IsSelected { get; set; }
        public string Name { get; set; }
    }
}
