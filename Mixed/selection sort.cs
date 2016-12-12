using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class selection
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int least,swap,count=0;
            Console.WriteLine("ENTER INPUT");
            for (int i=0; i<10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int u = 0; u < 9; u++)
            {
                least = arr[u];
                for (int y = u; y < 10; y++)
                {
                    if (arr[y] < least)
                    {
                        count = y;
                        least = arr[y];
                    }
                }
                if(count!=0)
                { 
                swap = arr[u];
                arr[u] = least;
                arr[count] = swap;
                count = 0;
            }

            }
            for(int h=0;h<10;h++)
            {
                Console.WriteLine(arr[h]);
            }
            
        }
    }
}
