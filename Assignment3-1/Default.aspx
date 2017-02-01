<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<link href="Assign-3-final1.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TITLE!</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Login page: </h1>

        <table> 

        <tr>
            <td>Please enter your email; this is your User Name: </td>
            <td>
            <asp:TextBox ID="UserTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td>Please enter your Password: </td>
            <td>
            <asp:TextBox ID="PWTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="LoginButton" runat="server" Text="Button" OnClick="LoginButton_Click" />

            </td>

            <td>
                <asp:Label ID="ResultLabel" runat="server" Text="Label"></asp:Label>

            </td>
        </tr>

        </table>

    </div>
    </form>
</body>
</html>
