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
    public partial class FrmValidaciones : Form
    {
        public FrmValidaciones()
        {
            InitializeComponent();
        }

        private void Txt(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void TxtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '@' || e.KeyChar == '.' || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else if(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                return;
            }
        }

        private void BtnValidad_Click(object sender, EventArgs e)
        {
            //Validando el formato Email
            if(!ClassValidaciones.ValidaEmail(TxtEmail.Text))
            {
                MessageBox.Show("EL formato de correo no es valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Correo electronico valido...");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
