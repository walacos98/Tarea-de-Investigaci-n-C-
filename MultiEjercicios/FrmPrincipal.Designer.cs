
namespace MultiEjercicios
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPedidos = new System.Windows.Forms.Button();
            this.LblEjercicios = new System.Windows.Forms.Label();
            this.BtnValidadiociones = new System.Windows.Forms.Button();
            this.BtnPromedioNotas = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnNumerosNaturales = new System.Windows.Forms.Button();
            this.BtnContarQuesos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPedidos
            // 
            this.BtnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPedidos.Location = new System.Drawing.Point(34, 89);
            this.BtnPedidos.Name = "BtnPedidos";
            this.BtnPedidos.Size = new System.Drawing.Size(101, 64);
            this.BtnPedidos.TabIndex = 0;
            this.BtnPedidos.Text = "Ejercicio Pedidos";
            this.BtnPedidos.UseVisualStyleBackColor = true;
            this.BtnPedidos.Click += new System.EventHandler(this.BtnPedidos_Click);
            // 
            // LblEjercicios
            // 
            this.LblEjercicios.AutoSize = true;
            this.LblEjercicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEjercicios.Location = new System.Drawing.Point(285, 25);
            this.LblEjercicios.Name = "LblEjercicios";
            this.LblEjercicios.Size = new System.Drawing.Size(153, 37);
            this.LblEjercicios.TabIndex = 1;
            this.LblEjercicios.Text = "Ejercicios";
            // 
            // BtnValidadiociones
            // 
            this.BtnValidadiociones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidadiociones.Location = new System.Drawing.Point(170, 89);
            this.BtnValidadiociones.Name = "BtnValidadiociones";
            this.BtnValidadiociones.Size = new System.Drawing.Size(101, 64);
            this.BtnValidadiociones.TabIndex = 2;
            this.BtnValidadiociones.Text = "Ejercicio Validaciones";
            this.BtnValidadiociones.UseVisualStyleBackColor = true;
            this.BtnValidadiociones.Click += new System.EventHandler(this.BtnValidadiociones_Click);
            // 
            // BtnPromedioNotas
            // 
            this.BtnPromedioNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPromedioNotas.Location = new System.Drawing.Point(303, 89);
            this.BtnPromedioNotas.Name = "BtnPromedioNotas";
            this.BtnPromedioNotas.Size = new System.Drawing.Size(101, 64);
            this.BtnPromedioNotas.TabIndex = 3;
            this.BtnPromedioNotas.Text = "Ejercicio Promedio Notas";
            this.BtnPromedioNotas.UseVisualStyleBackColor = true;
            this.BtnPromedioNotas.Click += new System.EventHandler(this.BtnPromedioNotas_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(712, 467);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnNumerosNaturales
            // 
            this.BtnNumerosNaturales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNumerosNaturales.Location = new System.Drawing.Point(433, 89);
            this.BtnNumerosNaturales.Name = "BtnNumerosNaturales";
            this.BtnNumerosNaturales.Size = new System.Drawing.Size(101, 64);
            this.BtnNumerosNaturales.TabIndex = 5;
            this.BtnNumerosNaturales.Text = "Ejercicio Numeros Naturales";
            this.BtnNumerosNaturales.UseVisualStyleBackColor = true;
            this.BtnNumerosNaturales.Click += new System.EventHandler(this.BtnNumerosNaturales_Click);
            // 
            // BtnContarQuesos
            // 
            this.BtnContarQuesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContarQuesos.Location = new System.Drawing.Point(565, 89);
            this.BtnContarQuesos.Name = "BtnContarQuesos";
            this.BtnContarQuesos.Size = new System.Drawing.Size(101, 64);
            this.BtnContarQuesos.TabIndex = 6;
            this.BtnContarQuesos.Text = "Ejercicio Contar Quesos";
            this.BtnContarQuesos.UseVisualStyleBackColor = true;
            this.BtnContarQuesos.Click += new System.EventHandler(this.BtnContarQuesos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 502);
            this.Controls.Add(this.BtnContarQuesos);
            this.Controls.Add(this.BtnNumerosNaturales);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnPromedioNotas);
            this.Controls.Add(this.BtnValidadiociones);
            this.Controls.Add(this.LblEjercicios);
            this.Controls.Add(this.BtnPedidos);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPedidos;
        private System.Windows.Forms.Label LblEjercicios;
        private System.Windows.Forms.Button BtnValidadiociones;
        private System.Windows.Forms.Button BtnPromedioNotas;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnNumerosNaturales;
        private System.Windows.Forms.Button BtnContarQuesos;
    }
}