using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.PrestamosPersonales;

namespace Entidades
{
    namespace EntidadFinanciera
    {
        public class Financiera
        {
            #region "Atributos"
            private List<Prestamo> listaDePrestamos;
            private string razonSocial;
            #endregion

            #region "Propiedades"
            /// <summary>
            /// Lectura de los intereses totales ganados de prestamos en dolares calculado por el metodo CalcularInteresGanado
            /// </summary>
            public float InteresesEnDolares
            {
                get
                {
                    return this.CalcularInteresGanado(TipoDePrestamo.Dolares);
                }
            }
            /// <summary>
            /// Lectura de los intereses totales ganados de prestamos en pesos calculado por el metodo CalcularInteresGanado
            /// </summary>
            public float InteresesEnPesos
            {
                get
                {
                    return this.CalcularInteresGanado(TipoDePrestamo.Pesos);
                }
            }
            /// <summary>
            /// Lectura de los intereses totales ganados de prestamos calculado por el metodo CalcularInteresGanado
            /// </summary>
            public float InteresesTotales
            {
                get
                {
                    return this.CalcularInteresGanado(TipoDePrestamo.Todos);
                }
            }
            /// <summary>
            /// Lectura de lista de prestamos de la instancia tipo Financiera
            /// </summary>
            public List<Prestamo> ListaDePrestamos
            {
                get
                {
                    return this.listaDePrestamos;
                }
            }
            /// <summary>
            /// Lectura de la razon social de la instancia tipo Financiera
            /// </summary>
            public string RazonSocial
            {
                get
                {
                    return this.razonSocial;
                }
            }
            #endregion

            #region "Constructores"
            /// <summary>
            /// Constructor privado de instancias tipo Financiera encargado de inicializar la lista de prestamos
            /// </summary>
            private Financiera()
            {
                this.listaDePrestamos = new List<Prestamo>();
            }
            /// <summary>
            /// Constructar encargado de asignar la razon social definida a la instancia tipo Financiera
            /// </summary>
            /// <param name="razonSocial">Razon social con la que se iniciara la instancia</param>
            public Financiera(string razonSocial)
                : this()
            {
                this.razonSocial = razonSocial;
            }
            #endregion

            #region "Metodos"
            /// <summary>
            /// Metodo estatico encargado de exponer a traves de conversion explicita datos de la instancia tipo Financiera
            /// </summary>
            /// <param name="financiera">Instancia tipo Financiera de la que se mostraran los datos</param>
            /// <returns>string con detalle de la instancia</returns>
            public static string Mostrar(Financiera financiera)
            {
                return (string)financiera;
            }
            /// <summary>
            /// Ordena por fecha de vencimiento la lista de prestamos
            /// </summary>
            public void OrdenarPrestamos()
            {
                this.listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
            }
            /// <summary>
            /// Calcula la suma total de intereses segun el tipo de prestamo solicitado
            /// </summary>
            /// <param name="tipoPrestamo">TipoDePrestamo con el que se evaluara la suma total de intereses</param>
            /// <returns>float suma total de intereses del tipo de prestamo solicitado</returns>
            private float CalcularInteresGanado(TipoDePrestamo tipoPrestamo)
            {
                float interesesGanados = 0;
                switch (tipoPrestamo)
                {
                    case TipoDePrestamo.Pesos:
                        foreach (Prestamo prestamo in this.listaDePrestamos)
                        {
                            if (prestamo is PrestamoPesos)
                            {
                                interesesGanados += ((PrestamoPesos)prestamo).Interes;
                            }
                        }
                        break;
                    case TipoDePrestamo.Dolares:
                        foreach (Prestamo prestamo in this.listaDePrestamos)
                        {
                            if (prestamo is PrestamoDolar)
                            {
                                interesesGanados += ((PrestamoDolar)prestamo).Interes;
                            }
                        }
                        break;
                    case TipoDePrestamo.Todos:
                        foreach (Prestamo prestamo in this.listaDePrestamos)
                        {
                            if (prestamo is PrestamoPesos)
                            {
                                interesesGanados += ((PrestamoPesos)prestamo).Interes;
                            }
                            if (prestamo is PrestamoDolar)
                            {
                                interesesGanados += ((PrestamoDolar)prestamo).Interes;
                            }
                        }
                        break;
                    default:
                        interesesGanados = 0;
                        break;
                }
                return interesesGanados;
            }
            #endregion

