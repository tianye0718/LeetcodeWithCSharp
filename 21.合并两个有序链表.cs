/*
 * @lc app=leetcode.cn id=21 lang=csharp
 *
 * [21] 合并两个有序链表
 *
 * https://leetcode-cn.com/problems/merge-two-sorted-lists/description/
 *
 * algorithms
 * Easy (66.67%)
 * Likes:    2165
 * Dislikes: 0
 * Total Accepted:    840.7K
 * Total Submissions: 1.3M
 * Testcase Example:  '[1,2,4]\n[1,3,4]'
 *
 * 将两个升序链表合并为一个新的 升序 链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 
 * 
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入：l1 = [1,2,4], l2 = [1,3,4]
 * 输出：[1,1,2,3,4,4]
 * 
 * 
 * 示例 2：
 * 
 * 
 * 输入：l1 = [], l2 = []
 * 输出：[]
 * 
 * 
 * 示例 3：
 * 
 * 
 * 输入：l1 = [], l2 = [0]
 * 输出：[0]
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 两个链表的节点数目范围是 [0, 50]
 * -100 
 * l1 和 l2 均按 非递减顺序 排列
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
    // Method 1: double index
    // public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    // {
    //     if (list1 == null) return list2;
    //     if (list2 == null) return list1;
    //     ListNode resultNode = new ListNode();
    //     ListNode p = resultNode;
    //     while (list1 != null && list2 != null)
    //     {
    //         if (list1.val < list2.val)
    //         {
    //             p.next = list1;
    //             list1 = list1.next;
    //         }
    //         else
    //         {
    //             p.next = list2;
    //             list2 = list2.next;
    //         }
    //         p = p.next;
    //     }
    //     if (list1 == null) p.next = list2;
    //     if (list2 == null) p.next = list1;
    //     return resultNode.next;
    // }

    // Method 2: Recrusive
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;
        if (list1.val < list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }
        list2.next = MergeTwoLists(list1, list2.next);
        return list2;
    }
}
// @lc code=end

