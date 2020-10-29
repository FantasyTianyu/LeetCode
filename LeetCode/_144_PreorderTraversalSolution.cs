using System;
using System.Collections.Generic;

namespace LeetCode
{

    public class _144_PreorderTraversalSolution
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public _144_PreorderTraversalSolution()
        {
        }

        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> retList = new List<int>();
            if (root == null)
            {
                return retList;
            }

            TreeNode curNode = root;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (stack.Count != 0 || curNode != null)
            {
                while (curNode != null)
                {
                    retList.Add(curNode.val);
                    stack.Push(curNode);
                    curNode = curNode.left;
                }
                curNode = stack.Pop();
                curNode = curNode.right;
            }
            return retList;
        }
    }
}
