/*
 * File Name: Problem139.cs
* Name: Noah Grayem
* email:  grayemnm@mail.uc.edu
* Assignment Number: Final Project
* Due Date:   04/29/25
* Course #/Section:   IS 3050 001
* Semester/Year:   Spring 2025
* Brief Description of the assignment: Collaborate using github to create a webpage with problems and solutions from leetcode.

* Brief Description of what this module does: Build experience using github and improve communication and collaboration within teams.
* Citations: https://leetcode.com/problems/longest-valid-parentheses/

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