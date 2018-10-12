using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_42_Exception
{
    public class UnaException : Exception
    {
        public UnaException(string fallo,Exception exception) 
            :base(fallo, exception) { }
    }
}
