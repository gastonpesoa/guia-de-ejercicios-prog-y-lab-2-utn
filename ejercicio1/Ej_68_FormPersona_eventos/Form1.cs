using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_68_FormPersona_eventos
{
    public partial class FormPersona : Form
    {
        private Persona persona;
        private event DelegadoString DelegadoStringForm;

        public static void NotificarCambio(string msg)
        {
            MessageBox.Show(msg, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public FormPersona()
        {
            InitializeComponent();
        }

        private void FormPersona_Load(object sender, EventArgs e)
        {
            this.DelegadoStringForm += NotificarCambio;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            bool actualizada = false;

            if (this.persona == null)
            {
                this.persona = new Persona(txtNombre.Text, txtApellido.Text);
                this.btnCrear.Text = "Actualizar";
                this.DelegadoStringForm("Se ha creado a la persona\n" + persona.Mostrar());
            }
            else
            {
                if (this.persona.Apellido != txtApellido.Text && this.persona.Nombre != txtNombre.Text)
                {
                    this.persona.Apellido = txtApellido.Text;
                    this.persona.Nombre = txtNombre.Text;
                    this.DelegadoStringForm("Se ha cambiado el apellido y el nombre de la persona\n" + persona.Mostrar());
                    actualizada = true;
                }

                if (this.persona.Apellido != txtApellido.Text)
                {
                    this.persona.Apellido = txtApellido.Text;
                    this.DelegadoStringForm("Se ha cambiado el apellido de la persona\n" + persona.Mostrar());
                    actualizada = true;
                }

                if (this.persona.Nombre != txtNombre.Text)
                {
                    this.persona.Nombre = txtNombre.Text;
                    this.DelegadoStringForm("Se ha cambiado el nombre de la persona\n" + persona.Mostrar());
                    actualizada = true;
                }

                if (this.persona.Nombre == txtNombre.Text && this.persona.Apellido == txtApellido.Text && !actualizada)
                {
                    this.DelegadoStringForm("La persona " + persona.Mostrar() + " ya se ha creado");
                }
            }
        }
    }
}
