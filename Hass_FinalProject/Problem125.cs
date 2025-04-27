// Leet Code Problem #123
/* # File Name : Problem125.cs
# Student Name: Kolton Kohler
# email:  kohlerko@mail.uc.edu
# Assignment Number: Final Project  
# Due Date:   04/29/25
# Course #/Section:   IS3050 001
# Semester/Year:   Spring 2025
# Brief Description of the assignment: 
    Found a problem from LeetCode and used AI to code the solution
# Brief Description of what this module does. 
    Displays the best time to buy/sell stocks with two test cases
# Citations:
    https://chatgpt.com/c/6807b974-d978-8000-95ba-4c07d7da8b48
# Anything else that's relevant:
    https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii/description/
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hass_FinalProject
{
    public class Problem125
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0) return 0;
            int buy1 = int.MinValue, sell1 = 0, buy2 = int.MinValue, sell2 = 0;
            foreach (int p in prices)
            {
                buy1 = Math.Max(buy1, -p);
                sell1 = Math.Max(sell1, buy1 + p);
                buy2 = Math.Max(buy2, sell1 - p);
                sell2 = Math.Max(sell2, buy2 + p);
            }
            return sell2;
        }

        public string Solve()
        {
            var cases = new[]
            {
                new[]{3,3,5,0,0,3,1,4},
                new[]{7,6,4,3,1}
            };
            var results = cases.Select(c => MaxProfit(c));
            return string.Join(" | ", results.Select((r, i) => $"Test {i + 1}: {r}"));
        }
    }
}