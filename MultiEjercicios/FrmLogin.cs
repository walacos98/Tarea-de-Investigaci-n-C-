using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Walter Acosta
 * AA23053
*/

namespace MultiEjercicios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //Funcion del boton ingresar...
        private void BtnIngreso_Click(object sender, EventArgs e)
        {
            //Creamos y asignamos las variables user y pass
            string user, pass;
            //Usuario
            user = TxtUser.Text.TrimEnd();
            //Contraseña
            pass = TxtPass.Text.TrimEnd();
            try
            {
                if (user == "walacos98" && pass == "Apollo")
                {
                    MessageBox.Show(string.Format("Bienvenido {0}...", user));
                    this.Hide();
                    FrmPrincipal Fp = new FrmPrincipal();
                    Fp.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrertos...\n\nIntente de nuevo...");
                    TxtUser.Text = "";
                    TxtPass.Text = "";
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        //Boton Salir...
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
