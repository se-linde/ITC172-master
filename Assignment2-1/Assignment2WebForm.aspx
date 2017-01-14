<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Assignment2WebForm.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

        <asp:CheckBoxList ID="ProduceCheckBoxList" runat="server"></asp:CheckBoxList>
        <asp:Button ID="TotalButton" runat="server" Text="Get Total" OnClick="TotalButton_Click" />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

    </div>
    </form>
</body>
</html>