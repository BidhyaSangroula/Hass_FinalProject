<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Hass_FinalProject.index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hass Final Project</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.5/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-SgOJa3DmI69IUzQ2PVdRZhwQ+dy64/BUtbMJw1MZ8t5HZApcHrRKUc4W0kG879m7" crossorigin="anonymous"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="text-center" style="margin-top: 50px">
            <h2>Hass Final Project – LeetCode </h2>

            <!-- Problem Buttons -->
            <asp:Button ID="btnProblem125" runat="server" Text="Run Problem 125" OnClick="btnProblem125_Click" />
            <asp:Button ID="btnProblem139" runat="server" Text="Run Problem 139" OnClick="btnProblem139_Click" />
            <asp:Button ID="btnProblem254" runat="server" Text="Run Problem 254" OnClick="btnProblem254_Click" />
            <asp:Button ID="btnProblem454" runat="server" Text="Run Problem 454" OnClick="btnProblem454_Click" />

            <hr />

            <!-- Output Placeholders -->
            <h3>
                <asp:Label ID="lblTitle" runat="server" /></h3>
            <p>
                <strong></strong>
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
        </div>
    </form>
</body>
</html>
