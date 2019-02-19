using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using Negocio;
using Entidad;
using Utilidades;

namespace SitioInterfaz.usrctrl
{
    public partial class mantUsuarios : System.Web.UI.UserControl
    {
        ENAsignacionDispositivo objAsignacion = null;
        ENError objError = null;
        static string lsNombreMetodo = string.Empty;
        static string lsNombreClase = "mantUsuarios.aspx.cs";
        static string sPath = string.Empty; 

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void GuardarDispositivo(Boolean Edita, GridCommandEventArgs e)
        {
            String err = string.Empty;
            String IMEI = string.Empty;
            Boolean Activo = false;
            String UsuarioModIns = (String)Session["usuario"];

            try
            {
                sPath = HttpContext.Current.Request.Url.AbsolutePath;
                lsNombreClase = SUFunciones.ObtieneNombrePagina(sPath);
                IMEI = (e.Item.FindControl("cboDisp") != null ? (e.Item.FindControl("cboDisp") as RadComboBox).SelectedValue : string.Empty);
                Activo = (e.Item.FindControl("chkActivo") as CheckBox).Checked;
                UsuarioModIns = (Session["usuario"]!=null?Session["usuario"].ToString():string.Empty);

                objAsignacion = new ENAsignacionDispositivo();
                objAsignacion.CodImei = IMEI;
                objAsignacion.Activo = (SUConversiones.ConvierteAInt16(Activo==true?1:0));
                objAsignacion.Usuario = txtUsuario.Text;
                objAsignacion.UsuarioModificacion = UsuarioModIns;
                objAsignacion.UsuarioCreacion = UsuarioModIns;

                if (Edita)
                    SNAsignarDispositivos.RealizaAsignarDispositivo(objAsignacion, lsNombreClase);                  
                else
                {
                    SNAsignarDispositivos.RealizaAsignarDispositivo(objAsignacion, lsNombreClase);                  
                    if (!err.Trim().Equals(""))
                    {
                        lblError.Visible = true;
                        lblError.Text = err;
                        e.Canceled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                lblError.Text = ex.Message.ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString(),(Session["usuario"]!=null?Session["usuario"].ToString():string.Empty));
                SNError.IngresaError(objError);
                e.Canceled = true;
            }
        }

        protected void grDispositivos_InsertCommand(object sender, GridCommandEventArgs e)
        {
            try
            {
                GuardarDispositivo(false, e);
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                //lblError.Text = lsNombreMetodo + " - " + PrmMensajesSistema.MensajeError.ToString();
                lblError.Text = ex.Message.ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString(),(Session["usuario"]!=null?Session["usuario"].ToString():string.Empty));
                SNError.IngresaError(objError);
            }
        }

        protected void grDispositivos_DeleteCommand(object sender, GridCommandEventArgs e)
        {
            String IMEI = string.Empty;
            String Usuario = string.Empty;
            string UsuarioElimina = string.Empty;
            try
            {
                sPath = HttpContext.Current.Request.Url.AbsolutePath;
                lsNombreClase = SUFunciones.ObtieneNombrePagina(sPath);
                UsuarioElimina = (Session["usuario"]!=null?Session["usuario"].ToString():string.Empty);
                IMEI = e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["CodImei"].ToString();
                Usuario = e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["Usuario"].ToString();

                SNAsignarDispositivos.EliminaAsignacionDeDispositvoAUsuario(IMEI, Usuario, UsuarioElimina, lsNombreClase);
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                //lblError.Text = lsNombreMetodo + " - " + PrmMensajesSistema.MensajeError.ToString();
                lblError.Text = ex.Message.ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString(), (Session["usuario"] != null ? Session["usuario"].ToString() : string.Empty));
                SNError.IngresaError(objError);
            }

        }

        protected void grDispositivos_UpdateCommand(object sender, GridCommandEventArgs e)
        {
            try
            {
                GuardarDispositivo(true, e);
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                //lblError.Text = lsNombreMetodo + " - " + PrmMensajesSistema.MensajeError.ToString();
                lblError.Text = ex.Message.ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString(), (Session["usuario"] != null ? Session["usuario"].ToString() : string.Empty));
                SNError.IngresaError(objError);
            }
        }

        protected void grDispositivos_EditCommand(object sender, GridCommandEventArgs e)
        {

        }
        protected void grPermisos_DeleteCommand(object source, GridCommandEventArgs e)
        {
            //int Codigo = int.Parse(e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["CodPermiso"].ToString());
            //ProyectoJG.defPermiso.DeldefPermiso(Codigo);
        }

        protected void grPermisos_InsertCommand(object source, GridCommandEventArgs e)
        {
            //GuardarPemisos(false, e);
        }

        protected void grPermisos_UpdateCommand(object source, GridCommandEventArgs e)
        {
            //GuardarPemisos(true, e);
        }

        protected void grRoles_InsertCommand(object source, GridCommandEventArgs e)
        {
            int CodRol = 0;
            decimal AN8 = 0;
            String UsuarioModIns = string.Empty;
            try
            {
                sPath = HttpContext.Current.Request.Url.AbsolutePath;
                lsNombreClase = SUFunciones.ObtieneNombrePagina(sPath);

                CodRol = int.Parse((e.Item.FindControl("cboRol0") as RadComboBox).SelectedValue);
                AN8 = decimal.Parse(txtABAN8.Text.Trim());
                UsuarioModIns = (Session["usuario"]!=null?Session["usuario"].ToString():string.Empty);

                SNRoles.AsignarRolesAusuario(CodRol, txtUsuario.Text, AN8, UsuarioModIns, lsNombreClase);
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                lblError.Text = ex.Message.ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString(), (Session["usuario"] != null ? Session["usuario"].ToString() : string.Empty));
                SNError.IngresaError(objError);
                e.Canceled = true;
            }
        }
    }
}