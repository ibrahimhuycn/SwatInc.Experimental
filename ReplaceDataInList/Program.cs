using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceDataInList
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Make an instance of a list of person
            var people = new List<Person>
            {
                new Person() {NationalId = "A2526512", FirstName = "Ibrahim", LastName = "Hussain", Age = 29 },
                new Person() {NationalId="A309254", FirstName = "Ahmed Hisaan", LastName = "Saeed", Age = 30 }
            };

            //set is alive to false without copying the list to another
            var editedPerson = people[1];
            var a = people.IndexOf(editedPerson);
            editedPerson.IsAlive = false;

            if (a != -1) 
            {
                people[a] = editedPerson;
            }
            else
            {
                Console.WriteLine("Person not found!");
            }

            foreach (var item in people)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
