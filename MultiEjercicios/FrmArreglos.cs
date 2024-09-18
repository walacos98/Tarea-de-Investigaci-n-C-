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
    public partial class FrmArreglos : Form
    {
        public FrmArreglos()
        {
            InitializeComponent();
        }

        private void BtnVector_Click(object sender, EventArgs e)
        {
            int[] numero = new int[] {1,2,3,4,5};
            foreach(int element in numero)
            {
                MessageBox.Show(numero[element].ToString());
            }
        }

        private void BtnMatriz_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[3, 3] { {1,2,3 },{4,5,6 },{7,8,9 } };
            int elemento = matriz[1,2];
            MessageBox.Show("Matriz [1,2]: "+ elemento );
            String element = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    element = element + matriz[i, j].ToString() + " ";
                }
                element += "\n";
            }
            //MessageBox.Show(matriz[i, j].ToString());
            MessageBox.Show(element);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
