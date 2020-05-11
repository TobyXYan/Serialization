using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AttributeSerialize
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember(Name ="Joke")]    
        public int Age { get; set; }
    }
}
