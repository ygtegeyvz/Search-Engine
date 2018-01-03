<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UrlSıralama.aspx.cs" Inherits="SearchEngine.UrlSıralama" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 240px">
    <form id="form1" runat="server">
        <div>
            URL<br />
            <br />
            <asp:TextBox ID="UrlText" runat="server" Width="315px"></asp:TextBox>
            <br />
            <br />
            KELİMELER<br />
            <br />
            <asp:TextBox ID="KelimeText" runat="server" Width="315px"></asp:TextBox>
            <br />
            <br />
        </div>
         <asp:Button ID="btn_UrlSırala" runat="server" Text="Sırala" OnClick="btn_UrlSırala_Click" Width="86px" />
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btn_UrlSırala0" runat="server" Text="Ana Sayfaya Dön" OnClick="btn_Click" Width="129px" />
        <p>
            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" TextMode="MultiLine" Width="315px"></asp:TextBox>
        </p>
        <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" TextMode="MultiLine" Width="315px"></asp:TextBox>
    </form>
    
</body>
</html>
