using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_31_Cliente_Negocio_PuestoAtencion
{
    class Negocio
    {
<<<<<<< HEAD
=======
        //Campos
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        //Propiedades
        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                if (this != value)
                {
                    bool returnAux = this + value;
                }
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count();
            }
        }
        //Metodos
        //Constructores
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre)
            :this()
        {
            this.nombre = nombre;
        }
        //Sobrecargas
        public static bool operator ==(Negocio n, Cliente c)
        {
            bool returnAux = false;
            foreach (Cliente item in n.clientes)
            {
                if (item == c)
                {
                    returnAux = true;
                }
            }
            return returnAux;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool returnAux = false;
            if (n != c)
            {
                n.clientes.Enqueue(c);
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator ~(Negocio n)
        {
            bool returnAux = false;
            if (n.caja.Atender(n.Cliente))
            {
                returnAux = true;
            }
            return returnAux;
        }
>>>>>>> 6d8acc7d93531a7ff47f2d13abfb2b1c1abf0f05
    }
}
