using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_linked_list
{
    internal class TreeNode
    {
        public int Data;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int data)
        {
            Data = data;
            Left = Right = null;
        }
    }
}
