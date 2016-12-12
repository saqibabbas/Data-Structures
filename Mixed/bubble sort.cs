using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class z
    {
        int[] arr = new int[10];
        public z(int[] arrr)
        {
            this.arr = arrr;
        }
        public void swapp()
        {
            int swap;
             Console.WriteLine( "after sorting\n");
            for (int a = 0; a < 9; a++)
            {
                for (int b = 0; b <arr.Length; b++)
                {
                    if (arr[a] > arr[a+1])
                    {
                        swap = arr[a];
                        arr[a] = arr[a+1];
                        arr[a+1] = swap;
                    }
                }
            }
            for (int x = 0; x <arr.Length; x++)
            {
                Console.WriteLine(arr[x]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("enter numbers");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            z zee = new z(arr);
           zee.swapp();
           

        }
    }
}
