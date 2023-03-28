
namespace TPI_1
{
    partial class frmABMMaquina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMMaquina));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dtpFechaBaja = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaBaja = new System.Windows.Forms.Label();
            this.toolTipABMMaquina = new System.Windows.Forms.ToolTip(this.components);
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(280, 483);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 39);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.toolTipABMMaquina.SetToolTip(this.btnCancelar, "Pulse para Cancelar ");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(91, 483);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 39);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.toolTipABMMaquina.SetToolTip(this.btnGuardar, "Pulse para Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DisplayMember = "(ninguno)";
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "En Reparacion"});
            this.cmbEstado.Location = new System.Drawing.Point(175, 215);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(150, 39);
            this.cmbEstado.TabIndex = 3;
            this.toolTipABMMaquina.SetToolTip(this.cmbEstado, "Seleccione un Estado ");
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Silver;
            this.lblEstado.Location = new System.Drawing.Point(64, 215);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(75, 34);
            this.lblEstado.TabIndex = 43;
            this.lblEstado.Text = "Estado:";
            // 
            // dtpFechaBaja
            // 
            this.dtpFechaBaja.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaBaja.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpFechaBaja.CustomFormat = " ";
            this.dtpFechaBaja.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaBaja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaBaja.Location = new System.Drawing.Point(175, 158);
            this.dtpFechaBaja.Name = "dtpFechaBaja";
            this.dtpFechaBaja.Size = new System.Drawing.Size(150, 32);
            this.dtpFechaBaja.TabIndex = 2;
            this.toolTipABMMaquina.SetToolTip(this.dtpFechaBaja, "Seleccione fecha de baja de maquina");
            this.dtpFechaBaja.Value = new System.DateTime(2021, 8, 24, 0, 0, 0, 0);
            this.dtpFechaBaja.ValueChanged += new System.EventHandler(this.dtpFechaBaja_ValueChanged);
            this.dtpFechaBaja.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFechaBaja_KeyDown);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Silver;
            this.txtNombre.Location = new System.Drawing.Point(175, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(305, 29);
            this.txtNombre.TabIndex = 0;
            this.toolTipABMMaquina.SetToolTip(this.txtNombre, "Ingrese nombre");
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 288);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(121, 34);
            this.lblDescripcion.TabIndex = 27;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Silver;
            this.lblNombre.Location = new System.Drawing.Point(53, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 34);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFechaBaja
            // 
            this.lblFechaBaja.AutoSize = true;
            this.lblFechaBaja.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaBaja.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaBaja.ForeColor = System.Drawing.Color.Silver;
            this.lblFechaBaja.Location = new System.Drawing.Point(28, 156);
            this.lblFechaBaja.Name = "lblFechaBaja";
            this.lblFechaBaja.Size = new System.Drawing.Size(111, 34);
            this.lblFechaBaja.TabIndex = 28;
            this.lblFechaBaja.Text = "Fecha Baja:";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAlta.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpFechaAlta.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(175, 102);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(150, 32);
            this.dtpFechaAlta.TabIndex = 1;
            this.toolTipABMMaquina.SetToolTip(this.dtpFechaAlta, "Seleccione fecha de alta de maquina");
            this.dtpFechaAlta.Value = new System.DateTime(2021, 8, 24, 0, 0, 0, 0);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.txtDescripcion.Location = new System.Drawing.Point(175, 288);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(305, 163);
            this.txtDescripcion.TabIndex = 4;
            this.toolTipABMMaquina.SetToolTip(this.txtDescripcion, "Ingrese aqui una breve descripcion");
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaAlta.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.ForeColor = System.Drawing.Color.Silver;
            this.lblFechaAlta.Location = new System.Drawing.Point(33, 102);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(106, 34);
            this.lblFechaAlta.TabIndex = 47;
            this.lblFechaAlta.Text = "Fecha Alta:";
            // 
            // frmABMMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(518, 543);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dtpFechaAlta);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.dtpFechaBaja);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblFechaBaja);
            this.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MinimumSize = new System.Drawing.Size(517, 400);
            this.Name = "frmABMMaquina";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maquinas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.DateTimePicker dtpFechaBaja;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaBaja;
        private System.Windows.Forms.ToolTip toolTipABMMaquina;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.Label lblFechaAlta;
        public System.Windows.Forms.TextBox txtDescripcion;
    }
}