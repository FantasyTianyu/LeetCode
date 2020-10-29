using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _129_SumNumbers
    {
        public _129_SumNumbers()
        {
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public int SumNumbers(TreeNode root)
        {
            return GetNodeSum(root, 0);
        }

        private int GetNodeSum(TreeNode node, int preSum)
        {
            if (node == null)
            {
                return 0;
            }
            int sum = node.val + preSum * 10;
            if (node.left == null && node.right == null)
            {
                return sum;
            }
            else
            {
                return GetNodeSum(node.left, sum) + GetNodeSum(node.right, sum);
            }
        }
    }
}