            #region "Sobrecargas"
            /// <summary>
            /// Sobrecarga de conversion explicita a string encargado de retornar un string con los datos de la instancia
            /// </summary>
            /// <param name="financiera">Instancia de tipo Financiera de la que se expondran los datos</param>
            public static explicit operator string(Financiera financiera)
            {
                StringBuilder s = new StringBuilder();
                s.AppendLine("***********************************************RAZON SOCIAL**********************************************\n");
                s.AppendLine(financiera.RazonSocial);
                s.AppendLine("\n*******************************************DETALLE DE PRESTAMOS*******************************************\n");
                s.AppendFormat("{0, -20} {1, -20} {2, -20} {3, -20}\n", "Monto", "Vencimiento", "Interes", "Periodicidad");
                foreach (Prestamo prestamo in financiera.listaDePrestamos)
                {
                    s.AppendLine(prestamo.Mostrar());
                }
                s.AppendLine("\n*******************************************INFORME DE INTERESES********************************************\n");
                s.AppendFormat("{0, -33} {1,-33} {2,-33}\n", "Intereses Totales Ganados", "Intereses por Prestamos en Pesos", "Intereses por Prestamos en Dolares");
                s.AppendFormat("{0,-33} {1, -33} {2, -33}\n", financiera.InteresesTotales, financiera.InteresesEnPesos, financiera.InteresesEnDolares);
                s.AppendLine("\n***********************************************************************************************************\n");
                return s.ToString();
            }
            #endregion

            #region "Operadores"
            /// <summary>
            /// Sobrecarga del operador == encargado de evaluar si el prestamo solicitado forma parte de la lista o no
            /// Dos prestamos son iguales cuando poseen el mismo monto y fecha de vencimiento
            /// </summary>
            /// <param name="financiera">Instancia de tipo Financiera de la que se buscara en su lista de prestamos coincidencia</param>
            /// <param name="prestamo">Instancia de tipo Prestamo que se buscara coincidencia en la lista de prestamos</param>
            /// <returns>true se el prestamo se encuentra en la lista - false si no se encuentra</returns>
            public static bool operator ==(Financiera financiera, Prestamo prestamo)
            {
                bool returnAux = false;
                foreach (Prestamo prestamoEnLista in financiera.listaDePrestamos)
                {
                    if (prestamoEnLista.Monto == prestamo.Monto && (prestamoEnLista.Vencimiento.CompareTo(prestamo.Vencimiento) == 0))
                    {
                        returnAux = true;
                        break;
                    }
                }
                return returnAux;
            }
            /// <summary>
            /// Sobrecarga del operador == encargado de evaluar si el prestamo solicitado forma parte de la lista o no
            /// Dos prestamos son iguales cuando poseen el mismo monto y fecha de vencimiento
            /// </summary>
            /// <param name="financiera">Instancia de tipo Financiera de la que se buscara en su lista de prestamos coincidencia</param>
            /// <param name="prestamo">Instancia de tipo Prestamo que se buscara coincidencia en la lista de prestamos</param>
            /// <returns>false se el prestamo se encuentra en la lista - true si no se encuentra</returns>
            public static bool operator !=(Financiera financiera, Prestamo prestamo)
            {
                return !(financiera == prestamo);
            }
            /// <summary>
            /// Sobrecarga del operador + encargado agregar un nuevo prestamo a la lista de prestamos de la instancia tipo Financiera 
            /// Previa validacion de que el mismo no se encuentre en la lista previamente
            /// </summary>
            /// <param name="financiera">Instancia de tipo Financiera a en la que se agregara a su lista de prestamos el nuevo prestamo solicitado</param>
            /// <param name="prestamoNuevo">Instancia de tipo Prestamo que se agregara a la lista de prestamos</param>
            /// <returns>
            /// Financiera con nuevo prestamo agregado a la lista en caso de Ok 
            /// Misma financiera en caso de que que el prestamos ya se encuentre previamente en la lista
            /// </returns>
            public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
            {
                if (financiera != prestamoNuevo)
                {
                    financiera.listaDePrestamos.Add(prestamoNuevo);
                }
                return financiera;
            }
            #endregion
        }
    }
}
