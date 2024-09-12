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
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        //Boton Salir...
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boton mostar...
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            //Crar variables...
            double total = 0.0;

            //Calculamos si selecciono el envio normal...
            if (RadNormal.Checked == true && RadCasa.Checked == true)
            {
                total = 5 + 5;
            }
            else
            {
                if (RadNormal.Checked == true && RadCorreos.Checked == true)
                {
                    total = 5;
                }
            }

            //Calculamos si selecciono el envio Express...
            if (RadExpress.Checked == true && RadCasa.Checked == true)
            {
                total = 10 + 5;
            }
            else
            {
                if (RadExpress.Checked == true && RadCorreos.Checked == true)
                {
                    total = 10;
                }
            }

            //Calculamos si selecciono el envio Premiun...
            if (RadPremiun.Checked == true && RadCasa.Checked == true)
            {
                total = 20 + 5;
            }
            else
            {
                if (RadPremiun.Checked == true && RadCorreos.Checked == true)
                {
                    total = 20;
                }
            }

            //Mostramos el resultado...
            MessageBox.Show("El total del envio es: $" + total.ToString());
        }
    }
}
