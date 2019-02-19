using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using Utilidades;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Entidad;

namespace AccesoDatos
{
    public class ADHistorialSesiones
    {
        static string lsNombreMetodo = string.Empty;
        static string lsSentencia = string.Empty;
        static string lsNombreClase = "ADHistorialSesiones";
        static ENError objError = null;

        public static DataTable ObtieneHistorialSesiones()
        {
            Database ConexionSeguridad = null;
            DataTable dtDatos = null;
            try
            {

                ConexionSeguridad = ADConexionBD.CrearObjectoBaseDatosSeguridad();
                DbCommand Cmd = ConexionSeguridad.GetStoredProcCommand("spObtieneHistorialSesionTodos");
                lsSentencia = SUFunciones.ObtieneSentenciaSQL(Cmd);
                dtDatos = SUFunciones.ObtieneDataTableDeDataSet(ConexionSeguridad.ExecuteDataSet(Cmd));
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, lsSentencia, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
            return dtDatos;
        }

        public static int EliminaSesion( Guid IdSesion)
        {
            Database ConexionSeguridad = null;
            int nResultado=0;
            try
            {

                ConexionSeguridad = ADConexionBD.CrearObjectoBaseDatosSeguridad();
                DbCommand Cmd = ConexionSeguridad.GetStoredProcCommand("spEliminaSesion", IdSesion);
                lsSentencia = SUFunciones.ObtieneSentenciaSQL(Cmd);
                nResultado = SUConversiones.ConvierteAInt32(ConexionSeguridad.ExecuteScalar(Cmd));
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, lsSentencia, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
            return nResultado;
        }
    }
}
