﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SematikAnaliz.aspx.cs" Inherits="SearchEngine.SematikAnaliz" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 354px">
    <form id="form1" runat="server">
        <div>
            &nbsp;URL<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="600px"></asp:TextBox>
            <br />
            <br />
            KELİMELER<br />
            <br />
        </div>
        <asp:TextBox ID="TextBox2" runat="server" Width="600px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ara" Width="102px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Ana Sayfaya Dön" Width="126px" />
        <br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server"  ReadOnly="True" TextMode="MultiLine" Width="600px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox4" runat="server"  ReadOnly="True" TextMode="MultiLine" Width="600px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox5" runat="server"  ReadOnly="True" TextMode="MultiLine" Width="600px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox6" runat="server"  ReadOnly="True" TextMode="MultiLine" Width="600px"></asp:TextBox>
    </form>
</body>
</html>

