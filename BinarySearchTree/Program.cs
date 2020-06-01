using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree sim = new BinarySearchTree();
            sim.Add(50);
            sim.Add(5);
            sim.Add(10);
            sim.Add(60);
            sim.Add(70);
            sim.Add(50);
            sim.Add(20);
            sim.Add(100);

            sim.Search(60);
        }
    }
}
