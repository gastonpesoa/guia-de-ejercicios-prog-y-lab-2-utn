using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_36_MotoCross_VehiculoCarrera_Sobre_ej_30
{
    public class CompetenciaNoDisponibleException : Exception
    {
        #region "Atributos"
        private string nombreClase;
        private string nombreMetodo;
        #endregion

        #region "Propiedades"
        public string NombreClase
        {
            get { return this.nombreClase; }
        }
        public string NombreMetodo
        {
            get { return this.nombreMetodo; }
        }
        #endregion

        #region "Constructores"
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo)
            : base(mensaje)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        #endregion

        #region "Metodos"
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Excepción en el método {0} de la clase {1}:", this.NombreClase, this.NombreMetodo);
            s.AppendLine(this.Message);
            Exception exAux = this.InnerException;
            while (exAux != null)
            {
                s.AppendLine("\t" + exAux.Message);
                exAux = exAux.InnerException;
            }
            return s.ToString(); 
        }
        #endregion
    }
}
