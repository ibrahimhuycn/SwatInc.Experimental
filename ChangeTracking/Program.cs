using ChangeTracking.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            var person = new Person();
            person.Update(new PersonUpdateArgs()
            {
                Address = "Moshimaskee",
                DOB = DateTime.Parse("1991-02-14"),
                FirstName = "Ibrahim",
                Id = 1,
                LastName = "Hussain",
                PhoneNumber = "+9607657111"

            });
            var PeopleList = new UIViewModel(new BindingList<Person>()
            {
                person
            });

            Application.Run(new UI(PeopleList));
        }
    }
}
