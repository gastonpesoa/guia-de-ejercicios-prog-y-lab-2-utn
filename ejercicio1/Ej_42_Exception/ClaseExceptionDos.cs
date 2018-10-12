using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_42_Exception
{
    public class ClaseExceptionDos
    {
        public ClaseExceptionDos(bool creado)
        {
            creado = true;
        }

        public ClaseExceptionDos()
        {
            try
            {
                new ClaseException();
            }
            catch(DivideByZeroException e)
            {
                string fallo = "Math Error: No se puede dividir por cero";
                UnaException u = new UnaException(fallo, e);
                throw u;
            }
        }

        public void MetodoExceptionDos()
        {
            try
            {
                new ClaseExceptionDos();
            }
            catch(UnaException u)
            {
                string fallo = "Math Error Dos: No se puede dividir por cero";
                MiException m = new MiException(fallo, u);
                throw m;
            }
        }
    }
}
