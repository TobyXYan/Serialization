using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Linq;

namespace AttributeSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            var me = new Person() { FirstName = "Toby", LastName = "Yan", Age = 28 };
            var serializer = new DataContractSerializer(me.GetType());
            var stream = new MemoryStream();
            serializer.WriteObject(stream, me);
            stream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(XElement.Parse(Encoding.ASCII.GetString(stream.GetBuffer()).Replace("\0", "")));
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
