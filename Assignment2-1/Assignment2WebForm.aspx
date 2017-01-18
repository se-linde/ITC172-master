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
        <asp:Label ID="ShindigDisplay" runat="server" Text=""></asp:Label>
        <p><asp:Label ID="ShindigNo" runat="server" Text=""></asp:Label></p>

        
    </div>
    </form>
</body>
</html>