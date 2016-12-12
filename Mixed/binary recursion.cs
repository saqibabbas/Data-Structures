using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, target, start, end,length=0 ;
            Console.WriteLine("input array lenght");
            num = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[num];
            Console.WriteLine("enter numbers for array");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("enter number to find");
            target = Convert.ToInt32(Console.ReadLine());
            start = 0; end = array.Length - 1;
            recursion(array,start,end,target,length);
           
        }
        public static void recursion(int[] array,int start,int end,int target,int length)
        {
             int middle, check = 0 ;
                 middle = (start + end) / 2;
                 length++;
                 if (length<array.Length)
                 {

                     if (target == array[middle])
                     {
                         check = 1;
                         Console.WriteLine("found at array[" + middle + "] at "+length+"iteration");
                     }
                     else if (target < array[middle])
                     {
                         recursion(array, start, middle - 1, target,length);
                     }
                     else if (target > array[middle])
                     {
                         recursion(array, middle + 1, end, target,length);
                     }

                 }
            else if(check==0)
                Console.WriteLine("not found");
             
                
    }
    }
}
