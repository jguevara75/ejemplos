using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
namespace Utilidades
{
    public class SUFunciones
    {
        public static bool ValidaDataTable(DataTable dtAValidar)
        {
            bool lbdsValido = false;
            string lsNombreMetodo = String.Empty;
            try
            {
                lbdsValido = false;
                if (dtAValidar != null)
                {
                    if ((dtAValidar.Rows.Count > 0))
                    {
                        lbdsValido = true;
                    }
                }
            }
            catch
            {
                lbdsValido = false;
            }
            return lbdsValido;
        }

        public static bool ValidaDataSet(DataSet dsAValidar)
        {
            bool lbdsValido = false;
            string lsNombreMetodo = String.Empty;
            try
            {
                lbdsValido = false;
                if (dsAValidar != null)
                {
                    if ((dsAValidar.Tables.Count > 0))
                    {
                        if ((dsAValidar.Tables[0].Rows.Count > 0))
                        {
                            lbdsValido = true;
                        }
                    }
                }
            }
            catch
            {
                lbdsValido = false;
            }
            return lbdsValido;
        }
        public static DataTable ObtieneDataTableDeDataSet(DataSet dsAValidar)
        {
            string lsNombreMetodo = String.Empty;
            DataTable dtDatos = null;
            try
            {
                if (dsAValidar != null)
                {
                    if ((dsAValidar.Tables.Count > 0))
                    {
                        dtDatos = dsAValidar.Tables[0];
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return dtDatos;
        }

        public static string ObtieneSentenciaSQL(DbCommand objCmd)
        {
            if ((objCmd == null))
            {
                return "El objeto Command llega con valor Nulo o Nothing";
            }
            string Sentencia = String.Empty;
            StringBuilder strparam = new StringBuilder();
            strparam.Append(("EXEC "
                            + (Convert.ToString(objCmd.CommandText) + " ")));
            Sentencia = ("EXEC "
                        + (Convert.ToString(objCmd.CommandText) + " "));
            foreach (SqlParameter sqlparam in objCmd.Parameters)
            {
                switch (sqlparam.SqlDbType)
                {
                    case SqlDbType.Char:
                    case SqlDbType.NChar:
                    case SqlDbType.NText:
                    case SqlDbType.NVarChar:
                    case SqlDbType.Text:
                    case SqlDbType.VarChar:
                    case SqlDbType.Date:
                    case SqlDbType.DateTime:
                    case SqlDbType.DateTime2:
                    case SqlDbType.DateTimeOffset:
                    case SqlDbType.SmallDateTime:
                        strparam.Append(("\'"
                                        + (sqlparam.Value.ToString() + "\',")));
                        Sentencia = (Sentencia + ("\'"
                                    + (sqlparam.Value.ToString() + "\',")));
                        break;
                    default:
                        if ((sqlparam.ParameterName != "@RETURN_VALUE"))
                        {
                            strparam.Append((sqlparam.Value.ToString() + ","));
                            Sentencia = (Sentencia
                                        + (sqlparam.Value.ToString() + ","));
                        }
                        break;
                }
            }
            return TruncaCaracteres(strparam.ToString(), 0, (strparam.ToString().Trim().Length - 1));
        }
        public static string ObtieneValorLlaveConfig(string sLlaveConfig)
        {
            string sValor = string.Empty;
            try
            {
                sValor = (ConfigurationManager.AppSettings[sLlaveConfig] != null ? ConfigurationManager.AppSettings[sLlaveConfig].ToString() : string.Empty);
            }
            catch
            {
                sValor = string.Empty;
            }
            return sValor;
        }

        public static string ObtieneNombrePagina(string pvsPath)
        {
            string sValor = string.Empty;
            string[] strarry;
            int lengh = 0;
            try
            {
                strarry = pvsPath.Split('/');
                lengh = strarry.Length;
                sValor = strarry[lengh - 1]; 

            }
            catch
            {
                sValor = string.Empty;
            }
            return sValor;
        }
        public static string ConvierteNullAString(object oValor)
        {
            string sValor = string.Empty;
            try
            {
                sValor = (oValor==null?string.Empty:oValor.ToString());
            }
            catch
            {
                sValor = string.Empty;
            }
            return sValor;
        }
        public static string TruncaCaracteres(string cadena, int caracterInicial, int longitudCaracter)
        {
            string sCadeResultado = string.Empty;

            if ((caracterInicial >= cadena.Trim().Length))
            {
                return "";
            }
            else
            {

                if ((cadena.Trim().Length
                            >= (caracterInicial + longitudCaracter)))
                {
                    sCadeResultado = cadena.Substring(caracterInicial, longitudCaracter);
                }
                else
                {
                    sCadeResultado = cadena.Substring(caracterInicial, (cadena.Trim().Length - caracterInicial));
                }
                return sCadeResultado;
            }
        }
    }
}
