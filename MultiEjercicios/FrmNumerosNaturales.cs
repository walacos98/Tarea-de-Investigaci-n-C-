using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiEjercicios
{
    public partial class FrmNumerosNaturales : Form
    {
        public FrmNumerosNaturales()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            //Creamos Variables
            int Numero1, Numero2, Par = 0, Impar = 0;
            //Asignamos los valores...
            Numero1 = Convert.ToInt32(TxtNumero1.Text);
            Numero2 = Convert.ToInt32(TxtNumero2.Text);
            try
            {
                for (int i = Numero1 + 1; i < Numero2; i++)
                {
                    if(i % 2 == 0)
                    {
                        Par++;
                    }
                    else
                    {
                        Impar++;
                    }
                    LstMostrar.Items.Add(Convert.ToString(i));
                }
                MessageBox.Show(String.Format("Numeros pares: {0}\nNumeros Impares: {1}", Par, Impar));
            }
            catch (Exception)
            {
                MessageBox.Show("Favor de ingresar numeros... Formato Null invalido...", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNumero1.Clear();
            TxtNumero2.Clear();
            LstMostrar.Items.Clear();
            TxtNumero1.Focus();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
