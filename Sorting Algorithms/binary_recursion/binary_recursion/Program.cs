using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_recursion
{
    class Program
    {
      //  int mid;
        static void Main(string[] args)
        {
            int[] arr = { 1,2,4,5,6,7};
            int left=0, right=5, t=2;
            int result;

            result = Program.sea(arr, left, right, t);
            Console.WriteLine(result);
        }

     public static   int sea(int[] a, int left, int right, int t)
        {

           int mid = (left + right) / 2;
            if (t == a[mid])
            {
                return t;
            }
            if (t >= a[mid])
            {

                return sea(a, left + 1, right, t);

            }
            if (t <= a[mid])
            {

                return sea(a, left, right - 1, t);
            }
            return -1;
        }

}
}
