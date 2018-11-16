using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dao : IArchivos<Votacion>
    {
        #region "Campos"
        private SqlCommand comando;
        private SqlConnection conexion;
        #endregion

        public Dao()
        {
            try
            {
                String connectionString = "Server=.\\SQLEXPRESS;Database=votacion-sp-2018;Trusted_Connection=True;";
                this.conexion = new SqlConnection(connectionString);
                this.comando = new SqlCommand();
                this.comando.Connection = this.conexion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Votacion Leer(string rutaArchivo)
        {
            throw new NotImplementedException("Método no implementado");
        }

        public bool Guardar(string rutaArchivo, Votacion v)
        {
            bool returnAux = false;
            try
            {
                this.conexion.Open();

                this.comando.CommandText = "INSERT INTO dbo.Votaciones(nombreLey, afirmativos, negativos, abstenciones, nombreAlumno)" +
                    "VALUES('" + v.NombreLey + "'," + v.ContadorAfirmativo + "," + v.ContadorNegativo + "," + v.ContadorAbstencion + ",'" + "Gastón Pesoa" + "')";

                
                this.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.conexion.Close();
            }
            returnAux = true;
            return returnAux;
        }
    }
}
