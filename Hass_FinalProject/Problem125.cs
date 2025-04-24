/* Kolton Kohler - Problem 123
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