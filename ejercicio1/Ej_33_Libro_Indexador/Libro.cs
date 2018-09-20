using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_33_Libro_Indexador
{
    public class Libro
    {
        //Campos
        private List<string> paginas = new List<string>();
        //Propiedades
        public string this[int i]
        {
            get
            {
                string returnAux = "";
                if (i > 0 && i <= paginas.Count)
                {
                    returnAux = paginas[i];
                }
                return returnAux;
            }
            set
            {
                if (i > 0 && i <= paginas.Count)
                {
                    paginas[i] = value;
                }
                else
                {
                    paginas.Add(value);
                }
            }
        }
    }
}
