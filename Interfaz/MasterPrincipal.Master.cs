using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Infragistics.Web.UI.NavigationControls;
using Negocio;
using Entidad;
using Utilidades;


namespace SitioInterfaz
{
    public partial class MasterPrincipal : System.Web.UI.MasterPage
    {
        static string lsNombreMetodo = string.Empty;
        static string lsNombreClase = "MasterPrincipal.aspx.cs";
        static ENError objError = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            string lsUsuario = string.Empty;
            string lsNombreUsuario = string.Empty;
            try
            {
                lsUsuario = (Session["usuario"] == null ? string.Empty : Session["usuario"].ToString());
                lsNombreUsuario = (Session["NombreUsuario"] == null ? string.Empty : Session["NombreUsuario"].ToString());
                if (!this.IsPostBack)
                {
                    Label1.Text = "Usuario: " + lsUsuario + " - " + lsNombreUsuario + " | ";

                    CargarInterfaz();

                }
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());
                SNError.IngresaError(objError);
            }

        }
        private void CargarInterfaz()
        {
            string User = string.Empty;
            try
            {
                if (Session["usuario"] != null)
                {
                    User = Session["usuario"].ToString();
                }

                //ManejoSeguridad menu = new ManejoSeguridad();
                //SNPermisos menu = new SNPermisos ();
                SNObjetoAplicacion menu = new SNObjetoAplicacion();

                // menu.CrearMenu(1);

                //DataTable dt = menu.CrearMenu(2);
                DataTable dt = SNObjetoAplicacion.ConsultarObjetoAplicacionXUsuario(User);

                foreach (DataRow drMenuItem in dt.Rows)
                {
                    if (Convert.ToInt32(drMenuItem["CodMenuPadre"]) == Convert.ToInt32(drMenuItem["CodMenuHijo"]))   //padre
                    {
                        DataMenuItem mn = new DataMenuItem();
                        mn.Value = Convert.ToString(drMenuItem["CodMenuPadre"]);
                        mn.Text = Convert.ToString(drMenuItem["DescObjeto"]);
                        mn.NavigateUrl = Convert.ToString(drMenuItem["DireccionUrl"]);
                        //    mn.NavigateUrl = Convert.ToString("~/Restablecercontrasea.aspx"); 
                        this.WebDataMenu2.Items.Add(mn);
                        AdicionarMenuItem(ref  mn, dt);
                    }
                }
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());
                SNError.IngresaError(objError);
            }
        }


        //Funcion que crea menu o sub-menus de manera dinamica segun datos de que se pasan por datatable
        //se pasa por referencia el WebDataMenu, y se pasa el DataTable que se contruye a partir del 
        // id de rol que se pasa por parametros
        private void AdicionarMenuItem(ref DataMenuItem mn, DataTable dtMenuItems)
        {
            try
            {
                foreach (DataRow drMenuItem in dtMenuItems.Rows)
                {
                    if (Convert.ToString(drMenuItem["CodMenuPadre"]).Equals(mn.Value))
                    {
                        if (Convert.ToString(drMenuItem["CodMenuPadre"]) != Convert.ToString(drMenuItem["CodMenuHijo"]))
                        {
                            DataMenuItem mnew = new DataMenuItem();
                            mnew.Value = Convert.ToString(drMenuItem["CodMenuHijo"]);
                            mnew.Text = Convert.ToString(drMenuItem["DescObjeto"]);
                            mnew.NavigateUrl = Convert.ToString(drMenuItem["DireccionUrl"]);
                            mn.Items.Add(mnew);
                            AdicionarMenuItem(ref mnew, dtMenuItems);

                            //mnew.Menu.ItemClick  += new  System.EventHandler(this.MenuItemClick);
                            //mnew.Menu.ItemClick += new DataMenuItemEventHandler(this.MenuItemClick);
                            //mn.Menu.ItemClick += new DataMenuItemEventHandler(this.MenuItemClick);

                            //btn = new RadToolBarButton();
                            //btn.Text = "Nuevo";
                            //btn.Value = Convert.ToString(drMenuItem["CodMenuHijo"]);
                            //btn.CommandName = Convert.ToString(drMenuItem["CodMenuHijo"]);
                            //btn.ImageUrl = "~/Imagen/Img_Toolbar/add.png";
                            //RadToolBar1.Items.Add(btn);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());
                SNError.IngresaError(objError);
            }
        }

        //private void MenuItemClick(object sender, System.EventArgs e)
        //{
        //    frmPrincipal obj = new frmPrincipal();
        //    //btn = new RadToolBarButton();
        //    //btn.Text = "Nuevo";
        //    //btn.Value = "New";
        //    //btn.CommandName = "n";
        //    //btn.ImageUrl = "~/Imagen/Img_Toolbar/add.png";
        //    //RadToolBar1.Items.Add(btn);

        //    obj.Title = "Click Menu Dinamico";
        //}


        protected void WebDataMenu2_ItemClick(object sender, DataMenuItemEventArgs e)
        {
            int nSession = 0;
            try
            {
                nSession = (Session["SesioAsignada"] != null ? SUConversiones.ConvierteAInt32(Session["SesioAsignada"]) : 0);
                SNSessiones.ConsultarSesionAsignadaActiva(nSession);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());
                SNError.IngresaError(objError);
            }
        }



    


   
    }
}