<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <p>
            <asp:Label ID="lblEmployeeName" runat="server" Text="Employee Name" width="180px"></asp:Label>
            <asp:TextBox ID="txtEmployeeName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblEmployeePosition" runat="server" Text="Employee Position" width="180px"></asp:Label>
        <asp:TextBox ID="txtEmployeePosition" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblEmployeeEmail" runat="server" Text="Employee Email" width="180px"></asp:Label>
            <asp:TextBox ID="txtEmployeeEmail" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblEmployeeStartDate" runat="server" Text="Employee Start Date" width="180px"></asp:Label>
            <asp:TextBox ID="txtEmployeeStartDate" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblEmployeeSalary" runat="server" Text="Employee Salary" width="180px"></asp:Label>
            <asp:TextBox ID="txtEmployeeSalary" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="CheckBoxBonus" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Bonus Eligible" />
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" Width="50px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" style="margin-left:15px;" />
        </p>
    </form>
</body>
</html>
