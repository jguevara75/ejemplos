using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using Negocio;
using System.Data;
using Entidades;
using Utilidades;

namespace SitioInterfaz
{
    public partial class frmUsuario : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //public void ActualizaUsuario(string Usuario, string ABAN8, string CodModulo, string Clave, string Activo, string CodPregunta, string Respuesta)
        //{
            
        //    try
        //    {
        //        SNUsuario.ActualizaUsuario(Usuario, ABAN8, CodModulo, Clave, Activo, CodPregunta, Respuesta);                
        //    }
        //    catch (Exception ex)
        //    {
        //        SetMessage("Usuario: " + Usuario + " no pudo ser actualizado. Razón: " + ex.Message);
        //    }
        //}

        //public void IngresaUsuario(string Usuario, string ABAN8, string CodModulo, string Clave, string Activo, string CodPregunta, string Respuesta)
        //{
        //    try
        //    {
        //        SNUsuario.IngresaUsuario(Usuario, ABAN8, CodModulo, Clave, Activo, CodPregunta, Respuesta);
        //    }
        //    catch (Exception ex)
        //    {
        //        SetMessage("Usuario: " + Usuario + " no pudo ser actualizado. Razón: " + ex.Message);
        //    }
        //}

        //public DataTable ConsultaUsuarios()
        //{
        //    DataTable dtUsuarios = null;
        //    try
        //    {
        //        dtUsuarios = SNUsuario.ConsultaUsuarios();
        //    }
        //    catch (Exception ex)
        //    {
        //        SetMessage("No se pudo obtener usuarios. Razón: " + ex.Message);
        //    }
        //    return dtUsuarios;
        //}

        //protected void RadGrid1_ItemUpdated(object sender, Telerik.Web.UI.GridUpdatedEventArgs e)
        //{
        //    GridEditableItem item = (GridEditableItem)e.Item;
        //    String id = item.GetDataKeyValue("Usuario").ToString();

        //    if (e.Exception != null)
        //    {
        //        e.KeepInEditMode = true;
        //        e.ExceptionHandled = true;
        //        SetMessage("Usuario: " + id + " no pudo ser actualizado. Razón: " + e.Exception.Message);
        //    }
        //    else
        //    {
        //        SetMessage("Usuario: " + id + " fué actualizado exitosamente!");
        //    }
        //}

        //private void DisplayMessage(string text)
        //{
        //    RadGrid1.Controls.Add(new LiteralControl(string.Format("<span style='color:red'>{0}</span>", text)));
        //}

        //private void SetMessage(string message)
        //{
        //    gridMessage = message;
        //}
        //private string gridMessage = null;
        //protected void RadGrid1_DataBound(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(gridMessage))
        //    {
        //        DisplayMessage(gridMessage);
        //    }
        //}

        //protected void RadGrid1_UpdateCommand(object sender, GridCommandEventArgs e)
        //{
        //    tblDefUsuario objUsuario = null;
        //    try
        //    {
        //        objUsuario = new tblDefUsuario();
        //        objUsuario.Usuario = e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["Usuario"].ToString();
        //        objUsuario.ABAN8 = SUConversiones.ConvierteADecimal(e.Item.OwnerTableView.DataKeyValues[e.Item.ItemIndex]["ABAN8"].ToString());

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}