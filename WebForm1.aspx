<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WADLL.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Number 1:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />Enter Number 2:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br /><asp:Button ID="Button1" runat="server" Text="Addition" OnClick="Button1_Click" />
            <br /><asp:Button ID="Button2" runat="server" Text="Subtraction" OnClick="Button2_Click" />
            <br /><asp:Button ID="Button3" runat="server" Text="Multiplication" OnClick="Button3_Click" />
            <br />Solution:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>