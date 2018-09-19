using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_28_Diccionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int OrdenarDescendente(int num1, int num2)
        {
            return -num1.CompareTo(num2);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> miDiccionario = new Dictionary<string, int>();

            string[] palabras = richTxtBox.Text.Split(new char[] { ' ','.',',',';',':','!','?','(',')' });

            for (int i = 0; i < palabras.Length; i++)
            {
                if (!miDiccionario.ContainsKey(palabras[i]))
                {
                    miDiccionario.Add(palabras[i], 1);
                }
                else
                {
                    miDiccionario[palabras[i]]++;
                }
            }
        }
    }
}
