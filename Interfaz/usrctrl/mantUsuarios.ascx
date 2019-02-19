<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="mantUsuarios.ascx.cs" Inherits="SitioInterfaz.usrctrl.mantUsuarios" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<style type="text/css">
    .style1
    {
        width: 100%;
        
    }
    
    .style2
    {
        width: auto;
        margin-left: 5px;    
    }
    
</style>
<asp:Panel ID="pnlData" runat="server" Visible="False">
            
<div style="padding: 5px;">
<table cellpadding="0" cellspacing="0" class="style1" style="border: solid 1px #25a0da" >
    <tr>
        <td style=" background-color:#25a0da;color: White;padding: 5px;">
            DETALLE USUARIO</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
                <table cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td>
                            <table cellpadding="0" cellspacing="0" class="style2">
                                <tr>
                                    <td width="150">
                                        Usuario</td>
                                    <td width="10">
                                        &nbsp;</td>
                                    <td width="150">
                                        ABAN8</td>
                                    <td width="10">
                                        &nbsp;</td>
                                    <td width="150">
                                        Módulo</td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        &nbsp;</td>
                                    <td width="150">
                                        Contraseña</td>
                                    <td width="10">
                                        &nbsp;</td>

                                </tr>
                                <tr>
                                    <td>
                                        <telerik:RadTextBox ID="txtUsuario" Runat="server" 
                                            Enabled="<%# (Container is GridEditFormInsertItem) ? true : false %>" 
                                            Skin="Metro" style="top: 0px; left: 0px; height: 20px;" 
                                            Text='<%# Bind("Usuario") %>' Width="150px">
                                        </telerik:RadTextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <telerik:RadNumericTextBox ID="txtABAN8" Runat="server" Skin="Metro"  
                                            style="top: 0px; left: 0px"  
                                            Text='<%# (Eval("ABAN8") is DBNull)?0:Eval("ABAN8")  %>' Width="100px">
                                        <NumberFormat DecimalDigits="0"  GroupSeparator="" />
                                        </telerik:RadNumericTextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td colspan="2">
                                        <telerik:RadComboBox ID="cboModulo" Runat="server" Culture="es-ES" 
                                            DataSourceID="ObjModulos" DataTextField="NombreModulo" DataValueField="CodModulo"
                                            SelectedValue='<%# Bind("CodModulo") %>' 
                                            Skin="Metro"  Width="250px" AllowCustomText="True" MarkFirstMatch="True">
                                        </telerik:RadComboBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <asp:TextBox ID="txtPass" runat="server" value='<%# Eval("Clave") %>' TextMode="Password"></asp:TextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>

                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <table cellpadding="0" cellspacing="0" class="style2">
                                <tr>
                                    <td width="400px">
                                        Pregunta</td>
                                    <td width="10">
                                        &nbsp;</td>
                                    <td width="10">
                                        &nbsp;</td>
                                    <td width="400px">
                                        Respuesta</td>
                                    <td width="10">
                                        &nbsp;</td>
                                    <td width="150">
                                        Activo</td>
                                    <td width="10">
                                        &nbsp;</td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <telerik:RadComboBox ID="cboPregunta" Runat="server" Culture="es-ES" 
                                            DataSourceID="objPregunta" DataTextField="Descripcion" 
                                            SelectedValue='<%# Bind("CodPregunta") %>' 
                                            DataValueField="CodPregunta" Skin="Metro"  Width="400px" 
                                            AllowCustomText="True" MarkFirstMatch="True">
                                        </telerik:RadComboBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td>
                                        <telerik:RadTextBox ID="txtRepuesta" Runat="server" Skin="Metro" 
                                            style="top: 0px; left: 0px" Text='<%# Bind("Respuesta") %>' Width="300px">
                                        </telerik:RadTextBox>
                                    </td>
                                    <td>
                                        &nbsp;</td>
                                    <td rowspan="2" width="150">
                                        <asp:CheckBox ID="chkActivo0" runat="server" 
                                            Checked='<%# (Eval("Activo") is DBNull)?false:Eval("Activo")  %>' 
                                             />
                                    </td>
                                    <td>
                                        &nbsp;</td>

                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
        </td>
    </tr>
    <tr>
        <td>
            
        </td>
    </tr>
    <tr>
        <td>

        </td>
    </tr>
    <tr>
        <td>&nbsp;&nbsp;<asp:Label ID="lblError" runat="server" Text="Label" 
                Visible="False" ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="border-top: solid 1px #ddd; text-align:center; height: 40px; background: #25a0da">
            <telerik:RadButton ID="RadButton1" runat="server" Text="Guardar" 
                style="top: 0px; left: 0px" Skin="Metro" CommandName='<%# (Container is GridEditFormInsertItem) ? "PerformInsert" : "Update" %>' >
            </telerik:RadButton>
            &nbsp;&nbsp;
            <telerik:RadButton ID="RadButton2" runat="server" Text="Cancelar" 
                style="top: 0px; left: 0px" Skin="Metro" CommandName="Cancel" 
                >
            </telerik:RadButton>
        </td>
    </tr>
    </table>
