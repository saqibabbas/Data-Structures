using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int temp, val;
            Console.WriteLine("write input");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int q = 0; q < arr.Length; q++)
            {
                Console.Write(arr[q] + " ");
            }
            Console.WriteLine();
            for (int k = 0; k < arr.Length; k++)
            {
                for (int t = k + 1; t < arr.Length; t++)
                {
                    if (arr[t] < arr[k])
                    {
                        temp = arr[t];
                        val = t - 1;
                        for (int b = val; b >= k; b--)
                        {
                            arr[b + 1] = arr[b];
                            val--;
                        }
                        arr[k] = temp;

                        for (int z = 0; z < arr.Length; z++)
                        {
                            Console.Write(arr[z] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
