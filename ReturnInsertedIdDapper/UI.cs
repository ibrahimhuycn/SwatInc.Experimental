using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReturnInsertedIdDapper
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //null check
            Button save = (Button)sender;
            save.Enabled = false;

            //save data
            if (textBoxAutoId.Text != null & textBoxSurname.Text != null) 
            {

                var Names = new { Surname = textBoxSurname.Text };
                int d = SqlDataAccess.SaveData("usp_Insert_ReturnInsertedId_Row_WithIdReturn", Names);
                textBoxAutoId.Text = string.Concat("",d);
            };

            //clear textbox
            //load data
            //enable the save button
            save.Enabled = true;

        }
    }

    public class Surname
    {
        public int Id { get; set; }

        public string Surname { get; set; }

    }

    public class Surnames
    {
        public Surnames()
        {
            SurnamesCol = new List<Surname>();
        }
        public List<Surname> SurnamesCol { get; set; }
    }

}
   
