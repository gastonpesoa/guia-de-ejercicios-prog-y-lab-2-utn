using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_30_Competencia_AutoF1
{
    public class AutoF1
    {
        //Atributos
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        //Constructores
        private AutoF1()
        {
            this.EnCompetencia = false;
            this.CantidadCombustible = 0;
            this.VueltasRestantes = 0;
        }

        public AutoF1(short numero, string escuderia)
            :this()
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        //Propiedades
        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        //Sobrecargas
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.numero == a2.numero) && (a1.escuderia == a2.escuderia);  
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        //Metodo
        public string MostrarDatos()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Auto numero: {0} - Escuderia: {1} - En Competencia: {2} - Cantidad Vueltas Restantes: {3} - Cantidad Combustible: {4}", this.numero, this.escuderia, this.EnCompetencia, this.VueltasRestantes, this.CantidadCombustible);
            return s.ToString();
        }
    }
}
