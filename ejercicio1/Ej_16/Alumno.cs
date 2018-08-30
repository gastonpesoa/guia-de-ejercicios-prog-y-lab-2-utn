using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ej_16
{
    public class Alumno
    {
        
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void CalcularFinal()
        {
            Thread.Sleep(150);
            Random random = new Random();
            this.notaFinal = -1;
            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                this.notaFinal = random.Next(1,10);
            }
        }

        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if(this.notaFinal == -1)
            {
                stringBuilder.AppendFormat("{0} {1}\nLegajo: {2}\nNota 1: {3} Nota 2: {4}\nNota Final: {5}", this.nombre, this.apellido, this.legajo, this.nota1, this.nota2, "Alumno desaprobado");
            }
            else
            {
                stringBuilder.AppendFormat("{0} {1}\nLegajo: {2}\nNota 1: {3} Nota 2: {4}\nNota Final: {5}", this.nombre, this.apellido, this.legajo, this.nota1, this.nota2, this.notaFinal);
            }
            
            return stringBuilder.ToString();
        }
    }
}
