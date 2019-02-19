using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidad
{
    public class ENError
    {
        Int64 _IdError;

    
    public Int64 IdError {
        get {
            return _IdError;
        }
        set {
            _IdError = value;
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
    
    private string _Proceso;
    
    public string Proceso {
        get {
            return _Proceso;
        }
        set {
            _Proceso = value;
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

    public ENError(Int64 pvnIdError, DateTime pvdFecha, string pvsFechaNum, string pvsClase, string pvsProceso, string pvsMetodo, string pvsSentencia, string pvsDescripcion, string pvsUsuario) {
        _IdError = pvnIdError;
        _Fecha = pvdFecha;
        _FechaNum = pvsFechaNum;
        _Clase = pvsClase;
        _Proceso = pvsProceso;
        _Metodo = pvsMetodo;
        _Sentencia = pvsSentencia;
        _Descripcion = pvsDescripcion;
        _Usuario = pvsUsuario;
    }

    public ENError(string pvsClase, string pvsMetodo, string pvsSentencia, string pvsDescripcion, string pvsUsuario)
    {
        _Clase = pvsClase;
        _Proceso = string.Empty;
        _Metodo = pvsMetodo;
        _Sentencia = pvsSentencia;
        _Descripcion = pvsDescripcion;
        _Usuario = pvsUsuario;
    }
    public ENError(string pvsClase, string pvsMetodo, string pvsDescripcion, string pvsUsuario)
    {
        _Clase = pvsClase;
        _Proceso = string.Empty;
        _Metodo = pvsMetodo;
        _Sentencia = string.Empty;
        _Descripcion = pvsDescripcion;
        _Usuario = pvsUsuario;
    }

    public ENError(string pvsClase, string pvsMetodo, string pvsDescripcion)
    {
        _Clase = pvsClase;
        _Proceso = string.Empty;
        _Metodo = pvsMetodo;
        _Sentencia = string.Empty;
        _Descripcion = pvsDescripcion;
    }

    public ENError(ENError objError)
    {
        _IdError = objError.IdError;
        _Fecha = objError.Fecha;
        _FechaNum = objError.FechaNum;
        _Clase = objError.Clase;
        _Proceso = objError.Proceso;
        _Metodo = objError.Metodo;
        _Sentencia = objError.Sentencia;
        _Descripcion = objError.Descripcion;
        _Usuario = objError.Usuario;
    }

    public ENError()
    {
    }
    }
}
