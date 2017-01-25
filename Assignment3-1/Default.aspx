<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<link href="Assignment3-1.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Your Data Results!</h1>  
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <Columns>
            <asp:BoundField DataField="GrantTypeKey" 
            HeaderText="GrantTypeKey" SortExpression="GrantTypeKey" />
        </Columns>

    </div>
    </form>
</body>
</html>
