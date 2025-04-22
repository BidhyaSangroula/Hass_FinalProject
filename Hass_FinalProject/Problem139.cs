﻿/*
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
       
            static int LongestValidParentheses(string s)
            {
                int maxLength = 0;
                int left = 0, right = 0;

                // Left to right scan
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(')
                        left++;
                    else
                        right++;

                    if (left == right)
                        maxLength = Math.Max(maxLength, 2 * right);
                    else if (right > left)
                        left = right = 0;
                }

                left = right = 0;

                // Right to left scan
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] == '(')
                        left++;
                    else
                        right++;

                    if (left == right)
                        maxLength = Math.Max(maxLength, 2 * left);
                    else if (left > right)
                        left = right = 0;
                }

                return maxLength;
            }
        }
    
}