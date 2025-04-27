﻿<%-- 
# File Name : index.aspx
# Student Name: Bidhya Sangroula, Alex Jarvis, Noah Grayem, Kolton Kohler
# email: sangroba@mail.uc.edu, jarvisaw@mail.uc.edu, grayemnm@mail.uc.edu, kohlerko@mail.uc.edu
# Assignment Number: Final Project
# Due Date: 4/29/2025
# Course #/Section: IS3050-001
# Semester/Year: Spring 2025
# Brief Description of the assignment: 
     Implement and demonstrate solutions to selected LeetCode problems using C# in a web project. 
# Brief Description of what this module does: 
     This page shows buttons to run different coding problems and displays the results nicely on the screen.
# Citations: 
# chatpgt.com
# https://leetcode.com/
# Anything Else Important: 
--%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Hass_FinalProject.index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hass Final Project</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.5/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-SgOJa3DmI69IUzQ2PVdRZhwQ+dy64/BUtbMJw1MZ8t5HZApcHrRKUc4W0kG879m7" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="text-center" style="margin-top: 50px">
            <h1>Hass Final Project – LeetCode </h1>
            <br />
            <p>Team Member: Bidhya Sangroula, Alex Jarvis, Noah Grayem, Kolton Kohler</p>
            <br /> 
            <!-- Problem Buttons -->
            <asp:Button ID="btnClear" runat="server" Text="Clear Solution" OnClick="btnClear_Click" />
            <asp:Button ID="btnProblem125" runat="server" Text="Run Problem 125" OnClick="btnProblem125_Click" />
            <asp:Button ID="btnProblem139" runat="server" Text="Run Problem 139" OnClick="btnProblem139_Click" />
            <asp:Button ID="btnProblem254" runat="server" Text="Run Problem 254" OnClick="btnProblem254_Click" />
            <asp:Button ID="btnProblem454" runat="server" Text="Run Problem 454" OnClick="btnProblem454_Click" />

            <hr />

            <!-- Output Placeholders -->
            <h3>
                <asp:Label ID="lblTitle" runat="server" />
            </h3>
            <asp:Panel ID="pnlOutput" runat="server" Visible="false">
                <h3>
                    <asp:Label ID="Label1" runat="server" />
                </h3>
                <p>
                    <strong>Description:</strong>
                    <asp:Label ID="lblPrompt" runat="server" />
                </p>
                <p>
                    <strong>Test Cases:</strong>
                    <asp:Label ID="lblTestCases" runat="server" />
                </p>
                <p>
                    <strong>Results:</strong>
                    <asp:Label ID="lblResults" runat="server" />
                </p>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
