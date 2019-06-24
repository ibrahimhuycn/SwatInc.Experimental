using System;
using System.Collections.Generic;
using System.Linq;

namespace DapperDynamicSaveTest
{
    public class PeopleModel
    {
        public PeopleModel()
        {
            var person = new List<PersonModel>();
        }
        public List<PersonModel> PeopleList { get; set; }
    }
}
