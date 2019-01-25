using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // unsorted array
            int[] array = { 8, 4, 1, 9, 3, 5, 2, 6, 7, 0 };
            combsort(array);
            Console.WriteLine("sorted array");
            // to print sorted array
            for (int i = 0; i < array.Length; ++i)
                Console.Write(array[i] + " "); 
        }
        static void combsort(int[] array)
        {
            int n = array.Length;
            int gap = n;
            //to control the loop
            bool mark = false;
            while (mark == false)
            {
                // calculates gap
                gap = (gap * 10) / 13;

                if (gap < 1)
                {
                    gap = 1;
                    mark = true;
                }
                // Compare elements using the gap
                for (int i = 0; i < n - gap; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        // swaping
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;
                        // marking 
                        mark = false;
                    }
                }
            }
        }
    }
}
