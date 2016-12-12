using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubly_linklist
{
    class node
    {
     public   int data;
     public     node next;
     public  node previous;
     public node(int d)
        {
            data = d;
            next = null;
            previous = null;
        }
        public void displaynode()
    {
        Console.WriteLine(data);
    }

    }
    class doubly
    {
      node first,last;
        public doubly()
        {
           first = null;
           last = null;
        }
        public void addfirst(int d)
        {
            node temp = new node(d);
            if (first == null)
            {
                last = temp;
                first = temp;
            }
            else
            {
                first.previous = temp;
                temp.next = first;
                first = temp;
            }
        }
        
        public void addlast(int d)
        {
            node temp = new node(d);
            temp.previous = last;
            last.next = temp;
            last = temp;
       }
       
        public void deletefirst()
        {
            first.next.previous = null;
            first = first.next;

        }
        public void deletelast()
        {
            if (first.next == null)
                first.next.previous = null;
            else
            {
             
                last.previous.next = null;
                last = last.previous;
            }
        }
        public void search()
        {
            int num;
            if(first==null)
                Console.WriteLine("empty list!!!");
            else
            {
                Console.WriteLine("enter number to search");
                num = Convert.ToInt32(Console.ReadLine());
                node point = first;
                while(point!=null)
                {
                    if (point.data == num)
                    {
                        Console.WriteLine("found");
                        break;
                    }
                    else
                        point = point.next;
                }
                if(point==null)
                    Console.WriteLine("not found");
            }
        }
        public void search_delete()
        {
               int num;
            if(first==null)
                Console.WriteLine("empty list!!!");
            else
            {
                Console.WriteLine("enter number to search and delete");
                num = Convert.ToInt32(Console.ReadLine());
                node temp = first;
                node previous = first;
                while (temp != null)
                {
                    if (temp.data == num)
                    {
                        Console.WriteLine("found and deleted");
                        previous.next = temp.next;
                        temp.next.previous = null;
                        break;
                    }
                    else
                    { 
                        previous=temp;
                        previous = temp.next;
                    }
                }
                if(temp==null)
                    Console.WriteLine("not found");
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
            doubly a1 = new doubly();
          int input;
                int choice2;

                do
                {

                    Console.WriteLine("\n1) for add node to first\n 2) to print list\n 3)to search \n 4)delete first node\n 5) delete a last node \n 6)add node at last\n7)to search and delete\n0)for exit\n\n\n");
                    choice2 = Convert.ToInt32(Console.ReadLine());

                    switch (choice2)
                    {
                        case 1:
                            {
                                Console.WriteLine("enter number to add");
                                input = Convert.ToInt32(Console.ReadLine());
                                a1.addfirst(input);
                                Console.WriteLine("\n\nlist is\n");
                                a1.display();
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("\n\nlist is:\n");
                                a1.display();
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("enter number to search");
                                input = Convert.ToInt32(Console.ReadLine());
                                a1.search();
                                break;
                            }
                        case 4:
                            {
                                a1.deletefirst();
                                Console.WriteLine("\n\nlist is\n");
                                a1.display();
                                break;
                            }
                        case 5:
                            {
                                a1.deletelast();
                                Console.WriteLine("\n\nlist is:\n");
                                a1.display();
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("enter number to add");
                                input = Convert.ToInt32(Console.ReadLine());
                                a1.addlast(input);
                                Console.WriteLine("\nlist is:\n");
                                a1.display();
                                break;
                            }

                        case 7:
                            {
                                int data;
                                Console.WriteLine("enter number to search and delete");
                                data = Convert.ToInt32(Console.ReadLine());
                                a1.search_delete();
                                Console.WriteLine("\n\nlist is:\n");
                                a1.display();
                                break;
                            }
                        case 0:
                            {
                                Console.WriteLine("thanks for using doubly-linklist");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("wrong choice");
                                    break;
                            }
                        


                    }
                    continue;


                } while (choice2 !=0);
            }

        }
    }

