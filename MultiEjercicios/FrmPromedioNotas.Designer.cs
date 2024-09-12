
namespace MultiEjercicios
{
    partial class FrmPromedioNotas
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
            this.GrpNotas = new System.Windows.Forms.GroupBox();
            this.GrpPromedio = new System.Windows.Forms.GroupBox();
            this.LblCantAlumnos = new System.Windows.Forms.Label();
            this.TxtCantAlumnos = new System.Windows.Forms.TextBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblPromedio = new System.Windows.Forms.Label();
            this.TxtPromedio = new System.Windows.Forms.TextBox();
            this.GrpNotas.SuspendLayout();
            this.GrpPromedio.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpNotas
            // 
            this.GrpNotas.Controls.Add(this.BtnSalir);
            this.GrpNotas.Controls.Add(this.BtnIngresar);
            this.GrpNotas.Controls.Add(this.BtnNuevo);
            this.GrpNotas.Controls.Add(this.TxtCantAlumnos);
            this.GrpNotas.Controls.Add(this.LblCantAlumnos);
            this.GrpNotas.Location = new System.Drawing.Point(25, 31);
            this.GrpNotas.Name = "GrpNotas";
            this.GrpNotas.Size = new System.Drawing.Size(494, 170);
            this.GrpNotas.TabIndex = 0;
            this.GrpNotas.TabStop = false;
            this.GrpNotas.Text = "Ingresar Notas";
            // 
            // GrpPromedio
            // 
            this.GrpPromedio.Controls.Add(this.TxtPromedio);
            this.GrpPromedio.Controls.Add(this.LblPromedio);
            this.GrpPromedio.Location = new System.Drawing.Point(25, 237);
            this.GrpPromedio.Name = "GrpPromedio";
            this.GrpPromedio.Size = new System.Drawing.Size(494, 170);
            this.GrpPromedio.TabIndex = 1;
            this.GrpPromedio.TabStop = false;
            this.GrpPromedio.Text = "Promedio";
            // 
            // LblCantAlumnos
            // 
            this.LblCantAlumnos.AutoSize = true;
            this.LblCantAlumnos.Location = new System.Drawing.Point(42, 51);
            this.LblCantAlumnos.Name = "LblCantAlumnos";
            this.LblCantAlumnos.Size = new System.Drawing.Size(107, 13);
            this.LblCantAlumnos.TabIndex = 0;
            this.LblCantAlumnos.Text = "Cantidad de Alumnos";
            // 
            // TxtCantAlumnos
            // 
            this.TxtCantAlumnos.Location = new System.Drawing.Point(175, 51);
            this.TxtCantAlumnos.Name = "TxtCantAlumnos";
            this.TxtCantAlumnos.Size = new System.Drawing.Size(190, 20);
            this.TxtCantAlumnos.TabIndex = 1;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(74, 109);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(210, 109);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(104, 23);
            this.BtnIngresar.TabIndex = 3;
            this.BtnIngresar.Text = "Ingresar Notas";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(374, 109);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblPromedio
            // 
            this.LblPromedio.AutoSize = true;
            this.LblPromedio.Location = new System.Drawing.Point(98, 63);
            this.LblPromedio.Name = "LblPromedio";
            this.LblPromedio.Size = new System.Drawing.Size(51, 13);
            this.LblPromedio.TabIndex = 0;
            this.LblPromedio.Text = "Promedio";
            // 
            // TxtPromedio
            // 
            this.TxtPromedio.Location = new System.Drawing.Point(175, 63);
            this.TxtPromedio.Name = "TxtPromedio";
            this.TxtPromedio.Size = new System.Drawing.Size(100, 20);
            this.TxtPromedio.TabIndex = 1;
            // 
            // FrmPromedioNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 440);
            this.Controls.Add(this.GrpPromedio);
            this.Controls.Add(this.GrpNotas);
            this.Name = "FrmPromedioNotas";
            this.Text = "Promedio Notas";
            this.GrpNotas.ResumeLayout(false);
            this.GrpNotas.PerformLayout();
            this.GrpPromedio.ResumeLayout(false);
            this.GrpPromedio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpNotas;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox TxtCantAlumnos;
        private System.Windows.Forms.Label LblCantAlumnos;
        private System.Windows.Forms.GroupBox GrpPromedio;
        private System.Windows.Forms.TextBox TxtPromedio;
        private System.Windows.Forms.Label LblPromedio;
    }
}