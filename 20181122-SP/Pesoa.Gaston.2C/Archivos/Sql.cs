using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {
        #region "Campos"
        private SqlCommand comando;
        private SqlConnection conexion;
        #endregion

        public Sql()
        {
            try
            {
                String connectionString = "Server=.\\SQLEXPRESS;Database=patentes-sp-2018;Trusted_Connection=True;";
                this.conexion = new SqlConnection(connectionString);
                this.comando = new SqlCommand();
                this.comando.Connection = this.conexion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            try
            {
                this.conexion.Open();

                foreach (Patente p in datos)
                {
                    this.comando.CommandText = "INSERT INTO " + tabla + "(patente, tipo)" +
                    "VALUES('" + p.CodigoPatente + "','" + p.TipoCodigo.ToString() + "')";

                    this.comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.conexion.Close();
            }
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            SqlDataReader reader;
            Patente aux = null;
            try
            {
                this.comando.CommandText = "SELECT * FROM " + tabla;

                this.conexion.Open();

                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    aux = reader["patente"].ToString().ValidarPatente();
                    datos.Enqueue(aux);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo consultar de la base de datos: " + ex.Message, ex);
            }
            finally
            {
                this.conexion.Close();
            }
        }
    }
}
