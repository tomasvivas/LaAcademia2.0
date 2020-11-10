<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inscripciones.aspx.cs" Inherits="UI.Web.Inscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <div style="width: 742px; height: 558px">
    
        <asp:Panel ID="gridPanel" runat="server">
            <asp:GridView ID="dgInscripciones" runat="server" AutoGenerateColumns="False" SelectedRowStyle-BackColor="Blue"
                    SelectedRowStyle-ForeColor="White" OnSelectedIndexChanged="gridView_selectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID Curso" SortExpression="ID" />
                    <asp:BoundField DataField="DescComision" HeaderText="Comision" SortExpression="DescComision" />
                    <asp:BoundField DataField="DescMateria" HeaderText="Materia" SortExpression="DescMateria" />
                    <asp:BoundField DataField="AnioCalendario" HeaderText="AnioCalendario" SortExpression="AnioCalendario" />
                    <asp:BoundField DataField="Cupo" HeaderText="Cupo" SortExpression="Cupo" />
                    
                </Columns>
                <SelectedRowStyle BackColor="Blue" ForeColor="White" />
            </asp:GridView>
             <asp:Panel ID="gridActionsPanel" runat="server">
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:Button ID="btnNuevo" runat="server" BackColor="#99FF33" OnClick="btnNuevo_Click" Text="Nuevo" Width="84px" />
                    
            </asp:Panel>
        

    </asp:Panel>

       </div>
    
</asp:Content>
