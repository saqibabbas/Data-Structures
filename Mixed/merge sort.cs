using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergesort
{
    class Program
    {
        public static void mainmerge( int[] array,int start,int mid,int end)
        {
            int[] temp = new int[25];
            int left = (mid - 1);
            int pos= start;
          
            int elem = end - start + 1;


            while ((start <= left) && (mid <= end))
            {

                if (array[start] <= array[mid])
                {
                    temp[pos] = array[start];
                    start++;
                    pos++;
                }
                else 
                {
                    temp[pos] = array[mid];
                    mid++;
                    pos++;
                }
            }

                while (start <=left)
                {
                    temp[pos] = array[start];
                    start++;
                    pos++;
                }

                while (mid <= end)
                {
                    temp[pos] = array[mid];
                    mid++;
                    pos++;
                }



            
            for (int i =0; i <elem; i++)
            {
                 array[end] = temp[end];
                end--;
            }
            
         
        }
        public static void merge( int[] array,int start,int end)
        {
            int mid;
            if (end>start)
            {
                 mid = (start + end) / 2;
                merge(array, start, mid);
                merge(array, mid+1, end);

                mainmerge( array,start,mid+1,end);
            }

        }
        static void Main(string[] args)
        {
            int[] array = {77,44,0,3,23,33,11,10,9};
            merge( array,0,array.Length-1);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
          
        }
    }
}
