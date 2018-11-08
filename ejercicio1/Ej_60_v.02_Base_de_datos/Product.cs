using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_60_v._02_Base_de_datos
{
    public class Product
    {
        #region "Campos"
        private int productID;
        private string name;
        private string color;
        private double listPrice;
        #endregion

        #region "Propiedades"
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double ListPrice
        {
            get { return listPrice; }
            set { listPrice = value; }
        }
        #endregion

        #region "Constructores"
        public Product(string name, string color, double price)
        {
            this.Name = name;
            this.Color = color;
            this.ListPrice = price;
        }

        public Product(int id, string name, string color, double price)
            :this(name,color,price)
        {
            this.ProductID = id;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("{0} {1} {2} {3}", this.ProductID, this.Name, this.Color, this.ListPrice);
            return s.ToString();
        }
        #endregion
    }
}
