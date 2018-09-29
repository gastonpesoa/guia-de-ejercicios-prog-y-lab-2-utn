using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    namespace PrestamosPersonales
    {
        public class PrestamoDolar : Prestamo
        {
            #region "Atributos"
            private PeriodicidadDePagos periodicidad;
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
            /// <summary>
            /// Lectura de la periocidad de pago del prestamo
            /// </summary>
            public PeriodicidadDePagos Periodicidad
            {
                get
                {
                    return this.periodicidad;
                }
            }
            #endregion

            #region "Constructores"
            /// <summary>
            /// Constructor para instancias de tipo PrestamoDolar
            /// </summary>
            /// <param name="monto">Monto con el que se iniciara la instancia</param>
            /// <param name="vencimiento">Vencimiento con el que se iniciara la instancia</param>
            /// <param name="periodicidad">Periocidad de pago con la que se iniciara la instancia</param>
            public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad)
                : base(monto, vencimiento)
            {
                this.periodicidad = periodicidad;
            }
            /// <summary>
            /// Constructor para instancias de tipo PrestamoDolar
            /// </summary>
            /// <param name="prestamo">Prestamo con el que se invocara al constructor inicial 
            /// y se obtendran los datos para iniciara la instancia</param>
            /// <param name="periodicidad">Periodicidad de pago con el que se invocara al constructor inicial 
            /// y se obtendran los datos para iniciara la instancia</param>
            public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad)
                : this(prestamo.Monto, prestamo.Vencimiento, periodicidad) { }
            #endregion

            #region "Metodos"
            /// <summary>
            /// Metodo privado de instancia que calculara el total de interes del prestamo 
            /// de a cuerdo a la periodicidad del pago
            /// </summary>
            /// <returns>float interes total del prestamo</returns>
            private float CalcularInteres()
            {
                float interes;
                switch (this.Periodicidad)
                {
                    case PeriodicidadDePagos.Mensual:
                        interes = 0.25F;
                        break;
                    case PeriodicidadDePagos.Bimestral:
                        interes = 0.35F;
                        break;
                    case PeriodicidadDePagos.Trimestral:
                        interes = 0.40F;
                        break;
                    default:
                        interes = 0;
                        break;
                }
                return this.Monto * interes;
            }
            /// <summary>
            /// Implementacion del metodo abstracto heredado definido en clase base
            /// Incrementa el monto original en 2.5 dolares por cada dia de extendido el plazo
            /// Actualiza la fecha original de vencimiento
            /// </summary>
            /// <param name="nuevoVencimiento">Nueva fecha de vencimiento que se asignara a la instancia</param>
            public override void ExtenderPlazo(DateTime nuevoVencimiento)
            {
                int plazoExtendidoEnDias = (nuevoVencimiento - this.Vencimiento).Days;
                float incrementoMonto = plazoExtendidoEnDias * 2.5F;
                this.monto += incrementoMonto;
                this.Vencimiento = nuevoVencimiento;
            }
            /// <summary>
            /// Expone datos propios de la clase y clase base
            /// </summary>
            /// <returns>string con datos detalle del prestamo en dolares</returns>
            public override string Mostrar()
            {
                StringBuilder s = new StringBuilder();
                s.AppendFormat("{0,-20} {1,-20} {2,-20}", base.Mostrar(), this.Interes, this.Periodicidad);
                return s.ToString();
            }
            #endregion
        }
    }

}
