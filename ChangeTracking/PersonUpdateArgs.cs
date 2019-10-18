using System;
using System.Linq;

namespace ChangeTracking
{
    public class PersonUpdateArgs : EventArgs
    {
        public string LastName;
        public string PhoneNumber;
        public string Address;
        public DateTime DOB;
        public string FirstName;
        public int Id;
    }
}
