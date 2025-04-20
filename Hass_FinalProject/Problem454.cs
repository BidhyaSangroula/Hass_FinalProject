/*
 Bidhya Sangroula
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
            bool seenDigit = false;
            bool seenDot = false;
            bool seenExp = false;
            bool digitAfterExp = true;

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (char.IsDigit(c))
                {
                    seenDigit = true;
                    if (seenExp) digitAfterExp = true;
                }
                else if (c == '+' || c == '-')
                {
                    // Sign can only appear at the beginning or right after an exponent
                    if (i != 0 && !(s[i - 1] == 'e' || s[i - 1] == 'E'))
                    {
                        return false;
                    }
                }
                else if (c == '.')
                {
                    if (seenDot || seenExp)
                    {
                        return false;
                    }
                    seenDot = true;
                }
                else if (c == 'e' || c == 'E')
                {
                    if (seenExp || !seenDigit)
                    {
                        return false;
                    }
                    seenExp = true;
                    digitAfterExp = false; // we need to see a digit after the exponent
                }
                else
                {
                    return false;
                }
            }

            return seenDigit && digitAfterExp;
        }
    }
}