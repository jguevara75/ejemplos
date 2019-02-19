using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilidades
{
    public class SUConversiones
    {
        // '' <summary>
        // '' Crea un Objecto Database
        // '' </summary>
        // '' <retorna>Un Objecto base de datos</retorna>
        public static double ConvierteADouble(object oValor)
        {
            double nValorNumerico = 0;
            double outresult = 0;
            double.TryParse(oValor.ToString().Trim(),out outresult);
            if ((outresult == 0))
            {
                nValorNumerico = 0;
            }
            else
            {
                nValorNumerico = Convert.ToDouble(oValor.ToString().Trim());
            }
            return nValorNumerico;
        }

        // '' <summary>
        // '' Convierte un objeto a entero
        // '' </summary>
        // '' <retorna>Un valor entero</retorna>
        public static Int16 ConvierteAInt16(object oValor)
        {
            Int16 nValorNumerico = 0;
            Int16 outresult = 0;
            if (oValor != null)
            {
                Int16.TryParse(oValor.ToString().Trim(), out outresult);
                if ((outresult == 0))
                {
                    nValorNumerico = 0;
                }
                else
                {
                    nValorNumerico = Convert.ToInt16(oValor.ToString().Trim());
                }
            }
            return nValorNumerico;
        }

        // '' <summary>
        // '' Convierte un objeto a entero
        // '' </summary>
        // '' <retorna>Un valor entero</retorna>
        public static Int32 ConvierteAInt32(object oValor)
        {
            Int32 nValorNumerico = 0;
            Int32 outresult = 0;
            if (oValor != null)
            {
                Int32.TryParse(oValor.ToString().Trim(), out outresult);
                if ((outresult == 0))
                {
                    nValorNumerico = 0;
                }
                else
                {
                    nValorNumerico = Convert.ToInt32(oValor.ToString().Trim());
                }
            }
            return nValorNumerico;
        }

        // '' <summary>
        // '' Convierte un objeto a entero
        // '' </summary>
        // '' <retorna>Un valor entero</retorna>
        public static Int64 ConvierteAInt64(object oValor)
        {
            Int64 nValorNumerico = 0;
            Int64 outresult = 0;
            if (oValor != null)
            {
                Int64.TryParse(oValor.ToString().Trim(), out outresult);
                if ((outresult == 0))
                {
                    nValorNumerico = 0;
                }
                else
                {
                    nValorNumerico = Convert.ToInt64(oValor.ToString().Trim());
                }
            }
            else
            {
                nValorNumerico = 0;
            }
            return nValorNumerico;
        }

        // '' <summary>
        // '' Convierte un objeto a decimal
        // '' </summary>
        // '' <retorna>Un valor decimal</retorna>
        public static Decimal ConvierteADecimal(object oValor)
        {
            Decimal nValorNumerico = 0;
            Decimal outresult = 0;
            Decimal.TryParse(oValor.ToString().Trim(),out outresult);
            if ((outresult == 0))
            {
                nValorNumerico = 0;
            }
            else
            {
                nValorNumerico = Convert.ToDecimal(oValor.ToString().Trim());
            }
            return nValorNumerico;
        }

        // '' <summary>
        // '' Convierte un objeto a decimal
        // '' </summary>
        // '' <retorna>Un valor decimal</retorna>
        public static Boolean ConvierteABoolean(object oValor)
        {
            Boolean bValorBoolean = false;
            Boolean outresult = false;
            Boolean.TryParse(oValor.ToString().Trim(), out outresult);
            if ((outresult == false))
            {
                bValorBoolean = false;
            }
            else
            {
                bValorBoolean = Convert.ToBoolean(oValor.ToString().Trim());
            }
            return bValorBoolean;
        }
    }
}
