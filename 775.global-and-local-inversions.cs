/*
 * @lc app=leetcode id=775 lang=csharp
 *
 * [775] Global and Local Inversions
 *
 * https://leetcode.com/problems/global-and-local-inversions/description/
 *
 * algorithms
 * Medium (39.98%)
 * Likes:    241
 * Dislikes: 130
 * Total Accepted:    15.2K
 * Total Submissions: 38K
 * Testcase Example:  '[0]'
 *
 * We have some permutation A of [0, 1, ..., N - 1], where N is the length of
 * A.
 * 
 * The number of (global) inversions is the number of i < j with 0 <= i < j < N
 * and A[i] > A[j].
 * 
 * The number of local inversions is the number of i with 0 <= i < N and A[i] >
 * A[i+1].
 * 
 * Return true if and only if the number of global inversions is equal to the
 * number of local inversions.
 * 
 * Example 1:
 * 
 * 
 * Input: A = [1,0,2]
 * Output: true
 * Explanation: There is 1 global inversion, and 1 local inversion.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: A = [1,2,0]
 * Output: false
 * Explanation: There are 2 global inversions, and 1 local inversion.
 * 
 * 
 * Note:
 * 
 * 
 * A will be a permutation of [0, 1, ..., A.length - 1].
 * A will have length in range [1, 5000].
 * The time limit for this problem has been reduced.
 * 
 * 
 */

// @lc code=start
public class Solution {
    public bool IsIdealPermutation(int[] A) {
        var (sortedArray, globalInversion) = CountGlobalInversion(A);
        var localInversion = CountLocalInversion(A);

        return globalInversion == localInversion;
    }

    public int CountLocalInversion(int[] A){
        int localInversion = 0;
        for (int i = 0; i < A.Length - 1; i++)
        {
            if (A[i] > A[i+1]) localInversion++;
        }
        return localInversion;
    }

    public (int[], int) CountGlobalInversion(int[] A){
        if (A.Length == 1) return (A, 0);

        int[] firstHalfOfA = new int[A.Length/2];
        int[] secondHalfOfA = new int[A.Length - A.Length/2];
        Array.Copy(A, 0, firstHalfOfA, 0, firstHalfOfA.Length);
        Array.Copy(A, A.Length/2, secondHalfOfA, 0, secondHalfOfA.Length);
        var (B, x) = CountGlobalInversion(firstHalfOfA);
        var (C, y) = CountGlobalInversion(secondHalfOfA);

        var (D, z) = CountGlobalSplitInversion(B, C);

        return (D, x + y + z);
    }

    public (int[], int) CountGlobalSplitInversion(int[] B, int[] C){
        int[] D = new int[B.Length + C.Length];
        int i = 0;
        int j = 0;
        int splitInversion = 0;
        for (int n = 0; n < D.Length; n++)
        {
            if (i == B.Length) {
                Array.Copy(C, j, D, n, C.Length - j);
                break;
            }
            if (j == C.Length) {
                Array.Copy(B, i, D, n, B.Length - i);
                break;
            }
            if (B[i] < C[j]) {
                D[n] = B[i];
                i++;
            } else {
                D[n] = C[j];
                j++;
                splitInversion += B.Length - i;
            }
        }
        return (D, splitInversion);
    }
}
// @lc code=end

