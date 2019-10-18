using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTracking
{
    public class Person : IChangeTracking
    {
        private Person PersonBackup;

        private bool _isChanged;
        private string address;
        private DateTime dOB;
        private string firstName;

        private int id;
        private string lastName;
        private string phoneNumber;

        public void AcceptChanges()
        {
            this._isChanged = false;
        }

        public string Address => address;
        public DateTime DOB => dOB;
        public string FirstName => firstName;
        public int Id => id;

        public void Update(PersonUpdateArgs e)
        {
            this.PersonBackup = this;

            this.address = e.Address;
            this.dOB = e.DOB;
            this.firstName = e.FirstName;
            this.id = e.Id;
            this.lastName = e.LastName;
            this.phoneNumber = e.PhoneNumber;

            this._isChanged = true;

        }

        public bool IsChanged => _isChanged;
        public string LastName => lastName;
        public string PhoneNumber => phoneNumber;
    }
}
