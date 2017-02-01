<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GrantRequest.aspx.cs" Inherits="GrantRequest" %>

<!DOCTYPE html>
<link href="Assign-3-final1.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grant Request Results</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Grant Request Results!</h1>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>

    
    </div>
    </form>
</body>
</html>
