using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linklist
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
            Console.WriteLine(data);
        }

    }
    class linklist
    {
        node first;
        public linklist()
        {
            first = null;
        }
        public void addfirst(int data)
        {
            node temp = new node(data);
            temp.next = first;
            first = temp;
        }
        public void addlast(int data)
        {
            if (first == null)
            {
                node temp = new node(data);
                temp.next = first;
                first = temp;
            }
            else
            {
                node temp = new node(data);
                node temp1 = first;
                while (temp1.next != null)
                {
                    temp1 = temp1.next;
                }
                temp1.next = temp;
                temp.next = null;
            }
        }
        public void display()
        {
            if (first == null)
                Console.WriteLine("empty list");
            else
            {
                node temp = first;
                while (temp != null)
                {
                    temp.displaynode();
                    temp = temp.next;
                }
            }
        }
        public void search(int data)
        {
            if (first == null)
                Console.WriteLine("empty list");
            else
            {
                int check = 0;
                node temp = new node(data);
                node temp1 = first;
                while (temp1 != null)
                {
                    if (temp1.data == temp.data)
                    {
                        Console.WriteLine("found");
                        check = 1;
                    }
                    temp1 = temp1.next;
                }
                if (check == 0)
                    Console.WriteLine("not found");
            }
        }
        public void deletefirst()
        {

            if (first == null)
                Console.WriteLine("empty list");
            else
            {
                first = first.next;
            }
        }
        public void delete()
        {
            if (first == null)
                Console.WriteLine("empty list");
            else
            {
                node temp = first;
                node temp1 = first.next;
                while (temp1.next != null)
                {
                    temp = temp1;
                    temp1 = temp1.next;
                }
                temp.next = null;
            }
        }
        
        public void searchdelete(int data)
        {
            if(first==null)
                Console.WriteLine("empty list");
            else
            { 
            node temp=null;
            node temp1=first;
            while (temp1!= null)
            {
                
                if (temp1.data == data)
                {
                    if (temp == null)
                    {
                        first = first.next;
                        Console.WriteLine("found and deleted\n");
                        break;
                     
                    }
                    else
                    {
                        Console.WriteLine("found and deleted\n");
                        temp.next = temp1.next;
                        break;
                    }
                }
                temp = temp1;
                temp1 = temp1.next;
            }
            }

        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                int input;
                int choice ;
                int choice2=1;

                linklist z1 = new linklist();
                while (choice2 == 1)
                {
                     try
                    {
                    Console.WriteLine("\n1) for add node to first\n 2) to print list\n 3)to search \n 4)delete first node\n 5) delete a last node \n 6)add node at last\n7)to search and delete\n8)exit\n\n\n");
                    choice = Convert.ToInt32(Console.ReadLine());
                   
                        switch (choice)
                        {
                            case 1:
                                {
                                    Console.WriteLine("enter number to add");
                                    input = Convert.ToInt32(Console.ReadLine());
                                    z1.addfirst(input);
                                    Console.WriteLine("\n\nlist is\n");
                                    z1.display();
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("\n\nlist is:\n");
                                    z1.display();
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("enter number to search");
                                    input = Convert.ToInt32(Console.ReadLine());
                                    z1.search(input);
                                    break;
                                }
                            case 4:
                                {
                                    z1.deletefirst();
                                    Console.WriteLine("\n\nlist is\n");
                                    z1.display();
                                    break;
                                }
                            case 5:
                                {
                                    z1.delete();
                                    Console.WriteLine("\n\nlist is:\n");
                                    z1.display();
                                    break;
                                }
                            case 6:
                                {
                                    Console.WriteLine("enter number to add");
                                    input = Convert.ToInt32(Console.ReadLine());
                                    z1.addlast(input);
                                    Console.WriteLine("\nlist is:\n");
                                    z1.display();
                                    break;
                                }

                            case 7:
                                {
                                    int data;
                                    Console.WriteLine("enter number to search and delete");
                                    data = Convert.ToInt32(Console.ReadLine());
                                    z1.searchdelete(data);
                                    Console.WriteLine("\n\nlist is:\n");
                                    z1.display();
                                    break;
                                }
                            case 8:
                                {
                                    Console.WriteLine("thanks for using linklist");
                                    Environment.Exit(0);
                                    Console.WriteLine("press any key to exit");
                                    break;
                                }

                        }
                        continue;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("WRONG INPUT");
                        break;
                        
                    }
                }
            }

        }

    }
