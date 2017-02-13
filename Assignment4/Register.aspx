<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>
<link href="Books.css" rel="stylesheet" />
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>Last Name: </td>

            <td><asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox></td>

            <td>
                <asp:RequiredFieldValidator ID="LastName" runat="server" 
                    ErrorMessage="Last Name is required." ControlToValidate="LastNameTextBox"></asp:RequiredFieldValidator>
            </td>
            </tr>
        <tr>
            <td>First Name: </td>

            <td><asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox></td>

            <td></td>
            </tr>

            <td>Email: </td>

            <td><asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox></td>

            <td>    <asp:RequiredFieldValidator ID="EmailValidator" runat="server" 
                    ErrorMessage="Email is required." 
                ControlToValidate="EmailTextBox"></asp:RequiredFieldValidator>


                <asp:RegularExpressionValidator ID="EmailReGex" 
                    runat="server" ErrorMessage="Invalid Email"
                    ControlToValidate="EmailTextBox" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Apartment Number: </td>

            <td><asp:TextBox ID="ApartmentNumberTextBox" runat="server"></asp:TextBox></td>

            <td></td>
        </tr>
        <tr>
            <td>Street: </td>

            <td><asp:TextBox ID="StreetTextBox" runat="server"></asp:TextBox></td>

            <td></td>
        </tr>
        <tr>
            <td>City: </td>

            <td><asp:TextBox ID="CityTextBox" runat="server"></asp:TextBox></td>

            <td></td>
        </tr>
        <tr>
            <td>State: </td>

            <td><asp:TextBox ID="StateTextBox" runat="server"></asp:TextBox></td>

            <td></td>
        </tr>
        <tr>
            <td>Zip Code: </td>

            <td><asp:TextBox ID="ZipCodeTextBox" runat="server"></asp:TextBox></td>

            <td></td>
        </tr>
        <tr>
            <td>Home Phone: </td>

            <td><asp:TextBox ID="HomePhoneTextBox" runat="server"></asp:TextBox></td>

            <td>
                <asp:Label ID="HomePhoneLabel" runat="server" Text="Please enter without parenthesis or dashes."></asp:Label>
                
            </td>
        </tr>
        <tr>
            <td>Work Phone: </td>

            <td><asp:TextBox ID="WorkPhoneTextBox" runat="server"></asp:TextBox></td>

            <td></td>
        </tr>
        <tr>
            <td>Password: </td>

            <td><asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox></td>

            <td></td>


        </tr>
        
        <tr>
            <td>Confirm Password: </td>

            <td><asp:TextBox ID="ConfirmPasswordTextBox" runat="server" TextMode="Password"></asp:TextBox></td>

            <td>
                <asp:CompareValidator ID="ConfirmPassword" 
                    runat="server" ErrorMessage="Passwords don't match."
                    ControlToValidate="ConfirmPasswordTextBox"
                    ControlToCompare="PasswordTextBox"></asp:CompareValidator></td>


        </tr>
        
        <tr>
            <td><asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" /></td>
            <td>
                <asp:Label ID="ResultLabel" runat="server" Text="Label"></asp:Label></td>
            <td>&nbsp;</td>
        </tr>
    </table>

    </div>
    </form>
</body>
</html>
