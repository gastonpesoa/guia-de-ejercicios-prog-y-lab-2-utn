using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_38_Sobreescrito_Override
{
    public class Sobreescrito
    {
        public override string ToString()
        {
            return "\n¡Este es mi método ToString sobreescrito!\n"; 
        }

        public override bool Equals(object obj)
        {
            return obj is Sobreescrito;    
        }

        public override int GetHashCode()
        {
            return 1142510187;  
        }
    }
}
