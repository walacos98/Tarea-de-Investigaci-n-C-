
namespace MultiEjercicios
{
    partial class FrmLogin
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
            this.LblUser = new System.Windows.Forms.Label();
            this.LblPass = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.BtnIngreso = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Location = new System.Drawing.Point(62, 73);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(79, 24);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "Usuario:";
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.Location = new System.Drawing.Point(30, 147);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(111, 24);
            this.LblPass.TabIndex = 1;
            this.LblPass.Text = "Contraseña:";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(179, 77);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(111, 20);
            this.TxtUser.TabIndex = 2;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(179, 151);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(111, 20);
            this.TxtPass.TabIndex = 3;
            // 
            // BtnIngreso
            // 
            this.BtnIngreso.Location = new System.Drawing.Point(66, 259);
            this.BtnIngreso.Name = "BtnIngreso";
            this.BtnIngreso.Size = new System.Drawing.Size(87, 36);
            this.BtnIngreso.TabIndex = 4;
            this.BtnIngreso.Text = "Ingresar";
            this.BtnIngreso.UseVisualStyleBackColor = true;
            this.BtnIngreso.Click += new System.EventHandler(this.BtnIngreso_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(233, 259);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(87, 36);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(389, 345);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnIngreso);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.LblUser);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Button BtnIngreso;
        private System.Windows.Forms.Button BtnSalir;
    }
}

