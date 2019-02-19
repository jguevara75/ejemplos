using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidad
{
   public class ENUsuario
    {
        #region variables
            private string _Usuario;
            private int _CodModulo;
            private decimal _CodigoExterno;
            private string _NombreUsuario;
            private string _Clave; 
            private string _UsuarioCreacion;
            private DateTime _FechaCreacion; 
            private string _UsuarioModificacion;
            private DateTime _FechaModificacion;
            private int _codPregunta;
            private string _Respuesta;
            private Boolean _Activo;
       #endregion variables
       #region propiedaes
            public string Usuario
            {
                get
                {
                    return _Usuario;
                }
                set
                {
                    _Usuario = value;
                }
            }
            public string NombreUsuario
            {
                get
                {
                    return _NombreUsuario;
                }
                set
                {
                    _NombreUsuario = value;
                }
            }
            public int CodModulo
            {
                get
                {
                    return _CodModulo;
                }
                set
                {
                    _CodModulo = value;
                }
            }
            public decimal CodigoExterno
            {
                get
                {
                    return _CodigoExterno;
                }
                set
                {
                    _CodigoExterno = value;
                }
            }
            public string Clave{
                get
                {
                    return _Clave;
                }
                set
                {
                    _Clave = value;
                }
            } 
            public string UsuarioCreacion{
                get
                {
                    return _UsuarioCreacion;
                }
                set
                {
                    _UsuarioCreacion = value;
                }

            }
            public DateTime FechaCreacion{
                get
                {
                    return _FechaCreacion;
                }
                set
                {
                    _FechaCreacion = value;
                }
            }
            public string UsuarioModificacion{
                get
                {
                    return _UsuarioModificacion;
                }
                set
                {
                    _UsuarioModificacion = value;
                }
            }
            public DateTime FechaModificacion {
                get
                {
                    return _FechaModificacion;
                }
                set
                {
                    _FechaModificacion = value;
                }
            }
            public string Respuesta
            {
                get
                {
                    return _Respuesta;
                }
                set
                {
                    _Respuesta = value;
                }
            }
            public int CodPregunta
            {
                get
                {
                    return _codPregunta;
                }
                set
                {
                    _codPregunta = value;
                }
            }
            public Boolean Activo {
                get
                {
                    return _Activo;
                }
                set
                {
                    _Activo = value;
                }
            }
       #endregion propiedaes
       #region constructor
       /// <summary>
       /// 
       /// </summary>
       /// <param name="Usuario"></param>
       /// <param name="CodModulo"></param>
       /// <param name="CodigoExterno"></param>
       /// <param name="Clave"></param>
       /// <param name="UsuarioCreacion"></param>
       /// <param name="FechaCreacion"></param>
       /// <param name="UsuarioModificacion"></param>
       /// <param name="FechaModificacion"></param>
       /// <returns></returns>
            public ENUsuario (string Usuario,  string NombreUsuario,int CodModulo,decimal CodigoExterno, string Clave, string UsuarioCreacion,           DateTime FechaCreacion, string UsuarioModificacion, DateTime FechaModificacion, int codPregunta, string Respuesta, Boolean Activo) 
            {
                
                this._Usuario =  Usuario;
                this._CodModulo= CodModulo;
                this._CodigoExterno=CodigoExterno;
                this._NombreUsuario=NombreUsuario;
                this._Clave=Clave;
                this._UsuarioCreacion=UsuarioCreacion;
                this._FechaCreacion=FechaCreacion;
                this._UsuarioModificacion= UsuarioModificacion;
                this._FechaModificacion=FechaModificacion;
                this._codPregunta = codPregunta;
                this._Respuesta = Respuesta;
                this._Activo = Activo;

            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Usuario"></param>
            /// <param name="CodModulo"></param>
            /// <param name="CodigoExterno"></param>
            /// <param name="Clave"></param>
            /// <param name="UsuarioCreacion"></param>
            /// <param name="FechaCreacion"></param>
            /// <param name="UsuarioModificacion"></param>
            /// <param name="FechaModificacion"></param>
            /// <returns></returns>
            public ENUsuario(ENUsuario  objUsuario)
            {

                this._Usuario = objUsuario.Usuario;
                this._NombreUsuario = objUsuario.NombreUsuario;
                this._CodModulo = objUsuario.CodModulo;
                this._CodigoExterno = objUsuario.CodigoExterno;
                this._Clave = objUsuario.Clave;
                this._UsuarioCreacion = objUsuario.UsuarioCreacion;
                this._FechaCreacion = objUsuario.FechaCreacion;
                this._UsuarioModificacion = objUsuario.UsuarioModificacion;
                this._FechaModificacion = objUsuario.FechaModificacion;
                this._codPregunta = objUsuario.CodPregunta;
                this._Respuesta = objUsuario.Respuesta;
                this._Activo = objUsuario.Activo;

            }

            public ENUsuario() { }
       #endregion constructor
    }
}
