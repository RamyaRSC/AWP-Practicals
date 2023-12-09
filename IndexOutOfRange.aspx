<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexOutOfRange.aspx.cs" Inherits="Inheritance.IndexOutOfRange" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            numbers = { 10, 20, 30, 40, 50 }
            Enter the Index to access:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
