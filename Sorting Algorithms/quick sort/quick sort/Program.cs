using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quick_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int pivot;
            int[] arr = {90,10,20,6 };
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("ok");
            quick(0, arr.Length - 1, arr);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            //pivot = pivot_partition(0, arr.Length - 1, arr, arr[0]);
            //Console.WriteLine(pivot);
        }
        static int pivot_partition(int up,int down, int[] arr, int pivot)
        {
            int left = up;
            down++;
            while (true)
            { 
                // find bigger item
                while (up<arr.Length-1&& arr[++up] < pivot )
                {
                 
                } 
                // find smaller item
                while (down> 0 && arr[--down] > pivot)
                {
                    
                } 
                if (up >= down) 
                    break; 
                else 
                    swap(up, down,arr);
            } 
            swap(left, down,arr);
            Console.WriteLine("complete");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            return down;
        
        }
        static void swap (int one,int two,int [] arr)
        {
            
        int temp=arr[one];
            arr[one]=arr[two];
            arr[two]=temp;
        
        }
        static void quick(int left,int right,int [] array)
        {
            if (right - left <= 0) 
                return;
            else
            {
                int pivot = array[left];
                int final_pivot = pivot_partition(left, right, array, pivot);
                quick(left, final_pivot - 1, array);
                quick(final_pivot + 1, right, array);
            }
        }
    }
}
