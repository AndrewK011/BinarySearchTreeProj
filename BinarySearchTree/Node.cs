using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        //public Node link;
       // public Node root;
        public Node parent;
        public Node leftChildNode;
        public Node rightChildNode;
        //public Node right;
        //public Node left;
        private int data;
        public int Data { get { return data; } set { data = value; } }


        public Node(int data)
        {
            Data = data;
            parent = null;
            leftChildNode = null;
            rightChildNode = null;
        }



    }
}
