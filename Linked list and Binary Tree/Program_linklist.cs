using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linklist
{
    class Program
    {
        static void Main(string[] args)
        {
            char check;
            int input;
            link l = new link();
            Console.WriteLine("Insert first    : press 1");
            Console.WriteLine("Insert last     : press 2");
            Console.WriteLine("Display list    : press 3");
            Console.WriteLine("Delete first    : press 4");
            Console.WriteLine("Delete last     : press 5");
            Console.WriteLine("Find number     : press 6");
            Console.WriteLine("Find and delete : press 7");
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

                            l.insertfirst(input);
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("Enter number");
                            input = Convert.ToInt32(Console.ReadLine());

                            l.insertlast(input);
                            break;
                        }
                    
                    case '3':
                        {
                            l.displaylist();
                            break;
                        }
                    case '4':
                        {
                            l.deletefirst();
                            break;
                        }
                    case '5':
                        {
                            l.deletelast();
                            break;
                        }
                    case '6':
                        {
                            Console.WriteLine("Enter number");
                            input = Convert.ToInt32(Console.ReadLine());

                            l.find(input);
                            break;
                        }
                    case '7':
                        {
                            Console.WriteLine("Enter number");
                            input = Convert.ToInt32(Console.ReadLine());

                            l.findanddelete(input);
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
            data = d;
            next = null;
        }
        public void dis()
        {
            Console.WriteLine(data);
        }
    }
    class link
    {
        node first;
        public link()
        {
            first = null;
        }
        public void insertfirst(int d)
        {
            node temp = new node(d);
            temp.next = first;
            first = temp;
            
        
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
        public void insertlast(int d)
        {
            Console.WriteLine("insertlast");
            node temp = first;
            node current = first;
            while (current != null)
            {
                temp = current;
                current = current.next;
            }
            node last = new node(d);
            temp.next = last;
            last.next = null;
            
        }
        public void deletelast()
        {
            Console.WriteLine("deletelast");
            node current = first;
            node temp = first;
            while (current.next!=null)
            {
              
                    temp = current;
                    current = current.next;

             
            }
            temp.next = current.next;                             
        }
        public void find(int d)
        {
            node temp = first;
            while (temp.data!=d)
            {
                if (temp.next==null)
                {
                    return;
                }
                else
                temp = temp.next;
            }

            if (temp.data==d)
            {
                Console.WriteLine(d+"found");
            }
        
        }
        public void findanddelete(int d)
        {
            node temp = first;
            node previous = first;
            while (temp.data!=d)
            {
                if (temp.next==null)
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
            Console.WriteLine(d+"found and deleted");
        
        }
       


    
    }
}
