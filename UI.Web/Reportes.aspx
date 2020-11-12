<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="UI.Web.ReporteCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="36px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Ver reporte de:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>(Ninguno)</asp:ListItem>
            <asp:ListItem>Cursos</asp:ListItem>
            <asp:ListItem>Especialidades</asp:ListItem>
            <asp:ListItem>Planes</asp:ListItem>
            <asp:ListItem>Usuarios</asp:ListItem>
        </asp:DropDownList>
    </asp:Panel>
    <asp:Panel ID="PanelGrid" runat="server" Height="149px">
        <asp:GridView ID="GridView1" runat="server" Width="622px">
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="PanelDS" runat="server">
        <asp:ObjectDataSource ID="DSCursos" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.CursoLogic"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="DSPlanes" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.PlanLogic"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="DSEspecialidades" runat="server"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="DSUsuarios" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.UsuarioLogic"></asp:ObjectDataSource>
    </asp:Panel>
</asp:Content>
