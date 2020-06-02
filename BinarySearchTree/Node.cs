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
        public bool hasParent;
        public Node leftChildNode;
        public Node rightChildNode;
        private int data;
        public int Data { get { return data; } set { data = value; } }


        public Node(int data)
        {
            Data = data;
            hasParent = false;
            leftChildNode = null;
            rightChildNode = null;
        }



    }
}
