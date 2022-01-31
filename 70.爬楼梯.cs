/*
 * @lc app=leetcode.cn id=70 lang=csharp
 *
 * [70] 爬楼梯
 *
 * https://leetcode-cn.com/problems/climbing-stairs/description/
 *
 * algorithms
 * Easy (53.31%)
 * Likes:    2122
 * Dislikes: 0
 * Total Accepted:    667.5K
 * Total Submissions: 1.3M
 * Testcase Example:  '2'
 *
 * 假设你正在爬楼梯。需要 n 阶你才能到达楼顶。
 * 
 * 每次你可以爬 1 或 2 个台阶。你有多少种不同的方法可以爬到楼顶呢？
 * 
 * 注意：给定 n 是一个正整数。
 * 
 * 示例 1：
 * 
 * 输入： 2
 * 输出： 2
 * 解释： 有两种方法可以爬到楼顶。
 * 1.  1 阶 + 1 阶
 * 2.  2 阶
 * 
 * 示例 2：
 * 
 * 输入： 3
 * 输出： 3
 * 解释： 有三种方法可以爬到楼顶。
 * 1.  1 阶 + 1 阶 + 1 阶
 * 2.  1 阶 + 2 阶
 * 3.  2 阶 + 1 阶
 * 
 * 
 */

// @lc code=start
public class Solution {
    // Use recursive with haspmap to store result from previous steps
    // Dictionary<int, int> resultsForEachStep = new Dictionary<int, int>();
    // public int ClimbStairs(int n) {
    //     if (n == 1) return 1;
    //     if (n == 2) return 2;
    //     if (resultsForEachStep.ContainsKey(n)) {
    //         return resultsForEachStep[n];
    //     } else {
    //         int result = ClimbStairs(n-2) + ClimbStairs(n-1);
    //         resultsForEachStep.Add(n, result);
    //         return result;
    //     }
    // }
    public int ClimbStairs(int n) {
        if (n == 1) return 1;
        if (n == 2) return 2;
        
        int result = 0; // final result
        int pre = 2;    // result from pre-step
        int prePre = 1; // result from pre-pre-step

        for (int i = 3; i <= n; i++)
        {
            result = prePre + pre;
            prePre = pre;
            pre = result;
        }
        return result;
    }
}
// @lc code=end

