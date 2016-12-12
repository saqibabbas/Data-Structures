using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_aslinklist
{
    class Program
    {
        static void Main(string[] args)
        {
            queuelink link = new queuelink();
            link.rear(20);
            link.rear(30);
            link.rear(40);
            link.display();
            link.front();
            link.display();
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
    class queuelink
    {
        node first;
        node last;
        public queuelink()
        {
            first = null;
            last = null;
            
        }
        public void rear(int d)
        {
            //node temp = first;
            node temp = new node(d);

            if (last == null)
            {
                
                first=temp;
            }
            else
            {
                last.next = temp;
            }
                last = temp; 
        }
        public void display()
        {
            node temp = first;
            while (temp!=null)
	{
	         temp.dis();
             temp = temp.next;

	}
        }
        public void front()
        {
            if (first==null)
            {
                last = null;
            }
            else
            {
                first = first.next;
            }
        }
   
    }
}
