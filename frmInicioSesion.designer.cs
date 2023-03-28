
namespace TPI_1
{
    partial class frmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.pctContrasena = new System.Windows.Forms.PictureBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.pctMinimizar = new System.Windows.Forms.PictureBox();
            this.pctCerrar = new System.Windows.Forms.PictureBox();
            this.pctVer = new System.Windows.Forms.PictureBox();
            this.pctNoVer = new System.Windows.Forms.PictureBox();
            this.btnSoyAlumno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctContrasena)).BeginInit();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNoVer)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(120, 71);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(198, 198);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.CausesValidation = false;
            this.txtUsuario.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Location = new System.Drawing.Point(69, 311);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(298, 28);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // pctUsuario
            // 
            this.pctUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pctUsuario.Image")));
            this.pctUsuario.Location = new System.Drawing.Point(60, 300);
            this.pctUsuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(320, 47);
            this.pctUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctUsuario.TabIndex = 2;
            this.pctUsuario.TabStop = false;
            // 
            // pctContrasena
            // 
            this.pctContrasena.Image = ((System.Drawing.Image)(resources.GetObject("pctContrasena.Image")));
            this.pctContrasena.Location = new System.Drawing.Point(60, 373);
            this.pctContrasena.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pctContrasena.Name = "pctContrasena";
            this.pctContrasena.Size = new System.Drawing.Size(320, 47);
            this.pctContrasena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctContrasena.TabIndex = 3;
            this.pctContrasena.TabStop = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.CausesValidation = false;
            this.txtContraseña.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Gray;
            this.txtContraseña.Location = new System.Drawing.Point(69, 383);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(298, 28);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(60, 435);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(320, 47);
            this.btnIniciarSesion.TabIndex = 2;
            this.btnIniciarSesion.Text = "Ingresar";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBarra.Controls.Add(this.pctMinimizar);
            this.pnlBarra.Controls.Add(this.pctCerrar);
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(438, 27);
            this.pnlBarra.TabIndex = 10;
            this.pnlBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseDown);
            // 
            // pctMinimizar
            // 
            this.pctMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pctMinimizar.Image")));
            this.pctMinimizar.Location = new System.Drawing.Point(0, 0);
            this.pctMinimizar.Name = "pctMinimizar";
            this.pctMinimizar.Size = new System.Drawing.Size(33, 27);
            this.pctMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMinimizar.TabIndex = 14;
            this.pctMinimizar.TabStop = false;
            this.pctMinimizar.Click += new System.EventHandler(this.pctMinimizar_Click);
            // 
            // pctCerrar
            // 
            this.pctCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pctCerrar.Image")));
            this.pctCerrar.Location = new System.Drawing.Point(405, 0);
            this.pctCerrar.Name = "pctCerrar";
            this.pctCerrar.Size = new System.Drawing.Size(33, 27);
            this.pctCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCerrar.TabIndex = 13;
            this.pctCerrar.TabStop = false;
            this.pctCerrar.Click += new System.EventHandler(this.pctCerrar_Click);
            // 
            // pctVer
            // 
            this.pctVer.Image = ((System.Drawing.Image)(resources.GetObject("pctVer.Image")));
            this.pctVer.Location = new System.Drawing.Point(329, 373);
            this.pctVer.Name = "pctVer";
            this.pctVer.Size = new System.Drawing.Size(51, 47);
            this.pctVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVer.TabIndex = 14;
            this.pctVer.TabStop = false;
            this.pctVer.Click += new System.EventHandler(this.pctVer_Click);
            // 
            // pctNoVer
            // 
            this.pctNoVer.Image = ((System.Drawing.Image)(resources.GetObject("pctNoVer.Image")));
            this.pctNoVer.Location = new System.Drawing.Point(329, 373);
            this.pctNoVer.Name = "pctNoVer";
            this.pctNoVer.Size = new System.Drawing.Size(51, 47);
            this.pctNoVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctNoVer.TabIndex = 15;
            this.pctNoVer.TabStop = false;
            this.pctNoVer.Click += new System.EventHandler(this.pctNoVer_Click);
            // 
            // btnSoyAlumno
            // 
            this.btnSoyAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSoyAlumno.FlatAppearance.BorderSize = 0;
            this.btnSoyAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSoyAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSoyAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoyAlumno.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoyAlumno.ForeColor = System.Drawing.Color.Black;
            this.btnSoyAlumno.Location = new System.Drawing.Point(60, 494);
            this.btnSoyAlumno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSoyAlumno.Name = "btnSoyAlumno";
            this.btnSoyAlumno.Size = new System.Drawing.Size(320, 36);
            this.btnSoyAlumno.TabIndex = 3;
            this.btnSoyAlumno.Text = "Soy Alumno";
            this.btnSoyAlumno.UseVisualStyleBackColor = false;
            this.btnSoyAlumno.Click += new System.EventHandler(this.btnSoyAlumno_Click);
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(438, 542);
            this.ControlBox = false;
            this.Controls.Add(this.btnSoyAlumno);
            this.Controls.Add(this.pctVer);
            this.Controls.Add(this.pctNoVer);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.pctContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pctUsuario);
            this.Controls.Add(this.pctLogo);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmInicioSesion";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctContrasena)).EndInit();
            this.pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNoVer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pctUsuario;
        private System.Windows.Forms.PictureBox pctContrasena;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.PictureBox pctCerrar;
        private System.Windows.Forms.PictureBox pctMinimizar;
        private System.Windows.Forms.PictureBox pctVer;
        private System.Windows.Forms.PictureBox pctNoVer;
        private System.Windows.Forms.Button btnSoyAlumno;
    }
}