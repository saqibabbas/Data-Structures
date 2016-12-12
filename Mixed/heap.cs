using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heap
{
    class Program
    {
        public static void heapify(int[] array,int index,int max,string choice)
        {
            int temp;
            int ind;
          
            if(choice=="max")
            {
            while (index >= 0)
            {
                ind=(index-1)/2;
               if(ind>=0)
               {
                   if (array[ind] < array[index])
                   {
                       temp=array[ind];
                       array[ind] = array[index];
                       array[index] = temp;
                   }
               }

                index--;
            }
            
            }
            else if (choice == "min")
            {
                while (index >= 0)
                {
                    ind = (index - 1) / 2;
                    if (ind >= 0)
                    {
                        if (array[ind] > array[index])
                        {
                            temp = array[ind];
                            array[ind] = array[index];
                            array[index] = temp;
                        }
                    }

                    index--;
                }

            }
        }
        public static void display(int[] array)
        {

         
            for (int z = 0; z < array.Length; z++)
            {
                 Console.Write(array[z]+ " ");            
            }
            Console.WriteLine();
        }
        public static void heapsort(int[] array)
        {
            int temp, leftchild, rightchild,index=0,largerchild;
            int last = array.Length - 1;
            int point=last;
          
            while (last >= index)
            {
                leftchild = (2 * index) + 1;
                rightchild = leftchild + 1;
                temp = array[index];

                if (array[leftchild] < array[rightchild])
                {
                    largerchild = rightchild;
                    if(largerchild==point)
                        largerchild=leftchild;
                }
                else
                {
                    largerchild = leftchild;
                    if(largerchild==point)
                        largerchild=rightchild;
                }
                if (largerchild == last)
                    last--;
                array[index] = array[largerchild];


                if(last==index)
                {
                    array[largerchild] = temp;
                    break;
                }
             
                    array[largerchild] = array[last];
                    array[last] = temp;
                    point = last;   
                last--;
            }
    
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of elements");
            int num;
            string choice;
            num = Convert.ToInt32(Console.ReadLine());
           
            int[] array = new int[num];
            Console.WriteLine("enter elements");
            for (int i = 0; i < num; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("want max heap or min heap??");
            choice = Console.ReadLine();
            Console.Write("unsorted array:");

            for (int q = 0; q < num; q++)
            {
                Console.Write(array[q]+" ");
            }
            Console.WriteLine();    
           for(int j =0 ; j<array.Length;j++)
           heapify(array,j,num,choice);
           Console.Write("Heap is:"+" ");
           display(array);
           Console.Write("Heap sort:"+" ");
           heapsort(array);
           display(array);
           Console.ReadKey();
        }
    }
}
