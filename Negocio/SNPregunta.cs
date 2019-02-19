using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.Web.UI;
using Entidad;
using System.Data;
using AccesoDatos;
using Utilidades;
using System.Data.Common;

namespace Negocio
{
    public class SNPregunta
    {
        static string lsNombreMetodo = string.Empty;
        static string lsSentencia = string.Empty;
        static string lsNombreClase = "SNPreguntas";
        static ENError objError = null;

        public static DataTable ConsultaPreguntas()
        {
            DataTable dtDatos = null;
            try
            {

                dtDatos = ADPregunta.ConsultaPreguntas();
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
        public static void LlenaComboPreguntas(RadComboBox rcmbModulo)
        {
            //ListItem item=null;
            RadComboBoxItem item = null;
            try
            {
                item = new RadComboBoxItem();
                item.Value = "-1";
                item.Text = PrmMensajeSistema.ValorInicialCombo.ToString();
                rcmbModulo.DataTextField = "NombreModulo";
                rcmbModulo.DataValueField = "CodModulo";
                rcmbModulo.DataSource = ConsultaPreguntas();
                rcmbModulo.DataBind();
                rcmbModulo.Items.Add(item);
                rcmbModulo.SelectedValue = "-1";
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
        }

        public static void LlenaComboPreguntasSinDT(RadComboBox rcmbModulo)
        {
            RadComboBoxItem item = null;
            DataTable dtModulos = null;
            try
            {

                dtModulos = ConsultaPreguntas();

                if (SUFunciones.ValidaDataTable(dtModulos))
                {
                    foreach (DataRow Registro in dtModulos.Rows)
                    {
                        item = new RadComboBoxItem();
                        item.Value = Registro["CodPregunta"].ToString();
                        item.Text = (string)Registro["Descripcion"];
                        rcmbModulo.Items.Add(item);
                    }
                }
                item = new RadComboBoxItem();
                item.Value = "-1";
                item.Text = PrmMensajeSistema.ValorInicialCombo.ToString();
                rcmbModulo.Items.Add(item);
                rcmbModulo.SelectedValue = "-1";
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
        }

        public static int IngresarPreguntas(ENPreguntas objPreguntas, string pvsNombrePagina)
        {
            try
            {
                return ADPregunta.IngresarPreguntas(objPreguntas, pvsNombrePagina);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
        }

        public static int ModificarPreguntas(ENPreguntas objPreguntas, string pvsNombrePagina)
        {
            try
            {

                return ADPregunta.ModificarPreguntas(objPreguntas, pvsNombrePagina);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
        }

        public static int EliminarPreguntas(int IdPregunta, string UsuarioElimina, string pvsNombrePagina)
        {
            try
            {
                return ADPregunta.EliminarPreguntas(IdPregunta,UsuarioElimina, pvsNombrePagina);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
        }


        public static DbDataReader ValidarPreguntasEnUsuario(int CodPregunta)
        {
            DbDataReader drDdatos = null;
            try
            {
                drDdatos = ADPregunta.ValidarPreguntasEnUsuario(CodPregunta);
            }
            catch (Exception ex)
            {
                lsNombreMetodo = (new System.Diagnostics.StackFrame().GetMethod()).ToString();
                objError = new ENError(lsNombreClase, lsNombreMetodo, ex.Message.ToString());

                ADError.IngresaError(objError);
                throw ex;
            }
            return drDdatos;
        }

    }
}
