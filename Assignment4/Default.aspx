<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<link href="Books.css" rel="stylesheet" />

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">
    <title>Data Entities!</title>
</head>
<body>

 

    <form id="form1" runat="server">
    <div>
       <h1>Data Entities! </h1>
    <table>
        <tr>
            <td>User name:</td>
            <td><asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox> </td>
        </tr>

        <tr>
            <td>Password:</td>
            <td><asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox> </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
            </td>
            <td>
                <asp:Label ID="Errorlabel" runat="server" Text=""></asp:Label>

            </td>

        </tr>

    </table>

    </div>
    </form>
</body>
</html>
