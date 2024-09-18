
namespace MultiEjercicios
{
    partial class FrmArreglos
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
            this.BtnVector = new System.Windows.Forms.Button();
            this.BtnMatriz = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVector
            // 
            this.BtnVector.Location = new System.Drawing.Point(12, 26);
            this.BtnVector.Name = "BtnVector";
            this.BtnVector.Size = new System.Drawing.Size(116, 37);
            this.BtnVector.TabIndex = 0;
            this.BtnVector.Text = "Ejecutar Vector";
            this.BtnVector.UseVisualStyleBackColor = true;
            this.BtnVector.Click += new System.EventHandler(this.BtnVector_Click);
            // 
            // BtnMatriz
            // 
            this.BtnMatriz.Location = new System.Drawing.Point(134, 26);
            this.BtnMatriz.Name = "BtnMatriz";
            this.BtnMatriz.Size = new System.Drawing.Size(116, 37);
            this.BtnMatriz.TabIndex = 1;
            this.BtnMatriz.Text = "Ejecutar Matriz";
            this.BtnMatriz.UseVisualStyleBackColor = true;
            this.BtnMatriz.Click += new System.EventHandler(this.BtnMatriz_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(94, 90);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmArreglos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 145);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnMatriz);
            this.Controls.Add(this.BtnVector);
            this.Name = "FrmArreglos";
            this.Text = "FrmArreglos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVector;
        private System.Windows.Forms.Button BtnMatriz;
        private System.Windows.Forms.Button BtnSalir;
    }
}