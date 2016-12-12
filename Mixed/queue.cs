using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{

    class node
    {
        public int data;
        public node next;
        public node(int d)
        {
            data = d;
            next = null;
        }
        public void displaynode()
        {
            Console.Write(data + "  ");
        }
    }
    class queue
    {
        node first;
        public queue()
        {
            first = null;
        }
        public void enque()
        {
                int d;
                Console.Write("enque:");
                d = Convert.ToInt32(Console.ReadLine());
                node temp1 = new node(d);
                node temp = first;
            if(first==null)
            {
                temp1.next = first;
                first = temp1;
            }
            else{
            while(temp.next!=null)
            {
                temp = temp.next;
            }
            temp.next = temp1;
            }
            Console.WriteLine();

        }
        public void deque()
        {
            if(first==null)
                Console.WriteLine("empty queue");
            else
            {
            Console.WriteLine("deque:"+first.data);
            first = first.next;
        }
        }
        public void displayqueue()
        {
            if (first == null)
            {
                Console.WriteLine("empty queue");

            }
            else
            {
                Console.Write("List is: ");
                node temp = first;
                while (temp != null)
                {
                    temp.displaynode();
                    temp = temp.next;
                }
            }

            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          
            queue z1 = new queue();

            int choice=1,option;
            while(choice==1)
            {
                Console.WriteLine("SELECT OPTION\n\n1) ENQUEUE\n2)DE-QUEUE\n3)DISPLAY");
                option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        {
                            z1.enque();
                            break;
                        }
                    case 2:
                        {
                            z1.deque();
                            break;
                        }
                    case 3:
                        {
                            z1.displayqueue();
                            break;
                        }
                    default:
                        {
                        Console.WriteLine("wrong selection");
                            break;
                }
                }
                Console.WriteLine("press 1 to use further");
                choice = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
