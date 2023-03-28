
namespace TPI_1
{
    partial class frmABMAsistenciaAdministrador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMAsistenciaAdministrador));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpFechaAsistencia = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAsistencia = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.toolTipABMAsistencia = new System.Windows.Forms.ToolTip(this.components);
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(301, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 39);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.toolTipABMAsistencia.SetToolTip(this.btnCancelar, "Pulse para Cancelar ");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(80, 350);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 39);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.toolTipABMAsistencia.SetToolTip(this.btnGuardar, "Pulse para Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpFechaAsistencia
            // 
            this.dtpFechaAsistencia.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAsistencia.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpFechaAsistencia.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFechaAsistencia.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAsistencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaAsistencia.Location = new System.Drawing.Point(203, 187);
            this.dtpFechaAsistencia.Name = "dtpFechaAsistencia";
            this.dtpFechaAsistencia.Size = new System.Drawing.Size(215, 32);
            this.dtpFechaAsistencia.TabIndex = 9;
            this.toolTipABMAsistencia.SetToolTip(this.dtpFechaAsistencia, "Seleccione fecha de asistencia");
            this.dtpFechaAsistencia.Value = new System.DateTime(2021, 8, 24, 0, 0, 0, 0);
            // 
            // lblFechaAsistencia
            // 
            this.lblFechaAsistencia.AutoSize = true;
            this.lblFechaAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaAsistencia.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAsistencia.ForeColor = System.Drawing.Color.Silver;
            this.lblFechaAsistencia.Location = new System.Drawing.Point(52, 188);
            this.lblFechaAsistencia.Name = "lblFechaAsistencia";
            this.lblFechaAsistencia.Size = new System.Drawing.Size(145, 31);
            this.lblFechaAsistencia.TabIndex = 28;
            this.lblFechaAsistencia.Text = "Fecha Asistencia:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblDNI.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.Silver;
            this.lblDNI.Location = new System.Drawing.Point(74, 117);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(49, 34);
            this.lblDNI.TabIndex = 29;
            this.lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNI.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.Color.Silver;
            this.txtDNI.Location = new System.Drawing.Point(167, 119);
            this.txtDNI.MaxLength = 10;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ShortcutsEnabled = false;
            this.txtDNI.Size = new System.Drawing.Size(251, 29);
            this.txtDNI.TabIndex = 2;
            this.toolTipABMAsistencia.SetToolTip(this.txtDNI, "Ingrese DNI (sin puntos)");
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumno.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.ForeColor = System.Drawing.Color.Silver;
            this.lblAlumno.Location = new System.Drawing.Point(74, 51);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(81, 34);
            this.lblAlumno.TabIndex = 84;
            this.lblAlumno.Text = "Alumno:";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlumno.ForeColor = System.Drawing.Color.Silver;
            this.lblNombreAlumno.Location = new System.Drawing.Point(161, 51);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(0, 34);
            this.lblNombreAlumno.TabIndex = 85;
            // 
            // frmABMAsistenciaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(501, 478);
            this.Controls.Add(this.lblNombreAlumno);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFechaAsistencia);
            this.Controls.Add(this.lblFechaAsistencia);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtDNI);
            this.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MinimumSize = new System.Drawing.Size(517, 400);
            this.Name = "frmABMAsistenciaAdministrador";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.DateTimePicker dtpFechaAsistencia;
        private System.Windows.Forms.Label lblFechaAsistencia;
        private System.Windows.Forms.Label lblDNI;
        public System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.ToolTip toolTipABMAsistencia;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
    }
}