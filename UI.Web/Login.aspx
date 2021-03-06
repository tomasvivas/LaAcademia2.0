﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style6 {
            height: 12px;
        }
        
        .auto-style9 {
            height: 12px;
            width: 198px;
            right: auto;
        }
        .auto-style10 {
            width: 198px;
            height: 26px;
        }
        .auto-style11 {
            height: 26px;
        }
        .auto-style12 {
            width: 198px;
            height: 21px;
            right: auto;
        }
        .auto-style13 {
            height: 21px;
        }
        .auto-style14 {
            width: 198px;
            height: 60px;
            right: auto;
        }
        .auto-style15 {
            height: 60px;
        }
        .auto-style16 {
            width: 50%;
        }
        .auto-style17 {
            width: 198px;
            height: 49px;
        }
        .auto-style18 {
            height: 49px;
        }
        .auto-style19 {
            width: 198px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="margin-right: 0px;" class="auto-style16">
            <tr>
                <td class="auto-style14" style="background-color: #6699FF; font-family: 'Microsoft Sans Serif'; font-size: 28px; color: #FFFFFF; font-weight: bold; ">
                    &nbsp;<asp:Image ID="Image1" runat="server" Height="57px" ImageUrl="~/CSS/academia.png" Width="51px" />
&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style15" style="font-family: 'Microsoft Sans Serif'; font-size: 28px; font-weight: bold; color: #FFFFFF; background-color: #6699FF;">&nbsp;ACADEMIA</td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <asp:Image ID="Image2" runat="server" Height="38px" ImageUrl="~/CSS/usuarios.png" Width="36px" />
&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Font-Names="Microsoft Sans Serif" Font-Size="Medium" Text="Login usuario"></asp:Label>
                    </td>
                <td class="auto-style18"></td>
            </tr>
           >
            <tr>
                <td class="auto-style9" style="font-family: 'Microsoft Sans Serif'; font-size: small; ">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td class="auto-style6">
        <asp:TextBox ID="txtUsuario" runat="server" Width="154px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style12" style="font-family: 'microsoft sans Serif'; font-size: small; ">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="lblClave" runat="server" Text="Contraseña"></asp:Label>
                </td>
                <td class="auto-style13">
            <asp:TextBox ID="txtClave" runat="server" Width="154px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">
                    </td>
                <td class="auto-style11" style="font-family: 'microsoft sans Serif'; font-size: small;">
        &nbsp;<asp:Label ID="lnkError" runat="server" Text="El usuario y/o la contraseña son incorrectos" ForeColor="Red" ></asp:Label>

                </td>
            </tr>
            <tr>
                <td class="auto-style19">
                    &nbsp;</td>
                <td style="font-family: 'Microsoft Sans Serif'">
                    <br>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_click" BackColor="#99CCFF" BorderColor="#3399FF" />
                </td>
            </tr>
        </table>
        <p>
            &nbsp;</p>

    </form>
</body>
</html>
