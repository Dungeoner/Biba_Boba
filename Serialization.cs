using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Deserialization
{
    class Serialization
    {
        public string BinarySerializer(int size)
        {
            var arrayBinaryFormatter = new BinaryFormatter();
            Console.WriteLine("Path to file:");
            var path = Console.ReadLine();
            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                arrayBinaryFormatter.Serialize(fs, (ArrayFill.Filling(size)));
            }
            return path;
        }
    }
}