using System;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace BinarySearchTree
{
    
     /* node class cons*/
    class Node
    {
            public string info;
            public Node lchild;
            public Node rchild;

            //constructor for the node class

            public Node(string i, Node l, Node r)
            {
                info = i;
                lchild = l;
                rchild = r;
            }


    }
    class BinaryTree
    {
        public Node ROOT;

        public BinaryTree()
        {
            ROOT = null; // initializing root to null
        }

        public void insert(string element) // insert a node in the binary 
        {
            Node tmp, parent = null, currentNode = null;
            find(element, ref parent, ref currentNode);
            if (currentNode != null)
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else // if the specified node is not present 
            {
                tmp = new Node(element, null, null);
                if (parent == null)
                {
                    ROOT= tmp;
                }
                else if (string.Compare(element, parent.info) <0)
                {
                    if(string.Compare(element, parent.info) <0)
                        parent.lchild= tmp;
                }
                else
                {
                    parent.rchild= tmp;
                }
            }
        }
        public void find(string element, ref Node parent, ref Node currentNode)
        {
            currentNode = ROOT;
            parent =null;
            while ((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, parent.info) <0)
                    currentNode = currentNode.lchild;
                else
                    currentNode = currentNode.rchild;
            }
        }
    }
    

}
