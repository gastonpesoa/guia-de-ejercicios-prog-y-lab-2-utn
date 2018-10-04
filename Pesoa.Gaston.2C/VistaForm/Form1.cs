using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class Form1 : Form
    {
        #region "Atributos"
        public DirectorTecnico directorTecnico;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Crea una nueva instancia de tipo DirectorTecnico con los datos cargados en el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.directorTecnico = new DirectorTecnico(txtNombre.Text, txtApellido.Text, (int)numericUpDownEdad.Value, (int)numericUpDownDNI.Value, (int)numericUpDownExperiencia.Value);
            MessageBox.Show("Se ha creado el DT!");
        }
        /// <summary>
        /// Muestra un mensaje al usuario de acuerdo a si se creo previamente la instancia o
        /// si el Dt es apto o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (this.directorTecnico is null)
            {
                MessageBox.Show("Aún no se ha creado el DT del formulario");
            }
            else
            {
                if (this.directorTecnico.ValidarAptitud())
                {
                    MessageBox.Show("El DT es apto");
                }
                else
                {
                    MessageBox.Show("El DT no es apto");
                }
                
            }
        }
    }
}
