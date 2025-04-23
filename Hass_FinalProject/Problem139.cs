/*
 Noah Grayem
https://leetcode.com/problems/longest-valid-parentheses/
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hass_FinalProject
{
    public class Problem139
    {
        public int LongestValidParentheses(string s)
        {
            int maxLength = 0, left = 0, right = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(') left++; else right++;
                if (left == right) maxLength = Math.Max(maxLength, 2 * right);
                else if (right > left) left = right = 0;
            }
            left = right = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '(') left++; else right++;
                if (left == right) maxLength = Math.Max(maxLength, 2 * left);
                else if (left > right) left = right = 0;
            }
            return maxLength;
        }

        public string Solve()
        {
            // two sample test‑cases
            var inputs = new[] { "(()())", ")()())" };
            var results = inputs.Select(s => LongestValidParentheses(s));
            return string.Join(" | ", results.Select((r, i) => $"Test {i + 1}: {r}"));
        }
    }
}