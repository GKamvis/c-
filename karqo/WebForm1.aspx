<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="karqo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kalkulyator</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }
        .calculator {
            width: 300px;
            margin: 0 auto;
        }
        .calculator input[type="text"], .calculator select {
            width: 100%;
            margin-bottom: 10px;
            padding: 5px;
        }
        .calculator input[type="button"] {
            width: 100%;
            padding: 10px;
            color: white;
            background-color: blue;
            border: none;
            cursor: pointer;
        }
        .calculator input[type="button"]:hover {
            background-color: darkblue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="calculator">
            <h1>Kalkulyator</h1>
            <p>Bağlamanın uzunluğu 60 sm-dən yuxarı olduğu təqdirdə bağlamanın fiziki və həcm çəkisi ölçülür, kq olaraq hansı daha çox olarsa, çatdırılma ödənişi ona əsasən hesablanır.</p>
            <asp:DropDownList ID="ddlCountry" runat="server">
                <asp:ListItem>Ölkəni seçin</asp:ListItem>
                <asp:ListItem>Türkiye</asp:ListItem>
                <asp:ListItem>ABŞ</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlDeliveryType" runat="server">
                <asp:ListItem>Çatdırılma növü</asp:ListItem>
                <asp:ListItem>Adresə çatdırılma</asp:ListItem>
                <asp:ListItem>Filiala çatdırılma</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="txtWidth" runat="server" placeholder="En (sm)"></asp:TextBox>
            <asp:TextBox ID="txtHeight" runat="server" placeholder="Hündürlük (sm)"></asp:TextBox>
            <asp:TextBox ID="txtLength" runat="server" placeholder="Uzunluq (sm)"></asp:TextBox>
            <asp:TextBox ID="txtWeight" runat="server" placeholder="Çəki (kq)"></asp:TextBox>
            <p>Cemi: ₼<asp:Label ID="lblTotal" runat="server" Text="0"></asp:Label></p>
            <asp:Button ID="btnCalculate" runat="server" Text="Hesabla" OnClick="btnCalculate_Click" />

        </div>
    </form>
</body>
</html>
