<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="calculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>+</asp:ListItem>
        <asp:ListItem>-</asp:ListItem>
        <asp:ListItem>*</asp:ListItem>
        <asp:ListItem>/</asp:ListItem>
    </asp:DropDownList>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Hesabla" OnClick="Button1_Click" />
    <asp:Label ID="Label1" runat="server"></asp:Label>
</form>

    
</body>
</html>
