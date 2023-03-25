<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" Height="407px" Width="207px" BackColor="#0099CC" Font-Bold="False" ForeColor="White" style="margin-left: 0px; margin-top: 32px" ToolTip="OrderList"></asp:ListBox>
            <asp:ListBox ID="lstOrderLineList" runat="server" BackColor="#33CCCC" Font-Bold="True" Font-Italic="False" Font-Size="Small" ForeColor="White" Height="407px" style="margin-left: 14px; margin-top: 0px" ToolTip="OrderLineList" Width="207px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
