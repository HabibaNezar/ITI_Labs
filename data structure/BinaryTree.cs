using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structure_linked_list
{
    internal class BinaryTree
    {
        public TreeNode Root;
        public void InOrder(TreeNode root) //Left => Root => Right
        {
            if (root == null)
                return;

            InOrder(root.Left);
            Console.Write(root.Data + " ");
            
        }
        public void PreOrder(TreeNode root) //Root => Left => Right
        {
            if (root == null)
                return;

            Console.Write(root.Data + " ");
            PreOrder(root.Left);
            PreOrder(root.Right);
        }

        public void PostOrder(TreeNode root) //Left => Right => Root
        {
            if (root == null)
                return;

            PostOrder(root.Left);
            PostOrder(root.Right);
            Console.Write(root.Data + " ");
        }

        public void InOrder()
        {
            InOrder(Root);
        }

        public void PreOrder()
        {
            PreOrder(Root);
        }

        public void PostOrder()
        {
            PostOrder(Root);
        }
    }
}
