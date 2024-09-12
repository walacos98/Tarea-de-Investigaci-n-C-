
namespace MultiEjercicios
{
    partial class FrmContarQuesos
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
            this.LblQuesos = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.ComboQuesos = new System.Windows.Forms.ComboBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtCalcular = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnTerminar = new System.Windows.Forms.Button();
            this.LstResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblQuesos
            // 
            this.LblQuesos.AutoSize = true;
            this.LblQuesos.Location = new System.Drawing.Point(37, 70);
            this.LblQuesos.Name = "LblQuesos";
            this.LblQuesos.Size = new System.Drawing.Size(43, 13);
            this.LblQuesos.TabIndex = 0;
            this.LblQuesos.Text = "Quesos";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(37, 140);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(49, 13);
            this.LblCantidad.TabIndex = 1;
            this.LblCantidad.Text = "Cantidad";
            // 
            // ComboQuesos
            // 
            this.ComboQuesos.FormattingEnabled = true;
            this.ComboQuesos.Items.AddRange(new object[] {
            "Cheddar",
            "Ricota",
            "Masdan",
            "Mozzarella",
            "Gorgonzola"});
            this.ComboQuesos.Location = new System.Drawing.Point(107, 70);
            this.ComboQuesos.Name = "ComboQuesos";
            this.ComboQuesos.Size = new System.Drawing.Size(121, 21);
            this.ComboQuesos.TabIndex = 2;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(107, 140);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 20);
            this.TxtCantidad.TabIndex = 3;
            // 
            // TxtCalcular
            // 
            this.TxtCalcular.Location = new System.Drawing.Point(40, 190);
            this.TxtCalcular.Name = "TxtCalcular";
            this.TxtCalcular.Size = new System.Drawing.Size(75, 23);
            this.TxtCalcular.TabIndex = 4;
            this.TxtCalcular.Text = "Sumar";
            this.TxtCalcular.UseVisualStyleBackColor = true;
            this.TxtCalcular.Click += new System.EventHandler(this.TxtCalcular_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(201, 190);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 5;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnTerminar
            // 
            this.BtnTerminar.Location = new System.Drawing.Point(107, 224);
            this.BtnTerminar.Name = "BtnTerminar";
            this.BtnTerminar.Size = new System.Drawing.Size(104, 23);
            this.BtnTerminar.TabIndex = 7;
            this.BtnTerminar.Text = "Dejar de Contar";
            this.BtnTerminar.UseVisualStyleBackColor = true;
            this.BtnTerminar.Click += new System.EventHandler(this.BtnTerminar_Click);
            // 
            // LstResultado
            // 
            this.LstResultado.FormattingEnabled = true;
            this.LstResultado.Location = new System.Drawing.Point(31, 298);
            this.LstResultado.Name = "LstResultado";
            this.LstResultado.Size = new System.Drawing.Size(245, 147);
            this.LstResultado.TabIndex = 8;
            // 
            // FrmContarQuesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 469);
            this.Controls.Add(this.LstResultado);
            this.Controls.Add(this.BtnTerminar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtCalcular);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.ComboQuesos);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblQuesos);
            this.Name = "FrmContarQuesos";
            this.Text = "Contar Quesos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblQuesos;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.ComboBox ComboQuesos;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Button TxtCalcular;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnTerminar;
        private System.Windows.Forms.ListBox LstResultado;
    }
}