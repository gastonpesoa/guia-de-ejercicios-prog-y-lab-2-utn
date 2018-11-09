using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Ej_60_v._02_Base_de_datos
{
    public class DataBaseConecction
    {
        #region "SqlObjects"
        private SqlConnection conexion;
        private SqlCommand command;
        private SqlDataReader reader;
        private List<Product> productos;
        #endregion

        #region "Constructor"
        /// <summary>
        /// Constructor por defecto inicializa una conexion con la base de datos
        /// </summary>
        public DataBaseConecction()
        {
            try
            {
                this.productos = new List<Product>();
                this.conexion = new SqlConnection(this.ConnectionStringValue("AdventureWorks2012"));
                this.command = new SqlCommand();
                this.command.CommandType = System.Data.CommandType.Text;
                this.command.Connection = this.conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("No se conectó con la base de datos: " + ex.Message, ex);
            }
        }
        #endregion

        public List<Product> Productos { get { return this.productos; } }
        #region "Metodos"
        /// <summary>
        /// Retorna el conectionString correspondiente a la base de datos pasada como parametro
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private string ConnectionStringValue(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        
        public List<Product> MostrarTodos()
        {
            Product productAux = null;
            try
            {
                this.conexion.Open();
                this.command.CommandText = "SELECT * FROM Production.Product";
                this.reader = this.command.ExecuteReader();
                
                while(reader.Read())
                {
                    productAux = new Product(Convert.ToInt16(reader["ProductID"]), reader["Name"].ToString(), reader["Color"].ToString(), Convert.ToDouble(reader["ListPrice"]));
                    this.productos.Add(productAux);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo consultar de la base de datos: " + ex.Message, ex);
            }
            finally
            {
                this.conexion.Close();
            }
            return this.productos;
        }
        /// <summary>
        /// Retorna el item de la base de datos que coindcida con el Id pasado como parametro
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product SearchProductBydId(int id)
        {
            Product productAux = null;
            try
            {
                this.command.CommandText = "SELECT * FROM Production.Product WHERE ProductID="+id+"";

                this.conexion.Open();

                this.reader = command.ExecuteReader();
                if (reader.Read())
                {
                    productAux = new Product(id, reader["Name"].ToString(), reader["Color"].ToString(), Convert.ToDouble(reader["ListPrice"]));
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo consultar de la base de datos: " + ex.Message, ex);
            }
            finally
            {
                this.conexion.Close();
            }
            return productAux;
        }
        /// <summary>
        /// Inserta un nuevo item, pasado como parametro, en la base de datos
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool InsertItem(Product p)
        {
            bool returnAux = false;
            try
            {
                this.command.CommandText = "INSERT INTO Production.Product(Name, Color, ListPrice, ProductNumber, SafetyStockLevel, ReorderPoint, StandardCost, DaysToManufacture, SellStartDate) " +
                    "VALUES('" + p.Name + "', '" + p.Color + "', " + p.ListPrice + ", '" + "DC-456" + "', " + 1 + ", " + 1 + ", " + 1 + ", " + 1 + ", " + 1 + ") ";

                //this.command.Parameters.AddWithValue("@Namee", p.Name);
                //this.command.Parameters.AddWithValue("@Color", p.Color);
                //this.command.Parameters.AddWithValue("@ListPrice", p.ListPrice);
                this.conexion.Open();

                if (this.command.ExecuteNonQuery() == 4)
                {
                    returnAux = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo insertar la información a la base de datos: " + ex.Message, ex);
            }
            finally
            {
                this.conexion.Close();
            }
            return returnAux;
        }
        /// <summary>
        /// Actualiza en la base de datos el item con el Id pasado como parametro
        /// </summary>
        /// <param name="p"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool UpdateItem(int id)
        {
            Product product = null;
            bool returnAux = false;
            try
            {
                product = this.SearchProductBydId(id);

                this.command.CommandText = "UPDATE Production.Product " +
                    "SET Name = '" + product.Name + "', Color = '" + product.Color + "', ListPrice = " + product.ListPrice + " " +
                    "WHERE ProductID = " + id + "";

                this.conexion.Open();
                if (this.command.ExecuteNonQuery() > 0)
                {
                    returnAux = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron actualizar los datos: " + ex.Message, ex);
            }
            finally
            {
                this.conexion.Close();
            }
            return returnAux;
        }
        /// <summary>
        /// Elimina de la base de datos el item con el Id pasada como referencia
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteItem(int id)
        {
            bool returnAux = false;

            try
            {
                this.command.CommandText = "DELTE FROM Production.Product WHERE ProductID = @id";
                this.command.Parameters.AddWithValue("@id", id);

                this.conexion.Open();

                if (this.command.ExecuteNonQuery() > 0)
                {
                    returnAux = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el item seleccionado de la base de datos: " + ex.Message, ex);
            }
            finally
            {
                this.conexion.Close();
            }

            return returnAux;
        }
        #endregion
    }
}
