using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos;
using Entidad;
using System.Data;
using Entidades;
using Utilidades;

namespace Negocio
{
    public class SNError
    {
        static string lsNombreMetodo = string.Empty;
        static string lsSentencia = string.Empty;
        static string lsNombreClase = "SNError";
        //static ENError objError = null;

        public static void IngresaError(ENError  objError)
        {
            try
            {
                ADError.IngresaError(objError);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
            }
        }

    }
}
