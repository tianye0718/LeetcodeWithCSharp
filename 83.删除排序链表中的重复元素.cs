/*
 * @lc app=leetcode.cn id=83 lang=csharp
 *
 * [83] 删除排序链表中的重复元素
 *
 * https://leetcode-cn.com/problems/remove-duplicates-from-sorted-list/description/
 *
 * algorithms
 * Easy (53.75%)
 * Likes:    722
 * Dislikes: 0
 * Total Accepted:    365.8K
 * Total Submissions: 680.6K
 * Testcase Example:  '[1,1,2]'
 *
 * 给定一个已排序的链表的头 head ， 删除所有重复的元素，使每个元素只出现一次 。返回 已排序的链表 。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入：head = [1,1,2]
 * 输出：[1,2]
 * 
 * 
 * 示例 2：
 * 
 * 
 * 输入：head = [1,1,2,3,3]
 * 输出：[1,2,3]
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 链表中节点数目在范围 [0, 300] 内
 * -100 <= Node.val <= 100
 * 题目数据保证链表已经按升序 排列
 * 
 * 
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    // Method 1: cursor
    // public ListNode DeleteDuplicates(ListNode head)
    // {
    //     if (head == null || head.next == null) return head;
    //     ListNode currentNode = head;
    //     while (currentNode != null && currentNode.next != null)
    //     {
    //         if (currentNode.val == currentNode.next.val)
    //         {
    //             currentNode.next = currentNode.next.next;
    //         }
    //         else
    //         {
    //             currentNode = currentNode.next;
    //         }
    //     }
    //     return head;
    // }

    // Method 2: recursive
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null || head.next == null) return head;
        if (head.val == head.next.val)
        {
            head.next = head.next.next;
            return DeleteDuplicates(head);
        }
        else
        {
            head.next = DeleteDuplicates(head.next);
            return head;
        }
    }
}
// @lc code=end

