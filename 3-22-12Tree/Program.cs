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
            Console.Write("Please enter how many levels you want in the tree: ");
            tree.Levels = Convert.ToInt32(Console.ReadLine());

            tree.CreateTree();
            tree.RootNode.Print("");
        }
    }
}
