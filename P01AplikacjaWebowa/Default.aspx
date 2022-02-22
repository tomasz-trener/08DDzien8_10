<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P01AplikacjaWebowa.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnPrzyciskASP" OnClick="btnPrzyciskASP_Click" runat="server" Text="Przycisk ASP" />

        <input type="button" id="btnPrzyciskHTML" value="Przycisk HTML" />
    </form>
</body>
</html>
