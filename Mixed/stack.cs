using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class node
    {
       public int data;
      public  node next;
        public node(int d)
        {
            data = d;
            next = null;
        }
        public void displaynode()
        {
            Console.Write(data+"  ");
        }
    }
    class stack
    {
        int length;
        node first;
        public stack(int l)
        {
            length = l;
            first = null;
        }
        public void push()
        {
            node temp = first;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            if (count >= length)
                Console.WriteLine("overflow");
            else
            {
                int d;
                Console.Write("push:");
                d = Convert.ToInt32(Console.ReadLine());
                node temp1 = new node(d);
                temp1.next = first;
                first = temp1;
            }

            Console.WriteLine();
        }
        public void pop()
        {
            if (first == null)
                Console.WriteLine("underflow");
            else
            {
                node temp1 = first;
                Console.WriteLine("pop:" + temp1.data);
                first = first.next;
            }
        }
        public void displaystack()
        {
            if (first == null)
            {
                Console.WriteLine("empty stack");

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
            int l;
            Console.Write("ENTER LENGTH OF THE STACK:");
            l =Convert.ToInt32( Console.ReadLine());
            stack z1 = new stack(l);


            int choice = 1, option;
            while (choice == 1)
            {
                Console.WriteLine("SELECT OPTION\n\n1)PUSH\n2)POP\n3)DISPLAY");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            z1.push();
                            break;
                        }
                    case 2:
                        {
                            z1.pop();
                            break;
                        }
                    case 3:
                        {
                            z1.displaystack();
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
