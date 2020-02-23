using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Deserialization
{
    class Deserialization
    {
        public int[] BinaryDeserializer(string path)
        {
            var arrayBinaryFormatter = new BinaryFormatter();
            int[] array;
            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                array = (int[]) arrayBinaryFormatter.Deserialize(fs);
            }

            return array;
        }
        
    }
}
