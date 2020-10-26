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
    public partial class TestViewOne : Form
    {
        public TestViewOne()
        {
            InitializeComponent();
        }

        private void TestViewOne_Shown(object sender, EventArgs e)
        {
            UserAuthEvaluator.EvaluateAuthForItem<Form>(this);

        }
    }
}
