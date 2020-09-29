using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogResultTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDisplayDialog_Click(object sender, EventArgs e)
        {
            var dialog  = new DialogBox();
            dialog.ShowDialog();
            MessageBox.Show(dialog.DialogResult?.ToString());
        }
    }
}
