<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <div style="width: 881px; height: 558px">

    &nbsp;<asp:Panel ID="gridPanel" runat="server">
                <asp:GridView Descripcion="gridView" runat="server" AutoGenerateColumns="False"
                    SelectedRowStyle-BackColor="Blue"
                    SelectedRowStyle-ForeColor="White" OnSelectedIndexChanged="gridView_selectedIndexChanged" ID="cursoGV" Height="91px" Width="876px" DataSourceID="ObjectDataSource2" DataKeyNames="ID" >
                    <Columns>
                         <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                        <asp:BoundField DataField="IDComision" HeaderText="IDComision" SortExpression="IDComision" />
                        <asp:BoundField DataField="DescComision" HeaderText="DescComision" SortExpression="DescComision" />
                        <asp:BoundField DataField="IDMateria" HeaderText="IDMateria" SortExpression="IDMateria" />
                        <asp:BoundField DataField="DescMateria" HeaderText="DescMateria" SortExpression="DescMateria" />
                        <asp:BoundField HeaderText="AnioCalendario" DataField="AnioCalendario" SortExpression="AnioCalendario" />
                        <asp:BoundField HeaderText="Cupo" DataField="Cupo" SortExpression="Cupo" />

                    </Columns>
                     <SelectedRowStyle BackColor="Blue" ForeColor="White" />
                     </asp:GridView>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DataObjectTypeName="Business.Entities.Curso" DeleteMethod="Delete" SelectMethod="GetAll" TypeName="Business.Logic.CursoLogic" UpdateMethod="Save">
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                    </DeleteParameters>
                </asp:ObjectDataSource>
                <br />
                <asp:Panel ID="gridActionsPanel" runat="server">
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnNuevo" runat="server" BackColor="#99FF33" OnClick="btnNuevo_Click" Text="Nuevo" Width="84px" />
                     &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                     <asp:Button ID="btnEditar" runat="server" OnClick="btnEditar_Click" Text="Editar" Width="84px" />
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Button ID="btnEliminar" runat="server" BackColor="Red" ForeColor="White" OnClick="btnEliminar_Click" Text="Eliminar" Width="84px" />
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Button ID="btnNotas" runat="server" BackColor="Yellow" ForeColor="Black" OnClick="btnNotas_Click" Text="Notas" Width="84px" />
            </asp:Panel>
            </asp:Panel>
     <asp:Panel ID="formPanel" Visible="false" runat="server">
         &nbsp;<br>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Label ID="IdLbl" runat="server" Text="Id: "></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;
         <asp:TextBox ID="IdTxt" runat="server" Height="22px" Width="128px"></asp:TextBox>
        <br>
         <asp:Label ID="añoCalLbl" runat="server" Text="Año calendario: "></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;
         <asp:TextBox ID="añocalTxt" runat="server"></asp:TextBox>
        <br>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="CupoLbl" runat="server" Text="Cupo: "></asp:Label>
         &nbsp;
         <asp:TextBox ID="CupoTxt" runat="server"></asp:TextBox>
         <br />
         <br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Label ID="ComisionLbl" runat="server" Text="Comision: "></asp:Label>
         &nbsp;
<asp:DropDownList ID="idComi" runat="server" DataSourceID="objectcomision" DataTextField="Descripcion" DataValueField="ID"></asp:DropDownList>
        <asp:ObjectDataSource ID="objectcomision" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.ComisionLogic"></asp:ObjectDataSource>
         <br />           
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
             <asp:Label ID="MateLbl" runat="server" Text="Materia: "></asp:Label>
            &nbsp;
            <asp:DropDownList ID="idMate" runat="server" DataSourceID="objectmateria" DataTextField="Descripcion" DataValueField="ID"></asp:DropDownList>
        <asp:ObjectDataSource ID="objectmateria" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.MateriaLogic"></asp:ObjectDataSource>
         <asp:Panel runat="server" Descripcion="formActionsPanel">
             <br>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="btnAceptar" runat="server" BackColor="#CCFFFF" OnClick="btnAceptar_Click" Text="Aceptar" Width="84px" />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" Width="84px" />
             <br />
         </asp:Panel>
      
        </asp:Panel>  
                 </div>










</asp:Content>
