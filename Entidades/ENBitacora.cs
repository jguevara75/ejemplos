using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidad
{
    public class ENBitacora
    {
      Int64 _CodBitacora;

      public Int64 CodBitacora
      {
        get {
            return _CodBitacora;
        }
        set {
            _CodBitacora = value;
        }
    }

      Boolean _IndicaError;

      public Boolean IndicaError
      {
        get {
            return _IndicaError;
        }
        set {
            _IndicaError = value;
        }
    }
    
    private DateTime _Fecha;
    
    public DateTime Fecha {
        get {
            return _Fecha;
        }
        set {
            _Fecha = value;
        }
    }
    
    private string _FechaNum;
    
    public string FechaNum {
        get {
            return _FechaNum;
        }
        set {
            _FechaNum = value;
        }
    }
    
    private string _Clase;
    
    public string Clase {
        get {
            return _Clase;
        }
        set {
            _Clase = value;
        }
    }
    
    private string _Metodo;
    
    public string Metodo {
        get {
            return _Metodo;
        }
        set {
            _Metodo = value;
        }
    }
    
    private string _Sentencia;
    
    public string Sentencia {
        get {
            return _Sentencia;
        }
        set {
            _Sentencia = value;
        }
    }
    
    private string _Descripcion;
    
    public string Descripcion {
        get {
            return _Descripcion;
        }
        set {
            _Descripcion = value;
        }
    }

    private string _Usuario;
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
    public ENBitacora(Int64 pvnCodBitacora, Boolean pvnIndicaError, DateTime pvdFecha, string pvsFechaNum, 
                      string pvsClase, string pvsMetodo, string pvsSentencia, string pvsDescripcion
                      , string pvsUsuario)
    {
        _CodBitacora = pvnCodBitacora;
        _IndicaError = pvnIndicaError;
        _Fecha = pvdFecha;
        _FechaNum = pvsFechaNum;
        _Clase = pvsClase;
        _Metodo = pvsMetodo;
        _Sentencia = pvsSentencia;
        _Descripcion = pvsDescripcion;
        _Usuario = pvsUsuario;
    }

    public ENBitacora( string pvsClase,  string pvsMetodo, string pvsSentencia, string pvsDescripcion,string pvsUsuario)
    {
        _Clase = pvsClase;
        _Metodo = pvsMetodo;
        _Sentencia = pvsSentencia;
        _Descripcion = pvsDescripcion;
        _Usuario = pvsUsuario;
    }
    public ENBitacora(string pvsClase, string pvsMetodo, string pvsDescripcion, string pvsUsuario)
    {
        _Clase = pvsClase;
        _Metodo = pvsMetodo;
        _Sentencia = string.Empty;
        _Descripcion = pvsDescripcion;
        _Usuario = pvsUsuario;
    }

    public ENBitacora(ENBitacora objLogs)
    {
        _CodBitacora = objLogs.CodBitacora;
        _IndicaError = objLogs.IndicaError;
        _Fecha = objLogs.Fecha;
        _FechaNum = objLogs.FechaNum;
        _Clase = objLogs.Clase;
        _Metodo = objLogs.Metodo;
        _Sentencia = objLogs.Sentencia;
        _Descripcion = objLogs.Descripcion;
        _Usuario = objLogs.Usuario;
    }

    public ENBitacora()
        {
        }
    }
}
