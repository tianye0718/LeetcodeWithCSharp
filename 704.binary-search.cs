/*
 * @lc app=leetcode id=704 lang=csharp
 *
 * [704] Binary Search
 *
 * https://leetcode.com/problems/binary-search/description/
 *
 * algorithms
 * Easy (49.62%)
 * Likes:    348
 * Dislikes: 34
 * Total Accepted:    76.6K
 * Total Submissions: 154.4K
 * Testcase Example:  '[-1,0,3,5,9,12]\n9'
 *
 * Given a sorted (in ascending order) integer array nums of n elements and a
 * target value, write a function to search target in nums. If target exists,
 * then return its index, otherwise return -1.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: nums = [-1,0,3,5,9,12], target = 9
 * Output: 4
 * Explanation: 9 exists in nums and its index is 4
 * 
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: nums = [-1,0,3,5,9,12], target = 2
 * Output: -1
 * Explanation: 2 does not exist in nums so return -1
 * 
 * 
 * 
 * 
 * Note:
 * 
 * 
 * You may assume that all elements in nums are unique.
 * n will be in the range [1, 10000].
 * The value of each element in nums will be in the range [-9999, 9999].
 * 
 * 
 */

// @lc code=start
public class Solution {
    public int Search(int[] nums, int target) {
        int min = 0;
        int max = nums.Length - 1;
        int guess;
        while (min <= max)
        {
            guess = (min + max) / 2;
            if (nums[guess] == target) {
                return guess;
            } else if (nums[guess] > target)
            {
                max = guess - 1;
            } else {
                min = guess + 1;
            }
        }
        return -1;
    }
}
// @lc code=end

