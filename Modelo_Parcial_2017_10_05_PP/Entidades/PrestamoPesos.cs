using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    namespace PrestamosPersonales
    {
        public class PrestamoPesos : Prestamo
        {
            #region "Atributos"
            private float porcentajeInteres;
            #endregion

            #region "Propiedades"
            /// <summary>
            /// Lectura del interes calculado por el metodo CalcularInteres
            /// </summary>
            public float Interes
            {
                get
                {
                    return this.CalcularInteres();
                }
            }
            #endregion

            #region "Constructores"
            /// <summary>
            /// Constructor para instancias de tipo PrestamoPesos
            /// </summary>
            /// <param name="monto">Monto con el que se iniciara la instancia</param>
            /// <param name="vencimiento">Vencimiento con el que se iniciara la instancia</param>
            /// <param name="interes">Interes con el que se iniciara la instancia</param>
            public PrestamoPesos(float monto, DateTime vencimiento, float interes)
                :base(monto, vencimiento)
            {
                this.porcentajeInteres = interes;
            }
            /// <summary>
            /// Constructor para instancias de tipo PrestamoPesos
            /// </summary>
            /// <param name="prestamo">Objeto del tipo Prestamo con el que se iniciara la instancia</param>
            /// <param name="porcentajeInteres">porcentajeInteres con el que se iniciara la instancia</param>
            public PrestamoPesos(Prestamo prestamo, float porcentajeInteres)
                :this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres) { }
            #endregion

            #region "Metodos"
            /// <summary>
            /// Metodo privado de instancia que calculara el total de interes del prestamo
            /// a partir del monto y el porcentaje de interes definido
            /// </summary>
            /// <returns></returns>
            private float CalcularInteres()
            {
                return this.Monto * (this.porcentajeInteres / 100);
            }
            /// <summary>
            /// Implementacion del metodo abstracto heredado definido en clase base
            /// Incrementa el interes original un 0.25% por cada dia de extendido el plazo
            /// Actualiza la fecha original de vencimiento
            /// </summary>
            /// <param name="nuevoVencimiento">Nueva fecha de vencimiento que se asignara a la instancia</param>
            public override void ExtenderPlazo(DateTime nuevoVencimiento)
            {
                int plazoExtendidoEnDias = (nuevoVencimiento - this.Vencimiento).Days;
                float incrementoInteres = plazoExtendidoEnDias * (float)0.25;
                this.porcentajeInteres += incrementoInteres;
                this.Vencimiento = nuevoVencimiento;
            }
            /// <summary>
            /// Expone datos de la clase
            /// </summary>
            /// <returns>string con detalla de la instancia</returns>
            public override string Mostrar()
            {
                StringBuilder s = new StringBuilder();
                s.AppendFormat("{0} {1}", base.Mostrar(), this.Interes);
                return s.ToString();
            }
            #endregion
        }
    }
}
