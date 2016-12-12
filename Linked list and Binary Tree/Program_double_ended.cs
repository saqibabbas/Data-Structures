using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_ended_linklist
{
    class Program
    {
        static void Main(string[] args)
        {
            double_ended d = new double_ended();
            d.inerstfirst(10);
           d.inerstfirst(20);
           d.inerstfirst(30);
           d.displaylist();
           d.insertlast(40);
           d.insertlast(50);
           d.insertlast(60);
           d.displaylist();
           d.deletefirst(); d.deletefirst(); d.deletefirst(); d.deletefirst(); d.deletefirst(); d.deletefirst(); d.deletefirst();
           d.displaylist();
        }
    }
     class node
    {
        public int data;
        public node next;
        public node(int d)
        {
            this.data = d;
            this.next = null;

        }
        public void dis()
        {
            Console.WriteLine(this.data);
        }
    }
     class double_ended
     {
         node first;
         node last;
         public double_ended()
         {
             first = null;
             last = null;
         }
         public void inerstfirst(int d)
         {
             Console.WriteLine("insert firs");
             node temp = new node(d);
             if (last==null)
             {
                 first = temp;
                 last = temp;
             }
             else
             {
                 //node current = first;
                 temp.next = first;
                 first = temp;

             }
         
         
         }
         public void displaylist()
         {
             Console.WriteLine("display");
             node temp = first;
             while (temp!=null)
             {
                 temp.dis();
                 temp = temp.next;

             }
         
         }
         public void insertlast(int d)
         {
             Console.WriteLine("insert last");
         node temp=new node(d);
         if (first == null)
         {
             first = temp;
             last = temp;
         }
         else
         {


             last.next = temp;
             last = temp;
         }
         
         }
         public void deletefirst()
         {
             Console.WriteLine("delete firs");

             if (first==null)
             {
                 Console.WriteLine("no data");
                 return;
             }
             else
             {
                 first = first.next;
             }
         }
     
     }

}
