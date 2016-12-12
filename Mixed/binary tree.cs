using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class node
    {
        public int data;
        public node leftchild;
        public node rightchild;
        public node(int d)
        {
            data = d;
            leftchild = null;
            rightchild = null;
        }
      
        public void displaynode()
        {
            Console.Write(data);
        }
    }
    class tree
    {
        node root;
        public tree()
        {
            root = null;
        }
        public void addnode(int d)
        {
            node temp = new node(d);
           if (root == null)
            {
                root = temp;
            }
            else
            {
                node current = root;
                node parent;
                while (true)
                {
                    parent = current;
                    if (d < current.data)
                    {
                        current = current.leftchild;
                        if (current == null)
                        {
                            parent.leftchild = temp;
                            break;
                        }
                    }
                    else
                    {
                        current = current.rightchild;
                        if (current == null)
                        {
                            parent.rightchild = temp;
                            break;
                        }
                    }
                }
            }
        }
        public void search()
        {
            node current = root;
            Console.Write("enter number to search");
            int d = Convert.ToInt32(Console.ReadLine()); ;
            while (current.data != d)
            {
                if (d < current.data)
                {
                    current = current.leftchild;
                }
                else
                {
                    current = current.rightchild;
                }
                if (current == null)
                {
                    break;
                }
            }
            if(current==null)
                Console.WriteLine("not found");
            else
            {
                Console.WriteLine("found "+current.data);
            }

         
        }

        public node returnroot()
        {
            return root;
        }
        public void display(node root)
        {
            if (root != null)
            {
                display(root.leftchild);
                Console.Write(root.data + " ");
                display(root.rightchild);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            tree t1 = new tree();
            t1.addnode(42);
            t1.addnode(25);
            t1.addnode(65);
            t1.addnode(12);
            t1.display(t1.returnroot());
            Console.WriteLine();
            t1.search();
     
        }
    }
}
