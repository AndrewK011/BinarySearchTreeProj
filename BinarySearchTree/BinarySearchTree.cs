using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        List<Node> tree = new List<Node>();
        Node root;
        Node current;
        
        public void Add(int nodeData)
        {
            Node nodeToAdd = new Node(nodeData);
            if (root == null)
            {
                root = nodeToAdd;
            }

            else
            {
                current = root;
                while (nodeToAdd.parent == null)
                {
                    if (nodeToAdd.Data <= current.Data)
                    {
                        if (current.leftChildNode == null)
                        {
                            nodeToAdd.parent = current;
                            current.leftChildNode = nodeToAdd;
                        }
                        else
                        {
                            current = current.leftChildNode;
                        }
                    }
                    else
                    {
                        if(current.rightChildNode == null)
                        {
                            nodeToAdd.parent = current;
                            current.rightChildNode = nodeToAdd;
                        }
                        else
                        {
                            current = current.rightChildNode;
                        }
                    }
                }
            }
            tree.Add(nodeToAdd);
        }
        public void Search(int nodeDataToFind)
        {
            current = root;
            bool dataFound = false;
            while (!dataFound && current != null)
            {
                if (nodeDataToFind > current.Data)
                {
                    current = current.rightChildNode;
                }

                else if(nodeDataToFind < current.Data)
                {
                    current = current.leftChildNode;
                }
                else
                {
                    dataFound = true;                  
                }
            }

            if(dataFound)
            {
                Console.WriteLine($"{nodeDataToFind} was in the tree!");

            }
            else
            {
                Console.WriteLine($"{nodeDataToFind} was not in the tree!");
            }
        }
    }
}
