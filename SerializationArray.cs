using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Deserialization
{
    class SerializationArray
    {
        public static void  Array ()
        {
            Console.WriteLine("size");
            var size = Convert.ToInt32(Console.ReadLine());
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(Console.ReadLine(), FileMode.OpenOrCreate))
            {
                
                formatter.Serialize(fs, (ArrayFill.Filling(size)) );

            }
        }
    }
}    
