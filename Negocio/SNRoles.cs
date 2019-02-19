using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;
using Sitio.Entidad;
using System.Data;
using System.Data.Common;
using Utilidades;
using System.Web.UI;
using Telerik.Web.UI;
using System.Web.UI.WebControls;


namespace Negocio
{
    public class SNRoles
    {
        static string lsNombreMetodo = string.Empty;
        static string lsSentencia = string.Empty;
        static string lsNombreClase = "SNRoles";
        static ENError objError = null;

        public static int IngresoRoles(ENRoles objRoles,string pvsNombrePagina)
        {
            try
            {

                return ADRoles.IngresoRoles(objRoles,pvsNombrePagina);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
        }

        public static int ModificarRoles(ENRoles objRoles, string pvsNombrePagina)
        {
            try
            {

                return ADRoles.ModificarRoles(objRoles,pvsNombrePagina);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
        }

        public static DbDataReader ConsultarRolesTodos()
        {
            try
            {
                return ADRoles.ConsultarRolesTodos();
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
        }

        public static DataTable ConsultarRolesTodosDt()
        {
            try
            {
                return ADRoles.ConsultarRolesTodosDt();
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
        }

        public static int EliminaRolxLlave(int nRol,string UsuarioElimina,string pvsNombrePagina)
        {
            try
            {
                return ADRoles.EliminaRoleXLlave(nRol,pvsNombrePagina,UsuarioElimina);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
        }

        public static DbDataReader ConsultarRolesXLlave(int CodRol)
        {
            try
            {
                return ADRoles.ConsultarRolesXLlave(CodRol);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
        }

        public static DbDataReader ConsultarRolesXUsuario(string Usuario)
        {
            try
            {
                return ADRoles.ConsultarRolesXUsuario(Usuario);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
        }

        public static DataTable ConsultarRolesXUsuarioDT(string Usuario)
        {
            try
            {
                return ADRoles.ConsultarRolesXUsuarioDT(Usuario);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
        }

        public static DataTable ConsultarRolesNoAsignadosXUsuario(string Usuario)
        {
            try
            {
                return ADRoles.ConsultarRolesNoAsignadosXUsuario(Usuario);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
        }

        public static int AsignarRolesAusuario(int CodRol, string Usuario, decimal CodigoExterno, string UsuarioAsigna, string pvsNombrePagina)
        {
            try
            {
                return ADRoles.AsignarRoles(CodRol, Usuario, CodigoExterno, UsuarioAsigna,pvsNombrePagina);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
        }

        public static int EliminaRolAsignado(int CodRol, string Usuario, string UsuarioElimina, string pvsNombrePagina)
        {
            string lsNombrePagina = string.Empty;
            try
            {
                lsNombrePagina = (pvsNombrePagina!=null?pvsNombrePagina:"MantUsuario.aspx");
                return ADRoles.EliminaRolAsinado(CodRol, Usuario, UsuarioElimina, lsNombrePagina);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());
                ADError.IngresaError(objError);
                throw ex;
            }
        }
    }
}
