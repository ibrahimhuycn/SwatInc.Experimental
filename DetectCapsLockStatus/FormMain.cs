using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetectCapsLockStatus
{
    public partial class FormMain : Form
    {
        private bool? CapsLockStatus;
        private delegate void CapsLockStatusChanged(object sender, bool isLocked);
        private event CapsLockStatusChanged RaiseCapsLockStatusChanged;
        public FormMain()
        {
            InitializeComponent();

            this.RaiseCapsLockStatusChanged += FormMain_RaiseCapsLockStatusChanged;
            CheckCapsLockStatus();
        }

        private void FormMain_RaiseCapsLockStatusChanged(object sender, bool isLocked)
        {
            
            switch (isLocked)
            {
                case true:
                    this.labelCapsLockStatus.Text = "Caps Lock ON";
                    break;
                case false:
                    this.labelCapsLockStatus.Text = "Caps Lock OFF";
                    break;
            }
        }

        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            CheckCapsLockStatus();
        }

        private void CheckCapsLockStatus()
        {
            bool? CurentCapsLockStatus = Control.IsKeyLocked(Keys.CapsLock);


                if (CapsLockStatus == CurentCapsLockStatus) { return; }
                CapsLockStatus = CurentCapsLockStatus;
                RaiseCapsLockStatusChanged(this, (bool)CapsLockStatus);

        }
    }
}
