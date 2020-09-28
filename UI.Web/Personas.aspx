<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="UI.Web.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <div>

        <asp:Panel ID="gridPanel" runat="server">
                <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False"
                    SelectedRowStyle-BackColor="BLue"
                    SelectedRowStyle-ForeColor="White" OnSelectedIndexChanged="gridView_selectedIndexChanged" DataSourceID="ObjectDataSource1" DataKeyNames="ID" >
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                        <asp:BoundField HeaderText="Direccion" DataField="Direccion" SortExpression="Direccion" />
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" SortExpression="Nombre" />
                        <asp:BoundField DataField="FechNac" HeaderText="Fecha de Nacimiento" SortExpression="FechNac" />
                        <asp:BoundField HeaderText="Direccion" DataField="Direccion" SortExpression="Direccion" />
                        <asp:BoundField HeaderText="Plan" DataField="Plan" SortExpression="Plan" />
                        <asp:BoundField DataField="DescPlan" HeaderText="Descipcion Plan" SortExpression="DescPlan" />
                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                        <asp:BoundField DataField="TipoPersona" HeaderText="Tipo de persona" SortExpression="TipoPersona" />
                      
                    </Columns>
                    <SelectedRowStyle BackColor="Blue" ForeColor="White" />
                </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Business.Entities.Usuario" DeleteMethod="Delete" SelectMethod="GetAll" TypeName="Business.Logic.UsuarioLogic" UpdateMethod="Save">
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                    </DeleteParameters>
                </asp:ObjectDataSource>
                <br />
                <asp:Panel ID="gridActionsPanel" runat="server">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnNuevo" runat="server" BackColor="#99FF33" OnClick="btnNuevo_Click" Text="Nuevo" Width="84px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="btnEditar" runat="server" BackColor="#99CCFF" OnClick="btnEditar_Click" Text="Editar" Width="84px" />
                    &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                    <asp:Button ID="btnEliminar" runat="server" BackColor="Red" ForeColor="White" OnClick="btnEliminar_Click" Text="Eliminar" Width="84px" />
                    <br />
                </asp:Panel>
            </asp:Panel>
        <asp:Panel ID="formPanel" Visible="true" runat="server">
            <br>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="ID" runat ="server" Text="ID: "></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="IDTextBox" runat="server"></asp:TextBox>
            <br />
            <br /
            <asp:Label ID="nombreLabel" runat ="server" Text="Nombre: "></asp:Label>
            &nbsp;Nombre:&nbsp;&nbsp;
            <asp:TextBox ID="nombreTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="apellidoLabel" runat="server" Text="Apellido: "></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="apellidoTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="emailLabel" runat="server" Text="Email: "></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Telefono" runat="server" Text="Telefono: "></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="telefonoTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
             &nbsp;&nbsp;<asp:Label ID="fechNacLabel" runat="server" Text="Fecha de nacimiento: "></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="fechNacTextBox"  runat="server"></asp:TextBox>
            <br />
            <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Label ID="PlanLabel" runat="server" Text="Plan: "></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="planTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
             <asp:Label ID="descPlanLabel" runat="server" Text="Descripcion del plan: "></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="descPlanTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Label ID="tipoPersonaLable" runat="server" Text="Tipo Persona: "></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="tipoPersonaTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;<asp:Label ID="direccionLabel" runat="server" Text="Direccion: "></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="direccionTextBox"  runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Panel ID="formActionsPanel" runat="server">
                <br>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnAceptar" runat="server" BackColor="#CCFFFF" OnClick="btnAceptar_Click" Text="Aceptar" Width="84px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" Width="84px" />
            </asp:Panel>


        </asp:Panel>  
    </div>

</asp:Content>
