/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 *
 * https://leetcode.com/problems/median-of-two-sorted-arrays/description/
 *
 * algorithms
 * Hard (27.52%)
 * Likes:    5251
 * Dislikes: 764
 * Total Accepted:    530.1K
 * Total Submissions: 1.9M
 * Testcase Example:  '[1,3]\n[2]'
 *
 * There are two sorted arrays nums1 and nums2 of size m and n respectively.
 * 
 * Find the median of the two sorted arrays. The overall run time complexity
 * should be O(log (m+n)).
 * 
 * You may assume nums1 and nums2 cannot be both empty.
 * 
 * Example 1:
 * 
 * 
 * nums1 = [1, 3]
 * nums2 = [2]
 * 
 * The median is 2.0
 * 
 * 
 * Example 2:
 * 
 * 
 * nums1 = [1, 2]
 * nums2 = [3, 4]
 * 
 * The median is (2 + 3)/2 = 2.5
 * 
 * 
 */

// @lc code=start
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if ((nums1.Length + nums2.Length) % 2 == 1)
            return FindKthSmallest(nums1, 0, nums2, 0, (nums1.Length+nums2.Length)/2+1);
        else
            return (FindKthSmallest(nums1, 0, nums2, 0, (nums1.Length+nums2.Length)/2) + 
                FindKthSmallest(nums1, 0, nums2, 0, (nums1.Length+nums2.Length)/2 + 1)) / 2.0;
    }

    public int FindKthSmallest(int[] nums1, int left1, int[] nums2, int left2, int k){
        if (left1 >= nums1.Length) return nums2[left2 + k - 1];
        if (left2 >= nums2.Length) return nums1[left1 + k - 1];

        if (k == 1) return Math.Min(nums1[left1], nums2[left2]);

        int val1 = left1 + k/2 - 1 >= nums1.Length ? int.MaxValue : nums1[left1 + k/2 - 1];
        int val2 = left2 + k/2 - 1 >= nums2.Length ? int.MaxValue : nums2[left2 + k/2 - 1];

        if (val1 <= val2) return FindKthSmallest(nums1, left1 + k/2 - 1 + 1, nums2, left2, k - k/2);
        else return FindKthSmallest(nums1, left1, nums2, left2 + k/2 - 1 + 1, k - k/2);

    }
}
// @lc code=end

