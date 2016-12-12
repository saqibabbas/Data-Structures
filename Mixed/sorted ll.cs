using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorted_linklist
{
    class node
    {
       public int data;
        public node next;
        public node(int d)
        {
            data = d;
        }
        public void displaynode()
        {
            Console.WriteLine(data);
        }
    }
    class linklist
    {
       public node first;
        public linklist()
        {
            first = null;
        }


        public void add_sort(int d)
        {
            node temp = new node(d);
            if(first==null)
            {
                temp.next = first;
                first = temp;
            }
            else
            {
                node temp1 = first; 
                node prev = first;
               while(temp1!=null)
                {
                    if(temp1.data>d)
                    {
                        if (prev == temp1)
                        {
                            temp.next = temp1;
                            first = temp;
                        }
                        else
                        {
                            prev.next = temp;
                            temp.next = temp1;
                        }
                        break;
                    }
                    prev = temp1;
                    temp1 = temp1.next;
                }
                
                if(temp1==null)
                {
                    prev.next=temp;
                    temp.next=null;
                }
            }
        }
        public void display()
        {
            node temp = first;
            while(temp!=null)
            {
                temp.displaynode();
                temp = temp.next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            linklist z1 = new linklist();
            z1.add_sort(45);
            z1.add_sort(15);
            z1.add_sort(25);
            z1.add_sort(65);
            z1.add_sort(40);
            z1.add_sort(10);
            z1.add_sort(55);
            z1.add_sort(30);
            z1.display();


        }
    }
}
