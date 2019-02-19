<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPrincipal.Master" AutoEventWireup="true" CodeBehind="frmUsuario.aspx.cs" Inherits="SitioInterfaz.frmUsuario" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <telerik:RadStyleSheetManager ID="RadStyleSheetManager1" runat="server">
    </telerik:RadStyleSheetManager>
 
<telerik:RadScriptManager ID="RadScriptManager1" runat="server">
</telerik:RadScriptManager>
<telerik:RadSkinManager ID="RadSkinManager1" runat="server" Skin="Office2010Blue" ShowChooser="false">
</telerik:RadSkinManager>
<telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    <AjaxSettings>
        <telerik:AjaxSetting AjaxControlID="RadGrid1">
            <UpdatedControls>
                <telerik:AjaxUpdatedControl ControlID="RadGrid1" />
            </UpdatedControls>
        </telerik:AjaxSetting>
    </AjaxSettings>
</telerik:RadAjaxManager>
<table width="100%">
                    <th style=" background-color:#25a0da; height:100%; text-align:center; ">
                        <font color="white"><font size="small">Mantenimiento de Usuarios</font></font>
                    </th>
                    <tr style="width:100%">
                        <td style="width:100%">
                                <telerik:RadGrid ID="RadGrid1" runat="server" AllowPaging="True" CellSpacing="0"  
                                        GridLines="None" Skin="Office2010Blue" DataSourceID="ObjectDataSource1" 
                                        onitemupdated="RadGrid1_ItemUpdated" AutoGenerateColumns="False" 
                                    PageSize="5" onupdatecommand="RadGrid1_UpdateCommand">
                                <PagerStyle FirstPageToolTip="Primera página" LastPageToolTip="Ultima página" 
                                    Mode="NextPrevAndNumeric" NextPageToolTip="Próxima página" 
                                    PageSizeLabelText="Tamaño página" PrevPageToolTip="Página anterior" />
                                <ClientSettings EnableRowHoverStyle="true">
                                    <Selecting AllowRowSelect="true" />
                                </ClientSettings>
                                <MasterTableView DataSourceID="ObjectDataSource1"  CommandItemDisplay="Top" AllowAutomaticInserts="True" 
                                        AllowAutomaticUpdates="True" AllowSorting="True" DataKeyNames="Usuario"
                                        ShowFooter="True" >
                                <CommandItemSettings AddNewRecordText="Agregar Usuario" 
                                        RefreshText="Refrescar" />
                                <RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
                                <HeaderStyle Width="20px"></HeaderStyle>
                                </RowIndicatorColumn>

                                    <Columns>
                                        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Roles" 
                                            FilterControlAltText="Rol" HeaderText="Roles" 
                                            ImageUrl="Imagenes/role_icon.png" UniqueName="column1">
                                            <HeaderStyle Width="20px" />
                                        </telerik:GridButtonColumn>
                                        <telerik:GridEditCommandColumn ButtonType="ImageButton" HeaderText="Modificar">
                                            <HeaderStyle Width="25px" />
                                            <ItemStyle CssClass="MyImageButton" />
                                        </telerik:GridEditCommandColumn>
                                        <telerik:GridBoundColumn DataField="Usuario" HeaderText="Usuario" 
                                            SortExpression="Usuario" UniqueName="Usuario">
                                            <HeaderStyle Width="20px" />
                                            <FilterTemplate>
                                                <telerik:RadComboBox ID="rcmbUsurio" runat="server" AppendDataBoundItems="true" 
                                                    DataSourceID="ObjectDataSource5" DataTextField="Usuario" 
                                                    DataValueField="Usuario" Height="200px" 
                                                    OnClientSelectedIndexChanged="UsuarioIndexChanged" 
                                                    SelectedValue='<%# ((GridItem)Container).OwnerTableView.GetColumn("Usuario").CurrentFilterValue %>'>
                                                    <Items>
                                                        <telerik:RadComboBoxItem Text="Todo" />
                                                    </Items>
                                                </telerik:RadComboBox>
                                                <telerik:RadScriptBlock ID="RadScriptBlock1" runat="server">
                                                    <script type="text/javascript">

                                                        function UsuarioIndexChanged(sender, args) {
                                                            var tableView = $find("<%# ((GridItem)Container).OwnerTableView.ClientID %>");
                                                            tableView.filter("Usuario", args.get_item().get_value(), "EqualTo");
                                                        }
                                                     </script>
                                                </telerik:RadScriptBlock>
                                            </FilterTemplate>
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="CodigoExterno" HeaderText="Código" 
                                            SortExpression="CodigoExterno" UniqueName="CodigoExterno">
                                            <FilterTemplate>
                                                <telerik:RadComboBox ID="rcmbCodigoExter" runat="server" AppendDataBoundItems="true" 
                                                    DataSourceID="ObjectDataSource5" DataTextField="CodigoExterno" DataValueField="CodigoExterno" 
                                                    Height="200px" OnClientSelectedIndexChanged="CodigoIndexChanged" 
                                                    SelectedValue='<%# ((GridItem)Container).OwnerTableView.GetColumn("CodigoExterno").CurrentFilterValue %>'>
                                                    <Items>
                                                        <telerik:RadComboBoxItem Text="Todo" />
                                                    </Items>
                                                </telerik:RadComboBox>
                                                <telerik:RadScriptBlock ID="RadScriptBlock2" runat="server">
                                                    <script type="text/javascript">

                                                        function CodigoIndexChanged(sender, args) {
                                                            var tableView = $find("<%# ((GridItem)Container).OwnerTableView.ClientID %>");
                                                            tableView.filter("CodigoExterno", args.get_item().get_value(), "EqualTo");
                                                        }
                                                     </script>
                                                </telerik:RadScriptBlock>
                                            </FilterTemplate>
                                        </telerik:GridBoundColumn>
                                        <telerik:GridTemplateColumn AllowFiltering="false" DataField="Clave" 
                                            HeaderText="Clave" SortExpression="Clave" UniqueName="Clave" Visible="false">
                                            <ItemTemplate>
                                                <asp:Label ID="lblClave" runat="server" Text='<%#Bind("Clave") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <telerik:RadTextBox ID="rgctxtClave1" Runat="server" 
                                                    Text='<%# Bind("Clave") %>' TextMode="Password">
                                                </telerik:RadTextBox>
                                            </EditItemTemplate>
                                        </telerik:GridTemplateColumn>
                                        <telerik:GridCheckBoxColumn DataField="Activo" HeaderText="Activo" 
                                            SortExpression="Activo" UniqueName="Activo">
                                            <HeaderStyle Width="50px" />
                                        </telerik:GridCheckBoxColumn>
                                        <telerik:GridDropDownColumn DataField="CodModulo" 
                                            DataSourceID="ObjectDataSource2" EditFormColumnIndex="1" HeaderText="Modulo" 
                                            ListTextField="Descripcion" ListValueField="CodModulo" UniqueName="CodModulo" 
                                            Visible="false">
                                        </telerik:GridDropDownColumn>
                                        <telerik:GridDropDownColumn DataField="CodPregunta" 
                                            DataSourceID="ObjectDataSource3" EditFormColumnIndex="1" HeaderText="Pregunta" 
                                            ListTextField="Descripcion" ListValueField="CodPregunta" 
                                            UniqueName="CodPregunta" Visible="false">
                                        </telerik:GridDropDownColumn>
                                        <telerik:GridBoundColumn DataField="Respuesta" EditFormColumnIndex="1" 
                                            HeaderText="Respuesta" SortExpression="Respuesta" UniqueName="Respuesta" 
                                            Visible="false">
                                        </telerik:GridBoundColumn>
                                    </Columns>
                                    <EditFormSettings CaptionDataField="Usuario" 
                                        CaptionFormatString="Actualizando Usuario: {0}" ColumnNumber="2" 
                                        EditColumn-EditText="Guardar" EditColumn-UpdateText="Guardar" 
                                        FormCaptionStyle-BackColor="#25a0da" FormCaptionStyle-CssClass="bold" 
                                        FormCaptionStyle-ForeColor="White" FormMainTableStyle-BackColor="#ECF0FB">
                                        <FormTableItemStyle Wrap="False" />
                                        <FormMainTableStyle CellPadding="3" CellSpacing="0" CssClass="editTable" 
                                            GridLines="Horizontal" Width="100%" />
                                        <FormTableStyle BorderColor="#0066FF" CellPadding="2" CellSpacing="0" 
                                            CssClass="module" Height="110px" />
                                        <FormCaptionStyle BackColor="#25A0DA" CssClass="bold" ForeColor="White"></FormCaptionStyle>
                                        <FormTableAlternatingItemStyle Wrap="False" />
                                        <EditColumn ButtonType="ImageButton" CancelText="Cancelar" 
                                            InsertText="Ingresar Usuario" UniqueName="EditCommandColumn1" 
                                            UpdateText="Guardar Registro">
                                        </EditColumn>
                                        <FormTemplate>
                                         <table align="center" style="border: thin solid #6699FF">
                                          <tr>
                                                <td>
                                                    <asp:Label ID="LblUsuario" runat="server" Text="Usuario:"></asp:Label>
                                                </td>
                                                <td>
                                                    <telerik:RadTextBox ID="rtxtUsuario" runat="server"  Text='<%# Bind("Usuario") %>'>
                                                    </telerik:RadTextBox>
                                                </td>
                                                <td>
                                                    <asp:Label ID="lblCodigo" runat="server" Text="Código:"></asp:Label>
                                                </td>
                                                <td>
                                                    <telerik:RadNumericTextBox ID="rtxtCodigoExterno" Runat="server" 
                                                        CausesValidation="True" Culture="Spanish (Nicaragua)" DataType="System.Int32" 
                                                        DbValue='<%# Bind("CodigoExterno") %>' 
                                                        EmptyMessage="Digite el numero de la marcacion" MaxValue="9999999" MinValue="1" 
                                                         Width="140px">
                                                        <numberformat decimaldigits="0" groupseparator="" />
                                                    </telerik:RadNumericTextBox>
                                                </td>
                                          </tr>
                                          <tr>
                                            <td>
                                                <asp:Label ID="lbl" runat="server" Text="Descripción:"></asp:Label>
                                            </td>
                                            <td>
                                                <telerik:RadTextBox ID="txtDescripcion" Runat="server" 
                                                    EmptyMessage="Digite la Descripción" Skin="Office2007" 
                                                    Text='<%# Bind("Descripcion") %>' Width="200px">
                                                </telerik:RadTextBox>
                                            </td>
                                            <td>
                                                <asp:Label ID="Label4" runat="server" Text="Abreviatura:"></asp:Label>
                                            </td>
                                            <td>
                                                <telerik:RadTextBox ID="txtAbr" Runat="server" 
                                                    EmptyMessage="Digite Abreviaciones" Skin="Office2007" Text='<%# Bind("Abr") %>' 
                                                    Width="200px">
                                                </telerik:RadTextBox>
                                            </td>
                        </tr>
                                          <tr>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="Tipo de Marcación:"></asp:Label>
                            </td>
                            <td>
                                <telerik:RadComboBox ID="cboTipo" Runat="server" 
                                    SelectedValue='<%# Bind("TipoMarcacion") %>' Skin="Office2007">
                                    <Items>
                                        <telerik:RadComboBoxItem runat="server" Text="MT" Value="MT" />
                                        <telerik:RadComboBoxItem runat="server" Text="MO" Value="MO" />
                                    </Items>
                                </telerik:RadComboBox>
                            </td>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text="Costo:"></asp:Label>
                            </td>
                            <td>
                                <telerik:RadNumericTextBox ID="txtcosto" Runat="server" CausesValidation="True" 
                                    Culture="Spanish (Nicaragua)" DataType="System.Decimal" 
                                    DbValue='<%# Bind("Costo") %>' 
                                    EmptyMessage="Digite el costo de la marcacion" MaxValue="9999999" MinValue="0" 
                                    Skin="Office2007" Width="140px">
                                    <numberformat allowrounding="False" decimaldigits="2" groupseparator="" />
                                </telerik:RadNumericTextBox>
                            </td>
                        </tr>
                                          <tr>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="IdRate:"></asp:Label>
                            </td>
                            <td>
                                <telerik:RadTextBox ID="txtIdRate" Runat="server" 
                                    EmptyMessage="Digite el IdRate" Skin="Office2007" 
                                    Text='<%# Bind("IdRate") %>' Width="200px">
                                </telerik:RadTextBox>
                            </td>
                            <td>
                                <asp:Label ID="Label8" runat="server" Text="Codigo de Cobro:"></asp:Label>
                            </td>
                            <td>
                                <telerik:RadTextBox ID="txtCodCobro" Runat="server" 
                                    EmptyMessage="Digite el Codigo de Cobro" Skin="Office2007" 
                                    Text='<%# Bind("CodCobro") %>' Width="200px">
                                </telerik:RadTextBox>
                            </td>
                        </tr>
                                          <tr>
                            <td>
                                <asp:Label ID="Label9" runat="server" Text="UserBeConnected:"></asp:Label>
                            </td>
                            <td>
                                <telerik:RadTextBox ID="txtUserBC" Runat="server" 
                                    EmptyMessage="Digite el nombre de usuario del BeConnected" Skin="Office2007" 
                                    Text='<%# Bind("UserBC") %>' Width="200px">
                                </telerik:RadTextBox>
                            </td>
                            <td>
                                <asp:Label ID="Label10" runat="server" Text="PassBeConnected:"></asp:Label>
                            </td>
                            <td>
                                <telerik:RadTextBox ID="txtPassBeConnected" Runat="server" 
                                    EmptyMessage="Digite contraseña del BeConnected" Skin="Office2007" 
                                    Text='<%# Bind("PassBC") %>' Width="200px">
                                </telerik:RadTextBox>
                            </td>
                        </tr>
                                          <tr>
                            <td>
                                <asp:Label ID="Label11" runat="server" Text="No. Conexion SMPP"></asp:Label>
                            </td>
                            <td>
                                <telerik:RadComboBox ID="cboCnxSmpp" Runat="server" DataSourceID="dsCnxSmpp" 
                                    DataTextField="NoConection" DataValueField="NoConection" Skin="Office2007" 
                                    SelectedValue='<%# DataBinder.Eval( Container, "DataItem.CnxSmpp" ) %>'>
                                </telerik:RadComboBox>
                            </td>
                            <td>
                                <asp:Label ID="Label12" runat="server" Text="TipoMO:"></asp:Label>
                            </td>
                            <td>
                                <telerik:RadComboBox ID="cboTipoMO" Runat="server" DataSourceID="dsTipoMO" 
                                    DataTextField="Descripcion" DataValueField="IdTipoMO" Skin="Office2007" 
                                    SelectedValue='<%# Bind("IdTipoMO") %>'>
                                </telerik:RadComboBox>
                            </td>
                        </tr>
                                        </table>
                                        </FormTemplate>
                                    </EditFormSettings>
                                </MasterTableView>

                                <FilterMenu EnableImageSprites="False"></FilterMenu>
                                </telerik:RadGrid>
                    </td>
               </tr>
    </table>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ConsultaUsuarios" 
        TypeName="SitioInterfaz.frmUsuario" 
        UpdateMethod="ActualizaUsuario" 
        OldValuesParameterFormatString="original_{0}" 
        InsertMethod="IngresaUsuario">
    <InsertParameters>
        <asp:Parameter Name="Usuario" Type="String" />
        <asp:Parameter Name="CodigoExterno" Type="String" />
        <asp:Parameter Name="CodModulo" Type="String" />
        <asp:Parameter Name="Clave" Type="String" />
        <asp:Parameter Name="Activo" Type="String" />
        <asp:Parameter Name="CodPregunta" Type="String" />
        <asp:Parameter Name="Respuesta" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Usuario" Type="String" />
        <asp:Parameter Name="CodigoExterno" Type="String" />
        <asp:Parameter Name="CodModulo" Type="String" />
        <asp:Parameter Name="Clave" Type="String" />
        <asp:Parameter Name="Activo" Type="String" />
        <asp:Parameter Name="CodPregunta" Type="String" />
        <asp:Parameter Name="Respuesta" Type="String" />
    </UpdateParameters>
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
        SelectMethod="ConsultaModulos" TypeName="Negocio.SNModulo">
    </asp:ObjectDataSource>
    <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" 
        SelectMethod="ConsultaPreguntas" TypeName="Negocio.SNPregunta">
    </asp:ObjectDataSource>

</asp:Content>
