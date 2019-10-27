/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 *
 * https://leetcode.com/problems/search-insert-position/description/
 *
 * algorithms
 * Easy (41.24%)
 * Likes:    1596
 * Dislikes: 207
 * Total Accepted:    471.3K
 * Total Submissions: 1.1M
 * Testcase Example:  '[1,3,5,6]\n5'
 *
 * Given a sorted array and a target value, return the index if the target is
 * found. If not, return the index where it would be if it were inserted in
 * order.
 * 
 * You may assume no duplicates in the array.
 * 
 * Example 1:
 * 
 * 
 * Input: [1,3,5,6], 5
 * Output: 2
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: [1,3,5,6], 2
 * Output: 1
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: [1,3,5,6], 7
 * Output: 4
 * 
 * 
 * Example 4:
 * 
 * 
 * Input: [1,3,5,6], 0
 * Output: 0
 * 
 * 
 */

// @lc code=start
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int min = 0;
        int max = nums.Length - 1;
        while (min <= max)
        {
            if (min == max || min == max - 1){
                if (target <= nums[min]) return min;
                if (target == nums[max]) return max;
                if (target > nums[max]) return max + 1;
            }

            if (nums[(min + max) / 2] == target) {
                return (min + max) / 2;
            } else if (nums[(min + max) / 2] > target)
            {
                max = (min + max) / 2 - 1;
            } else {
                min = (min + max) / 2 + 1;
            }
        }
        return -1;
    }
}
// @lc code=end

