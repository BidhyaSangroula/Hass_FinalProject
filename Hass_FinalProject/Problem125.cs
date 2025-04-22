// Kolton Kohler - Problem 123
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hass_FinalProject
{
    public class Problem125
    {
        static void Main(string[] args)
        {
            // Example input
            int[] prices = { 3, 3, 5, 0, 0, 3, 1, 4 };

            int maxProfit = MaxProfit(prices);
            Console.WriteLine("Maximum Profit with at most two transactions: " + maxProfit);
        }

        static int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;

            int buy1 = int.MinValue, sell1 = 0;
            int buy2 = int.MinValue, sell2 = 0;

            foreach (int price in prices)
            {
                buy1 = Math.Max(buy1, -price);
                sell1 = Math.Max(sell1, buy1 + price);
                buy2 = Math.Max(buy2, sell1 - price);
                sell2 = Math.Max(sell2, buy2 + price);
            }

            return sell2;
        }
    }
}