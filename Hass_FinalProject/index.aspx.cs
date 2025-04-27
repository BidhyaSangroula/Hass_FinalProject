/*
# File Name : index.aspx.cs
# Student Name: Bidhya Sangroula, Alex Jarvis, Noah Grayem, Kolton Kohler
# email: sangroba@mail.uc.edu, jarvisaw@mail.uc.edu, grayemnm@mail.uc.edu, kohlerko@mail.uc.edu
# Assignment Number: Final Project
# Due Date: 4/29/2025
# Course #/Section: IS3050-001
# Semester/Year: Spring 2025
# Brief Description of the assignment: 
     Implement and demonstrate solutions to selected LeetCode problems using C# in a web project. 
# Brief Description of what this module does: 
    This module runs problem solutions when buttons are clicked and shows the results on the webpage.
# Citations: 
# chatpgt.com
# https://leetcode.com/
# Anything Else Important: 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hass_FinalProject
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblTitle.Text = "";
                lblPrompt.Text = "";
                lblTestCases.Text = "";
                lblResults.Text = "";
                pnlOutput.Visible = false;  // Hide output initially
            }
        }

        // Helper to display a problem
        protected void ShowProblem(string title, string prompt, string testCases, params string[] results)
        {
            pnlOutput.Visible = true; // Show output panel when displaying a problem
            lblTitle.Text = title;
            lblPrompt.Text = prompt;
            lblTestCases.Text = testCases;
            lblResults.Text = string.Join("<br/>", results);
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            pnlOutput.Visible = false; // Hide output panel when clearing
            lblTitle.Text = "";
            lblPrompt.Text = "";
            lblTestCases.Text = "";
            lblResults.Text = "";
        }

        // Button handler for Problem 125
        protected void btnProblem125_Click(object sender, EventArgs e)
        {
            var p = new Problem125();
            var cases = new[] {
                new [] {3,3,5,0,0,3,1,4},
                new [] {7,6,4,3,1}
            };
            var outputs = cases.Select(arr => p.MaxProfit(arr)).ToArray();
            ShowProblem(
                "Problem 125 – Best Time to Buy & Sell Stock III",
                "Find the maximum profit you can achieve. You may complete at most two transactions.",
                $"Test Case 1: {{ {string.Join(",", cases[0])} }} | Test Case 2: {{ {string.Join(",", cases[1])} }}",
                $"Test 1: {outputs[0]}",
                $"Test 2: {outputs[1]}"
            );
        }

        protected void btnProblem139_Click(object sender, EventArgs e)
        {
            var p = new Problem139();
            string[] inputs = { "(()())", ")()())" };
            var outputs = inputs.Select(s => p.LongestValidParentheses(s)).ToArray();
            ShowProblem(
                "Problem 139 – Longest Valid Parentheses",
                "Given a string containing just the characters '(' and ')', return the length of the longest valid (well-formed) parentheses substring.",
                $"Test Case 1: \"{inputs[0]}\" | Test Case 2: \"{inputs[1]}\"",
                $"Test 1: {outputs[0]}",
                $"Test 2: {outputs[1]}"
            );
        }

        protected void btnProblem254_Click(object sender, EventArgs e)
        {
            var p = new Problem254();
            string[] inputs = { "aacecaaa", "abcd" };
            var outputs = inputs.Select(s => p.ShortestPalindrome(s)).ToArray();
            ShowProblem(
                "Problem 254 – Shortest Palindrome",
                "Return the shortest palindrome you can find by performing this transformation.",
                $"Test Case 1: \"{inputs[0]}\" | Test Case 2: \"{inputs[1]}\"",
                $"Test 1: \"{outputs[0]}\"",
                $"Test 2: \"{outputs[1]}\""
            );
        }

        protected void btnProblem454_Click(object sender, EventArgs e)
        {
            var p = new Problem454();
            string[] inputs = { "2.3e10", " -90e3   " };
            var outputs = inputs.Select(s => p.IsNumber(s)).ToArray();
            ShowProblem(
                "Problem 454 – Valid Number",
                "Given a string s, return whether s is a valid number.",
                $"Test Case 1: \"{inputs[0]}\" | Test Case 2: \"{inputs[1]}\"",
                $"Test 1: {outputs[0]}",
                $"Test 2: {outputs[1]}"
            );
        }
    }
}