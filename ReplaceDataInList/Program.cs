using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceDataInList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make an instance of a list of person
            var people = new List<Person>
            {
                new Person() { FirstName = "Ibrahim", LastName = "Hussain", Age = 29 },
                new Person() { FirstName = "Ahmed Hisaan", LastName = "Saeed", Age = 30 }
            };

            //set is alive to false for Ibrahim without copying the list to another
            var editedPerson = new Person() { FirstName = "Ahmed Hisaan", LastName = "Saeed", Age = 30, IsAlive = false };
            var a = people.FindIndex( p => p.LastName == "Saeed");

            if (a != -1) 
            { 
                people.Insert(a, editedPerson); 
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

        public class Person
        {
            public Person()
            {
                IsAlive = true;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public bool IsAlive { get; set; }
            public Address Address { get; set; }

            public override string ToString()
            {
                return $"{FirstName} | {LastName} | {Age} | {IsAlive}";
            }
        }
        public class Address
        {
            public string Atoll { get; set; }
            public string Island { get; set; }
            public string House { get; set; }
        }
    }
}
