
namespace TPI_1
{
    partial class frmMaquinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaquinas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tstBarraLateralAlumno = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbBaja = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlNombrePantalla = new System.Windows.Forms.Panel();
            this.lblNombrePantalla = new System.Windows.Forms.Label();
            this.dgvMaquinas = new System.Windows.Forms.DataGridView();
            this.colIDMaquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.tstBarraLateralAlumno.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.pnlNombrePantalla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).BeginInit();
            this.SuspendLayout();
            // 
            // tstBarraLateralAlumno
            // 
            this.tstBarraLateralAlumno.AutoSize = false;
            this.tstBarraLateralAlumno.BackColor = System.Drawing.Color.White;
            this.tstBarraLateralAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tstBarraLateralAlumno.BackgroundImage")));
            this.tstBarraLateralAlumno.Dock = System.Windows.Forms.DockStyle.Right;
            this.tstBarraLateralAlumno.GripMargin = new System.Windows.Forms.Padding(0);
            this.tstBarraLateralAlumno.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tstBarraLateralAlumno.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsbModificar,
            this.tsbBaja,
            this.tsbCerrar});
            this.tstBarraLateralAlumno.Location = new System.Drawing.Point(1114, 0);
            this.tstBarraLateralAlumno.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tstBarraLateralAlumno.Name = "tstBarraLateralAlumno";
            this.tstBarraLateralAlumno.Padding = new System.Windows.Forms.Padding(0);
            this.tstBarraLateralAlumno.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tstBarraLateralAlumno.Size = new System.Drawing.Size(114, 554);
            this.tstBarraLateralAlumno.TabIndex = 1;
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.AutoSize = false;
            this.tsbAgregar.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbAgregar.ForeColor = System.Drawing.Color.Silver;
            this.tsbAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(105, 105);
            this.tsbAgregar.Text = "Agregar";
            this.tsbAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.AutoSize = false;
            this.tsbModificar.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbModificar.ForeColor = System.Drawing.Color.Silver;
            this.tsbModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(105, 105);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbBaja
            // 
            this.tsbBaja.AutoSize = false;
            this.tsbBaja.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbBaja.ForeColor = System.Drawing.Color.Silver;
            this.tsbBaja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBaja.Name = "tsbBaja";
            this.tsbBaja.Size = new System.Drawing.Size(105, 105);
            this.tsbBaja.Text = "Dar de Baja";
            this.tsbBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBaja.Click += new System.EventHandler(this.tsbBaja_Click);
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.AutoSize = false;
            this.tsbCerrar.BackColor = System.Drawing.Color.Brown;
            this.tsbCerrar.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCerrar.ForeColor = System.Drawing.Color.Silver;
            this.tsbCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(105, 105);
            this.tsbCerrar.Text = "Cerrar";
            this.tsbCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.AutoScroll = true;
            this.pnlContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContenedor.BackgroundImage")));
            this.pnlContenedor.Controls.Add(this.btnImprimir);
            this.pnlContenedor.Controls.Add(this.cmbEstado);
            this.pnlContenedor.Controls.Add(this.lblEstado);
            this.pnlContenedor.Controls.Add(this.btnBuscar);
            this.pnlContenedor.Controls.Add(this.txtBuscador);
            this.pnlContenedor.Controls.Add(this.lblNombre);
            this.pnlContenedor.Controls.Add(this.pnlNombrePantalla);
            this.pnlContenedor.Controls.Add(this.dgvMaquinas);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1228, 554);
            this.pnlContenedor.TabIndex = 2;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(630, 49);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(173, 32);
            this.cmbEstado.TabIndex = 13;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Silver;
            this.lblEstado.Location = new System.Drawing.Point(549, 49);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(75, 34);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(823, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 33);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscador.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscador.Location = new System.Drawing.Point(288, 50);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(245, 33);
            this.txtBuscador.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Silver;
            this.lblNombre.Location = new System.Drawing.Point(183, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 34);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // pnlNombrePantalla
            // 
            this.pnlNombrePantalla.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlNombrePantalla.BackColor = System.Drawing.Color.DimGray;
            this.pnlNombrePantalla.Controls.Add(this.lblNombrePantalla);
            this.pnlNombrePantalla.Location = new System.Drawing.Point(500, 0);
            this.pnlNombrePantalla.Name = "pnlNombrePantalla";
            this.pnlNombrePantalla.Size = new System.Drawing.Size(287, 35);
            this.pnlNombrePantalla.TabIndex = 1;
            // 
            // lblNombrePantalla
            // 
            this.lblNombrePantalla.AutoSize = true;
            this.lblNombrePantalla.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePantalla.Location = new System.Drawing.Point(92, -4);
            this.lblNombrePantalla.Name = "lblNombrePantalla";
            this.lblNombrePantalla.Size = new System.Drawing.Size(112, 39);
            this.lblNombrePantalla.TabIndex = 0;
            this.lblNombrePantalla.Text = "Maquinas";
            // 
            // dgvMaquinas
            // 
            this.dgvMaquinas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaquinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMaquinas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMaquinas.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvMaquinas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaquinas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMaquinas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaquinas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaquinas.ColumnHeadersHeight = 30;
            this.dgvMaquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMaquinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDMaquina,
            this.colNombre,
            this.colDescripcion,
            this.colFechaAlta,
            this.colEstado,
            this.colFechaBaja});
            this.dgvMaquinas.EnableHeadersVisualStyles = false;
            this.dgvMaquinas.GridColor = System.Drawing.Color.DimGray;
            this.dgvMaquinas.Location = new System.Drawing.Point(136, 100);
            this.dgvMaquinas.Name = "dgvMaquinas";
            this.dgvMaquinas.ReadOnly = true;
            this.dgvMaquinas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaquinas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaquinas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMaquinas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMaquinas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaquinas.Size = new System.Drawing.Size(954, 150);
            this.dgvMaquinas.TabIndex = 0;
            this.dgvMaquinas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMaquinas_CellFormatting);
            this.dgvMaquinas.DoubleClick += new System.EventHandler(this.dgvMaquinas_DoubleClick);
            // 
            // colIDMaquina
            // 
            this.colIDMaquina.HeaderText = "ID Maquina";
            this.colIDMaquina.Name = "colIDMaquina";
            this.colIDMaquina.ReadOnly = true;
            this.colIDMaquina.Width = 96;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 79;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Width = 102;
            // 
            // colFechaAlta
            // 
            this.colFechaAlta.HeaderText = "Fecha Alta";
            this.colFechaAlta.Name = "colFechaAlta";
            this.colFechaAlta.ReadOnly = true;
            this.colFechaAlta.Width = 93;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 70;
            // 
            // colFechaBaja
            // 
            this.colFechaBaja.HeaderText = "Fecha Baja";
            this.colFechaBaja.Name = "colFechaBaja";
            this.colFechaBaja.ReadOnly = true;
            this.colFechaBaja.Width = 96;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Location = new System.Drawing.Point(1013, 354);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(77, 71);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmMaquinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1228, 554);
            this.Controls.Add(this.tstBarraLateralAlumno);
            this.Controls.Add(this.pnlContenedor);
            this.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMaquinas";
            this.Load += new System.EventHandler(this.frmMaquinas_Load);
            this.tstBarraLateralAlumno.ResumeLayout(false);
            this.tstBarraLateralAlumno.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.pnlNombrePantalla.ResumeLayout(false);
            this.pnlNombrePantalla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip tstBarraLateralAlumno;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlNombrePantalla;
        private System.Windows.Forms.Label lblNombrePantalla;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBuscador;
        public System.Windows.Forms.DataGridView dgvMaquinas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ToolStripButton tsbBaja;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDMaquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaBaja;
        public System.Windows.Forms.Button btnImprimir;
    }
}