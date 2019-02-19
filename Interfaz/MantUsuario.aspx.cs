using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using Negocio;
using Entidad;
using Entidades;
using Utilidades;
using System.Data;



namespace SitioInterfaz
{
    public partial class Seguridad : System.Web.UI.Page
    {

        static string lsNombreMetodo = string.Empty;
        static string lsNombreClase = "MantUsuario.aspx.cs";
        static ENError objError = null;
        static tblDefUsuario objUsuario = null;

        protected void Page_Load(object sender, EventArgs e)
        {
       
        }

        private void GuardarUsuario(Boolean Edita, GridCommandEventArgs e)
        {
            String err = string.Empty;
            UserControl usr = null;
            Label lblError = null;
            string sPath = string.Empty;
            
            //String Usuario = string.Empty;
            try
            {

            sPath = HttpContext.Current.Request.Url.AbsolutePath;
            lsNombreClase = SUFunciones.ObtieneNombrePagina(sPath);

            usr = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);
            lblError = (usr.FindControl("lblError") as Label);

            objUsuario = new tblDefUsuario();

            objUsuario.Usuario = (usr.FindControl("txtUsuario") as RadTextBox).Text;
            objUsuario.ABAN8 = SUConversiones.ConvierteAInt64((usr.FindControl("txtABAN8") as RadNumericTextBox).Text);
            objUsuario.CodModulo = SUConversiones.ConvierteAInt16((usr.FindControl("cboModulo") as RadComboBox).SelectedValue);
            objUsuario.Clave = (usr.FindControl("txtPass") as TextBox).Text;
            objUsuario.CodPregunta = SUConversiones.ConvierteAInt16((usr.FindControl("cboPregunta") as RadComboBox).SelectedValue);
            objUsuario.Respuesta = (usr.FindControl("txtRepuesta") as RadTextBox).Text;
            objUsuario.UsuarioModificacion = (Session["usuario"]!=null?Session["usuario"].ToString():string.Empty);
            objUsuario.UsuarioCreacion = (Session["usuario"] != null ? Session["usuario"].ToString() : string.Empty);
            objUsuario.Activo = (usr.FindControl("chkActivo0") as CheckBox).Checked;


            
            lblError.Visible = true;
            err = valida(objUsuario.ABAN8,objUsuario.CodPregunta, objUsuario.CodModulo, objUsuario.Usuario, objUsuario.Clave, objUsuario.Respuesta);

            if (!err.Trim().Equals(""))
            {
                lblError.Text = err;
                e.Canceled = true;
                return;
            }

            if (Edita)
                //ProyectoJG.mantUsuarios.UpdUsuario(Usuario, ABAN8, CodModulo, Clave, UsuarioModIns, Activo, CodPregunta, Respuesta);
                SNUsuario.ActualizaUsuario(objUsuario, lsNombreClase);
            else
            {
                SNUsuario.IngresaUsuario(objUsuario, lsNombreClase);
                //err = ProyectoJG.mantUsuarios.InsUsuario(Usuario, ABAN8, CodModulo, Clave, UsuarioModIns, Activo, CodPregunta, Respuesta);
            }
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                //lblError.Text = lsNombreMetodo + " - " + PrmMensajesSistema.MensajeError.ToString();
                lblError.Text = ex.Message.ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString(), (Session["usuario"] != null ? Session["usuario"].ToString() : string.Empty));
                SNError.IngresaError(objError);
                e.Canceled = true;
            }
        }

        private String valida(decimal AN8, int CodPregunta,int CodModulo, String Usuario, String Clave, String Respuesta)
        {
            try
            {
                if (Usuario.Trim().Equals(""))
                    return "Ingrese el <b>Usuario</b>";
                if (AN8 == 0)
                    return "Ingrese el codigo de AN8 del <b>Usuario</b> ";
                if (AN8.ToString().Length <= 0)
                    return "Ingrese el codigo de AN8 del <b>Usuario</b> ";
                if (CodModulo == 0)
                    return "Ingrese el <b>modulo</b>";
                if (Clave.Trim().Equals(""))
                    return "Ingrese la <b>Clave</b> del Usuario";
                if (CodPregunta == 0)
                    return "Ingrese la <b>pregunta</b> ";
                if (Respuesta.Trim().Equals(""))
                    return "Ingrese la <b>Respuesta</b> de la pregunta seleccionada";

                return "";
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                //lblError.Text = lsNombreMetodo + " - " + PrmMensajesSistema.MensajeError.ToString();
                lblError.Text = ex.Message.ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString(), (Session["usuario"] != null ? Session["usuario"].ToString() : string.Empty));
                SNError.IngresaError(objError);
                return "";
            }
        }

        protected void grUsuarios_InsertCommand(object sender, GridCommandEventArgs e)
        {
            try
            {
                GuardarUsuario(false, e);
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

        protected void grUsuarios_DeleteCommand(object sender, GridCommandEventArgs e)
        {
            String Usuario = string.Empty;
            String UsuarioElimina = string.Empty;
            string sPath = string.Empty;
            try
            {
                sPath = HttpContext.Current.Request.Url.AbsolutePath;
                lsNombreClase = SUFunciones.ObtieneNombrePagina(sPath);
                UsuarioElimina = (Session["usuario"] != null ? Session["usuario"].ToString() : string.Empty);
                Usuario = e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["Usuario"].ToString();
                SNUsuario.EliminaUsuario(Usuario, UsuarioElimina, lsNombreClase);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                //lblError.Text = lsNombreMetodo + " - " + PrmMensajesSistema.MensajeError.ToString();
                lblError.Text = ex.Message.ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString(), (Session["usuario"] != null ? Session["usuario"].ToString() : string.Empty));
                SNError.IngresaError(objError);
            }
        }

        protected void grUsuarios_UpdateCommand(object sender, GridCommandEventArgs e)
        {
            try
            {
                GuardarUsuario(true, e);
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
               // lblError.Text = lsNombreMetodo + " - " + PrmMensajesSistema.MensajeError.ToString();
                lblError.Text = ex.Message.ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString(), (Session["usuario"] != null ? Session["usuario"].ToString() : string.Empty));
                SNError.IngresaError(objError);
            }
        }

        protected void grUsuarios_ItemCreated(object sender, GridItemEventArgs e)
        {
            try
            {
                if (e.Item is GridEditFormItem && e.Item.IsInEditMode)
                {
                    GridEditFormItem item = (GridEditFormItem)e.Item;
                    UserControl userControl = (UserControl)e.Item.FindControl(GridEditFormItem.EditFormUserControlID);
                    switch (SUConversiones.ConvierteAInt16(Session["tipoedit"]))
                    {
                        case 2:
                            (userControl.FindControl("grDispositivos") as RadGrid).Visible = true;
                            (userControl.FindControl("pnlData") as Panel).Visible = false;
                            (userControl.FindControl("pnlRoles") as Panel).Visible = false;
                            break;
                        case 3:
                            (userControl.FindControl("grDispositivos") as RadGrid).Visible = false;
                            (userControl.FindControl("pnlData") as Panel).Visible = false;
                            (userControl.FindControl("pnlRoles") as Panel).Visible = false;

                            break;
                        case 4:
                            (userControl.FindControl("pnlRoles") as Panel).Visible = true;
                            (userControl.FindControl("grDispositivos") as RadGrid).Visible = false;
                            (userControl.FindControl("pnlData") as Panel).Visible = false;
                            break;
                        default:
                            (userControl.FindControl("pnlData") as Panel).Visible = true;
                            (userControl.FindControl("grDispositivos") as RadGrid).Visible = false;
                            (userControl.FindControl("pnlRoles") as Panel).Visible = false;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                // lblError.Text = lsNombreMetodo + " - " + PrmMensajesSistema.MensajeError.ToString();
                lblError.Text = ex.Message.ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString(), (Session["usuario"] != null ? Session["usuario"].ToString() : string.Empty));
                SNError.IngresaError(objError);
            }
        }

        protected void grUsuarios_ItemCommand(object sender, GridCommandEventArgs e)
        {
            try
            {
                switch (e.CommandName)
                {
                    case "Select":
                        Session["tipoedit"] = 2;
                        e.Item.Edit = true;
                        e.Item.OwnerTableView.Rebind();
                        break;
                    case "Permiso":
                        Session["tipoedit"] = 3;
                        e.Item.Edit = true;
                        e.Item.OwnerTableView.Rebind();
                        break;
                    case "Rol":
                        Session["tipoedit"] = 4;
                        e.Item.Edit = true;
                        e.Item.OwnerTableView.Rebind();
                        break;
                    default:
                        Session["tipoedit"] = 1;
                        break;
                }
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                // lblError.Text = lsNombreMetodo + " - " + PrmMensajesSistema.MensajeError.ToString();
                lblError.Text = ex.Message.ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString(), (Session["usuario"] != null ? Session["usuario"].ToString() : string.Empty));
                SNError.IngresaError(objError);
            }
        }

    protected void grUsuarios_SelectedIndexChanged(object sender, EventArgs e)
    {
        /*foreach (GridItem item in grUsuarios.MasterTableView.Items)
       {
           if (item is GridEditableItem)
           {
               GridEditableItem editableItem = item as GridDataItem;
               editableItem.Edit = true;
           }
       }
        
       grUsuarios.MasterTableView.IsItemInserted = true;
       grUsuarios.Rebind();*/
    }
    }
}