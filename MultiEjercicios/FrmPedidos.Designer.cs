
namespace MultiEjercicios
{
    partial class FrmPedidos
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.GrbEnvio = new System.Windows.Forms.GroupBox();
            this.RadPremiun = new System.Windows.Forms.RadioButton();
            this.RadExpress = new System.Windows.Forms.RadioButton();
            this.RadNormal = new System.Windows.Forms.RadioButton();
            this.GrbEntrega = new System.Windows.Forms.GroupBox();
            this.RadCorreos = new System.Windows.Forms.RadioButton();
            this.RadCasa = new System.Windows.Forms.RadioButton();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.GrbEnvio.SuspendLayout();
            this.GrbEntrega.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.LblTitulo.Location = new System.Drawing.Point(25, 33);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(341, 24);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Elija como desea recibir su pedido:";
            // 
            // GrbEnvio
            // 
            this.GrbEnvio.Controls.Add(this.RadPremiun);
            this.GrbEnvio.Controls.Add(this.RadExpress);
            this.GrbEnvio.Controls.Add(this.RadNormal);
            this.GrbEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbEnvio.ForeColor = System.Drawing.SystemColors.Control;
            this.GrbEnvio.Location = new System.Drawing.Point(29, 95);
            this.GrbEnvio.Name = "GrbEnvio";
            this.GrbEnvio.Size = new System.Drawing.Size(225, 124);
            this.GrbEnvio.TabIndex = 1;
            this.GrbEnvio.TabStop = false;
            this.GrbEnvio.Text = "Opciones de Envio";
            // 
            // RadPremiun
            // 
            this.RadPremiun.AutoSize = true;
            this.RadPremiun.Location = new System.Drawing.Point(7, 85);
            this.RadPremiun.Name = "RadPremiun";
            this.RadPremiun.Size = new System.Drawing.Size(150, 20);
            this.RadPremiun.TabIndex = 2;
            this.RadPremiun.TabStop = true;
            this.RadPremiun.Text = "Premium (2 días $20)";
            this.RadPremiun.UseVisualStyleBackColor = true;
            // 
            // RadExpress
            // 
            this.RadExpress.AutoSize = true;
            this.RadExpress.Location = new System.Drawing.Point(6, 59);
            this.RadExpress.Name = "RadExpress";
            this.RadExpress.Size = new System.Drawing.Size(192, 20);
            this.RadExpress.TabIndex = 1;
            this.RadExpress.TabStop = true;
            this.RadExpress.Text = "Envio Express (10 Días $10)";
            this.RadExpress.UseVisualStyleBackColor = true;
            // 
            // RadNormal
            // 
            this.RadNormal.AutoSize = true;
            this.RadNormal.Location = new System.Drawing.Point(7, 33);
            this.RadNormal.Name = "RadNormal";
            this.RadNormal.Size = new System.Drawing.Size(183, 20);
            this.RadNormal.TabIndex = 0;
            this.RadNormal.TabStop = true;
            this.RadNormal.Text = "Envio Normal (20 Días $5 )";
            this.RadNormal.UseVisualStyleBackColor = true;
            // 
            // GrbEntrega
            // 
            this.GrbEntrega.Controls.Add(this.RadCorreos);
            this.GrbEntrega.Controls.Add(this.RadCasa);
            this.GrbEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbEntrega.ForeColor = System.Drawing.SystemColors.Control;
            this.GrbEntrega.Location = new System.Drawing.Point(293, 95);
            this.GrbEntrega.Name = "GrbEntrega";
            this.GrbEntrega.Size = new System.Drawing.Size(225, 124);
            this.GrbEntrega.TabIndex = 2;
            this.GrbEntrega.TabStop = false;
            this.GrbEntrega.Text = "Opciones de Entrega";
            // 
            // RadCorreos
            // 
            this.RadCorreos.AutoSize = true;
            this.RadCorreos.Location = new System.Drawing.Point(6, 70);
            this.RadCorreos.Name = "RadCorreos";
            this.RadCorreos.Size = new System.Drawing.Size(187, 20);
            this.RadCorreos.TabIndex = 1;
            this.RadCorreos.TabStop = true;
            this.RadCorreos.Text = "Recoger en Correo (Gratis)";
            this.RadCorreos.UseVisualStyleBackColor = true;
            // 
            // RadCasa
            // 
            this.RadCasa.AutoSize = true;
            this.RadCasa.Location = new System.Drawing.Point(6, 33);
            this.RadCasa.Name = "RadCasa";
            this.RadCasa.Size = new System.Drawing.Size(89, 20);
            this.RadCasa.TabIndex = 0;
            this.RadCasa.TabStop = true;
            this.RadCasa.Text = "Casa ( $5 )";
            this.RadCasa.UseVisualStyleBackColor = true;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.Location = new System.Drawing.Point(85, 256);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(86, 34);
            this.BtnMostrar.TabIndex = 3;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(356, 256);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(86, 34);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(536, 314);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.GrbEntrega);
            this.Controls.Add(this.GrbEnvio);
            this.Controls.Add(this.LblTitulo);
            this.Name = "FrmPedidos";
            this.Text = "Pedidos";
            this.GrbEnvio.ResumeLayout(false);
            this.GrbEnvio.PerformLayout();
            this.GrbEntrega.ResumeLayout(false);
            this.GrbEntrega.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.GroupBox GrbEnvio;
        private System.Windows.Forms.RadioButton RadPremiun;
        private System.Windows.Forms.RadioButton RadExpress;
        private System.Windows.Forms.RadioButton RadNormal;
        private System.Windows.Forms.GroupBox GrbEntrega;
        private System.Windows.Forms.RadioButton RadCorreos;
        private System.Windows.Forms.RadioButton RadCasa;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button BtnSalir;
    }
}