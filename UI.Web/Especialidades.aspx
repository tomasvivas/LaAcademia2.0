<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.Web.Especialidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
<div>

    <asp:Panel ID="gridPanel" runat="server">
                <asp:GridView Descripcion="gridView" runat="server" AutoGenerateColumns="false"
                    SelectedRowStyle-BackColor="Black"
                    SelectedRowStyle-ForeColor="White"
                    DataKeyNames="Descripcion" OnSelectedIndexChanged="gridView_selectedIndexChanged" >
                    <Columns>
                        <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                         <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
                    </Columns>
                     </asp:GridView>
                <asp:Panel Descripcion="gridActionsPanel" runat="server">
                     <asp:LinkButton Descripcion="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
              <asp:LinkButton Descripcion="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
              <asp:LinkButton Descripcion="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
            </asp:Panel>
            </asp:Panel>
     <asp:Panel Descripcion="formPanel" Visible="false" runat="server">
            <asp:Label Descripcion="descripcionLabel" runat ="server" Text="Descripcion: "></asp:Label>
            <asp:TextBox Descripcion="descripcionTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Panel Descripcion="formActionsPanel" runat="server">
                <asp:LinkButton Descripcion="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
                <asp:LinkButton Descripcion="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
              </asp:Panel>
              </asp:Panel>  
                 </div>
        </asp:Content>

