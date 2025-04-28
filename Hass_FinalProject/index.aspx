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
    chatpgt.com
    https://leetcode.com/
# Anything Else Important: 
--%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Hass_FinalProject.index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hass Final Project</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.5/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-SgOJa3DmI69IUzQ2PVdRZhwQ+dy64/BUtbMJw1MZ8t5HZApcHrRKUc4W0kG879m7" crossorigin="anonymous">
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <div class="container text-center mt-5">
            <h1 class="text-primary">Hass Final Project – LeetCode</h1>
            <br />
            <p>
                <strong class="text-primary">Team Members:</strong>
                <span class="text-dark">Bidhya Sangroula, Alex Jarvis, Noah Grayem, Kolton Kohler</span>
            </p>
            <br />

            <!-- Problem Buttons -->
            <div class="mb-4">
                <asp:Button ID="btnClear" runat="server" CssClass="btn btn-danger m-2" Text="Clear Solution" OnClick="btnClear_Click" />
                <asp:Button ID="btnProblem125" runat="server" CssClass="btn btn-primary m-2" Text="Run Problem 125" OnClick="btnProblem125_Click" />
                <asp:Button ID="btnProblem139" runat="server" CssClass="btn btn-success m-2" Text="Run Problem 139" OnClick="btnProblem139_Click" />
                <asp:Button ID="btnProblem254" runat="server" CssClass="btn btn-warning m-2" Text="Run Problem 254" OnClick="btnProblem254_Click" />
                <asp:Button ID="btnProblem454" runat="server" CssClass="btn btn-info m-2" Text="Run Problem 454" OnClick="btnProblem454_Click" />
            </div>

            <hr />

            <!-- Output Placeholders -->
            <asp:Panel ID="pnlOutput" runat="server" CssClass="card shadow p-4 bg-white" Visible="false">
                <h3 class="text-primary">
                    <asp:Label ID="lblTitle" runat="server" />
                </h3>
                <p class="text-dark">
                    <strong class="text-success">Description:</strong><br />
                    <asp:Label ID="lblPrompt" runat="server" />
                </p>
                <p class="text-dark">
                    <strong class="text-warning">Test Cases:</strong><br />
                    <asp:Label ID="lblTestCases" runat="server" />
                </p>
                <p class="text-dark">
                    <strong class="text-info">Results:</strong><br />
                    <asp:Label ID="lblResults" runat="server" />
                </p>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
