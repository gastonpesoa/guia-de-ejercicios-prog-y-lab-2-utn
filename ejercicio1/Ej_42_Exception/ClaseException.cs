using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_42_Exception
{
    public class ClaseException
    {
        public static void MetodoException(int numUno, int numDos)
        {
            try
            {
                int r = numUno / numDos;
            }
            catch(DivideByZeroException e)
            {
                throw e;
            }
        }

        public ClaseException()
        {
            try
            {
                ClaseException.MetodoException(1, 0);
            }
            catch(DivideByZeroException d)
            {
                throw d;
            }
        }
    }
}
