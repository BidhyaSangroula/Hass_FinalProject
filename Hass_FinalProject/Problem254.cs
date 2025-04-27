/*
* File Name: Problem254.cs
* Name: Alex Jarvis
* email: jarvisaw@mail.uc.edu
* Assignment Number: Final Project
* Due Date: 4/29/25
* Course #/Section: IS3050 001
* Semester/Year: Spring / 2025
* Brief Description of the assignment: 
    This assignment had us solve four hard problems and configure an index web form.
* Brief Description of what this module does. 
    This module proved our collaboration skills and tested our skills within C#, CSS, etc.
* Citations: 
   https://gemini.google.com/app/b02eadcf3f2ecad5
* Anything else that's relevant: 
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