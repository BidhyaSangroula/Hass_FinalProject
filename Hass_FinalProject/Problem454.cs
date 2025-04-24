/*
# File Name : Problem454.cs
# Student Name: Bidhya Sangroula
# email: sangroba@mail.uc.edu
# Assignment Number: Assignment 09
# Due Date:  04/29/2025
# Course #/Section: IS 3050 Section 001
# Semester/Year: Spring/2025
# Brief Description of the assignment:
    
# Brief Description of what this module does:
    
# Citations:
    chatgpt.com
# Anything else that's relevant:
    https://leetcode.com/problems/valid-number/description/
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hass_FinalProject
{
    public class Problem454
    {
        public bool IsNumber(string s)
        {
            s = s.Trim();
            bool seenDigit = false, seenDot = false, seenExp = false, digitAfterExp = true;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (char.IsDigit(c)) { seenDigit = true; if (seenExp) digitAfterExp = true; }
                else if (c == '+' || c == '-')
                {
                    if (i > 0 && !(s[i - 1] == 'e' || s[i - 1] == 'E')) return false;
                }
                else if (c == '.')
                {
                    if (seenDot || seenExp) return false; seenDot = true;
                }
                else if (c == 'e' || c == 'E')
                {
                    if (seenExp || !seenDigit) return false;
                    seenExp = true; digitAfterExp = false;
                }
                else return false;
            }
            return seenDigit && digitAfterExp;
        }

        public string Solve()
        {
            var inputs = new[] { "2.3e10", " -90e3   " };
            var results = inputs.Select(IsNumber);
            return string.Join(" | ", results.Select((b, i) => $"Test {i + 1}: {b}"));
        }
    }
}