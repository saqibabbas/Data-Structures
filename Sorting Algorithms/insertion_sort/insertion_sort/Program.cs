using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 6, 1, 0 };
            int[] b = insertion(arr);
            foreach (int item in b)
            {
                Console.WriteLine(item);
            }
        }
        static int[] insertion(int[] array)
        {
                for (int j = 1; j < array.Length; j++)
                {
                    int temp = array[j];
                    int check = j;
                    while (check>0 && array[check-1]>=temp)
                    {
                        array[check] = array[check - 1];
                        check--;
                    }
                    array[check] = temp;
                }
            
            return array;

        }
    }
}
