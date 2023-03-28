
namespace TPI_1
{
    partial class frmMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMensaje));
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.lblNombreDestinatario = new System.Windows.Forms.Label();
            this.lblNombreClase = new System.Windows.Forms.Label();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblNombreDia = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblNombreProfesor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.ForeColor = System.Drawing.Color.Silver;
            this.txtMensaje.Location = new System.Drawing.Point(38, 217);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensaje.ShortcutsEnabled = false;
            this.txtMensaje.Size = new System.Drawing.Size(530, 245);
            this.txtMensaje.TabIndex = 26;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Silver;
            this.lblMensaje.Location = new System.Drawing.Point(32, 180);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(90, 34);
            this.lblMensaje.TabIndex = 27;
            this.lblMensaje.Text = "Mensaje:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(330, 486);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 39);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(141, 486);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(117, 39);
            this.btnEnviar.TabIndex = 28;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.BackColor = System.Drawing.Color.Transparent;
            this.lblDestinatario.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinatario.ForeColor = System.Drawing.Color.Silver;
            this.lblDestinatario.Location = new System.Drawing.Point(39, 67);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(123, 34);
            this.lblDestinatario.TabIndex = 30;
            this.lblDestinatario.Text = "Destinatario:";
            // 
            // lblNombreDestinatario
            // 
            this.lblNombreDestinatario.AutoSize = true;
            this.lblNombreDestinatario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreDestinatario.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDestinatario.ForeColor = System.Drawing.Color.Silver;
            this.lblNombreDestinatario.Location = new System.Drawing.Point(159, 67);
            this.lblNombreDestinatario.Name = "lblNombreDestinatario";
            this.lblNombreDestinatario.Size = new System.Drawing.Size(51, 34);
            this.lblNombreDestinatario.TabIndex = 31;
            this.lblNombreDestinatario.Text = "dato";
            // 
            // lblNombreClase
            // 
            this.lblNombreClase.AutoSize = true;
            this.lblNombreClase.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreClase.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreClase.ForeColor = System.Drawing.Color.Silver;
            this.lblNombreClase.Location = new System.Drawing.Point(159, 19);
            this.lblNombreClase.Name = "lblNombreClase";
            this.lblNombreClase.Size = new System.Drawing.Size(51, 34);
            this.lblNombreClase.TabIndex = 33;
            this.lblNombreClase.Text = "dato";
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.BackColor = System.Drawing.Color.Transparent;
            this.lblClase.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClase.ForeColor = System.Drawing.Color.Silver;
            this.lblClase.Location = new System.Drawing.Point(95, 19);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(67, 34);
            this.lblClase.TabIndex = 32;
            this.lblClase.Text = "Clase:";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.lblDia.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.Silver;
            this.lblDia.Location = new System.Drawing.Point(432, 19);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(47, 34);
            this.lblDia.TabIndex = 34;
            this.lblDia.Text = "Dia:";
            // 
            // lblNombreDia
            // 
            this.lblNombreDia.AutoSize = true;
            this.lblNombreDia.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreDia.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDia.ForeColor = System.Drawing.Color.Silver;
            this.lblNombreDia.Location = new System.Drawing.Point(473, 19);
            this.lblNombreDia.Name = "lblNombreDia";
            this.lblNombreDia.Size = new System.Drawing.Size(51, 34);
            this.lblNombreDia.TabIndex = 35;
            this.lblNombreDia.Text = "dato";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Silver;
            this.lblHora.Location = new System.Drawing.Point(473, 67);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 34);
            this.lblHora.TabIndex = 37;
            this.lblHora.Text = "dato";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.Silver;
            this.lblHorario.Location = new System.Drawing.Point(394, 67);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(85, 34);
            this.lblHorario.TabIndex = 36;
            this.lblHorario.Text = "Horario:";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.BackColor = System.Drawing.Color.Transparent;
            this.lblProfesor.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor.ForeColor = System.Drawing.Color.Silver;
            this.lblProfesor.Location = new System.Drawing.Point(66, 110);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(96, 34);
            this.lblProfesor.TabIndex = 38;
            this.lblProfesor.Text = "Profesor:";
            // 
            // lblNombreProfesor
            // 
            this.lblNombreProfesor.AutoSize = true;
            this.lblNombreProfesor.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreProfesor.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProfesor.ForeColor = System.Drawing.Color.Silver;
            this.lblNombreProfesor.Location = new System.Drawing.Point(159, 110);
            this.lblNombreProfesor.Name = "lblNombreProfesor";
            this.lblNombreProfesor.Size = new System.Drawing.Size(51, 34);
            this.lblNombreProfesor.TabIndex = 39;
            this.lblNombreProfesor.Text = "dato";
            // 
            // frmMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(614, 554);
            this.Controls.Add(this.lblNombreProfesor);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblNombreDia);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblNombreClase);
            this.Controls.Add(this.lblClase);
            this.Controls.Add(this.lblNombreDestinatario);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lblMensaje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMensaje";
            this.Text = "Mensaje de Notificacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Label lblNombreDestinatario;
        private System.Windows.Forms.Label lblNombreClase;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblNombreDia;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblNombreProfesor;
    }
}