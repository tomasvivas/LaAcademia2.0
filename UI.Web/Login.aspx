<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 211px;
        }
        .auto-style3 {
            width: 211px;
            height: 11px;
        }
        .auto-style4 {
            height: 11px;
        }
        .auto-style5 {
            width: 211px;
            height: 12px;
        }
        .auto-style6 {
            height: 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">
        <asp:Label ID="lblBienvenido" runat="server" Text="Bienvenido a la Academia"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Por favor, ingrese su usuario y contraseña"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style5">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td class="auto-style6">
        <asp:TextBox ID="txtUsuario" runat="server" Width="154px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblClave" runat="server" Text="Contraseña"></asp:Label>
                </td>
                <td>
            <asp:TextBox ID="txtClave" runat="server" Width="154px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>
        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
        <asp:LinkButton ID="lnkRecordarClave" runat="server" Text="Olvidé mi Clave" OnClick="lnkRecordarClave_Click"></asp:LinkButton>

                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <p>
            &nbsp;</p>

    </form>
</body>
</html>
