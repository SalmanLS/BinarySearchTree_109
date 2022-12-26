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

        public void inOrder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Root Is Empty.");
                return;
            }
            if (ptr != null)
            {
                inOrder(ptr.lchild);
                Console.WriteLine(ptr.info + " ");
                inOrder(ptr.rchild);
            }
        }

        public void preOrder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Root Is Empty. ");
                return;
            }
            if (ptr != null)
            {
                Console.WriteLine(ptr.info + " ");
                preOrder(ptr.lchild);
                preOrder(ptr.rchild);
            }
        }
        public void postOrder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Root Is Empty. ");
                return;
            }
            if (ptr != null)
            {
                postOrder(ptr.lchild);
                postOrder(ptr.rchild);
                Console.WriteLine(ptr.info + " ");
            }
        }

        static void Main(string[] args)
        {
            BinaryTree x = new BinaryTree();
            while (true)
            {
                Console.WriteLine("\n Menu");
                Console.WriteLine("1. Implement insert operation");
                Console.WriteLine("2. Perform inorder traversal");
                Console.WriteLine("3. Perform preorder traversal");
                Console.WriteLine("4. Perform postorder traversal");
                Console.WriteLine("5. Exit");
                Console.Write("\n Enter your choice (1-5) : ");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case '1':
                        {
                            Console.WriteLine("Enter a word: ");
                            string word = Console.ReadLine();
                            x.insert(word);
                        }
                        break;
                    case '2':
                        {
                            x.inOrder(x.ROOT);
                        }
                        break;
                    case '3':
                        {
                            x.preOrder(x.ROOT);
                        }
                        break;
                    case '4':
                        {
                            x.postOrder(x.ROOT);
                        }
                        break;
                    case '5':
                        return;
                    default:
                        {
                            Console.WriteLine("Invalid Option");
                            break;

                        }
                        
                }   

            }
        }
    }
    

}
