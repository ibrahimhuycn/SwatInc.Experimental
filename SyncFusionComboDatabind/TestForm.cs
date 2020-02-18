using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncFusionComboDatabind
{
    public partial class TestForm : Form
    {
        private TestFormViewModel _viewModel;

        public TestForm(TestFormViewModel testFormViewModel)
        {
            InitializeComponent();
            this._viewModel = testFormViewModel;
            InitializeBinding();
        }

        private void InitializeBinding()
        {
            this.sfComboBox1.DataSource = _viewModel.person;
            this.sfComboBox1.ValueMember = nameof(Person.Id);
            this.sfComboBox1.DisplayMember = nameof(Person.FullName);

            this.sfComboBox1.DataBindings.Add(new Binding("SelectedValue", _viewModel, nameof(_viewModel.SelectedName)));
        }
    }

    public class TestFormViewModel : INotifyPropertyChanged
    {
        public TestFormViewModel()
        {
            this.person = new BindingList<Person>();
            SetUpDemoData();
        }

        private void SetUpDemoData()
        {
            this.person.Add(new Person() { Id = 100, FullName = "Ahmed Hussain" });
            this.person.Add(new Person() { Id = 200, FullName = "Ibrahim Hussain" });
            this.person.Add(new Person() { Id = 300, FullName = "Khalid Hussain" });
        }

        public BindingList<Person> person;
        private string selectedName;

        public event PropertyChangedEventHandler PropertyChanged;

        public string SelectedName
        {
            get => selectedName;
            set
            {
                selectedName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedName)));
                Debug.WriteLine(value);
            }
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }
}


