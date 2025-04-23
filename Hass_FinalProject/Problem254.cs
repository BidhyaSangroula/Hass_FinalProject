/*
 Alex Jarvis
https://leetcode.com/problems/shortest-palindrome/
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hass_FinalProject
{
    public class Problem254
    {
        public string ShortestPalindrome(string s)
        {
            int n = s.Length, i = 0;
            for (int j = n - 1; j >= 0; j--)
                if (s[i] == s[j]) i++;
            if (i == n) return s;
            string suffix = s.Substring(i);
            return new string(suffix.Reverse().ToArray()) + s;
        }

        public string Solve()
        {
            var inputs = new[] { "aacecaaa", "abcd" };
            var outputs = inputs.Select(ShortestPalindrome);
            return string.Join(" | ", outputs.Select((o, i) => $"Test {i + 1}: \"{o}\""));
        }
    }
}