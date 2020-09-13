﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="UI.Web.Planes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

    <div>

    <asp:Panel ID="gridPanel" runat="server">
                <asp:GridView Descripcion="gridView" runat="server" AutoGenerateColumns="False"
                    SelectedRowStyle-BackColor="Blue"
                    SelectedRowStyle-ForeColor="White" OnSelectedIndexChanged="gridView_selectedIndexChanged" ID="gridView" Height="91px" Width="698px" DataSourceID="ObjectDataSource2" DataKeyNames="ID" >
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField HeaderText="ID" DataField="ID" SortExpression="ID" />
                        <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" SortExpression="Descripcion" />
                        <asp:BoundField DataField="IDEspecialidad" HeaderText="IDEspecialidad" SortExpression="IDEspecialidad" />
                        <asp:BoundField DataField="DescEspecialidad" HeaderText="DescEspecialidad" SortExpression="DescEspecialidad" />
                    </Columns>
                     <SelectedRowStyle BackColor="Blue" ForeColor="White" />
                     </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DataObjectTypeName="Business.Entities.Plan" DeleteMethod="Delete" SelectMethod="GetAll" TypeName="Business.Logic.PlanLogic" UpdateMethod="Save">
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                    </DeleteParameters>
                </asp:ObjectDataSource>
                <br />
                <asp:Panel ID="gridActionsPanel" runat="server">
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="btnNuevo" runat="server" BackColor="#99FF33" OnClick="btnNuevo_Click" Text="Nuevo" Width="84px" />
                     &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                     <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" Width="84px" />
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Button ID="btnEliminar" runat="server" BackColor="Red" ForeColor="White" OnClick="btnEliminar_Click" Text="Eliminar" Width="84px" />
            </asp:Panel>
            </asp:Panel>
     <asp:Panel ID="formPanel" Visible="false" runat="server">
         &nbsp;<br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="iDLabel" runat="server" Text="ID: "></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;
         <asp:TextBox ID="idTextBox" runat="server"></asp:TextBox>
         <br />
         <br />
         &nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="descripcionLabel" runat="server" Text="Descripcion: "></asp:Label>
         &nbsp;&nbsp;
         <asp:TextBox ID="descripcionTextBox" runat="server"></asp:TextBox>
         <br />
         <br />
         <asp:Label ID="idEspecialidadLabel" runat="server" Text="ID Especialidad: "></asp:Label>
         &nbsp;
         <asp:TextBox ID="idEspecialidadTextBox" runat="server"></asp:TextBox>
         <br />
         <br />
         <asp:Panel runat="server" Descripcion="formActionsPanel">
             <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="btnAceptar" runat="server" BackColor="#CCFFFF" OnClick="btnAceptar_Click" Text="Aceptar" Width="84px" />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" Width="84px" />
             </br>
         </asp:Panel>
         </br>
        </asp:Panel>  
                 </div>

</asp:Content>
