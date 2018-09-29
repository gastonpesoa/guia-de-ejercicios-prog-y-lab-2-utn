using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    namespace PrestamosPersonales
    {
        public abstract class Prestamo
        {
            #region "Atributos"
            protected float monto;
            protected DateTime vencimiento;
            #endregion

            #region "Propiedades"
            /// <summary>
            /// Lectura del monto del prestamo
            /// </summary>
            public float Monto
            {
                get
                {
                    return this.monto;
                }
            }
            /// <summary>
            /// Lectura del vencimiento del prestamo
            /// Escritura, del vencimiento del prestamo ingresado, en caso de que sea superior a la fecha actual
            /// Caso contrario asigna fecha actual
            /// </summary>
            public DateTime Vencimiento
            {
                get
                {
                    return this.vencimiento;
                }
                set
                {
                    DateTime fechaActual = DateTime.Now;
                    if (value.CompareTo(fechaActual) > 0)
                    {
                        this.vencimiento = value;
                    }
                    else
                    {
                        this.vencimiento = fechaActual;
                    }
                }
            }
            #endregion

            #region "Constructores"
            /// <summary>
            /// Constructor de instancias tipo Prestamo
            /// </summary>
            /// <param name="monto">Monto con el que se iniciara la instancia</param>
            /// <param name="vencimiento">Vencimiento con el que se iniciara la instancia</param>
            public Prestamo(float monto, DateTime vencimiento)
            {
                this.monto = monto;
                this.vencimiento = vencimiento;
            }
            #endregion

            #region "Metodos"
            /// <summary>
            /// Expone detalle del prestamo
            /// </summary>
            /// <returns>string con datos del prestamo</returns>
            public virtual string Mostrar()
            {
                StringBuilder s = new StringBuilder();
                s.AppendFormat("{0,-20} {1,-20}", this.Monto, this.Vencimiento);
                return s.ToString();
            }
            /// <summary>
            /// Metodo estatico utilizado en el metodo Sort de la lista de prestamos de la clase Financiera
            /// </summary>
            /// <param name="p1">Prestamo 1 a ser comparado</param>
            /// <param name="p2">Prestamo 2 a ser comparado</param>
            /// <returns>int resultado de la comparacion</returns>
            public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
            {
                return p1.Vencimiento.CompareTo(p2.Vencimiento);
            }
            /// <summary>
            /// Definicion de metodo abstracto a ser implementado en clases derivadas
            /// </summary>
            /// <param name="nuevoVencimiento"></param>
            public abstract void ExtenderPlazo(DateTime nuevoVencimiento);
            #endregion
        }

    }
}
