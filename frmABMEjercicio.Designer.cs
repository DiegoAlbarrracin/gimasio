
namespace TPI_1
{
    partial class frmABMEjercicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMEjercicio));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTipoEjercicio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbTipoEjercicio = new System.Windows.Forms.ComboBox();
            this.toolTipABMEjercicio = new System.Windows.Forms.ToolTip(this.components);
            this.lblMaquina = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtMaquina = new System.Windows.Forms.TextBox();
            this.btnBuscarMaquina = new System.Windows.Forms.Button();
            this.btnSinMaquina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(380, 502);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 39);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.toolTipABMEjercicio.SetToolTip(this.btnCancelar, "Pulse para Cancelar ");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(191, 502);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 39);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.toolTipABMEjercicio.SetToolTip(this.btnGuardar, "Pulse para Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTipoEjercicio
            // 
            this.lblTipoEjercicio.AutoSize = true;
            this.lblTipoEjercicio.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoEjercicio.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEjercicio.ForeColor = System.Drawing.Color.Silver;
            this.lblTipoEjercicio.Location = new System.Drawing.Point(27, 100);
            this.lblTipoEjercicio.Name = "lblTipoEjercicio";
            this.lblTipoEjercicio.Size = new System.Drawing.Size(133, 34);
            this.lblTipoEjercicio.TabIndex = 41;
            this.lblTipoEjercicio.Text = "Tipo Ejercicio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.lblDescripcion.Location = new System.Drawing.Point(40, 290);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(121, 34);
            this.lblDescripcion.TabIndex = 32;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Silver;
            this.txtNombre.Location = new System.Drawing.Point(192, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(252, 29);
            this.txtNombre.TabIndex = 0;
            this.toolTipABMEjercicio.SetToolTip(this.txtNombre, "Ingrese nombre");
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.txtDescripcion.Location = new System.Drawing.Point(193, 298);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(305, 163);
            this.txtDescripcion.TabIndex = 5;
            this.toolTipABMEjercicio.SetToolTip(this.txtDescripcion, "Ingrese aqui una breve descripcion");
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Silver;
            this.lblNombre.Location = new System.Drawing.Point(74, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 34);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre:";
            // 
            // cmbTipoEjercicio
            // 
            this.cmbTipoEjercicio.FormattingEnabled = true;
            this.cmbTipoEjercicio.Location = new System.Drawing.Point(193, 99);
            this.cmbTipoEjercicio.Name = "cmbTipoEjercicio";
            this.cmbTipoEjercicio.Size = new System.Drawing.Size(251, 39);
            this.cmbTipoEjercicio.TabIndex = 1;
            this.toolTipABMEjercicio.SetToolTip(this.cmbTipoEjercicio, "Seleccione el tipo de ejercicio");
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.BackColor = System.Drawing.Color.Transparent;
            this.lblMaquina.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaquina.ForeColor = System.Drawing.Color.Silver;
            this.lblMaquina.Location = new System.Drawing.Point(12, 165);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(148, 34);
            this.lblMaquina.TabIndex = 49;
            this.lblMaquina.Text = "Maquina Usada:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DisplayMember = "(ninguno)";
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.ItemHeight = 31;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(193, 232);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(150, 39);
            this.cmbEstado.TabIndex = 4;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Silver;
            this.lblEstado.Location = new System.Drawing.Point(85, 233);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(75, 34);
            this.lblEstado.TabIndex = 51;
            this.lblEstado.Text = "Estado:";
            // 
            // txtMaquina
            // 
            this.txtMaquina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaquina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaquina.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaquina.ForeColor = System.Drawing.Color.Silver;
            this.txtMaquina.Location = new System.Drawing.Point(191, 170);
            this.txtMaquina.MaxLength = 10;
            this.txtMaquina.Name = "txtMaquina";
            this.txtMaquina.ReadOnly = true;
            this.txtMaquina.ShortcutsEnabled = false;
            this.txtMaquina.Size = new System.Drawing.Size(251, 29);
            this.txtMaquina.TabIndex = 53;
            // 
            // btnBuscarMaquina
            // 
            this.btnBuscarMaquina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarMaquina.BackgroundImage")));
            this.btnBuscarMaquina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMaquina.Location = new System.Drawing.Point(448, 170);
            this.btnBuscarMaquina.Name = "btnBuscarMaquina";
            this.btnBuscarMaquina.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarMaquina.TabIndex = 2;
            this.toolTipABMEjercicio.SetToolTip(this.btnBuscarMaquina, "Presione para buscar Maquina");
            this.btnBuscarMaquina.UseVisualStyleBackColor = true;
            this.btnBuscarMaquina.Click += new System.EventHandler(this.btnBuscarMaquina_Click);
            // 
            // btnSinMaquina
            // 
            this.btnSinMaquina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSinMaquina.BackgroundImage")));
            this.btnSinMaquina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSinMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinMaquina.Location = new System.Drawing.Point(487, 170);
            this.btnSinMaquina.Name = "btnSinMaquina";
            this.btnSinMaquina.Size = new System.Drawing.Size(36, 30);
            this.btnSinMaquina.TabIndex = 3;
            this.toolTipABMEjercicio.SetToolTip(this.btnSinMaquina, "Presione para Quitar maquina");
            this.btnSinMaquina.UseVisualStyleBackColor = true;
            this.btnSinMaquina.Click += new System.EventHandler(this.btnSinMaquina_Click);
            // 
            // frmABMEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(535, 581);
            this.Controls.Add(this.btnSinMaquina);
            this.Controls.Add(this.txtMaquina);
            this.Controls.Add(this.btnBuscarMaquina);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblMaquina);
            this.Controls.Add(this.cmbTipoEjercicio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTipoEjercicio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MinimumSize = new System.Drawing.Size(517, 400);
            this.Name = "frmABMEjercicio";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTipoEjercicio;
        private System.Windows.Forms.Label lblDescripcion;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolTip toolTipABMEjercicio;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblMaquina;
        public System.Windows.Forms.ComboBox cmbTipoEjercicio;
        public System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.TextBox txtMaquina;
        private System.Windows.Forms.Button btnBuscarMaquina;
        private System.Windows.Forms.Button btnSinMaquina;
    }
}