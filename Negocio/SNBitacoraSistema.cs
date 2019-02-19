using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;
using Entidad;
using System.Data;
using Entidades;
using Utilidades;
using System.Data.Common;

namespace Negocio
{
    public class SNBitacoraSistema
    {
        static string lsNombreMetodo = string.Empty;
        static string lsSentencia = string.Empty;
        static string lsNombreClase = "SNBitacoraSistema";
        static ENError objError = null;

        public static DataTable ObtieneHistorialSesiones()
        {
            DataTable dtDatos = null;
            try
            {
                dtDatos = ADHistorialSesiones.ObtieneHistorialSesiones();
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

        public static List<ENBitacora> ObtieneBitacoraList()
        {
            DataTable dtDatos = null;
            List<ENBitacora> lstObjBitacora = null;
            ENBitacora objBitacora = null;
            try
            {
                lstObjBitacora = new List<ENBitacora>();
                dtDatos = ADBitacoraSistema.ObtieneLogsTodos();
                if (SUFunciones.ValidaDataTable(dtDatos))
                {
                    
                    foreach (DataRow drc in dtDatos.Rows)
                    {
                        objBitacora = new ENBitacora();
                        objBitacora.CodBitacora = SUConversiones.ConvierteAInt64(drc["IdBitacora"].ToString());
                        objBitacora.IndicaError = Boolean.Parse((drc["IndicaError"].ToString() == "1" ? "true" : "false"));
                        objBitacora.Clase= drc["Clase"].ToString();
                        objBitacora.Fecha = DateTime.Parse( drc["Fecha"].ToString());
                        objBitacora.FechaNum = drc["FechaNum"].ToString();
                        objBitacora.Metodo = drc["Metodo"].ToString();
                        objBitacora.Sentencia = drc["Sentencia"].ToString();
                        objBitacora.Descripcion= drc["Descripcion"].ToString();
                        objBitacora.Usuario = drc["Usuario"].ToString();
                        lstObjBitacora.Add(objBitacora);
                    }
                }

                dtDatos = ADError.ObtieneErroresTodos();
                if (SUFunciones.ValidaDataTable(dtDatos))
                {
                    foreach (DataRow drc in dtDatos.Rows)
                    {
                        objBitacora = new ENBitacora();
                        objBitacora.CodBitacora = SUConversiones.ConvierteAInt64(drc["IdError"].ToString());
                        objBitacora.IndicaError = Boolean.Parse((drc["IndicaError"].ToString()=="1"?"true":"false"));
                        objBitacora.Clase = drc["Clase"].ToString();
                        objBitacora.Fecha = DateTime.Parse(drc["Fecha"].ToString());
                        objBitacora.FechaNum = drc["FechaNum"].ToString();
                        objBitacora.Metodo = drc["Metodo"].ToString();
                        objBitacora.Sentencia = drc["Sentencia"].ToString();
                        objBitacora.Descripcion = drc["Descripcion"].ToString();
                        objBitacora.Usuario = drc["Usuario"].ToString();
                        lstObjBitacora.Add(objBitacora);
                    }
                }
                if (lstObjBitacora.Count <=0)
                {
                    //lstObjBitacora = new List<ENBitacora>();
                    objBitacora = new ENBitacora();
                    objBitacora.CodBitacora = 0;
                    objBitacora.IndicaError = true;
                    objBitacora.Clase = string.Empty;
                    objBitacora.Fecha = new DateTime(1900, 1, 1);
                    objBitacora.FechaNum = string.Empty;
                    objBitacora.Metodo = string.Empty;
                    objBitacora.Sentencia = string.Empty;
                    objBitacora.Descripcion = string.Empty;
                    lstObjBitacora.Add(objBitacora);

                    lstObjBitacora.Add(objBitacora);
                }
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
            return lstObjBitacora;
        }

        public static int IngresarBitacora(ENBitacora objBitacora)
        {
            try
            {

                return ADBitacoraSistema.IngresaBitacora(objBitacora);
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
