﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmsUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Change this line to switch between Twilio || Telesign
            Application.Run(new OnlineSMS(new OnlineSmsViewmodel(new NexmoMessaging.Sms())));
        }
    }
}
