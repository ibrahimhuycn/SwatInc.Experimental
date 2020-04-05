namespace ReplaceDataInList
{
    partial class Program
    {
        public class Person
        {
            public Person()
            {
                IsAlive = true;
                NationalId = "A309254";
            }
            public string NationalId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public bool IsAlive { get; set; }
            public Address Address { get; set; }

            public override string ToString()
            {
                return $"{FirstName} | {LastName} | {Age} | {IsAlive}";
            }

            public override bool Equals(object obj)
            {
                var person = (Person)obj;
                if (person.NationalId == this.NationalId) return true;
                return false;
            }
        }
    }
}
