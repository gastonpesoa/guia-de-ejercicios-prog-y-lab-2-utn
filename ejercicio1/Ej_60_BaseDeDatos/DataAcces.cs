using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Ej_60_BaseDeDatos
{
    public class DataAcces
    {
        public List<Product> GetProducts(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AdventureWorks2012")))
            {
                var output = connection.Query<Product>($"select * from Production.Product where Name = '{ name }'").ToList();
                return output;
            }
        }
    }
}
