<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="UI.Web.ReporteCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="50px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Ver reporte de:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="dplReportes" runat="server" OnSelectedIndexChanged="dplReportes_SelectedIndexChanged">
            <asp:ListItem>(Ninguno)</asp:ListItem>
            <asp:ListItem>Cursos</asp:ListItem>
            <asp:ListItem>Especialidades</asp:ListItem>
            <asp:ListItem>Planes</asp:ListItem>
            <asp:ListItem>Usuarios</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;
        <asp:Button ID="btnGenerarReporte" runat="server" BackColor="#66FF33" BorderColor="#009900" ForeColor="Black" OnClick="Button3_Click" Text="Generar" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
    </asp:Panel>
    <asp:Panel ID="PanelGrid" runat="server" Height="192px">
        <asp:GridView ID="gvReportes" runat="server" Width="818px" AutoGenerateColumns="True" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="PanelDS" runat="server" Height="173px">
        <asp:ObjectDataSource ID="DSCursos" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.CursoLogic" DataObjectTypeName="Business.Entities.Curso" InsertMethod="Save" UpdateMethod="Save"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="DSPlanes" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.PlanLogic"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="DSEspecialidades" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.EspecialidadLogic"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="DSUsuarios" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.UsuarioLogic"></asp:ObjectDataSource>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
    </asp:Panel>
</asp:Content>
