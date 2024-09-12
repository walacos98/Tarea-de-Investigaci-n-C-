
namespace MultiEjercicios
{
    partial class FrmValidaciones
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
            this.LblNumeros = new System.Windows.Forms.Label();
            this.LblLetras = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.BtnValidar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtNumeros = new System.Windows.Forms.TextBox();
            this.TxtLetras = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblNumeros
            // 
            this.LblNumeros.AutoSize = true;
            this.LblNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeros.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblNumeros.Location = new System.Drawing.Point(57, 131);
            this.LblNumeros.Name = "LblNumeros";
            this.LblNumeros.Size = new System.Drawing.Size(106, 16);
            this.LblNumeros.TabIndex = 0;
            this.LblNumeros.Text = "Solo Numeros";
            // 
            // LblLetras
            // 
            this.LblLetras.AutoSize = true;
            this.LblLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLetras.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblLetras.Location = new System.Drawing.Point(57, 55);
            this.LblLetras.Name = "LblLetras";
            this.LblLetras.Size = new System.Drawing.Size(87, 16);
            this.LblLetras.TabIndex = 1;
            this.LblLetras.Text = "Solo Letras";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblEmail.Location = new System.Drawing.Point(57, 195);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(137, 16);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "Correo Electronico";
            // 
            // BtnValidar
            // 
            this.BtnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnValidar.Location = new System.Drawing.Point(91, 292);
            this.BtnValidar.Name = "BtnValidar";
            this.BtnValidar.Size = new System.Drawing.Size(103, 39);
            this.BtnValidar.TabIndex = 3;
            this.BtnValidar.Text = "Validar";
            this.BtnValidar.UseVisualStyleBackColor = true;
            this.BtnValidar.Click += new System.EventHandler(this.BtnValidad_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnSalir.Location = new System.Drawing.Point(300, 292);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(103, 39);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(212, 195);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(217, 20);
            this.TxtEmail.TabIndex = 5;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // TxtNumeros
            // 
            this.TxtNumeros.Location = new System.Drawing.Point(212, 127);
            this.TxtNumeros.Name = "TxtNumeros";
            this.TxtNumeros.Size = new System.Drawing.Size(217, 20);
            this.TxtNumeros.TabIndex = 6;
            this.TxtNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeros_KeyPress);
            // 
            // TxtLetras
            // 
            this.TxtLetras.Location = new System.Drawing.Point(212, 54);
            this.TxtLetras.Name = "TxtLetras";
            this.TxtLetras.Size = new System.Drawing.Size(217, 20);
            this.TxtLetras.TabIndex = 7;
            this.TxtLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLetras_KeyPress);
            // 
            // FrmValidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 365);
            this.Controls.Add(this.TxtLetras);
            this.Controls.Add(this.TxtNumeros);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnValidar);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblLetras);
            this.Controls.Add(this.LblNumeros);
            this.Name = "FrmValidaciones";
            this.Text = "Validaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumeros;
        private System.Windows.Forms.Label LblLetras;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Button BtnValidar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtNumeros;
        private System.Windows.Forms.TextBox TxtLetras;
    }
}