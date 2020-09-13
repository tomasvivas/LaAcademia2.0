<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml%22%3E
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> LA ACADEMIA </title>
</head>
<body>
   <form id="form1" runat="server">
        <div>
            <h1> LA ACADEMIA </h1>
        </div>
       <div>
           <asp:Panel ID="formPanel" Visible="false" runat="server">

            <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Usuario: "></asp:Label>
            <asp:TextBox ID="nombreUsuarioTextBox" runat="server" Height="22px"></asp:TextBox>
            <br />
            <asp:Label ID="claveLabel" runat="server" Text="Clave: "></asp:Label>
            <asp:TextBox ID="claveTextbox" TextMode="Password" runat="server"></asp:TextBox>
            </asp:Panel>

        </div>
       <div>
            <asp:Panel ID="formActionsPanel" runat="server">
                <asp:LinkButton ID="ingresarLinkButton" runat="server" OnClick="ingresarLinkButton_Click">Ingresar</asp:LinkButton>
            </asp:Panel>

         </div>
      </form>
</body>
</html>
