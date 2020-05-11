using System;

namespace JsonSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { FirstName = "Toby", LastName = "Yan" };
            string filePath = @"C:\ProjectsOutput\Serialization\data.save";
            var serializer = new DataSerializer();
            serializer.JsonSerialize( person, filePath);

            Person restoredPerson = null;
            restoredPerson = (Person)serializer.JsonDeserialize(typeof(Person), filePath);
            Console.WriteLine($"The person deserialized whose first name is {restoredPerson.FirstName}, last name is {restoredPerson.LastName}");
            Console.ReadLine();
        }
    }
}
