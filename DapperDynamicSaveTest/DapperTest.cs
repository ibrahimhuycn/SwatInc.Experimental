using System;
using System.Linq;
using System.Windows.Forms;

namespace DapperDynamicSaveTest
{
    public partial class DapperTest : Form
    {
        public DapperTest()
        {
            InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var p = new PersonModel
            {
                IdCardNumber = textBoxIdCard.Text,
                PersonName = textBoxName.Text,
                Address = textBoxAddress.Text
            };

            SqlDataAccess.SaveData("usp_InsertPerson", p);
        }
    }
}