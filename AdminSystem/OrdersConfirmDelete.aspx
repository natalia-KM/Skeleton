<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblConfirmDeleteQuestion" runat="server" BorderColor="White" BorderWidth="15px" Font-Bold="False" Font-Italic="False" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="margin-left: 84px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="margin-left: 36px" Text="No" />
    </form>
</body>
</html>
