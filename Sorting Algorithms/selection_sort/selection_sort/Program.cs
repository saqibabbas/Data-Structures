using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {2,5,1,48,6,-1,0 };
            int[] b = selection(arr);
            foreach (int item in b)
            {
                Console.WriteLine(item);
            }
        }
        static int [] selection(int [] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i]>arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        
        }

    }
}
