using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace ExtendingComboboxFunctionality
{
    public partial class Form1 : Form
    {
        private Form1ViewModel _viewModel;

        public Form1(Form1ViewModel viewModel)
        {
            InitializeComponent();
            this._viewModel = viewModel;
            InitializeBindings();
        }

        private void InitializeBindings()
        {
            this.comboBox1.DataSource = _viewModel.NamesList;
            this.comboBox1.DisplayMember = "Name";

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            _viewModel.FilterValue = comboBox1.Text;

        }
    }


    public class Form1ViewModel
    {
        public DataTable Names = new DataTable();
        public List<string> NamesList;
        private string _filterValue;


        public string FilterValue 
        {
            get
            {
                return _filterValue;
            }
            set
            {
                if (_filterValue == value) return;
                _filterValue = value;
                this.AppyFilter();
            }
        }
        public Form1ViewModel()
        {
            AddDemoData();
            this.NamesList = new List<string>();
            this.AppyFilter();
        }

        public void AppyFilter()
        {
            DataRow[] rows = Names.Select(string.Format("Name LIKE '%{0}%'", FilterValue));
            NamesList.Clear();
            foreach (DataRow r in rows)
            {
                NamesList.Add(r.Field<string>("Name"));
                Debug.WriteLine(r.Field<string>("Name"));
            }
                
        }

        private void AddDemoData()
        {
            //Define the structure for Names table
            DataColumn[] columns =
            {
                new DataColumn ("Id",typeof(string)),
                new DataColumn ("Name",typeof(string))
            };
            Names.Columns.AddRange(columns);
            Names.Rows.Add("1", "Nisha");
            Names.Rows.Add("2", "Hassan");
            Names.Rows.Add("3", "Naani");
            Names.Rows.Add("4", "Ibbe");
            Names.Rows.Add("5", "Adhurey");
            Names.Rows.Add("6", "Nadha");
            Names.Rows.Add("7", "Umey");
            Names.Rows.Add("8", "Thaathu");
            Names.Rows.Add("9", "Ahmed");
        }


    }
}

