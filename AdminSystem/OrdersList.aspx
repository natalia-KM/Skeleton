<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" Height="407px" Width="207px" BackColor="#0099CC" Font-Bold="False" ForeColor="White" style="margin-left: 0px; margin-top: 32px" ToolTip="OrderList (Displays through Dates)"></asp:ListBox>
            <asp:ListBox ID="lstOrderLineList" runat="server" BackColor="#33CCCC" Font-Bold="True" Font-Italic="False" Font-Size="Small" ForeColor="White" Height="407px" style="margin-left: 14px; margin-top: 0px" ToolTip="OrderLineList (Displays OrderIDs)" Width="207px"></asp:ListBox>
            <asp:Button ID="btnCheckOrderID" runat="server" OnClick="btnCheckOrderID_Click" Text="Check Selected Order's OrderID" Width="276px" style="margin-left: 16px" ToolTip="Returns OrderID of selected order in the list of orders" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblORDERS" runat="server" Font-Names="Segoe UI" Font-Size="Large" style="margin-left: 33px" Text="ORDERS" Width="216px"></asp:Label>
            <asp:Label ID="lblORDERLINES" runat="server" Font-Names="Segoe UI" Font-Size="Large" style="margin-left: 0px" Text="ORDERLINES" Width="98px"></asp:Label>
            <br />
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="ADD" ToolTip="Add record" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="EDIT ORDER" />
        <asp:Button ID="btnEdit_OrderLine" runat="server" OnClick="btnEdit_OrderLine_Click" Text="EDIT ORDERLINE" Width="138px" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="DELETE ORDER" Width="119px" style="margin-left: 0px" />
        <br />
        <br />
        <asp:Label ID="lblEnterMsg" runat="server" Text="Enter an Order Date:"></asp:Label>
        <asp:TextBox ID="txtOrderDateFilter" runat="server" style="margin-left: 9px" ToolTip="Enter a OrderDate value to filter the records."></asp:TextBox>
        <br />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="APPLY FILTER" />
        <asp:Button ID="btnClear" runat="server" Text="CLEAR" OnClick="btnClear_Click" />
        <p>
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        </p>
    </form>
</body>
</html>
