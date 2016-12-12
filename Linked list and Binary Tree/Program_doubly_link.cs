using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubly_linklist
{
    class Program
    {
        static void Main(string[] args)
        {
            doublylink doubly = new doublylink();
            doubly.insertfirst(10);
            doubly.insertfirst(14);
            doubly.insertfirst(18);
            doubly.displayforward();
            doubly.insertlast(12);
            doubly.insertlast(30);
            doubly.displayforward();
            doubly.displaybackward();
        }
    }
    class Node
    {
        public int data;
        public Node next;
        public Node previous;
        public Node(int value)
        {
            this.data = value;
            next = null;
            previous = null;
        }
        public void dis()
        {
            Console.WriteLine(data);
        }
    }

    class doublylink
    {
        public Node first;
        public Node last;
        public doublylink()
        {
            first = null;
        }
        public void insertfirst(int data)
        {
            
            Node temp = new Node(data);
            if (first == null)
            {                
                last = temp;
            }
            else
            {
                first.previous = temp;                
            }
            temp.next = first;
            first = temp;
        }
        public void displayforward()
        {
            Console.WriteLine("dislay forward");
            Node temp = first;
            while (temp!=null)	
            {
	         temp.dis();
             temp = temp.next;
            }              
        }
        public void displaybackward()
        {
            Console.WriteLine("dislay backward");
            Node temp = last;
            while (temp != null)
            {
                temp.dis();
                temp = temp.previous;
            }
        }
        public void insertlast(int data)
        {
            Node temp = new Node(data);
            if (last==null)
            {
                first = temp;
            }
            else
            {
                last.next = temp;
                temp.previous=last;
            }
            last = temp;
        }
    }
}
