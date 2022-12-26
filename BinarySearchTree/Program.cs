using System;

namespace BinarySearchTree
{
    class Program
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
    }

}
