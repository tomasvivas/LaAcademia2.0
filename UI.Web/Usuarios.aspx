<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>


 
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <div>

        <asp:Panel ID="gridPanel" runat="server">
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
                    SelectedRowStyle-BackColor="Black"
                    SelectedRowStyle-ForeColor="White" OnSelectedIndexChanged="gridView_selectedIndexChanged" DataSourceID="ObjectDataSource1" DataKeyNames="ID" >
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                        <asp:BoundField HeaderText="NombreUsuario" DataField="NombreUsuario" SortExpression="NombreUsuario" />
                        <asp:BoundField HeaderText="Clave" DataField="Clave" SortExpression="Clave" />
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" SortExpression="Nombre" />
                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                        <asp:CheckBoxField DataField="Habilitado" HeaderText="Habilitado" SortExpression="Habilitado" />
                    </Columns>
                    <SelectedRowStyle BackColor="Black" ForeColor="White" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Business.Entities.Usuario" DeleteMethod="Delete" SelectMethod="GetAll" TypeName="Business.Logic.UsuarioLogic" UpdateMethod="Save">
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                    </DeleteParameters>
                </asp:ObjectDataSource>
            <asp:Panel ID="gridActionsPanel" runat="server">
              <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
            </asp:Panel>
            </asp:Panel>
        <asp:Panel ID="formPanel" Visible="false" runat="server">
            <asp:Label ID="nombreLabel" runat ="server" Text="Nombre: "></asp:Label>
            <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="apellidoLabel" runat="server" Text="Apellido: "></asp:Label>
            <asp:TextBox ID="apellidoTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="emailLabel" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
            <br />
            
            <asp:CheckBox ID="habilitadoCheckBox" runat="server" Text="Habilitado"></asp:CheckBox> 
            <br />
            <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Usuario: "></asp:Label>
            <asp:TextBox ID="nombreUsuarioTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="claveLabel" runat="server" Text="Clave: "></asp:Label>
            <asp:TextBox ID="claveTextbox" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="repetirClaveLabel" runat="server" Text="Repetir clave: "></asp:Label>
            <asp:TextBox ID="repetirClaveTextBox" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <asp:Panel ID="formActionsPanel" runat="server">
                <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
                <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
            </asp:Panel>
        </asp:Panel>  
    </div>
</asp:Content>
