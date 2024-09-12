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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //Boton para salir
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boton para iniciar el ejercicio Pedidos...
        private void BtnPedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos Fp = new FrmPedidos();
            Fp.Show();
        }

        private void BtnValidadiociones_Click(object sender, EventArgs e)
        {
            FrmValidaciones Fp = new FrmValidaciones();
            Fp.Show();
        }

        private void BtnPromedioNotas_Click(object sender, EventArgs e)
        {
            FrmPromedioNotas Fp = new FrmPromedioNotas();
            Fp.Show();
        }

        private void BtnNumerosNaturales_Click(object sender, EventArgs e)
        {
            FrmNumerosNaturales Fp = new FrmNumerosNaturales();
            Fp.Show();
        }

        private void BtnContarQuesos_Click(object sender, EventArgs e)
        {
            FrmContarQuesos Fp = new FrmContarQuesos();
            Fp.Show();
        }
    }
}
