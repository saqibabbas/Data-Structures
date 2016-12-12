using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search
{
    class bin
    {
        int start, end, target,mid,check=0;
        int[] arr;
        public bin(int[] arr,int start,int end,int target)
        {
            this.end = end;
            this.start = start;
            this.target = target;
            this.arr = arr;
            searching();

        }
        public void searching()
        {
            for (int y = 0; y < arr.Length; y++)
            {
                mid = (start + end) / 2;
                if (arr[mid] == target)
                {
                    check = 1;
                    Console.WriteLine("found at array[" + mid + "]");
                    break;
                }

                else if (target < arr[mid])
                {
                    end = mid;
                }
                else if (target > arr[mid])
                {
                    start = mid;
                }
            }
            if (check==0)
            Console.WriteLine("not found");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {10,20,30,40,50,60,70,80,90};
            Console.WriteLine("enter number to be found");
            bin zee;
            int num, start = 0,end=array.Length;
            num = Convert.ToInt32(Console.ReadLine());
            zee = new bin(array, start, end, num);
           

        }
    }
}
