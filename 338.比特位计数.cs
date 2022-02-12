/*
 * @lc app=leetcode.cn id=338 lang=csharp
 *
 * [338] 比特位计数
 *
 * https://leetcode-cn.com/problems/counting-bits/description/
 *
 * algorithms
 * Easy (78.68%)
 * Likes:    887
 * Dislikes: 0
 * Total Accepted:    182.8K
 * Total Submissions: 232.2K
 * Testcase Example:  '2'
 *
 * 给你一个整数 n ，对于 0 <= i <= n 中的每个 i ，计算其二进制表示中 1 的个数 ，返回一个长度为 n + 1 的数组 ans
 * 作为答案。
 * 
 * 
 * 
 * 
 * 
 * 示例 1：
 * 
 * 
 * 输入：n = 2
 * 输出：[0,1,1]
 * 解释：
 * 0 --> 0
 * 1 --> 1
 * 2 --> 10
 * 
 * 
 * 示例 2：
 * 
 * 
 * 输入：n = 5
 * 输出：[0,1,1,2,1,2]
 * 解释：
 * 0 --> 0
 * 1 --> 1
 * 2 --> 10
 * 3 --> 11
 * 4 --> 100
 * 5 --> 101
 * 
 * 
 * 
 * 
 * 提示：
 * 
 * 
 * 0 <= n <= 10^5
 * 
 * 
 * 
 * 
 * 进阶：
 * 
 * 
 * 很容易就能实现时间复杂度为 O(n log n) 的解决方案，你可以在线性时间复杂度 O(n) 内用一趟扫描解决此问题吗？
 * 你能不使用任何内置函数解决此问题吗？（如，C++ 中的 __builtin_popcount ）
 * 
 * 
 * 
 * 
 */

// @lc code=start
public class Solution
{
    // use x & (x-1) to remove last 1
    // public int[] CountBits(int n)
    // {
    //     int[] bits = new int[n + 1];
    //     for (int i = 1; i <= n; i++)
    //     {
    //         bits[i] = bits[i & (i - 1)] + 1;
    //     }
    //     return bits;
    // }

    // use odd and even
    public int[] CountBits(int n)
    {
        int[] bits = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            bits[i] = (i & 1) == 1 ? bits[i - 1] + 1 : bits[i >> 1];
        }
        return bits;
    }
}
// @lc code=end

