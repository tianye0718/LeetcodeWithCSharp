/*
 * @lc app=leetcode id=70 lang=csharp
 *
 * [70] Climbing Stairs
 *
 * https://leetcode.com/problems/climbing-stairs/description/
 *
 * algorithms
 * Easy (50.33%)
 * Likes:    9827
 * Dislikes: 304
 * Total Accepted:    1.3M
 * Total Submissions: 2.6M
 * Testcase Example:  '2'
 *
 * You are climbing a staircase. It takes n steps to reach the top.
 * 
 * Each time you can either climb 1 or 2 steps. In how many distinct ways can
 * you climb to the top?
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: n = 2
 * Output: 2
 * Explanation: There are two ways to climb to the top.
 * 1. 1 step + 1 step
 * 2. 2 steps
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: n = 3
 * Output: 3
 * Explanation: There are three ways to climb to the top.
 * 1. 1 step + 1 step + 1 step
 * 2. 1 step + 2 steps
 * 3. 2 steps + 1 step
 * 
 * 
 * 
 * Constraints:
 * 
 * 
 * 1 <= n <= 45
 * 
 * 
 */

// @lc code=start
public class Solution {
    // // Use recursive but with hashmap to save
    // // the result of previous steps
    // Dictionary<int, int> results = new Dictionary<int, int>();
    // public int ClimbStairs(int n) {
    //     if (n == 1) return 1;
    //     if (n == 2) return 2;
    //     if (results.ContainsKey(n)) {
    //         return results[n];
    //     } else
    //     {
    //         int result = ClimbStairs(n-2) + ClimbStairs(n-1);
    //         results.Add(n, result);
    //         return result;
    //     }
    // }

    // Use FOR loop
    public int ClimbStairs(int n) {
        if (n == 1) return 1;
        if (n == 2) return 2;

        int result = 0;
        int pre = 2;
        int prePre = 1;
        for (int i = 3; i <= n; i++)        {
            result = prePre + pre;
            prePre = pre;
            pre = result;
        }
        return result;
    }
}
// @lc code=end

