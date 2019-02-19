using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;
using Sitio.Entidad;
using System.Data;
using Utilidades;
namespace Negocio
{
    public class SNUsuario
    {
        static string lsNombreMetodo = string.Empty;
        static string lsSentencia = string.Empty;
        static string lsNombreClase = "SNUsuario";
        static ENError objError = null;

        public static int IngresaUsuario(tblDefUsuario objUsuario, string pvsNombrePagina)
        {
            int lnRespuesta = 0;
            try
            {

                lnRespuesta = SUConversiones.ConvierteAInt16(ADUsuario.IngresaUsuario(objUsuario, pvsNombrePagina));
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
            return lnRespuesta;
        }

        public static int IngresaUsuario(string codigoEcterno, string Usuario, string CodModulo, string Clave, string Activo, string CodPregunta, string Respuesta, string pvsNombrePagina)
        {
            int lnRespuesta = 0;
            tblDefUsuario objUsuario=null;
            try
            {
                objUsuario = new tblDefUsuario();

                objUsuario.codigoEcterno = SUConversiones.ConvierteADecimal(codigoEcterno);
                objUsuario.Usuario = Usuario;
                objUsuario.CodModulo = SUConversiones.ConvierteAInt16(CodModulo);
                objUsuario.Clave = Clave;
                objUsuario.Activo = SUConversiones.ConvierteABoolean(Activo);
                objUsuario.CodPregunta = SUConversiones.ConvierteAInt16(CodPregunta);
                objUsuario.Respuesta = Respuesta;
                lnRespuesta = SUConversiones.ConvierteAInt16(ADUsuario.IngresaUsuario(objUsuario, pvsNombrePagina));
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
            return lnRespuesta;
        }

        public static int ActualizaUsuario(string Usuario, string codigoEcterno, string CodModulo, string Clave, string Activo, string CodPregunta, string Respuesta,string NombrePagina)
        {
            int lnRespuesta = 0;
            tblDefUsuario objUsuario = null;
            try
            {
                objUsuario = new tblDefUsuario();

                objUsuario.codigoEcterno = SUConversiones.ConvierteADecimal(codigoEcterno);
                objUsuario.Usuario = Usuario;
                objUsuario.CodModulo = SUConversiones.ConvierteAInt16(CodModulo);
                objUsuario.Clave = Clave;
                objUsuario.Activo = SUConversiones.ConvierteABoolean(Activo);
                objUsuario.CodPregunta = SUConversiones.ConvierteAInt16(CodPregunta);
                objUsuario.Respuesta = Respuesta;
                lnRespuesta = SUConversiones.ConvierteAInt16(ADUsuario.ActualizaUsuario(objUsuario, NombrePagina));
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
            return lnRespuesta;
        }
        public static int ActualizaUsuario(tblDefUsuario objUsuario,string NombrePagina)
        {
            int lnRespuesta = 0;
            try
            {

                lnRespuesta = SUConversiones.ConvierteAInt16(ADUsuario.ActualizaUsuario(objUsuario, NombrePagina));
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
            return lnRespuesta;
        }
        public static int EliminaUsuario(string Usuario,string UsuarioElimina,string pvsNombrePagina)
        {
            int lnRespuesta = 0;
            try
            {

                lnRespuesta = SUConversiones.ConvierteAInt16(ADUsuario.EliminaUsuario(Usuario, UsuarioElimina, pvsNombrePagina));
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
            return lnRespuesta;
        }

        public static string ObtinenNombreUsuario(int CodUsuario)
        {
            string lsNombre = string.Empty;
            try
            {

                lsNombre = ADUsuario.ObtieneNombreUsuario(CodUsuario);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
            return lsNombre;
        }

        public static DataTable ConsultaUsuarioxLlave(string CodUsuario, string UsuarioConsulta,string NombrePagina)
        {
            DataTable dtDatos = null;
            try
            {

                dtDatos = ADUsuario.ConsultaUsuarioxCodUsuario(CodUsuario,NombrePagina, UsuarioConsulta);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
            return dtDatos;
        }

        public static DataTable ConsultaUsuarios()
        {
            DataTable dtDatos = null;
            try
            {

                dtDatos = ADUsuario.ConsultaUsuarios();
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
            return dtDatos;
        }
    }
}
