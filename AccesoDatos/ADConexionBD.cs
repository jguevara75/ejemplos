using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace AccesoDatos
{
    public class ADConexionBD
    {
        // '' <summary>
        // '' Crea un Objecto Database
        // '' </summary>
        // '' <retorna>Un Objecto base de datos</retorna>
        public static Database CrearObjectoBaseDatosSeguridad()
        {
            Database dbSistemaGerencial = null;
            try
            {
                dbSistemaGerencial = DatabaseFactory.CreateDatabase("ConSegu");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return dbSistemaGerencial;
        }
    }
}
