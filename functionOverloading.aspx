<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="functionOverloading.aspx.cs" Inherits="Inheritance.functionOverloading" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Circle" OnClick="Button1_Click1" style="height: 29px" />
            <asp:Button ID="Button2" runat="server" Text="Rectangle" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Square" OnClick="Button3_Click" />
        </div>
    </form>
</body>
</html>
