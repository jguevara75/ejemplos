using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using Entidades;
using Entidad;
using System.Data;
using Utilidades;

namespace AccesoDatos
{
    public class ADError
    {
        static string lsNombreMetodo = string.Empty;
        static string lsSentencia = string.Empty;
        static string lsNombreClase = "ADErrores";
        static ENError objError = null;

        public static Int16 IngresaError(ENError objError)
        {
            Database ConexionSeguridad = null;
            Int16 lnRespuesta = 0;
            try
            {

                ConexionSeguridad = ADConexionBD.CrearObjectoBaseDatosSeguridad();
                DbCommand Cmd = ConexionSeguridad.GetStoredProcCommand("IngresardetError", objError.Clase, 
                                                                        objError.Metodo, objError.Sentencia,objError.Descripcion
                                                                        , objError.Usuario);
                lsSentencia = SUFunciones.ObtieneSentenciaSQL(Cmd);
                ConexionSeguridad.ExecuteNonQuery(Cmd);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lnRespuesta;
        }

        public static DataTable ObtieneErroresTodos()
        {
            Database ConexionSeguridad = null;
            DataTable dtDatos = null;
            try
            {

                ConexionSeguridad = ADConexionBD.CrearObjectoBaseDatosSeguridad();
                DbCommand Cmd = ConexionSeguridad.GetStoredProcCommand("spObtieneErroresTodos");
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

    }
}
