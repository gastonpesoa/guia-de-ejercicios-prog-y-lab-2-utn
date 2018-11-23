using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patentes;
using Entidades;
using Archivos;
using System.Threading;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        Queue<Patente> cola;
        public List<Thread> hilos;

        public FrmPpal()
        {
            InitializeComponent();

            this.cola = new Queue<Patente>();
            this.hilos = new List<Thread>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            this.vistaPatente1.finExposicion += this.ProximaPatente;
            this.vistaPatente2.finExposicion += this.ProximaPatente;
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                Xml<Patente> xml = new Xml<Patente>();
                xml.Leer("patente.xml", out this.cola);
                this.InicializarSimulacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            try
            {
                Texto texto = new Texto();
                texto.Leer("patentes.txt", out this.cola);
                this.InicializarSimulacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            try
            {
                Sql sql = new Sql();
                sql.Leer("Patentes", out this.cola);
                this.InicializarSimulacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ProximaPatente(VistaPatente patente)
        {
            while(this.cola.Count > 0)
            {
                Thread nuevoHilo = new Thread(patente.MostrarPatente);
                hilos.Add(nuevoHilo);
                nuevoHilo.Start(patente);
            }
        }

        private void FinalizarSimulacion()
        {
            foreach (Thread h in this.hilos)
            {
                if (h.IsAlive && h != null)
                {
                    h.Abort();
                }
            }
        }

        private void InicializarSimulacion()
        {
            this.FinalizarSimulacion();
            this.ProximaPatente(this.vistaPatente1);
            this.ProximaPatente(this.vistaPatente2); 
        }
    }
}
