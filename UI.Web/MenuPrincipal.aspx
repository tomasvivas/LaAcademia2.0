<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="UI.Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Menú Principal</title>
    <style type="text/css">
        .auto-style1 {
            height: 521px;
        }
        .auto-style2 {
            width: 55%;
            height: 236px;
        }
        .auto-style4 {
            width: 1105px;
        }
        .auto-style6 {
            width: 281px;
        }
        .auto-style7 {
            width: 1105px;
            height: 56px;
        }
        .auto-style8 {
            height: 56px;
        }
    </style>
</head>
<body>
    <form id="Menú Principal" runat="server" class="auto-style1">
        <table class="auto-style2">
            <tr>
                <td class="auto-style7" style="background-color: #6699FF; font-family: 'microsoft sans Serif'; font-size: 28px; font-weight: bold; color: #FFFFFF;">
                    <asp:Image ID="Image1" runat="server" Height="53px" ImageUrl="~/CSS/academia.png" Width="47px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; LA ACADEMIA</td>
                <td style="background-color: #6699FF" class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <select id="cmbMenu" class="auto-style6" name="cmbMenu">
                        <option value="Usuarios"></option>
                        <option value="Personas"></option>
                        <option value="Especialidades"></option>
                        <option value="Planes"></option>
                        <option value="Materias"></option>
                        <option value="Cursos"></option>
                    </select>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
