<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Deneme1.aspx.cs" Inherits="HesapMakinesi.Arayuz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Sayı 1"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Sayı 2"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Sonuç"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Topla" />
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Çıkar" />
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Çarp" />
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Böl" />
                        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Temizle" />
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Hesapla" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
