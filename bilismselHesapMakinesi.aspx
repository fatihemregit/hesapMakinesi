<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bilismselHesapMakinesi.aspx.cs" Inherits="HesapMakinesi.bilismselHesapMakinesi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <asp:TextBox ID="TextBox1" runat="server" Width="646px"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="x ^ 2" />
            <asp:Button ID="Button2" runat="server" Text="1/x" />
            <asp:Button ID="Button3" runat="server" Text="|x|" />
            <asp:Button ID="Button4" runat="server" Text="Mod" />
            <asp:Button ID="Button26" runat="server" Text="=" OnClick="Button26_Click" />
            <br />
            <asp:Button ID="Button5" runat="server" Text="karekök" />
            <asp:Button ID="Button6" runat="server" Text="Faktoriyel" />
            <br />
            <asp:Button ID="Button7" runat="server" Text="x ^ y" />
            <asp:Button ID="Button8" runat="server" Text="10 ^ x" />
            <asp:Button ID="Button9" runat="server" Text="Log10" />
            <asp:Button ID="Button10" runat="server" Text="Ln" />
            <br />
            <asp:Button ID="Button11" runat="server" Text="+/-" />
            <br />
            <asp:Button ID="Button12" runat="server" OnClick="forNumberButton" Text="1" />
            <asp:Button ID="Button13" runat="server" OnClick="forNumberButton" Text="2" />
            <asp:Button ID="Button14" runat="server" OnClick="forNumberButton" Text="3" />
            <asp:Button ID="Button15" runat="server" OnClick="forNumberButton" Text="4" />
            <asp:Button ID="Button16" runat="server" OnClick="forNumberButton" Text="5" />
            <br />
            <asp:Button ID="Button17" runat="server" OnClick="forNumberButton" Text="6" />
            <asp:Button ID="Button18" runat="server" OnClick="forNumberButton" Text="7" />
            <asp:Button ID="Button19" runat="server" OnClick="forNumberButton" Text="8" />
            <asp:Button ID="Button20" runat="server" OnClick="forNumberButton" Text="9" />
            <asp:Button ID="Button21" runat="server" OnClick="forNumberButton" Text="0" />
            <br />
            <asp:Button ID="Button22" runat="server" OnClick="forBasicOperationButton" Text="+" />
            <asp:Button ID="Button23" runat="server" OnClick="forBasicOperationButton" Text="-" />
            <asp:Button ID="Button24" runat="server" OnClick="forBasicOperationButton" Text="/" />
            <asp:Button ID="Button25" runat="server" OnClick="forBasicOperationButton" Text="*" />
            <asp:Button ID="Button27" runat="server" OnClick="Button27_Click" Text="Temizle" />
           
        </div>
    </form>
</body>
</html>
