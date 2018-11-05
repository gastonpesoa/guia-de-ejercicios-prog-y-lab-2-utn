using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_60_BaseDeDatos
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string ProductNumber { get; set; }

        public string Color { get; set; }

        public short SafetyStockLevel { get; set; }

        public float ListPrice { get; set; }

        public string Size { get; set; }

        public decimal Weight { get; set; }

        public DateTime SellStartDate { get; set; }

        public DateTime SellEndDate { get; set; }

        public string MostrarDatos
        {
            // "332 Freewheel Silver ($0.0000)" 
            get { return $"{ ProductID } { Name } { Color } (${ ListPrice })"; }
   
        }

    }
}
