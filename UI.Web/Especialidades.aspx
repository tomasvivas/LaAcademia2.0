<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.Web.Especialidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
<div>

    <asp:Panel ID="gridPanel" runat="server">
                <asp:GridView Descripcion="gridView" runat="server" AutoGenerateColumns="false"
                    SelectedRowStyle-BackColor="Black"
                    SelectedRowStyle-ForeColor="White"
                    DataKeyNames="ID" OnSelectedIndexChanged="gridView_selectedIndexChanged" Height="129px" Width="257px" >
                    <Columns>
                        <asp:BoundField HeaderText="ID" DataField="ID" />
                        <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                         <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
                    </Columns>
                     </asp:GridView>
                <asp:Panel ID="gridActionsPanel" runat="server">
                     <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
              <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
              <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
            </asp:Panel>
            </asp:Panel>
     <asp:Panel ID="formPanel" Visible="false" runat="server">
            <asp:Label ID="iDLabel" runat ="server" Text="ID: "></asp:Label>
           <asp:TextBox ID="idTextBox" runat="server"></asp:TextBox>
            <asp:Label ID="descripcionLabel" runat ="server" Text="Descripcion: "></asp:Label>
            <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Panel Descripcion="formActionsPanel" runat="server">
                <asp:LinkButton Descripcion="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
                <asp:LinkButton Descripcion="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
              </asp:Panel>
              </asp:Panel>  
                 </div>
        </asp:Content>

