<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="nico01.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtConteo" runat="server"></asp:TextBox>
            <asp:Button ID="btnIncrementa" runat="server" Text="Incrementa" OnClick="btnIncrementa_Click"></asp:Button>
        </div>
    </form>
</body>
</html>
