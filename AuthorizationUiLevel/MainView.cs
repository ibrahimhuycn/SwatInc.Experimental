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
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            AuthDetailModelSingleton.Claims = new List<string>();
            ShowAuthView();
        }

        private void ShowAuthView()
        {
            var view = new AuthView();
            if (!UserAuthEvaluator.EvaluateAuthForItem<Form>(view))
            {
                MessageBox.Show("You are not authorized to view " + view.Name);
                return;
            }
            view.MdiParent = this;
            view.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            var view = new TestViewOne();
            if (!UserAuthEvaluator.EvaluateAuthForItem<Form>(view))
            {
                MessageBox.Show("You are not authorized to view " + view.Name);
                return;
            }
            view.MdiParent = this;
            view?.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            var view = new TestViewTwo();
            view.MdiParent = this;
            if (!UserAuthEvaluator.EvaluateAuthForItem<Form>(view))
            {
                MessageBox.Show("You are not authorized to view " + view.Name);
                return;
            }
            view.Show();
        }
    }
}
