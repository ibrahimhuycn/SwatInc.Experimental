using System.ComponentModel;
using System.Data;
using System.Diagnostics;

namespace ExtendingComboboxFunctionality
{
    public class Form1ViewModel
    {
        public DataTable Names = new DataTable();
        public BindingList<string> NamesList = new BindingList<string>();
        private BindingList<string> NamesListTemp = new BindingList<string>();

        public Form1ViewModel()
        {
            AddDemoData();
            AppyFilter(string.Empty);
        }

        public void AppyFilter(string FilterValue)
        {
            NamesList.Clear();
            DataRow[] rows = Names.Select(string.Format("Name LIKE '%{0}%'", FilterValue));
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

