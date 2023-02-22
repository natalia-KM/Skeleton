<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblProductNo" runat="server" Text="Product Number" width="121px"></asp:Label>
            <asp:TextBox ID="txtProductNo" runat="server" style="margin-left: 10px" TextMode="Number"></asp:TextBox>
        </div>
        <asp:Label ID="lblProductDescription" runat="server" Text="Product Description"></asp:Label>
        <asp:TextBox ID="txtProductDescription" runat="server" style="margin-left: 10px"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="121px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="margin-left: 10px" TextMode="DateTime"></asp:TextBox>
        <br />
        <asp:Label ID="lblSize" runat="server" Text="Size" width="121px"></asp:Label>
        <asp:TextBox ID="txtSize" runat="server" style="margin-left: 10px"></asp:TextBox>
        <br />
        <asp:Label ID="lblType" runat="server" Text="Type" width="121px"></asp:Label>
        <asp:TextBox ID="txtType" runat="server" style="margin-left: 10px"></asp:TextBox>
        <br />
        <asp:Label ID="lblStock" runat="server" Text="Stock" width="121px"></asp:Label>
        <asp:TextBox ID="txtStock" runat="server" style="margin-left: 10px" TextMode="Number"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="121px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="margin-left: 10px"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