</div>
            </asp:Panel>

<div style="padding: 5px">
            <telerik:RadGrid ID="grDispositivos" runat="server" Skin="Metro" 
                AllowPaging="True" AutoGenerateColumns="False" CellSpacing="0" Culture="es-ES" 
                DataSourceID="objDispositivoAsignados" GridLines="None"
                OnDeleteCommand="grDispositivos_DeleteCommand"
                OnInsertCommand="grDispositivos_InsertCommand"
                OnUpdateCommand="grDispositivos_UpdateCommand" Visible="False">
<ClientSettings>
<Selecting CellSelectionMode="None"></Selecting>
</ClientSettings>

<MasterTableView CommandItemDisplay="Top" 
                    DataKeyNames="CodImei,CodImsi,CodAndroid,Usuario,CodAN8" 
                    DataSourceID="objDispositivoAsignados" 
                    NoMasterRecordsText="No se encontraron dispositivos.">
<CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Agregar Dispositivo" RefreshText="Refrescar Lista"></CommandItemSettings>

<RowIndicatorColumn Visible="True" FilterControlAltText="Filter RowIndicator column">
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn Visible="True" FilterControlAltText="Filter ExpandColumn column">
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>

    <Columns>
        <telerik:GridBoundColumn DataField="CodImei" 
            FilterControlAltText="Filter CodImei column" HeaderText="IMEI" ReadOnly="True" 
            SortExpression="CodImei" UniqueName="CodImei">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="CodImsi" 
            FilterControlAltText="Filter CodImsi column" HeaderText="IMSI" ReadOnly="True" 
            SortExpression="CodImsi" UniqueName="CodImsi">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="CodAndroid" 
            FilterControlAltText="Filter CodAndroid column" HeaderText="CodAndroid" 
            ReadOnly="True" SortExpression="CodAndroid" UniqueName="CodAndroid" 
            Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Usuario" 
            FilterControlAltText="Filter Usuario column" HeaderText="Usuario" 
            ReadOnly="True" SortExpression="Usuario" UniqueName="Usuario" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="CodAN8" DataType="System.Decimal" 
            FilterControlAltText="Filter CodAN8 column" HeaderText="CodAN8" ReadOnly="True" 
            SortExpression="CodAN8" UniqueName="CodAN8" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="UsuarioCreacion" 
            FilterControlAltText="Filter UsuarioCreacion column" 
            HeaderText="UsuarioCreacion" SortExpression="UsuarioCreacion" 
            UniqueName="UsuarioCreacion" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaCreacion" DataType="System.DateTime" 
            FilterControlAltText="Filter FechaCreacion column" HeaderText="FechaCreacion" 
            SortExpression="FechaCreacion" UniqueName="FechaCreacion" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="UsuarioModificacion" 
            FilterControlAltText="Filter UsuarioModificacion column" 
            HeaderText="UsuarioModificacion" SortExpression="UsuarioModificacion" 
            UniqueName="UsuarioModificacion" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="FechaModificacion" 
            DataType="System.DateTime" 
            FilterControlAltText="Filter FechaModificacion column" 
            HeaderText="FechaModificacion" SortExpression="FechaModificacion" 
            UniqueName="FechaModificacion" Visible="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Marca" 
            FilterControlAltText="Filter Marca column" HeaderText="Marca" 
            SortExpression="Marca" UniqueName="Marca">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="NumeroCelular" 
            FilterControlAltText="Filter NumeroCelular column" HeaderText="Número Celular" 
            SortExpression="NumeroCelular" UniqueName="NumeroCelular">
        </telerik:GridBoundColumn>
        <telerik:GridCheckBoxColumn DataField="Activo" DataType="System.Boolean" 
            FilterControlAltText="Filter Activo column" HeaderText="Activo" 
            SortExpression="Activo" UniqueName="Activo">
        </telerik:GridCheckBoxColumn>
        <telerik:GridEditCommandColumn ButtonType="ImageButton" 
            FilterControlAltText="Filter EditCommandColumn column">
        </telerik:GridEditCommandColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
            ConfirmDialogType="RadWindow" ConfirmText="Desea Eliminar el Dispositivo?" 
            FilterControlAltText="Filter DeleteColumn column" Resizable="False"  Text="Eliminar Registro"
            UniqueName="DeleteColumn" ImageUrl="~/Imagen/delete.ico" HeaderTooltip="Eliminar Registro">
        </telerik:GridButtonColumn>
    </Columns>

