using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            StreamWriter sW = null;
            try
            {
                sW = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                    "\\" + archivo, true);
                foreach (Patente p in datos)
                {
                    sW.WriteLine(p.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al abrir/escribir el archivo de texto\n" + ex.Message, ex);
            }
            finally
            {
                if (!(sW is null))
                {
                    sW.Close();
                }
            }
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            Patente pAux;
            string aux;
            StreamReader sR = null;
            try
            {
                sR = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                    "\\" + archivo);
                while (sR.ReadLine() != "")
                {
                    aux = sR.ReadLine();
                    pAux = aux.ValidarPatente();
                    datos.Enqueue(pAux);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer el archivo\n" + ex.Message, ex);
            }
            finally
            {
                if (!(sR is null))
                {
                    sR.Close();
                }
            }
        }
    }
}
