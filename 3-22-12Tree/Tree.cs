using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_22_12Tree
{
    class Tree
    {
        private Node rootNode;
        private int levels;

        public int Levels
        {
            get { return levels; }
            set { levels = value; }
        }

        public Node RootNode
        {
            get { return rootNode; }
            set { rootNode = value; }
        }

        public void CreateTree()
        {
            rootNode = new Node();
            rootNode.Data = 1;
            rootNode.Parent = null;
            rootNode.last = true;

            if (levels > 1)
            {
                CreateTree(rootNode, 2);
            }

            //go back and set up neighbors
            SetNeighbors(rootNode, 2);
        }

        public void CreateTree(Node node, int level)
        {
          //- The value for the children nodes is determined as follows:
          // If it's the left children, its value will be the sum of the parent's value and the parent's left neighbor's value. If the parent has no left neighbor, then the child's value is the same as its parent.
          // If it's the right children, its value will be the sum of the parent's value and the parent's right neighbor's value. If the parent has no right neighbor, then the child's value is the same as its parent.

            node.LeftChild = new Node();
            node.RightChild = new Node();

            //set the parents
            node.LeftChild.Parent = node;
            node.RightChild.Parent = node;

            //set the neighbots
            node.LeftChild.RightNeighbor = node.RightChild;
            node.RightChild.LeftNeighbor = node.LeftChild;

            node.RightChild.last = true;

            //set values


            //set data
            if (node.LeftNeighbor != null)
            {
                node.LeftChild.Data = node.Data + node.LeftNeighbor.Data;
            }
            else
            {
                node.LeftChild.Data = node.Data;
            }
            if (node.RightNeighbor != null)
            {
                node.RightChild.Data = node.Data + node.RightNeighbor.Data;
            }
            else
            {
                node.RightChild.Data = node.Data;
            }

            //move on to the next level
            if(level < levels)
            {
                CreateTree(node.LeftChild, level + 1);
                CreateTree(node.RightChild, level + 1);
            }

     
        }

        public void SetNeighbors(Node temp, int level)
        {
                if (temp.RightNeighbor == null && temp.Parent != null && temp.Parent.RightNeighbor != null)
                {
                    Node tempNeighbor = rootNode.RightChild;
                    for (int j = 0; j < level - 3; j++)
                    {
                        tempNeighbor = tempNeighbor.LeftChild;
                    }
                    temp.RightNeighbor = tempNeighbor;
                }
                if (temp.LeftNeighbor == null && temp.Parent != null && temp.Parent.LeftNeighbor != null)
                {
                    Node tempNeighbor = rootNode.LeftChild;
                    for (int j = 0; j < level - 3; j++)
                    {
                        tempNeighbor = tempNeighbor.RightChild;
                    }
                    temp.LeftNeighbor = tempNeighbor;
                }

                //set data
                if (temp.LeftNeighbor != null)
                {
                    temp.LeftChild.Data = temp.Data + temp.LeftNeighbor.Data;
                }
                else
                {
                    temp.LeftChild.Data = temp.Data;
                }
                if (temp.RightNeighbor != null)
                {
                    temp.RightChild.Data = temp.Data + temp.RightNeighbor.Data;
                }
                else
                {
                    temp.RightChild.Data = temp.Data;
                }

                if (level < levels)
                {
                    SetNeighbors(temp.RightChild, level + 1);
                    SetNeighbors(temp.LeftChild, level + 1);
                }
        }




    }
}
