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
    public partial class FrmPromedioNotas : Form
    {
        public FrmPromedioNotas()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //Asignacion de variables...
            int CantidadAlumnos, Nota, i;
            Double Promedio = 0;
            try
            {
                CantidadAlumnos = Convert.ToInt32(TxtCantAlumnos.Text);
                //Proceso...
                //Implementando el ciclo for...
                for (i = 1; i <= CantidadAlumnos; i++)
                {
                    //Leer la nota del alumno n...
                    //Validar la nota Do-While
                    do
                    {
                        //Agregar Referencia en framework>VisualBasic
                        Nota = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la nota del alumno: " + i, "Registro Nota"));
                    } while (Nota < 0 || Nota > 10);
                    Promedio += Nota;
                }
                TxtPromedio.Text = Convert.ToString(Promedio / CantidadAlumnos);
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            //DEjando en blanco las cajas de texto...
            TxtCantAlumnos.Clear();
            TxtPromedio.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //Boton paraa cerrar...
            Close();
        }
    }
}
