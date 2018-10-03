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
            List<KeyValuePair<string, int>> dicList = new List<KeyValuePair<string, int>>();
            StringBuilder s = new StringBuilder();

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

            dicList = miDiccionario.ToList();
            dicList.Sort((x, y) => Ej_28_Diccionarios.Form1.OrdenarDescendente(x.Value,y.Value));

            s.AppendLine("Palabras con mas apariciones: ");
            for(int i = 0; i < 3; i++)
            {
                s.AppendFormat("* {0} - apariciones: {1}\n", dicList[i].Key, dicList[i].Value);
            }
            MessageBox.Show(s.ToString(), "TOP 3",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
