using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_60_v._02_Base_de_datos
{
    public partial class ABMProducts : Form
    {
        private DataBaseConecction dBC = null;

        public ABMProducts()
        {
            InitializeComponent();
        }

        private void ABMProducts_Load(object sender, EventArgs e)
        {
            try
            {
                this.dBC = new DataBaseConecction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private bool ValidId(string id, out int validId)
        {
            return int.TryParse(id, out validId);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.ValidId(txtBoxProductId.Text, out int validId))
            {
                this.ClearTxtBox();
                Product pAux = null;
                try
                {
                    pAux = this.dBC.SearchProductBydId(validId);
                    //int n = dataGridViewProducts.Rows.Add();
                    this.MostrarProduct(pAux);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El ID del producto debe ser numerico", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxListPrice.Text, out double validPrice))
            {
                Product newProduct = new Product(textBoxName.Text, textBoxColor.Text, validPrice);
                this.ClearTxtBox();
                try
                {
                    if(dBC.InsertItem(newProduct))
                    {
                        this.MostrarProduct(newProduct);
                    } 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("El precio del producto debe ser numerico", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void MostrarProduct(Product p)
        {
            dataGridViewProducts.Rows[0].Cells[0].Value = p.ProductID;
            dataGridViewProducts.Rows[0].Cells[1].Value = p.Name;
            dataGridViewProducts.Rows[0].Cells[2].Value = p.Color;
            dataGridViewProducts.Rows[0].Cells[3].Value = p.ListPrice;
        }

        private void ClearTxtBox()
        {
            txtBoxProductId.Text = "";
            textBoxName.Text = "";
            textBoxColor.Text = "";
            textBoxListPrice.Text = "";
        }
    }
}