<EditFormSettings EditFormType="Template">
<EditColumn FilterControlAltText="Filter EditCommandColumn column"></EditColumn>
    <FormTemplate>
        <div style="padding: 10px;">
            <table cellpadding="0" cellspacing="0" width="100%" 
                style="border: solid 1px #25a0da">
                <tr>
                    <td style=" background-color:#25a0da;color: White;padding: 5px;">
                        DETALLE DISPOSITIVO</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp; Dispositivo</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;
                        <telerik:RadComboBox ID="cboDisp" Runat="server" Culture="es-ES" 
                            DataSourceID="objDispositivoNoAsignados" DataTextField="Modelo" DataValueField="Imei" 
                            SelectedValue='<%# Bind("CodImei") %>' Skin="Metro" Width="300px" AllowCustomText="True" MarkFirstMatch="True"
                            Enabled="<%# (Container is GridEditFormInsertItem) ? true : false %>" >
                        </telerik:RadComboBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;&nbsp;
                        <asp:CheckBox ID="chkActivo" runat="server" 
                            Checked='<%# (Eval("Activo") is DBNull)?false:Eval("Activo")  %>' 
                            Text="Activo" />
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td style="border-top: solid 1px #ddd; text-align: center; height: 40px; background: #25a0da">
                        <telerik:RadButton ID="RadButton3" runat="server" 
                            CommandName='<%# (Container is GridEditFormInsertItem) ? "PerformInsert" : "Update" %>' 
                            Skin="Metro" style="top: 0px; left: 0px" Text="Guardar">
                        </telerik:RadButton>
                        &nbsp;&nbsp;
                        <telerik:RadButton ID="RadButton4" runat="server" CommandName="Cancel" 
                            Skin="Metro" style="top: 0px; left: 0px" Text="Cancelar">
                        </telerik:RadButton>
                    </td>
                </tr>
            </table>
        </div>
    </FormTemplate>
</EditFormSettings>
</MasterTableView>

