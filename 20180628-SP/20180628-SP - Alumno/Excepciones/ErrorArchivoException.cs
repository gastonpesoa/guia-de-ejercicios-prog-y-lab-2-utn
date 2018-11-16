using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ErrorArchivoException : Exception
    {
        public ErrorArchivoException(string mje, Exception inner)
            :base(mje, inner)
        {

        }
    }
}
