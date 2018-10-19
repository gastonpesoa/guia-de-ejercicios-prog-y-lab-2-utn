using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesContabilidad
{
    public class Contabilidad<T,U> where T : Documento where U : Documento
    {
        #region "Atributos"
        private List<T> egresos;
        private List<U> ingresos;
        #endregion

        #region "Propiedades"
        public List<T> Egresos
        {
            get { return this.egresos; }
        }

        public List<U> Ingresos
        {
            get { return this.ingresos; }
        }
        #endregion

        #region "Constructores"
        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }
        #endregion

        #region "Metodos"
        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            c.Egresos.Add(egreso);
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.Ingresos.Add(ingreso);
            return c;
        }
        #endregion
    }
}
