<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Assignment2WebForm.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<link href="Assignment2.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Calendar of Shindigs!</h1>  
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <p><asp:Label ID="ShindigDisplay" runat="server" Text=""></asp:Label></p>
        <p><asp:Label ID="ShindigNo" runat="server" Text=""></asp:Label></p>

        
    </div>
    </form>
</body>
</html>