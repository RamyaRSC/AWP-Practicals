<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AJAX_and_XML.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView> <br />
            enter name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />
            enter rollno:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> <br />
            enter class:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br /> <br /> <br /> <br />
            <asp:Button ID="Button1" runat="server" Text="read" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="write" OnClick="Button2_Click" />

        </div>
    </form>
</body>
</html>
