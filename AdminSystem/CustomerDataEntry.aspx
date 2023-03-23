<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="92px"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="margin-left: 8px" Text="Find" />
        <p>
            <asp:Label ID="lblFullName" runat="server" Text="Full Name" width="92px"></asp:Label>
            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblEmail" runat="server" Text="Email" width="92px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number"></asp:Label>
            <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date of Birth" width="92px"></asp:Label>
            <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblTotalSpent" runat="server" Text="Total Spent" width="92px"></asp:Label>
        <asp:TextBox ID="txtTotalSpent" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkPaymentDataAdded" runat="server" Text="Payment Data Added" />
        </p>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="margin-left: 61px" Text="Cancel" />
        </p>
    </form>
</body>
</html>
