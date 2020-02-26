using System;
using System.Windows.Forms;

namespace SmsUI
{
    public partial class OnlineSMS : Form
    {
        private OnlineSmsViewmodel _viewModel;

        public OnlineSMS(OnlineSmsViewmodel viewmodel)
        {
            InitializeComponent();
            this._viewModel = viewmodel;
            InitializeBinding();
        }

        private void InitializeBinding()
        {
            this.textBoxSenderNumber.DataBindings.Add
                (new Binding("Text", _viewModel, nameof(_viewModel.From)));

            this.textBoxReceiverNumber.DataBindings.Add
                (new Binding("Text", _viewModel, nameof(_viewModel.To)));

            this.textBoxTextMessage.DataBindings.Add
                (new Binding("Text", _viewModel, nameof(_viewModel.Message)));

        }

        private void buttonSendSMS_Click(object sender, EventArgs e)
        {
            bool IsSuccess  = _viewModel.SendMessage();

            switch (IsSuccess)
            {
                case true:
                    MessageBox.Show("Message sent successfully!");
                    break;
                case false:
                    MessageBox.Show("An error occured. Failed sending message.");
                    break;
                default:
                    break;
            }
        }
    }
}
