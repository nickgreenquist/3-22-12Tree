using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_22_12Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Levels = 5;

            tree.CreateTree();
            tree.RootNode.Print("");
        }
    }
}