<FilterMenu EnableImageSprites="False"></FilterMenu>
            </telerik:RadGrid>
            </div>

            <div style="padding: 5px">
                <asp:Panel ID="pnlPermisos" runat="server" Visible="False">
                    <telerik:RadGrid ID="grPermisos" runat="server" Skin="Metro" 
                AllowPaging="True" AutoGenerateColumns="False" CellSpacing="0" Culture="es-ES" 
                 GridLines="None"
                OnDeleteCommand="grPermisos_DeleteCommand"
                OnInsertCommand="grPermisos_InsertCommand"
                OnUpdateCommand="grPermisos_UpdateCommand">
                        <ClientSettings>
                            <Selecting CellSelectionMode="None">
                            </Selecting>
                        </ClientSettings>
                        <MasterTableView CommandItemDisplay="Top" 
                    DataKeyNames="CodPermiso" 
                    NoMasterRecordsText="No se encontraron permisos.">
                            <CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Agregar Permisos" RefreshText="Refrescar Lista">
                            </CommandItemSettings>
                            <RowIndicatorColumn Visible="True" 
        FilterControlAltText="Filter RowIndicator column">
                            </RowIndicatorColumn>
                            <ExpandCollapseColumn Visible="True" 
        FilterControlAltText="Filter ExpandColumn column">
                            </ExpandCollapseColumn>
                            <Columns>
                                <telerik:GridBoundColumn DataField="CodPermiso" 
            FilterControlAltText="Filter CodPermiso column" HeaderText="CodPermiso" ReadOnly="True" 
            SortExpression="CodPermiso" UniqueName="CodPermiso" DataType="System.Int32" Visible="False">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="Rol" 
            FilterControlAltText="Filter Rol column" 
            HeaderText="Rol" SortExpression="Rol" 
            UniqueName="Rol">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="Accion" 
            FilterControlAltText="Filter Accion column" 
            HeaderText="Accion" SortExpression="Accion" 
            UniqueName="Accion">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="NombreFrm" 
            FilterControlAltText="Filter NombreFrm column" HeaderText="NombreFrm" 
            SortExpression="NombreFrm" UniqueName="NombreFrm">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="CodRol" DataType="System.Int32" 
                                    FilterControlAltText="Filter CodRol column" HeaderText="CodRol" 
                                    SortExpression="CodRol" UniqueName="CodRol" Visible="False">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="CodAccion" DataType="System.Int32" 
                                    FilterControlAltText="Filter CodAccion column" HeaderText="CodAccion" 
                                    SortExpression="CodAccion" UniqueName="CodAccion" Visible="False">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="CodObjeto" DataType="System.Int32" 
                                    FilterControlAltText="Filter CodObjeto column" HeaderText="CodObjeto" 
                                    SortExpression="CodObjeto" UniqueName="CodObjeto" Visible="False">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="UsuarioAsignacion" 
                                    FilterControlAltText="Filter UsuarioAsignacion column" 
                                    HeaderText="UsuarioAsignacion" SortExpression="UsuarioAsignacion" 
                                    UniqueName="UsuarioAsignacion" Visible="False">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="FechaAsignacion" DataType="System.DateTime" 
                                    FilterControlAltText="Filter FechaAsignacion column" 
                                    HeaderText="FechaAsignacion" SortExpression="FechaAsignacion" 
                                    UniqueName="FechaAsignacion" Visible="False">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="UrlAccion" 
                                    FilterControlAltText="Filter UrlAccion column" HeaderText="UrlAccion" 
                                    SortExpression="UrlAccion" UniqueName="UrlAccion">
                                </telerik:GridBoundColumn>
                                <telerik:GridCheckBoxColumn DataField="EsInclusiva" DataType="System.Boolean" 
                                    FilterControlAltText="Filter EsInclusiva column" HeaderText="EsInclusiva" 
                                    SortExpression="EsInclusiva" UniqueName="EsInclusiva">
                                </telerik:GridCheckBoxColumn>
                                <telerik:GridCheckBoxColumn DataField="Activo" DataType="System.Boolean" 
                                    FilterControlAltText="Filter Activo column" HeaderText="Activo" 
                                    SortExpression="Activo" UniqueName="Activo">
                                </telerik:GridCheckBoxColumn>
                                <telerik:GridEditCommandColumn ButtonType="ImageButton" 
                                    FilterControlAltText="Filter EditCommandColumn column">
                                </telerik:GridEditCommandColumn>
                                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                    ConfirmDialogType="RadWindow" ConfirmText="Desea Eliminar el Permiso?" 
                                    FilterControlAltText="Filter DeleteColumn column" Resizable="False" 
                                    UniqueName="DeleteColumn" ImageUrl="~/Imagen/delete.ico" Text="Eliminar Registro">
                                </telerik:GridButtonColumn>
                            </Columns>
                            <EditFormSettings EditFormType="Template">
                                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                </EditColumn>
                                <FormTemplate>
                                    <div style="padding: 10px;">
                                        <table cellpadding="0" cellspacing="0" class="style1" 
                                            style="border: solid 1px #25a0da">
                                            <tr>
                                                <td style=" background-color:#25a0da;color: White;padding: 5px;">
                                                    DETALLE PERMISO</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <table cellpadding="0" cellspacing="0" class="style1">
                                                        <tr>
                                                            <td>
                                                                <table cellpadding="0" cellspacing="0" class="style2">
                                                                    <tr>
                                                                        <td width="150">
                                                                            Rol</td>
                                                                        <td width="10">
                                                                            &nbsp;</td>
                                                                        <td width="150">
                                                                            Acción</td>
                                                                        <td width="10">
                                                                            &nbsp;</td>
                                                                        <td width="150">
                                                                            Objeto</td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <telerik:RadComboBox ID="cboRol" Runat="server" Culture="es-ES" 
                                                                                DataSourceID="sdRol" DataTextField="NombreRol" 
                                                                                DataValueField="CodRol" Skin="Metro" Width="150px"
                                                                                SelectedValue='<%# Bind("CodRol") %>' AllowCustomText="True" MarkFirstMatch="True">
                                                                            </telerik:RadComboBox>
                                                                        </td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                        <td>
                                                                            <telerik:RadComboBox ID="cboAccion" Runat="server" Culture="es-ES" 
                                                                                DataSourceID="sdAccion" DataTextField="Accion" 
                                                                                DataValueField="CodAccion" Skin="Metro" Width="150px"
                                                                                SelectedValue='<%# Bind("CodAccion") %>' AllowCustomText="True" MarkFirstMatch="True">
                                                                            </telerik:RadComboBox>
                                                                        </td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                        <td>
                                                                            <telerik:RadComboBox ID="cboObjecto" Runat="server" Culture="es-ES" 
                                                                                DataSourceID="ObjModulos" DataTextField="NomObjeto" DataValueField="CodObjeto" 
                                                                                Skin="Metro" Width="150px"
                                                                                SelectedValue='<%# Bind("CodObjeto") %>' AllowCustomText="True" MarkFirstMatch="True">
                                                                            
                                                                            </telerik:RadComboBox>
                                                                        </td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <table cellpadding="0" cellspacing="0" class="style2">
                                                                    <tr>
                                                                        <td width="150">
                                                                            Url Acción</td>
                                                                        <td width="10">
                                                                            &nbsp;</td>
                                                                        <td rowspan="2" width="150">
                                                                            <asp:CheckBox ID="chkInclusiva" runat="server" 
                                                                                Checked='<%# (Eval("EsInclusiva") is DBNull)?false:Eval("EsInclusiva")  %>' 
                                                                                Text="Es Inclusiva" />
                                                                        </td>
                                                                        <td width="10">
                                                                            &nbsp;</td>
                                                                        <td rowspan="2" width="150">
                                                                            <asp:CheckBox ID="chkActivo" runat="server" 
                                                                                Checked='<%# (Eval("Activo") is DBNull)?false:Eval("Activo")  %>' 
                                                                                Text="Activo" />
                                                                        </td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <telerik:RadTextBox ID="txtUrlAccion" Runat="server" Skin="Metro" 
                                                                                style="top: 0px; left: 0px" Text='<%# Bind("UrlAccion") %>' Width="150px">
                                                                            </telerik:RadTextBox>
                                                                        </td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;&nbsp;<asp:Label ID="lblError" runat="server" ForeColor="Red" Text="Label" 
                                                        Visible="False"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="border-top: solid 1px #ddd; text-align: center; height: 40px; background: #25a0da">
                                                    <telerik:RadButton ID="RadButton1" runat="server" 
                                                        CommandName='<%# (Container is GridEditFormInsertItem) ? "PerformInsert" : "Update" %>' 
                                                        Skin="Metro" style="top: 0px; left: 0px" Text="Guardar">
                                                    </telerik:RadButton>
                                                    &nbsp;&nbsp;
                                                    <telerik:RadButton ID="RadButton2" runat="server" CommandName="Cancel" 
                                                        Skin="Metro" style="top: 0px; left: 0px" Text="Cancelar">
                                                    </telerik:RadButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </FormTemplate>
                            </EditFormSettings>
                        </MasterTableView>
                        <FilterMenu EnableImageSprites="False">
                        </FilterMenu>
                    </telerik:RadGrid>
                </asp:Panel>
            </div>

            <div style="padding: 5px">
                <asp:Panel ID="pnlRoles" runat="server" Visible="False">
                    <telerik:RadGrid ID="grRoles" runat="server" Skin="Metro" 
                AllowPaging="True" AutoGenerateColumns="False" CellSpacing="0" Culture="es-ES" 
                DataSourceID="objRolesAsignados" GridLines="None"
                OnInsertCommand="grRoles_InsertCommand"
                AllowAutomaticDeletes="True">
                        <ClientSettings>
                            <Selecting CellSelectionMode="None">
                            </Selecting>
                        </ClientSettings>
                        <MasterTableView CommandItemDisplay="Top" 
                    DataKeyNames="CodRol,Usuario" 
                    DataSourceID="objRolesAsignados" 
                    NoMasterRecordsText="No se encontraron roles.">
                            <CommandItemSettings ExportToPdfText="Export to PDF" 
        AddNewRecordText="Agregar Roles" RefreshText="Refrescar Lista">
                            </CommandItemSettings>
                            <RowIndicatorColumn Visible="True" 
        FilterControlAltText="Filter RowIndicator column">
                            </RowIndicatorColumn>
                            <ExpandCollapseColumn Visible="True" 
        FilterControlAltText="Filter ExpandColumn column">
                            </ExpandCollapseColumn>
                            <Columns>
                                <telerik:GridBoundColumn DataField="CodRol" 
                                    FilterControlAltText="Filter CodRol column" HeaderText="CodRol" SortExpression="CodRol" 
                                    UniqueName="CodRol" DataType="System.Int32" ReadOnly="True" 
                                    Visible="False">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="Usuario" 
                                    FilterControlAltText="Filter Usuario column" HeaderText="Usuario" ReadOnly="True" 
                                    SortExpression="Usuario" UniqueName="Usuario" Visible="False">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="AN8" 
                                    FilterControlAltText="Filter AN8 column" HeaderText="AN8" 
                                    SortExpression="AN8" UniqueName="AN8" Visible="False" DataType="System.Decimal">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="UsuarioCreacion" 
                                    FilterControlAltText="Filter UsuarioCreacion column" 
                                    HeaderText="UsuarioCreacion" SortExpression="UsuarioCreacion" 
                                    UniqueName="UsuarioCreacion" Visible="False">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="FechaCreacion" 
                                    FilterControlAltText="Filter FechaCreacion column" 
                                    HeaderText="FechaCreacion" SortExpression="FechaCreacion" 
                                    UniqueName="FechaCreacion" Visible="False" DataType="System.DateTime">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="UsuarioModificacion" 
                                    FilterControlAltText="Filter UsuarioModificacion column" HeaderText="UsuarioModificacion" 
                                    SortExpression="UsuarioModificacion" UniqueName="UsuarioModificacion" 
                                    Visible="False">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="FechaModificacion" 
                                    FilterControlAltText="Filter FechaModificacion column" 
                                    HeaderText="FechaModificacion" SortExpression="FechaModificacion" 
                                    UniqueName="FechaModificacion" Visible="False" DataType="System.DateTime">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="NombreRol" 
                                    FilterControlAltText="Filter Rol column" 
                                    HeaderText="Rol" SortExpression="NombreRol" 
                                    UniqueName="NombreRol">
                                </telerik:GridBoundColumn>
                                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                    ConfirmDialogType="RadWindow" ConfirmText="Desea Eliminar el Rol?" 
                                    FilterControlAltText="Filter DeleteColumn column" Resizable="False" 
                                    UniqueName="DeleteColumn" ImageUrl="~/Imagen/delete.ico" Text="Eliminar Registro">
                                </telerik:GridButtonColumn>
                                  
                            </Columns>
                            <EditFormSettings EditFormType="Template">
                                <EditColumn FilterControlAltText="Filter EditCommandColumn column">
                                </EditColumn>
                                <FormTemplate>
                                    <div style="padding: 10px;">
                                        <table cellpadding="0" cellspacing="0" class="style1" 
                                            style="border: solid 1px #25a0da">
                                            <tr>
                                                <td style=" background-color:#25a0da;color: White;padding: 5px;">
                                                    DETALLE ROL</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <table cellpadding="0" cellspacing="0" class="style1">
                                                        <tr>
                                                            <td>
                                                                <table cellpadding="0" cellspacing="0" class="style2">
                                                                    <tr>
                                                                        <td width="150">
                                                                            Rol</td>
                                                                        <td width="10">
                                                                            &nbsp;</td>
                                                                        <td width="10">
                                                                            &nbsp;</td>
                                                                        <td width="150">
                                                                            &nbsp;</td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <telerik:RadComboBox ID="cboRol0" Runat="server" Culture="es-ES" 
                                                                                DataSourceID="objRolesNoAsignados" DataTextField="NombreRol" 
                                                                                DataValueField="CodRol" Skin="Metro" Width="150px"
                                                                                SelectedValue='<%# Bind("CodRol") %>' AllowCustomText="True" MarkFirstMatch="True">
                                                                            </telerik:RadComboBox>
                                                                        </td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                &nbsp;</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;&nbsp;<asp:Label ID="lblError0" runat="server" ForeColor="Red" Text="Label" 
                                                        Visible="False"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="border-top: solid 1px #ddd; text-align: center; height: 40px; background: #25a0da">
                                                    <telerik:RadButton ID="RadButton5" runat="server" 
                                                        CommandName='<%# (Container is GridEditFormInsertItem) ? "PerformInsert" : "Update" %>' 
                                                        Skin="Metro" style="top: 0px; left: 0px" Text="Guardar">
                                                    </telerik:RadButton>
                                                    &nbsp;&nbsp;
                                                    <telerik:RadButton ID="RadButton6" runat="server" CommandName="Cancel" 
                                                        Skin="Metro" style="top: 0px; left: 0px" Text="Cancelar">
                                                    </telerik:RadButton>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                </FormTemplate>
                            </EditFormSettings>
                        </MasterTableView>
                        <FilterMenu EnableImageSprites="False">
                        </FilterMenu>
                    </telerik:RadGrid>
                </asp:Panel>
            </div>



