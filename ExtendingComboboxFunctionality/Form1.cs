using System;
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

            listBox1.DataSource = _viewModel.NamesList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (listBox1.Visible == false) listBox1.Visible = true;
            _viewModel.AppyFilter(textBox1.Text);
        }


        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                if(listBox1.Items.Count != 0)
                {
                    textBox1.Text = listBox1.Items[0].ToString();
                }

                listBox1.Visible = false;
            }
        }
    }
}

