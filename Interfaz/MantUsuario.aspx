<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="MantUsuario.aspx.cs" Inherits="SitioInterfaz.Seguridad" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="0" cellspacing="0" class="style1" align="center" width="95%">
        <tr >
            <td >
            <asp:Label ID="lblError" runat="server" Text="" Font-Bold="true" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style=" background-color:#25a0da;color: White;padding: 5px;">MANTENIMIENTO DE 
                USUARIOS</td>
        </tr>
        <tr>
            <td>
                <telerik:RadGrid ID="grUsuarios" runat="server" AutoGenerateColumns="False" 
                    CellSpacing="0" Culture="es-ES" GridLines="None" Skin="Office2010Blue" 
                    DataSourceID="odUsuarios" Width="100%"
                    OnItemCreated="grUsuarios_ItemCreated" 
                    OnItemCommand="grUsuarios_ItemCommand"
                    OnSelectedIndexChanged="grUsuarios_SelectedIndexChanged"
                    OnInsertCommand="grUsuarios_InsertCommand" 
                    OnUpdateCommand="grUsuarios_UpdateCommand" 
                    OnDeleteCommand="grUsuarios_DeleteCommand" 
                     AllowFilteringByColumn="true"
                    style="margin-right: 0px" PageSize="7" AllowPaging="True">
                    <PagerStyle FirstPageToolTip="Primera página" LastPageToolTip="Ultima página" 
                                    Mode="NextPrevAndNumeric" NextPageToolTip="Próxima página" 
                                    PageSizeLabelText="Tamaño página" PrevPageToolTip="Página anterior" />
            <GroupingSettings CaseSensitive="false" />
            <ClientSettings EnableRowHoverStyle="true">
            <Selecting CellSelectionMode="None" AllowRowSelect="True"></Selecting>
            </ClientSettings>
<MasterTableView DataSourceID="odUsuarios" DataKeyNames="Usuario"
                        CommandItemDisplay="Top" 
                        NoMasterRecordsText="No hay registros de usuarios.">
<CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Agregar Usuario" RefreshText="Refrescar Lista"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridEditCommandColumn ButtonType="ImageButton"
            FilterControlAltText="Filter EditCommandColumn column" 
            EditText="Editar Usuario">
            <HeaderStyle Width="30px" />
        </telerik:GridEditCommandColumn>
       <telerik:GridTemplateColumn UniqueName="AsignaMovil" AllowFiltering="false">
            <ItemTemplate>
              <asp:ImageButton ID="ImageButton2" runat="server" CommandName="Select" ToolTip="Asignar Moviles" 
                ImageUrl="~/Imagen/cell.png" />
            </ItemTemplate>
            <HeaderStyle Width="30px" />
      </telerik:GridTemplateColumn>
      <telerik:GridTemplateColumn UniqueName="AsignaRol" AllowFiltering="false">
            <ItemTemplate>
              <asp:ImageButton ID="ImageButton4" runat="server" CommandName="Rol" ToolTip="Establecer Roles"
                ImageUrl="~/Imagen/rol.png" />
            </ItemTemplate>
            <HeaderStyle Width="30px" />
      </telerik:GridTemplateColumn>
       <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            ConfirmDialogType="RadWindow" ConfirmText="Desea Eliminar el Usuario?" 
            FilterControlAltText="Filter DeleteColumn column" Resizable="False"  Text="Eliminar Registro"
            UniqueName="DeleteColumn" ImageUrl="~/Imagen/delete.ico">
             <HeaderStyle Width="30px" />
        </telerik:GridButtonColumn> 
        <telerik:GridBoundColumn DataField="Usuario"  FilterControlWidth="100%"
            FilterControlAltText="Filter Usuario column" HeaderText="Usuario" ReadOnly="True" 
            SortExpression="Usuario" UniqueName="Usuario" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains" 
            ShowFilterIcon="false">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="ABAN8" FilterControlWidth="100%"
            FilterControlAltText="Filter ABAN8 column" HeaderText="ABAN8" 
            SortExpression="ABAN8" UniqueName="ABAN8" DataType="System.Int64"
            AutoPostBackOnFilter="true" CurrentFilterFunction="EqualTo" 
            ShowFilterIcon="false">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="CodModulo" DataType="System.Int32" 
            FilterControlAltText="Filter CodModulo column" HeaderText="CodModulo" SortExpression="CodModulo" 
            UniqueName="CodModulo" Visible="False"
            AutoPostBackOnFilter="true" CurrentFilterFunction="EqualTo" 
            ShowFilterIcon="false">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Clave" 
            FilterControlAltText="Filter Clave column" HeaderText="Clave" 
            SortExpression="Clave" UniqueName="Clave" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Descripcion" FilterControlWidth="100%"
            FilterControlAltText="Filter Descripcion column" HeaderText="Pregunta" 
            SortExpression="Descripcion" UniqueName="Descripcion" AutoPostBackOnFilter="true" CurrentFilterFunction="Contains" 
                            ShowFilterIcon="false">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Respuesta" 
            FilterControlAltText="Filter Respuesta column" HeaderText="Respuesta" 
            SortExpression="Respuesta" UniqueName="Respuesta" Visible="false">
        </telerik:GridBoundColumn>
        <telerik:GridCheckBoxColumn DataField="Activo" DataType="System.Boolean" 
            FilterControlAltText="Filter Activo column" HeaderText="Activo" 
            SortExpression="Activo" UniqueName="Activo" AutoPostBackOnFilter="true" CurrentFilterFunction="EqualTo" 
                            ShowFilterIcon="false">
        </telerik:GridCheckBoxColumn>
        <telerik:GridBoundColumn DataField="CodPregunta" DataType="System.Int32" 
            FilterControlAltText="Filter CodPregunta column" HeaderText="CodPregunta" 
            SortExpression="CodPregunta" UniqueName="CodPregunta" Visible="False">
        </telerik:GridBoundColumn>

    </Columns>

 <EditFormSettings ColumnNumber="2" 
        EditFormType="WebUserControl" UserControlName="usrctrl/mantUsuarios.ascx">
                <FormTableItemStyle Wrap="False"></FormTableItemStyle>
                <FormCaptionStyle CssClass="EditFormHeader" BackColor="#0066FF" 
                    ForeColor="White"></FormCaptionStyle>
                <FormMainTableStyle GridLines="None" CellSpacing="0" CellPadding="3"
                    Width="100%" BackColor="#CCFFFF"></FormMainTableStyle>
                <FormTableStyle CellSpacing="0" CellPadding="2" Height="110px"></FormTableStyle>
                <FormTableAlternatingItemStyle Wrap="False"></FormTableAlternatingItemStyle>
                <EditColumn ButtonType="ImageButton" InsertText="Agregar" UpdateText="Actualizar"
                    UniqueName="EditCommandColumn1" CancelText="Cancelar">
                </EditColumn>
                <FormTableButtonRowStyle HorizontalAlign="Right" CssClass="EditFormButtonRow"></FormTableButtonRowStyle>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>
                </telerik:RadGrid>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:ObjectDataSource ID="odUsuarios" runat="server" SelectMethod="ConsultaUsuarios" 
                                TypeName="Negocio.SNUsuario">
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadAjaxManagerProxy ID="RadAjaxManagerProxy1" runat="server">
                    <AjaxSettings>
                        <telerik:AjaxSetting AjaxControlID="grUsuarios">
                            <UpdatedControls>
                                <telerik:AjaxUpdatedControl ControlID="grUsuarios" 
                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                                <telerik:AjaxUpdatedControl ControlID="lblError" 
                                    LoadingPanelID="RadAjaxLoadingPanel1" />
                            </UpdatedControls>
                        </telerik:AjaxSetting>
                    </AjaxSettings>
                </telerik:RadAjaxManagerProxy>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" Runat="server" 
                    Skin="Metro">
                </telerik:RadAjaxLoadingPanel>
            </td>
        </tr>
    </table>

</asp:Content>