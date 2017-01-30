<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GrantRequestBooks.aspx.cs" Inherits="GrantRequestBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Books</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Books!</h1>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>

    </div>
    </form>
</body>
</html>
