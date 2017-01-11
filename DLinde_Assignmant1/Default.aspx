<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tip Calculator!</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Tip Calculator!</h1>
    <div>
        <p>
        <asp:Label ID="Label1" runat="server" Text="Enter Meal Amount: "></asp:Label>
            <!-- renamed because this textbox will be referred to in code. --> 
        <asp:TextBox ID="MealTextBox" runat="server"></asp:TextBox>
        </p>
        
        <asp:RadioButtonList ID="TipPercentsRadioButtonList" runat="server"></asp:RadioButtonList>
        
        <asp:TextBox ID="OtherTextBox" runat="server"></asp:TextBox>
        <p>
        <asp:Button ID="SubmitButton" runat="server" Text="Calculate" OnClick="SubmitButton_Click" />
        </p>
      
        <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
  

    </div>
    </form>
</body>
</html>
