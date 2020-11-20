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
            int[] list1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] list2 = new int[] { 6, 5, 4, 3, 2, 1 };

            int temp;

            for (int i = 0; i < list1.Length; i++)
            {
                temp = list1[i];
                list1[i] = list2[i];
                list2[i] = temp;

                Console.WriteLine(list2, list1);
            }
        }
    }
}
