using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_sort
{
    class quick
    {
        int temp,i,j,pivot;
        public quick(int[] arr,int start,int end)
        {
         
            Console.WriteLine(end);
            if(start<end)
            {
                 pivot = partition(arr,start,end);
                 partition(arr,start,pivot-1);
                 partition(arr,pivot+1,end);
            }
            for(int m=0;m<arr.Length;m++)
            Console.Write(arr[m]+" ");
            
        }
        public int partition(int[] arr,int i,int j)
        {
            int pivot2 = arr[1];
            int temp,start=i,end=j;
            while(i<j)
            {
                while (arr[i] < pivot2)
                    i++;
                while (arr[j] > pivot2)
                    j--;
                if(i<j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
                else if(i>=j)
                {
                    temp = pivot2;
                    pivot2= arr[j];
                    arr[j] = temp;
                }
            }
            return j;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {55,10,5,34,67};
            quick zee = new quick(arr,0,arr.Length-1);
            

        }
    }
}
