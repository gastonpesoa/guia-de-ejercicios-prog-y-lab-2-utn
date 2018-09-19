using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ej_31_Cliente_Negocio_PuestoAtencion
{
    public class PuestoAtencion
    {   
        //Atributos
        private static int numeroActual;
        private Puesto puesto;
        //Enumerados
        public enum Puesto
        {
            Caja1,
            Caja2
        }
        //Propiedades
        public static int NumeroActual
        {
            get
            {
                PuestoAtencion.numeroActual++;
                return PuestoAtencion.numeroActual;
            }
        }
        //Metodos
        //Constructores
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        
        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            Random r = new Random();
            Thread.Sleep(r.Next(1000, 3000));
            return true;

        }
    }
}
