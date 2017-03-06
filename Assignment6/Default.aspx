<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<link href="Assignment6.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Login!</h1>
        <table>
            <tr>
                <td>User name: </td>
                <td>
                    <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td>Password: </td>
                <td>
                    <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="LoginButton" runat="server" Text="Log In!" OnClick="LoginButton_Click"></asp:Button></td>
            </tr>

            <tr>

                <td>
                    <asp:Label ID="Resultlabel" runat="server" Text=""></asp:Label></td>
            </tr>

        </table>

        <asp:LinkButton ID="RegisterLinkButton" runat="server"
             PostBackUrl ="~/Register.aspx">Register</asp:LinkButton>

    </div>
    </form>
</body>
</html>
