using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackas_linklist
{
    class Program
    {
        static void Main(string[] args)
        {

            char check;
            int input;
            linklist link = new linklist();
            Console.WriteLine("push            : press 1");
            Console.WriteLine("pop             : press 2");
            Console.WriteLine("Display list    : press 3");
            while (true)
            {
                Console.WriteLine("Enter choice ");

                check = Convert.ToChar(Console.ReadLine());
                switch (check)
                {
                    case '1':
                        {
                            Console.WriteLine("Enter number");
                            input = Convert.ToInt32(Console.ReadLine());
                            link.push(input);
                            break;
                        }
                    case '2':
                        {                            
                         link.pop();
                            break;
                        }
                    case '3':
                        {
                            link.display();
                            break;
                        }
                }
            }                    
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
    class linklist
    {
        node first;
        public linklist()
        {
            this.first = null;
        }
        public void push(int d)
        {
            node temp = new node(d);
            temp.next = first;
            first = temp;                
        }
        public void pop()
        {
            if (first==null)
            {
                Console.WriteLine("stack underflow");
            }
            else
            {
                first = first.next;
            }
        
        }
        public void display()
        {
            Console.WriteLine("List");
            node temp = first;
            while (temp!=null)
            {
                temp.dis();
                temp = temp.next;
            }
        
        }

    }
}
