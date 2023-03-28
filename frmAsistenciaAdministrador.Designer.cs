
namespace TPI_1
{
    partial class frmAsistenciaAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsistenciaAdministrador));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tstBarraLateralAsistencia = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbBaja = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnTraerTodas = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlNombrePantalla = new System.Windows.Forms.Panel();
            this.lblNombrePantalla = new System.Windows.Forms.Label();
            this.dgvAsisencias = new System.Windows.Forms.DataGridView();
            this.colIDAsistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaAsistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblirReportes = new System.Windows.Forms.Label();
            this.toolTipAsistencias = new System.Windows.Forms.ToolTip(this.components);
            this.tstBarraLateralAsistencia.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.pnlNombrePantalla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsisencias)).BeginInit();
            this.SuspendLayout();
            // 
            // tstBarraLateralAsistencia
            // 
            this.tstBarraLateralAsistencia.AutoSize = false;
            this.tstBarraLateralAsistencia.BackColor = System.Drawing.Color.White;
            this.tstBarraLateralAsistencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tstBarraLateralAsistencia.BackgroundImage")));
            this.tstBarraLateralAsistencia.Dock = System.Windows.Forms.DockStyle.Right;
            this.tstBarraLateralAsistencia.GripMargin = new System.Windows.Forms.Padding(0);
            this.tstBarraLateralAsistencia.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tstBarraLateralAsistencia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsbModificar,
            this.tsbBaja,
            this.tsbCerrar});
            this.tstBarraLateralAsistencia.Location = new System.Drawing.Point(1114, 0);
            this.tstBarraLateralAsistencia.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tstBarraLateralAsistencia.Name = "tstBarraLateralAsistencia";
            this.tstBarraLateralAsistencia.Padding = new System.Windows.Forms.Padding(0);
            this.tstBarraLateralAsistencia.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tstBarraLateralAsistencia.Size = new System.Drawing.Size(114, 554);
            this.tstBarraLateralAsistencia.TabIndex = 1;
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
            this.pnlContenedor.Controls.Add(this.lblirReportes);
            this.pnlContenedor.Controls.Add(this.btnImprimir);
            this.pnlContenedor.Controls.Add(this.label1);
            this.pnlContenedor.Controls.Add(this.lblSeparador);
            this.pnlContenedor.Controls.Add(this.btnBuscarAlumno);
            this.pnlContenedor.Controls.Add(this.lblAlumno);
            this.pnlContenedor.Controls.Add(this.txtDNI);
            this.pnlContenedor.Controls.Add(this.btnTraerTodas);
            this.pnlContenedor.Controls.Add(this.dtpFecha);
            this.pnlContenedor.Controls.Add(this.btnBuscar);
            this.pnlContenedor.Controls.Add(this.lblFecha);
            this.pnlContenedor.Controls.Add(this.pnlNombrePantalla);
            this.pnlContenedor.Controls.Add(this.dgvAsisencias);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1228, 554);
            this.pnlContenedor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(466, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 44);
            this.label1.TabIndex = 17;
            this.label1.Text = "|";
            // 
            // lblSeparador
            // 
            this.lblSeparador.AutoSize = true;
            this.lblSeparador.BackColor = System.Drawing.Color.Transparent;
            this.lblSeparador.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador.ForeColor = System.Drawing.Color.Silver;
            this.lblSeparador.Location = new System.Drawing.Point(617, 45);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(28, 44);
            this.lblSeparador.TabIndex = 16;
            this.lblSeparador.Text = "|";
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarAlumno.BackgroundImage")));
            this.btnBuscarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAlumno.Location = new System.Drawing.Point(1001, 56);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(38, 33);
            this.btnBuscarAlumno.TabIndex = 15;
            this.toolTipAsistencias.SetToolTip(this.btnBuscarAlumno, "Busca asistencias correspondientes al DNI ingresado");
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.btnBuscarAlumno_Click);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumno.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.ForeColor = System.Drawing.Color.Silver;
            this.lblAlumno.Location = new System.Drawing.Point(657, 54);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(130, 31);
            this.lblAlumno.TabIndex = 14;
            this.lblAlumno.Text = "DNI de Alumno:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(793, 57);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(202, 30);
            this.txtDNI.TabIndex = 13;
            // 
            // btnTraerTodas
            // 
            this.btnTraerTodas.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTraerTodas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTraerTodas.BackgroundImage")));
            this.btnTraerTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraerTodas.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTraerTodas.Location = new System.Drawing.Point(500, 53);
            this.btnTraerTodas.Name = "btnTraerTodas";
            this.btnTraerTodas.Size = new System.Drawing.Size(111, 33);
            this.btnTraerTodas.TabIndex = 12;
            this.btnTraerTodas.Text = "TRAER TODAS";
            this.toolTipAsistencias.SetToolTip(this.btnTraerTodas, "Trae todas las asistencias sin filtro");
            this.btnTraerTodas.UseVisualStyleBackColor = false;
            this.btnTraerTodas.Click += new System.EventHandler(this.btnTraerTodas_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = " ";
            this.dtpFecha.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(234, 55);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(149, 30);
            this.dtpFecha.TabIndex = 11;
            this.dtpFecha.Value = new System.DateTime(1753, 1, 1, 3, 28, 0, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            this.dtpFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFecha_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(389, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 33);
            this.btnBuscar.TabIndex = 10;
            this.toolTipAsistencias.SetToolTip(this.btnBuscar, "Busca asistencias en la fecha ingresada");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Silver;
            this.lblFecha.Location = new System.Drawing.Point(142, 55);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 31);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
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
            this.lblNombrePantalla.Size = new System.Drawing.Size(134, 39);
            this.lblNombrePantalla.TabIndex = 0;
            this.lblNombrePantalla.Text = "Asistencias";
            // 
            // dgvAsisencias
            // 
            this.dgvAsisencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsisencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAsisencias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAsisencias.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvAsisencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsisencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAsisencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsisencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAsisencias.ColumnHeadersHeight = 30;
            this.dgvAsisencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAsisencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDAsistencia,
            this.colAlumno,
            this.colFechaAsistencia});
            this.dgvAsisencias.EnableHeadersVisualStyles = false;
            this.dgvAsisencias.GridColor = System.Drawing.Color.DimGray;
            this.dgvAsisencias.Location = new System.Drawing.Point(136, 100);
            this.dgvAsisencias.Name = "dgvAsisencias";
            this.dgvAsisencias.ReadOnly = true;
            this.dgvAsisencias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsisencias.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAsisencias.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAsisencias.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAsisencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsisencias.Size = new System.Drawing.Size(954, 150);
            this.dgvAsisencias.TabIndex = 0;
            this.dgvAsisencias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAlumnos_CellFormatting);
            // 
            // colIDAsistencia
            // 
            this.colIDAsistencia.HeaderText = "ID Asistencia";
            this.colIDAsistencia.Name = "colIDAsistencia";
            this.colIDAsistencia.ReadOnly = true;
            this.colIDAsistencia.Width = 108;
            // 
            // colAlumno
            // 
            this.colAlumno.HeaderText = "Nombre Alumno";
            this.colAlumno.Name = "colAlumno";
            this.colAlumno.ReadOnly = true;
            this.colAlumno.Width = 127;
            // 
            // colFechaAsistencia
            // 
            this.colFechaAsistencia.HeaderText = "Fecha Asistencia";
            this.colFechaAsistencia.Name = "colFechaAsistencia";
            this.colFechaAsistencia.ReadOnly = true;
            this.colFechaAsistencia.Width = 131;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Location = new System.Drawing.Point(1013, 351);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(77, 71);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTipAsistencias.SetToolTip(this.btnImprimir, "Presione para dirigirse a la pantalla de Reportes de Asistencias");
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblirReportes
            // 
            this.lblirReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblirReportes.AutoSize = true;
            this.lblirReportes.BackColor = System.Drawing.Color.Transparent;
            this.lblirReportes.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblirReportes.ForeColor = System.Drawing.Color.Silver;
            this.lblirReportes.Location = new System.Drawing.Point(817, 351);
            this.lblirReportes.Name = "lblirReportes";
            this.lblirReportes.Size = new System.Drawing.Size(178, 31);
            this.lblirReportes.TabIndex = 19;
            this.lblirReportes.Text = "Ir a sección Reportes";
            // 
            // frmAsistenciaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1228, 554);
            this.Controls.Add(this.tstBarraLateralAsistencia);
            this.Controls.Add(this.pnlContenedor);
            this.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAsistenciaAdministrador";
            this.Load += new System.EventHandler(this.frmAsistencias_Load);
            this.tstBarraLateralAsistencia.ResumeLayout(false);
            this.tstBarraLateralAsistencia.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.pnlNombrePantalla.ResumeLayout(false);
            this.pnlNombrePantalla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsisencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip tstBarraLateralAsistencia;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlNombrePantalla;
        private System.Windows.Forms.Label lblNombrePantalla;
        private System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.DataGridView dgvAsisencias;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolStripButton tsbBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDAsistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaAsistencia;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnTraerTodas;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblirReportes;
        private System.Windows.Forms.ToolTip toolTipAsistencias;
    }
}