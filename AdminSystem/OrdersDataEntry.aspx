<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderID" runat="server" Text="Order ID" width="92px"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server" Height="16px" style="margin-left: 11px" Width="105px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="margin-left: 21px; margin-top: 0px" Text="FIND" />
        </div>
        <p>
            <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" width="92px"></asp:Label>
            <asp:TextBox ID="txtOrderDate" runat="server" style="margin-left: 11px" Width="105px"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderCost" runat="server" Text="Order Cost" width="92px"></asp:Label>
        <asp:TextBox ID="txtOrderCost" runat="server" style="margin-left: 11px" Width="105px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="92px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" style="margin-left: 11px" Width="105px"></asp:TextBox>
        </p>
        <asp:Label ID="lblNotes" runat="server" Text="Notes" width="92px"></asp:Label>
        <asp:TextBox ID="txtNotes" runat="server" Height="16px" style="margin-left: 11px" Width="450px"></asp:TextBox>
        <p>
            <asp:Label ID="lblOrderQuantity" runat="server" Text="Order Quantity"></asp:Label>
            <asp:TextBox ID="txtOrderQuantity" runat="server" style="margin-left: 11px" Width="105px"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkDispatched" runat="server" BorderWidth="0px" style="margin-left: 2px; margin-bottom: 0px" Text="Dispatched" Width="99px" />
        <p>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="40px" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="margin-left: 13px" Text="CANCEL" Width="77px" />
    </form>
</body>
</html>
