<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P04AJAX.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="lib/jquery/jquery-3.6.0.min.js"></script>
    <script src="js/DefaultJs.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:Button ID="btnPrzyciskNET" OnClick="btnPrzyciskNET_Click" runat="server" Text="Przycisk NET" />
        <asp:Label ID="lblWynik" runat="server" Text="Label"></asp:Label>

        <br />
        Durgie rozwiązanie HTML
        <br />
        <input id="btnPrzyciskHTML" type="button" value="Przycisk HTML" />
        <span id="spWynik"></span>

    </form>
</body>
</html>
