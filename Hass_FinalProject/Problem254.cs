using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hass_FinalProject
{
    public class Problem254
    {
        public class Solution
        {
            public string ShortestPalindrome(string s)
            {
                int n = s.Length;
                if (n <= 1)
                {
                    return s;
                }

                int i = 0;
                for (int j = n - 1; j >= 0; j--)
                {
                    if (s[i] == s[j])
                    {
                        i++;
                    }
                }

                if (i == n)
                {
                    return s;
                }

                string suffix = s.Substring(i);
                char[] reversedSuffixChars = suffix.Reverse().ToArray();
                string reversedSuffix = new string(reversedSuffixChars);
                return reversedSuffix + s;
            }
        }
    }
}