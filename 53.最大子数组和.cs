/*
 * @lc app=leetcode.cn id=53 lang=csharp
 *
 * [53] 最大子数组和
 *
 * https://leetcode-cn.com/problems/maximum-subarray/description/
 *
 * algorithms
 * Easy (55.21%)
 * Likes:    4355
 * Dislikes: 0
 * Total Accepted:    852K
 * Total Submissions: 1.5M
 * Testcase Example:  '[-2,1,-3,4,-1,2,1,-5,4]'
 *
 * 给你一个整数数组 nums ，请你找出一个具有最大和的连续子数组（子数组最少包含一个元素），返回其最大和。
 * 
 * 子数组 是数组中的一个连续部分。
 * 
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入：nums = [-2,1,-3,4,-1,2,1,-5,4]
 * 输出：6
 * 解释：连续子数组 [4,-1,2,1] 的和最大，为 6 。
 * 
 * 
 * 示例 2：
 * 
 * 
 * 输入：nums = [1]
 * 输出：1
 * 
 * 
 * 示例 3：
 * 
 * 
 * 输入：nums = [5,4,-1,7,8]
 * 输出：23
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 1 <= nums.length <= 10^5
 * -10^4 <= nums[i] <= 10^4
 * 
 * 
 * 
 * 
 * 进阶：如果你已经实现复杂度为 O(n) 的解法，尝试使用更为精妙的 分治法 求解。
 * 
 */

// @lc code=start
public class Solution
{
    // DPv1, use DP array
    // public int MaxSubArray(int[] nums)
    // {
    //     int[] dp = new int[nums.Length];
    //     dp[0] = nums[0];
    //     int result = dp[0];
    //     for (int i = 1; i < nums.Length; i++)
    //     {
    //         dp[i] = Math.Max(dp[i - 1] + nums[i], nums[i]);
    //         if (dp[i] > result) result = dp[i];
    //     }
    //     return result;
    // }

    // DPv2, without dp array
    public int MaxSubArray(int[] nums)
    {
        int prev = nums[0];
        int result = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            prev = Math.Max(prev + nums[i], nums[i]);
            if (prev > result) result = prev;
        }
        return result;
    }
}
// @lc code=end

