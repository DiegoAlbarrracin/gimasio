
namespace TPI_1
{
    partial class frmPlanes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tstBarraLateralAlumno = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbBaja = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.cmbTipoPlan = new System.Windows.Forms.ComboBox();
            this.lblTipoPlan = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.dgvEjercicioxPlan = new System.Windows.Forms.DataGridView();
            this.colIDEjercicioxPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEjercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepeticiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlNombrePantalla = new System.Windows.Forms.Panel();
            this.lblNombrePantalla = new System.Windows.Forms.Label();
            this.dgvPlanes = new System.Windows.Forms.DataGridView();
            this.colIDPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.tstBarraLateralAlumno.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjercicioxPlan)).BeginInit();
            this.pnlNombrePantalla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).BeginInit();
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
            this.pnlContenedor.Controls.Add(this.cmbTipoPlan);
            this.pnlContenedor.Controls.Add(this.lblTipoPlan);
            this.pnlContenedor.Controls.Add(this.btnAyuda);
            this.pnlContenedor.Controls.Add(this.dgvEjercicioxPlan);
            this.pnlContenedor.Controls.Add(this.cmbEstado);
            this.pnlContenedor.Controls.Add(this.lblEstado);
            this.pnlContenedor.Controls.Add(this.btnBuscar);
            this.pnlContenedor.Controls.Add(this.txtBuscador);
            this.pnlContenedor.Controls.Add(this.lblNombre);
            this.pnlContenedor.Controls.Add(this.pnlNombrePantalla);
            this.pnlContenedor.Controls.Add(this.dgvPlanes);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1228, 554);
            this.pnlContenedor.TabIndex = 2;
            // 
            // cmbTipoPlan
            // 
            this.cmbTipoPlan.FormattingEnabled = true;
            this.cmbTipoPlan.Location = new System.Drawing.Point(551, 52);
            this.cmbTipoPlan.Name = "cmbTipoPlan";
            this.cmbTipoPlan.Size = new System.Drawing.Size(173, 32);
            this.cmbTipoPlan.TabIndex = 1;
            // 
            // lblTipoPlan
            // 
            this.lblTipoPlan.AutoSize = true;
            this.lblTipoPlan.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoPlan.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPlan.ForeColor = System.Drawing.Color.Silver;
            this.lblTipoPlan.Location = new System.Drawing.Point(466, 53);
            this.lblTipoPlan.Name = "lblTipoPlan";
            this.lblTipoPlan.Size = new System.Drawing.Size(88, 31);
            this.lblTipoPlan.TabIndex = 16;
            this.lblTipoPlan.Text = "Tipo Plan:";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAyuda.BackColor = System.Drawing.Color.Gold;
            this.btnAyuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAyuda.BackgroundImage")));
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Location = new System.Drawing.Point(136, 460);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(64, 63);
            this.btnAyuda.TabIndex = 6;
            this.btnAyuda.Text = "AYUDA";
            this.btnAyuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // dgvEjercicioxPlan
            // 
            this.dgvEjercicioxPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEjercicioxPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEjercicioxPlan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEjercicioxPlan.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvEjercicioxPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEjercicioxPlan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEjercicioxPlan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEjercicioxPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEjercicioxPlan.ColumnHeadersHeight = 30;
            this.dgvEjercicioxPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEjercicioxPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDEjercicioxPlan,
            this.colEjercicio,
            this.colSeries,
            this.colRepeticiones,
            this.colMaquina,
            this.colDia,
            this.colObservaciones});
            this.dgvEjercicioxPlan.EnableHeadersVisualStyles = false;
            this.dgvEjercicioxPlan.GridColor = System.Drawing.Color.DimGray;
            this.dgvEjercicioxPlan.Location = new System.Drawing.Point(136, 276);
            this.dgvEjercicioxPlan.Name = "dgvEjercicioxPlan";
            this.dgvEjercicioxPlan.ReadOnly = true;
            this.dgvEjercicioxPlan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEjercicioxPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEjercicioxPlan.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEjercicioxPlan.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEjercicioxPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEjercicioxPlan.Size = new System.Drawing.Size(692, 178);
            this.dgvEjercicioxPlan.TabIndex = 5;
            this.dgvEjercicioxPlan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEjercicioxPlan_CellFormatting);
            // 
            // colIDEjercicioxPlan
            // 
            this.colIDEjercicioxPlan.HeaderText = "Nº";
            this.colIDEjercicioxPlan.Name = "colIDEjercicioxPlan";
            this.colIDEjercicioxPlan.ReadOnly = true;
            this.colIDEjercicioxPlan.Width = 48;
            // 
            // colEjercicio
            // 
            this.colEjercicio.HeaderText = "Ejercicio";
            this.colEjercicio.Name = "colEjercicio";
            this.colEjercicio.ReadOnly = true;
            this.colEjercicio.Width = 82;
            // 
            // colSeries
            // 
            this.colSeries.HeaderText = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.ReadOnly = true;
            this.colSeries.Width = 71;
            // 
            // colRepeticiones
            // 
            this.colRepeticiones.HeaderText = "Repeticiones";
            this.colRepeticiones.Name = "colRepeticiones";
            this.colRepeticiones.ReadOnly = true;
            this.colRepeticiones.Width = 106;
            // 
            // colMaquina
            // 
            this.colMaquina.HeaderText = "Maquina";
            this.colMaquina.Name = "colMaquina";
            this.colMaquina.ReadOnly = true;
            this.colMaquina.Width = 81;
            // 
            // colDia
            // 
            this.colDia.HeaderText = "Dia";
            this.colDia.Name = "colDia";
            this.colDia.ReadOnly = true;
            this.colDia.Width = 51;
            // 
            // colObservaciones
            // 
            this.colObservaciones.HeaderText = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            this.colObservaciones.ReadOnly = true;
            this.colObservaciones.Width = 120;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(822, 51);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(173, 32);
            this.cmbEstado.TabIndex = 2;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Silver;
            this.lblEstado.Location = new System.Drawing.Point(748, 49);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 31);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(1001, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 33);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscador.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscador.Location = new System.Drawing.Point(215, 51);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(245, 33);
            this.txtBuscador.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Silver;
            this.lblNombre.Location = new System.Drawing.Point(130, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 31);
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
            this.lblNombrePantalla.Size = new System.Drawing.Size(86, 39);
            this.lblNombrePantalla.TabIndex = 0;
            this.lblNombrePantalla.Text = "Planes";
            // 
            // dgvPlanes
            // 
            this.dgvPlanes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPlanes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPlanes.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvPlanes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlanes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlanes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlanes.ColumnHeadersHeight = 30;
            this.dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDPlan,
            this.colNombre,
            this.colTipoPlan,
            this.colDescripcion,
            this.colEstado});
            this.dgvPlanes.EnableHeadersVisualStyles = false;
            this.dgvPlanes.GridColor = System.Drawing.Color.DimGray;
            this.dgvPlanes.Location = new System.Drawing.Point(136, 100);
            this.dgvPlanes.Name = "dgvPlanes";
            this.dgvPlanes.ReadOnly = true;
            this.dgvPlanes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPlanes.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPlanes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanes.Size = new System.Drawing.Size(954, 150);
            this.dgvPlanes.TabIndex = 4;
            this.dgvPlanes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanes_CellClick);
            this.dgvPlanes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPlanes_CellFormatting);
            // 
            // colIDPlan
            // 
            this.colIDPlan.HeaderText = "ID Plan";
            this.colIDPlan.Name = "colIDPlan";
            this.colIDPlan.ReadOnly = true;
            this.colIDPlan.Width = 73;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre de Plan";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 126;
            // 
            // colTipoPlan
            // 
            this.colTipoPlan.HeaderText = "Tipo Plan";
            this.colTipoPlan.Name = "colTipoPlan";
            this.colTipoPlan.ReadOnly = true;
            this.colTipoPlan.Width = 86;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Width = 102;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 70;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Location = new System.Drawing.Point(1013, 383);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(77, 71);
            this.btnImprimir.TabIndex = 17;
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmPlanes
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
            this.Name = "frmPlanes";
            this.Load += new System.EventHandler(this.frmPlanes_Load);
            this.tstBarraLateralAlumno.ResumeLayout(false);
            this.tstBarraLateralAlumno.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjercicioxPlan)).EndInit();
            this.pnlNombrePantalla.ResumeLayout(false);
            this.pnlNombrePantalla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).EndInit();
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
        public System.Windows.Forms.DataGridView dgvPlanes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ToolStripButton tsbBaja;
        private System.Windows.Forms.ComboBox cmbEstado;
        public System.Windows.Forms.DataGridView dgvEjercicioxPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.ComboBox cmbTipoPlan;
        private System.Windows.Forms.Label lblTipoPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDEjercicioxPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEjercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepeticiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservaciones;
        public System.Windows.Forms.Button btnImprimir;
    }
}