<asp:ObjectDataSource ID="ObjModulos" runat="server" 
    SelectMethod="ConsultaModulos" 
    TypeName="Negocio.SNModulo">
</asp:ObjectDataSource>


<asp:ObjectDataSource ID="objPregunta" runat="server" 
    SelectMethod="ConsultaPreguntas" 
    TypeName="Negocio.SNPregunta">
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="objDispositivoAsignados" runat="server" 
    SelectMethod="ConsultarDispistivosAsigadoAUsuario" 
    TypeName="Negocio.SNAsignarDispositivos">
    <SelectParameters>
        <asp:ControlParameter ControlID="txtUsuario" Name="Usuario" PropertyName="Text" 
            Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>


<asp:ObjectDataSource ID="objDispositivoNoAsignados" runat="server" 
    SelectMethod="ConsultarDispistivosActivosNoAsignado" 
    TypeName="Negocio.SNAsignarDispositivos">
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="objRolesNoAsignados" runat="server" 
    SelectMethod="ConsultarRolesNoAsignadosXUsuario" 
    TypeName="Negocio.SNRoles">
    <SelectParameters>
        <asp:ControlParameter ControlID="txtUsuario" Name="Usuario" PropertyName="Text" 
            Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>

<asp:ObjectDataSource ID="objRolesAsignados" runat="server" 
    DeleteMethod="EliminaRolAsignado" SelectMethod="ConsultarRolesXUsuarioDT" 
    TypeName="Negocio.SNRoles">
    <DeleteParameters>
        <asp:Parameter Name="CodRol" Type="Int32" />
        <asp:Parameter Name="Usuario" Type="String" />
        <asp:Parameter Name="UsuarioElimina" Type="String" />
        <asp:Parameter Name="pvsNombrePagina" Type="String" />
    </DeleteParameters>
    <SelectParameters>
        <asp:ControlParameter ControlID="txtUsuario" Name="Usuario" PropertyName="Text" 
            Type="String" />
    </SelectParameters>
</asp:ObjectDataSource>
