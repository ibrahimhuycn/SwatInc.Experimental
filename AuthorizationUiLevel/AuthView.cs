using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthorizationUiLevel
{
    public partial class AuthView : Form
    { 
        public AuthView()
        {
            InitializeComponent();
        }

        private void AddLabels()
        {
            AuthDetailModelSingleton.Claims.Add("Label1Access");
            AuthDetailModelSingleton.Claims.Add("Label2Access");
        }

        private void buttonRevokeAllAccess_Click(object sender, EventArgs e)
        {
            AuthDetailModelSingleton.Claims.Clear();
        }

        private void buttonGrantViewOneAccess_Click(object sender, EventArgs e)
        {
            AuthDetailModelSingleton.Claims.Add("TestViewOneAccess");
        }

        private void buttonGrantViewTwoAccess_Click(object sender, EventArgs e)
        {
            AuthDetailModelSingleton.Claims.Add("TestViewTwoAccess");
        }

        private void buttonGrantButton1Access_Click(object sender, EventArgs e)
        {
            AuthDetailModelSingleton.Claims.Add("Button1Access");
        }

        private void buttonButton2Access_Click(object sender, EventArgs e)
        {
            AuthDetailModelSingleton.Claims.Add("Button2Access");
        }
    }
}
