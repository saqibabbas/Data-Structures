using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorted_linklist
{
    class Program
    {
        static void Main(string[] args)
        {
            sorted_link sort = new sorted_link();
            sort.insertfirst(12);
            sort.insertfirst(15);
            sort.insertfirst(10);
            sort.insertfirst(50);
            
            sort.displaylist();
            sort.deletefirst();
            sort.displaylist();
            sort.findanddelete(15);
            sort.displaylist();
        }
    }
    class node
    {
        public int data;
        public node next;
        public node(int d)
        {
            data = d;
            next = null;
        }
        public void dis()
        {
            Console.WriteLine(data);
        }
    }
    class sorted_link
    {
        node first;
        public sorted_link()
        {
            first = null;
        }
        public void insertfirst(int d)
        {
            node temp = new node(d);
            node previous = null;
            node current = first;
            while (current!=null && d>current.data)
            {
                previous = current;
                current = current.next;
            }
            if (previous==null)
            {
                first = temp;
            }
            else
            {
                previous.next = temp;
            }
            temp.next = current;


        }
        public void displaylist()
        {
            Console.WriteLine("display");
            node temp = first;
            while (temp != null)
            {
                temp.dis();
                temp = temp.next;
            }


        }
        public void deletefirst()
        {
            if (first != null)
            {
                first = first.next;
                Console.WriteLine("first deleted");
            }
            else
            {
                Console.WriteLine("empty list");
            }
        }
        
        
        public void find(int d)
        {
            node temp = first;
            while (temp.data != d)
            {
                if (temp.next == null)
                {
                    return;
                }
                else
                    temp = temp.next;
            }

            if (temp.data == d)
            {
                Console.WriteLine(d + "found");
            }

        }
        public void findanddelete(int d)
        {
            node temp = first;
            node previous = first;
            while (temp.data != d)
            {
                if (temp.next == null)
                {
                    return;

                }
                else
                {
                    previous = temp;
                    temp = temp.next;
                }
            }
            if (temp == first)
            {
                first = first.next;
            }
            else
            {
                previous.next = temp.next;
            }
            Console.WriteLine(d + "found and deleted");

        }




    }
}
