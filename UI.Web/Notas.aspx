<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Notas.aspx.cs" Inherits="UI.Web.Notas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <div style="width: 742px; height: 558px">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView Descripcion="gridView" runat="server" AutoGenerateColumns="False"
                    SelectedRowStyle-BackColor="Blue"
                    SelectedRowStyle-ForeColor="White" OnSelectedIndexChanged="gridView_selectedIndexChanged" 
                    ID="gvNotas" Height="91px" Width="698px" DataSourceID="ObjectDataSource1" DataKeyNames="ID">

        </asp:GridView>

        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>

    </asp:Panel>
        <asp:Panel ID="gridActionsPanel" runat="server">
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnNota" runat="server" BackColor="#99FF33" OnClick="btnNota_Click" Text="Inscribir nota" Width="84px" />
                    
            </asp:Panel>

        <asp:Panel ID="formPanel" Visible="false" runat="server">
         &nbsp;<br>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="IdLbl" runat="server" Text="Ingrese la nota: "></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;
         <asp:TextBox ID="txtNota" runat="server" Height="22px" Width="128px"></asp:TextBox>
        <br>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnIngresar" runat="server" BackColor="#99FF33" OnClick="btnIngresar_Click" Text="Aceptar" Width="84px" />
            </asp:Panel>
        </div>
</asp:Content>
