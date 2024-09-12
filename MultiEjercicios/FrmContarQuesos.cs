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
    public partial class FrmContarQuesos : Form
    {
        public FrmContarQuesos()
        {
            InitializeComponent();
        }

        //Declaracion de variables globales...
        int Cheddar = 0, Ricota = 0, Masdan = 0, Mozzarella = 0, Gorgonzola = 0, Cantidad, total = 0;

        //Boton de limpiar para agregar nuevos quesos...
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            //Dejando en blanco los text...
            ComboQuesos.Text = "";
            TxtCantidad.Text = "";
            ComboQuesos.Focus();
        }

        private void TxtCalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de Variables
            string Quesos;

            //Limpinando ListBox...
            LstResultado.Items.Clear();
            try
            {
                //Asignando Variables...
                Quesos = ComboQuesos.Text;
                Cantidad = Convert.ToInt32(TxtCantidad.Text);

                //Sumando cada queso
                if (Quesos == "Cheddar")
                {
                    for (int i = Cheddar; i < Cantidad; i++)
                    {
                        Cheddar++;
                    }
                }
                else
                {
                    if (Quesos == "Ricota")
                    {
                        for (int i = Ricota; i < Cantidad; i++)
                        {
                            Ricota++;
                        }
                    }
                    else
                    {
                        if (Quesos == "Masdan")
                        {
                            for (int i = Masdan; i < Cantidad; i++)
                            {
                                Masdan++;
                            }
                        }
                        else
                        {
                            if (Quesos == "Mozzarella")
                            {
                                for (int i = Mozzarella; i < Cantidad; i++)
                                {
                                    Mozzarella++;
                                }
                            }
                            else
                            {
                                if (Quesos == "Gorgonzola")
                                {
                                    for (int i = Gorgonzola; i < Cantidad; i++)
                                    {
                                        Gorgonzola++;
                                    }
                                }
                                else
                                {
                                    //Mostrar error por si se metio un queso diferente...
                                    MessageBox.Show("Favor de ingresar un Queso correcto...","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    //Limpinado los text...
                                    ComboQuesos.Text = "";
                                    TxtCantidad.Text = "";
                                    ComboQuesos.Focus();
                                }
                            }
                        }
                    }
                }

                total = Cheddar + Ricota + Masdan + Mozzarella + Gorgonzola;

                LstResultado.Items.Add(string.Format("Total de los quesos: {0}", total));
                LstResultado.Items.Add(string.Format("Cheddar: {0}", Cheddar));
                LstResultado.Items.Add(string.Format("Ricota: {0}", Ricota));
                LstResultado.Items.Add(string.Format("Masdan: {0}", Masdan));
                LstResultado.Items.Add(string.Format("Mozzarella: {0}", Mozzarella));
                LstResultado.Items.Add(string.Format("Gongonzola: {0}", Gorgonzola));
            }catch
            {
                MessageBox.Show("Ingresar los datos por favor...");
            }
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Día finalizado, total de quesos vendidos: " + total,"Informacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
                ComboQuesos.Text = "";
                TxtCantidad.Text = "";
                ComboQuesos.Focus();
                LstResultado.Items.Clear();
                total = 0;
                Cheddar = 0;
                Ricota = 0;
                Masdan = 0;
                Mozzarella = 0;
                Gorgonzola = 0;

            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
