using System;

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

    }
    

}
