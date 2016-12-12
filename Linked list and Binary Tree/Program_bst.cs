using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree b = new BinarySearchTree();
            b.insert(10);
            b.insert(12);
            b.insert(4);
            b.insert(6);
            b.inorder(b.root);
        }
    }
    
        
        class Node
        {
            public int data;
            public Node left;
            public Node right;
            public Node(int value)
            {
                this.data = value;
                left = null;
                right = null;
            }
        }
        class BinarySearchTree
        {
             public Node root;
            static int count;
            public BinarySearchTree()
            {
                root = null;
            }

        
            

        
            public void insert(int data)
            {
                Node temp = new Node(data);
                if (root==null)
                {
                    root = temp;

                }
                else
                {

                    Node current = root;
                while (true)
                {
                    if (temp.data > current.data)
                    {
                        if (current.right == null)
                        {
                            current.right = temp;
                            break;
                        }
                        current = current.right;
                    }
                    else
                    {
                        if (current.left == null)
                        {
                            current.left = temp;
                            break;
                        }
                        current = current.left;
                    }
                }
                }
            }
        
            public void inorder(Node root)
            {
                if (root != null)
                {
                    inorder(root.left);
                    Console.Write(root.data + " ");
                    inorder(root.right);
                }
            }

        }   
}

