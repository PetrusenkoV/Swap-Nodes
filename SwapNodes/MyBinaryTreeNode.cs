using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNodes
{
    public class MyBinaryTreeNode
    {
        public int Value { get; set; }
        public int Level { get; set; } // used for hackerrank
        public MyBinaryTreeNode Left;
        public MyBinaryTreeNode Right;

        public MyBinaryTreeNode(int value, int lvl)
        {
            Value = value;
            Level = lvl;
        }
    }
}
