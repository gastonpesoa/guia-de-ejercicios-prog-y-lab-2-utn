using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_17
{
    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        /// <summary>
        /// Constructor de la clase Boligrafo
        /// </summary>
        /// <param name="tinta"></param>
        /// <param name="color"></param>
        public Boligrafo(short tinta,ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        /// <summary>
        /// Obtiene el color de la tinta del boligrafo
        /// </summary>
        /// <returns></returns>
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        /// <summary>
        /// Obtiene el nivel de tinta del boligrafo
        /// </summary>
        /// <returns></returns>
        public short GetTinta()
        {
            return this.tinta;
        }

        /// <summary>
        /// Asigna el nivel de tinta del boligrafo validando que sea mayor a cero
        /// y menor a la capacidad maxima
        /// </summary>
        /// <param name="tinta"></param>
        private void SetTinta(short tinta)
        {
            if(tinta >=0 && tinta <= cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }
        }
        
        /// <summary>
        /// Asigna la cantidad maxima de tinta al boligrafo
        /// </summary>
        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        /// <summary>
        /// Consume el nivel de tinta, verifica que el resto no sea menor a cero
        /// y dibuja mediante tantos '*' como haya podido gastar 
        /// </summary>
        /// <param name="gasto"></param>
        /// <param name="dibujo"></param>
        /// <returns></returns>
        public bool Pintar(int gasto, out string dibujo)
        {
            bool returnAux = false;
            dibujo = "";
            int resto = this.GetTinta() - (short)gasto;
            if (resto > 0)
            {
                this.SetTinta((short)resto);
                returnAux = true;

                for(int i = 1; i <= gasto; i++)
                {
                    dibujo += '*';  
                }
            }

            return returnAux;
        }
    }
}
