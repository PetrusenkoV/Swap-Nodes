using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNodes
{
    public class BinaryTree
    {        
        public int TreeLevel { get; set; } // used for hackerrank
        public MyBinaryTreeNode Root { get; set; }

        public BinaryTree()
        {
            Root = new MyBinaryTreeNode(1, 1);
            TreeLevel = 1;
        }       

        public MyBinaryTreeNode FindByValue(MyBinaryTreeNode current, MyBinaryTreeNode prev, int value)
        {
            MyBinaryTreeNode result = current;

            if (current == null || current.Value > value)
            {
                return null;
            }
            if (current.Value == value)
            {
                return result;
            }

            if (current.Value < value)
            {
                result = FindByValue(current.Left, current, value);

                if (result == null)
                {
                    result = FindByValue(current.Right, current, value);
                }
            }

            return result;
        }


        public void AddChildrenToNode(int value, int left, int right)
        {
            MyBinaryTreeNode node = FindByValue(Root, Root, value);

            node.Left = AddElement(node.Left, node, left);
            node.Right = AddElement(node.Right, node, right);            
        }
        public MyBinaryTreeNode AddElement(MyBinaryTreeNode node, MyBinaryTreeNode current, int value)
        {
            if (value == -1)
            {
                node = null;
            }
            else
            {
                node = new MyBinaryTreeNode(value, current.Level + 1);

                if (TreeLevel == node.Level - 1)
                {
                    TreeLevel++;
                }
            }

            return node;
        }
        public void InorderTraversal(MyBinaryTreeNode node)
        {
            if (node.Left != null)
            {
                InorderTraversal(node.Left);
            }

            Console.Write(node.Value + " ");

            if (node.Right != null)
            {
                InorderTraversal(node.Right);
            }
        }

        public void SwapNodes(MyBinaryTreeNode node)
        {
            MyBinaryTreeNode temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
        }

        public void SwapAtLevel(MyBinaryTreeNode current, int lvl)
        {
            if (current == null)
            {
                return;
            }

            if (current.Level == lvl)
            {
                SwapNodes(current);
            }
            else
            {
                SwapAtLevel(current.Left, lvl);
                SwapAtLevel(current.Right, lvl);
            }

        }
    }
}
