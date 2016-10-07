using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNodes
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            tree.AddChildrenToNode(1, 2, 3);
            tree.AddChildrenToNode(2, 4, 5);
            tree.AddChildrenToNode(3, 6, -1);
            tree.AddChildrenToNode(4, -1, 7);
            tree.AddChildrenToNode(5, 8, 9);
            tree.AddChildrenToNode(6, 10, 11);
            tree.AddChildrenToNode(7, 12, 13);
            tree.AddChildrenToNode(8, -1, 14);
            tree.AddChildrenToNode(9, -1, -1);
            tree.AddChildrenToNode(10, 15, -1);
            tree.AddChildrenToNode(11, 16, 17);
            tree.AddChildrenToNode(12, -1, -1);
            tree.AddChildrenToNode(13, -1, -1);
            tree.AddChildrenToNode(14, -1, -1);
            tree.AddChildrenToNode(15, -1, -1);
            tree.AddChildrenToNode(16, -1, -1);
            tree.AddChildrenToNode(17, -1, -1);

            tree.InorderTraversal(tree.Root);
            Console.WriteLine("\n" + tree.TreeLevel);
            tree.SwapAtLevel(tree.Root, 2);
            tree.InorderTraversal(tree.Root);
            tree.SwapAtLevel(tree.Root, 4);
            Console.WriteLine();
            tree.InorderTraversal(tree.Root);

            Console.ReadLine();

        }
    }
}
