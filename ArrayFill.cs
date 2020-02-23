using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_Deserialization
{
    class ArrayFill
    {
        public static int[] Filling(int size)
        {
            var array = new int[size];
            var rnd = new Random();
            for(var i = 0; i < size; i++)
            {
                array[i] = rnd.Next(100);
            }

            return array;
        }
    }

}
