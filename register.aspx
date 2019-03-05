<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:Label ID="Label1" runat="server" Text="用户名称："></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="账户号："></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="密码："></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="~/images/12323213.jpg" Visible="False" Width="100px" />
        <asp:Image ID="Image2" runat="server" Height="100px" Width="100px" ImageUrl="~/images/timg.jpg" Visible="False" />
        <br />
        <asp:Button ID="Button1" runat="server" Height="28px" OnClick="Button1_Click" Text="注册" Width="53px" />
    
    </div>
    </form>
    <p style="text-align: center">
        &nbsp;</p>
</body>
</html>
