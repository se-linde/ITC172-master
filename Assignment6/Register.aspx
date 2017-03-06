<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>
<link href="Assignment6.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Register</h1>

    <p>Lastname: <asp:TextBox ID="LastnameTextBox" runat="server"></asp:TextBox></p>
    <p>Firstname: <asp:TextBox ID="FirstnameTextBox" runat="server"></asp:TextBox></p>
    <p>Email: <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox></p>
    <p>Apartment: <asp:TextBox ID="ApartmentTextBox" runat="server"></asp:TextBox></p>
    <p>Street: <asp:TextBox ID="StreetTextBox" runat="server"></asp:TextBox></p>
    <p>City: <asp:TextBox ID="CityTextBox" runat="server"></asp:TextBox></p>
    <p>State: <asp:TextBox ID="StateTextBox" runat="server"></asp:TextBox></p>
    <p>Zipcode: <asp:TextBox ID="ZipcodeTextBox" runat="server"></asp:TextBox></p>
    <p>Home Phone: <asp:TextBox ID="HomephoneTextBox" runat="server"></asp:TextBox></p>
    <p>Work Phone: <asp:TextBox ID="WorkphoneTextBox" runat="server"></asp:TextBox></p>
    <p>Password: <asp:TextBox ID="PasswordTextBox" textMode="Password" runat="server"></asp:TextBox></p>
    
<p>

    <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click"/>
    <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>

</p>
        <asp:LinkButton ID="LoginLinkButton" runat="server" PostBackUrl="~/Default.aspx">Login</asp:LinkButton>


    
</div>
</form>
</body>
</html>
