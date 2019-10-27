using ChangeTracking.Models;
using ChangeTracking.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeTracking
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

          // var patient = new PatientModel() { MedicalRecordNumber = "ASD2345", LastName = "" };

            Application.Run(new ChangeTrackingView(new ChangeTrackingViewModel(new PatientModel())));
        }
    }
}
