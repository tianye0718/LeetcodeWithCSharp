/*
 * @lc app=leetcode.cn id=145 lang=csharp
 *
 * [145] 二叉树的后序遍历
 *
 * https://leetcode-cn.com/problems/binary-tree-postorder-traversal/description/
 *
 * algorithms
 * Easy (75.31%)
 * Likes:    751
 * Dislikes: 0
 * Total Accepted:    360.2K
 * Total Submissions: 477.9K
 * Testcase Example:  '[1,null,2,3]'
 *
 * 给你一棵二叉树的根节点 root ，返回其节点值的 后序遍历 。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入：root = [1,null,2,3]
 * 输出：[3,2,1]
 * 
 * 
 * 示例 2：
 * 
 * 
 * 输入：root = []
 * 输出：[]
 * 
 * 
 * 示例 3：
 * 
 * 
 * 输入：root = [1]
 * 输出：[1]
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 树中节点的数目在范围 [0, 100] 内
 * -100 <= Node.val <= 100
 * 
 * 
 * 
 * 
 * 进阶：递归算法很简单，你可以通过迭代算法完成吗？
 * 
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    // With Recrusive
    // public IList<int> PostorderTraversal(TreeNode root)
    // {
    //     List<int> res = new List<int>();
    //     AccessTree(root, res);
    //     return res;
    // }
    // private void AccessTree(TreeNode root, List<int> res)
    // {
    //     if (root == null) return;
    //     AccessTree(root.left, res);
    //     AccessTree(root.right, res);
    //     res.Add(root.val);
    // }

    // With Loop
    public IList<int> PostorderTraversal(TreeNode root)
    {
        List<int> res = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode prevNode = null;
        while (root != null || stack.Count != 0)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }

            root = stack.Pop();
            if (root.right == null || root.right == prevNode)
            {
                res.Add(root.val);
                prevNode = root;
                root = null;
            }
            else
            {
                stack.Push(root);
                root = root.right;
            }
        }
        return res;
    }
}
// @lc code=end

