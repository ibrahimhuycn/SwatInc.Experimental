using System;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace WaitForms
{
    public partial class AuthenticationUI : Form
    {
        public AuthenticationUI()
        {
            InitializeComponent();
            SetUiState(AuthState.NotAuthenticated);
        }

        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
            //Open Wait Form 
            SplashScreenManager.ShowForm(this, typeof(AuthenticationWaitForm), true, true, false);

            //The Wait Form is opened in a separate thread. To change its Description, use the SetWaitFormDescription method. 
            for (int i = 1; i <= 100; i++)
            {
                SplashScreenManager.Default.SetWaitFormDescription(i.ToString() + "%");
                Thread.Sleep(10);
            }

            //Close Wait Form 
            SplashScreenManager.CloseForm(false);
            SetUiState(AuthState.Authenticated);

        }

        private enum AuthState
        {
            NotAuthenticated,
            Authenticated
        }

        private void SetUiState(AuthState e)
        {
            switch (e)
            {
                case AuthState.NotAuthenticated:
                    panelControlAuthenticatedMessage.Hide();
                    panelControlLoginPage.Show();
                    break;
                case AuthState.Authenticated:
                    panelControlAuthenticatedMessage.Show();
                    panelControlLoginPage.Hide();
                    break;
                default:
                    break;
            }
        }
    }
}
