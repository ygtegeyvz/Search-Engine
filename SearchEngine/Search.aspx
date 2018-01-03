<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="SearchEngine.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 81px">

            URL<br />
            <br />

            <asp:TextBox ID="UrlText" runat="server" Width="250px"></asp:TextBox>
            &nbsp;<br />
            <br />
            Anahtar Kelime<br />
            <br />
            <asp:TextBox ID="KeyText" runat="server" Width="250px"></asp:TextBox>
            &nbsp;<br />
            <br />
            <asp:Button ID="SearchButton" runat="server" Text="Ara" OnClick="SearchButton_Click" Width="67px" />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="SearchButton0" runat="server" Text="Ana Sayfaya Dön" OnClick="SearchButton1_Click" Width="141px" />

            <br />
            <br />
            <asp:TextBox ID="text_goruntule" runat="server" ReadOnly="True" TextMode="MultiLine" Width="250px"></asp:TextBox>

        </div>
    </form>
</body>
</html>
