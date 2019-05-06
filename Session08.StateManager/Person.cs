using System;
using System.Collections.Generic;

namespace Session08.StateManager
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Contact> Contacts { get; set; }
        public JobData  JobData { get; set; }
    }
}
