
namespace MultiEjercicios
{
    partial class FrmNumerosNaturales
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
            this.LblNumero1 = new System.Windows.Forms.Label();
            this.LblNumero2 = new System.Windows.Forms.Label();
            this.TxtNumero1 = new System.Windows.Forms.TextBox();
            this.TxtNumero2 = new System.Windows.Forms.TextBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LstMostrar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblNumero1
            // 
            this.LblNumero1.AutoSize = true;
            this.LblNumero1.Location = new System.Drawing.Point(26, 75);
            this.LblNumero1.Name = "LblNumero1";
            this.LblNumero1.Size = new System.Drawing.Size(53, 13);
            this.LblNumero1.TabIndex = 0;
            this.LblNumero1.Text = "Numero 1";
            // 
            // LblNumero2
            // 
            this.LblNumero2.AutoSize = true;
            this.LblNumero2.Location = new System.Drawing.Point(26, 132);
            this.LblNumero2.Name = "LblNumero2";
            this.LblNumero2.Size = new System.Drawing.Size(53, 13);
            this.LblNumero2.TabIndex = 1;
            this.LblNumero2.Text = "Numero 2";
            // 
            // TxtNumero1
            // 
            this.TxtNumero1.Location = new System.Drawing.Point(97, 67);
            this.TxtNumero1.Name = "TxtNumero1";
            this.TxtNumero1.Size = new System.Drawing.Size(100, 20);
            this.TxtNumero1.TabIndex = 2;
            // 
            // TxtNumero2
            // 
            this.TxtNumero2.Location = new System.Drawing.Point(97, 129);
            this.TxtNumero2.Name = "TxtNumero2";
            this.TxtNumero2.Size = new System.Drawing.Size(100, 20);
            this.TxtNumero2.TabIndex = 3;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(29, 179);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrar.TabIndex = 4;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(122, 179);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 5;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(214, 179);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LstMostrar
            // 
            this.LstMostrar.FormattingEnabled = true;
            this.LstMostrar.Location = new System.Drawing.Point(29, 232);
            this.LstMostrar.Name = "LstMostrar";
            this.LstMostrar.Size = new System.Drawing.Size(260, 199);
            this.LstMostrar.TabIndex = 7;
            // 
            // FrmNumerosNaturales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 450);
            this.Controls.Add(this.LstMostrar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.TxtNumero2);
            this.Controls.Add(this.TxtNumero1);
            this.Controls.Add(this.LblNumero2);
            this.Controls.Add(this.LblNumero1);
            this.Name = "FrmNumerosNaturales";
            this.Text = "Numeros Naturales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumero1;
        private System.Windows.Forms.Label LblNumero2;
        private System.Windows.Forms.TextBox TxtNumero1;
        private System.Windows.Forms.TextBox TxtNumero2;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ListBox LstMostrar;
    }
}