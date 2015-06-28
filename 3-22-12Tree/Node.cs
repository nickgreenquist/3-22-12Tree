using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_22_12Tree
{
    class Node
    {
        private int data;
        private Node rightChild;
        private Node leftChild;
        private Node parent;
        private Node leftNeighbor;
        private Node rightNeighbor;
        public bool last;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node RightChild
        {
            get { return rightChild; }
            set { rightChild = value; }
        }
        public Node LeftChild
        {
            get { return leftChild; }
            set { leftChild = value; }
        }

        public Node LeftNeighbor
        {
            get { return leftNeighbor; }
            set { leftNeighbor = value; }
        }

        public Node RightNeighbor
        {
            get { return rightNeighbor; }
            set { rightNeighbor = value; }
        }

        public Node Parent
        {
            get { return parent; }
            set { parent = value;  }
        }

        public void Print(string indent)
        {
            Console.Write(indent);
            if(last)
            {
                Console.Write("\\-");
                indent += "  ";
            }
            else
            {
                Console.Write("|=");
                indent += "| ";

            }
            Console.WriteLine(data);

            if (leftChild != null)
            {
                leftChild.Print(indent);
            }
            if (rightChild != null)
            {
                rightChild.Print(indent);
            }
        }
    }
}
