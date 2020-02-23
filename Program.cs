using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Deserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ser = new Serialization();
            Console.WriteLine("Array size:");
            var path = Ser.BinarySerializer(Convert.ToInt32(Console.ReadLine()));
            var Deser = new Deserialization();
            OutputMessage.Messenger(Deser.BinaryDeserializer(path));
            Console.ReadKey();
        }
    }
}
