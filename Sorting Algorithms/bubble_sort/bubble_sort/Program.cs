using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr={2,5,6,1,0};
            int [] b=bubble(arr);
            foreach (int item in b)
	{
		 Console.WriteLine(item);
	}
        }
        static int[] bubble(int[] array)
        {
            for (int i = array.Length-1; i >=1 ; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j]>array[j+1])
                    {
                        int temp = array[j+1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        
        }
    }
}
