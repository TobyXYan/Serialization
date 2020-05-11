using System;
using System.Collections.Generic;
using System.Text;

namespace JsonSerialization
{
    [Serializable]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
