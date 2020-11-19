using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        public static void Main()
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] array2 = new int[] { 6, 5, 4, 3, 2, 1 };
           
           
            while (array1.Length == array2.Length)
            {
                array1 = array2;
                /*array1 = array2*/;
            }

            Console.WriteLine(array1, array2);
        }
    }
}
