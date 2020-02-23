using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Deserialization
{
    class OutputMessage
    {
        public static void Messenger(int[] array)
        {
            Console.WriteLine("Deserialized:");
            foreach (int a in array)
            {
                Console.WriteLine(a);
            }
        }
    }
}
