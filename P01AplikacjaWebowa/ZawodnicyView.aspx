<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ZawodnicyView.aspx.cs" Inherits="P01AplikacjaWebowa.ZawodnicyView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="ZawodnicyViewStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <div style="float: left">
                <span>Podaj kolumny</span>
                <asp:CheckBoxList ID="clbKolumny" runat="server"></asp:CheckBoxList>
            </div>
            <div style="float: left">
                <asp:ListBox ID="lbDane" AutoPostBack="true" OnSelectedIndexChanged="lbDane_SelectedIndexChanged" Height="500" Width="200" runat="server"></asp:ListBox>
            </div>
            <div style="float: left;display: inline-grid;" id="dvFunkcje">
                <asp:Button ID="btnWczytaj" OnClick="btnWczytaj_Click" runat="server" Text="Wczytaj" />
                <asp:Button ID="btnDodaj" OnClick="btnDodaj_Click" runat="server" Text="Dodaj" />
                <asp:Button ID="btnUsun" OnClick="btnUsun_Click" runat="server" Text="Usuń" />
                <asp:Button ID="btnEdytuj" runat="server" OnClick="btnEdytuj_Click" Text="Edytuj" />
            </div>
            <div  style="float: left;margin-left:10px">
                <table>
                    <tr>
                        <td>Imie</td>
                        <td><asp:TextBox ID="txtImie" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Nazwisko</td>
                        <td><asp:TextBox ID="txtNazwisko" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Kraj</td>
                        <td><asp:TextBox ID="txtKraj" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Data Urodzenia</td>
                        <td><asp:TextBox ID="txtDataUr" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Waga</td>
                        <td><asp:TextBox ID="txtWaga" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Wzrost</td>
                        <td><asp:TextBox ID="txtWzrost" runat="server"></asp:TextBox></td>
                    </tr>
                </table>
            </div>


        </div>
    </form>
</body>
</html>
