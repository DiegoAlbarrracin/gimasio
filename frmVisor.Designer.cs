
namespace TPI_1
{
    partial class frmVisor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisor));
            this.vPlanPersonalizadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPlanPersonalizado = new TPI_1.DataSetPlanPersonalizado();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.cmbReporte = new System.Windows.Forms.ComboBox();
            this.lblReporte = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.rpvVisor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetEjercicioE = new TPI_1.DataSetEjercicioE();
            this.EjercicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EjercicioTableAdapter = new TPI_1.DataSetEjercicioETableAdapters.EjercicioTableAdapter();
            this.MaquinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaquinaTableAdapter = new TPI_1.DataSetEjercicioETableAdapters.MaquinaTableAdapter();
            this.TipoEjercicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TipoEjercicioTableAdapter = new TPI_1.DataSetEjercicioETableAdapters.TipoEjercicioTableAdapter();
            this.vPlanPersonalizadoTableAdapter = new TPI_1.DataSetPlanPersonalizadoTableAdapters.vPlanPersonalizadoTableAdapter();
            this.tstBarraLateralReportes = new System.Windows.Forms.ToolStrip();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.cmbClase = new System.Windows.Forms.ComboBox();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.lblIncluirC = new System.Windows.Forms.Label();
            this.lblIncluirA = new System.Windows.Forms.Label();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.btnBorrarAlumno = new System.Windows.Forms.Button();
            this.toolTipfrmVisor = new System.Windows.Forms.ToolTip(this.components);
            this.nudFechaDesde = new System.Windows.Forms.NumericUpDown();
            this.nudFechaHasta = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.vPlanPersonalizadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPlanPersonalizado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEjercicioE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EjercicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaquinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipoEjercicioBindingSource)).BeginInit();
            this.tstBarraLateralReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFechaDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFechaHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // vPlanPersonalizadoBindingSource
            // 
            this.vPlanPersonalizadoBindingSource.DataMember = "vPlanPersonalizado";
            this.vPlanPersonalizadoBindingSource.DataSource = this.DataSetPlanPersonalizado;
            // 
            // DataSetPlanPersonalizado
            // 
            this.DataSetPlanPersonalizado.DataSetName = "DataSetPlanPersonalizado";
            this.DataSetPlanPersonalizado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(885, 10);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(156, 35);
            this.btnGenerarReporte.TabIndex = 1;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // cmbReporte
            // 
            this.cmbReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReporte.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReporte.FormattingEnabled = true;
            this.cmbReporte.Items.AddRange(new object[] {
            "Alumnos",
            "Profesores",
            "Maquinas",
            "Ejercicios",
            "Planes",
            "Plan de Alumno",
            "Clases",
            "Asistencias"});
            this.cmbReporte.Location = new System.Drawing.Point(302, 10);
            this.cmbReporte.Name = "cmbReporte";
            this.cmbReporte.Size = new System.Drawing.Size(198, 32);
            this.cmbReporte.TabIndex = 3;
            this.cmbReporte.SelectedIndexChanged += new System.EventHandler(this.cmbReporte_SelectedIndexChanged);
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.BackColor = System.Drawing.Color.Transparent;
            this.lblReporte.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReporte.ForeColor = System.Drawing.Color.Silver;
            this.lblReporte.Location = new System.Drawing.Point(117, 10);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(185, 34);
            this.lblReporte.TabIndex = 26;
            this.lblReporte.Text = "Seleccione Reporte:";
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(665, 10);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(179, 33);
            this.txtDNI.TabIndex = 27;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.Silver;
            this.lblFiltro.Location = new System.Drawing.Point(540, 10);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(119, 34);
            this.lblFiltro.TabIndex = 28;
            this.lblFiltro.Text = "Ingrese DNI:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Alumnos",
            "Profesores",
            "Maquinas",
            "Ejercicios",
            "Planes",
            "Plan de Alumno"});
            this.cmbEstado.Location = new System.Drawing.Point(665, 11);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(204, 32);
            this.cmbEstado.TabIndex = 31;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // rpvVisor
            // 
            this.rpvVisor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            reportDataSource1.Name = "DataSetPlanPersonalizado";
            reportDataSource1.Value = this.vPlanPersonalizadoBindingSource;
            this.rpvVisor.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvVisor.LocalReport.ReportEmbeddedResource = "TPI_1.Reportes.RDLCPlanPersonalizado.rdlc";
            this.rpvVisor.Location = new System.Drawing.Point(123, 161);
            this.rpvVisor.Name = "rpvVisor";
            this.rpvVisor.ServerReport.BearerToken = null;
            this.rpvVisor.Size = new System.Drawing.Size(918, 272);
            this.rpvVisor.TabIndex = 32;
            // 
            // DataSetEjercicioE
            // 
            this.DataSetEjercicioE.DataSetName = "DataSetEjercicioE";
            this.DataSetEjercicioE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EjercicioBindingSource
            // 
            this.EjercicioBindingSource.DataMember = "Ejercicio";
            this.EjercicioBindingSource.DataSource = this.DataSetEjercicioE;
            // 
            // EjercicioTableAdapter
            // 
            this.EjercicioTableAdapter.ClearBeforeFill = true;
            // 
            // MaquinaBindingSource
            // 
            this.MaquinaBindingSource.DataMember = "Maquina";
            this.MaquinaBindingSource.DataSource = this.DataSetEjercicioE;
            // 
            // MaquinaTableAdapter
            // 
            this.MaquinaTableAdapter.ClearBeforeFill = true;
            // 
            // TipoEjercicioBindingSource
            // 
            this.TipoEjercicioBindingSource.DataMember = "TipoEjercicio";
            this.TipoEjercicioBindingSource.DataSource = this.DataSetEjercicioE;
            // 
            // TipoEjercicioTableAdapter
            // 
            this.TipoEjercicioTableAdapter.ClearBeforeFill = true;
            // 
            // vPlanPersonalizadoTableAdapter
            // 
            this.vPlanPersonalizadoTableAdapter.ClearBeforeFill = true;
            // 
            // tstBarraLateralReportes
            // 
            this.tstBarraLateralReportes.AutoSize = false;
            this.tstBarraLateralReportes.BackColor = System.Drawing.Color.White;
            this.tstBarraLateralReportes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tstBarraLateralReportes.BackgroundImage")));
            this.tstBarraLateralReportes.Dock = System.Windows.Forms.DockStyle.Right;
            this.tstBarraLateralReportes.GripMargin = new System.Windows.Forms.Padding(0);
            this.tstBarraLateralReportes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tstBarraLateralReportes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCerrar});
            this.tstBarraLateralReportes.Location = new System.Drawing.Point(1098, 0);
            this.tstBarraLateralReportes.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tstBarraLateralReportes.Name = "tstBarraLateralReportes";
            this.tstBarraLateralReportes.Padding = new System.Windows.Forms.Padding(0);
            this.tstBarraLateralReportes.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tstBarraLateralReportes.Size = new System.Drawing.Size(114, 445);
            this.tstBarraLateralReportes.TabIndex = 33;
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
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click_1);
            // 
            // cmbClase
            // 
            this.cmbClase.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(302, 63);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(198, 32);
            this.cmbClase.TabIndex = 34;
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.BackColor = System.Drawing.Color.Transparent;
            this.lblClase.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClase.ForeColor = System.Drawing.Color.Silver;
            this.lblClase.Location = new System.Drawing.Point(117, 61);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(165, 34);
            this.lblClase.TabIndex = 35;
            this.lblClase.Text = "Seleccione Clase:";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.BackColor = System.Drawing.Color.Transparent;
            this.lblProfesor.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor.ForeColor = System.Drawing.Color.Silver;
            this.lblProfesor.Location = new System.Drawing.Point(563, 61);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(96, 34);
            this.lblProfesor.TabIndex = 37;
            this.lblProfesor.Text = "Profesor:";
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(665, 61);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(204, 32);
            this.cmbProfesor.TabIndex = 36;
            this.cmbProfesor.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbProfesor_Format);
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.BackColor = System.Drawing.Color.Transparent;
            this.lblFormato.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.ForeColor = System.Drawing.Color.Silver;
            this.lblFormato.Location = new System.Drawing.Point(563, 109);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(88, 34);
            this.lblFormato.TabIndex = 41;
            this.lblFormato.Text = "Formato:";
            // 
            // cmbFormato
            // 
            this.cmbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormato.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Items.AddRange(new object[] {
            "Detallado",
            "Resumido"});
            this.cmbFormato.Location = new System.Drawing.Point(665, 109);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(204, 32);
            this.cmbFormato.TabIndex = 40;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumno.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.ForeColor = System.Drawing.Color.Silver;
            this.lblAlumno.Location = new System.Drawing.Point(117, 109);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(179, 34);
            this.lblAlumno.TabIndex = 39;
            this.lblAlumno.Text = "Seleccione Alumno:";
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkTodos.BackgroundImage")));
            this.chkTodos.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTodos.ForeColor = System.Drawing.SystemColors.Control;
            this.chkTodos.Location = new System.Drawing.Point(875, 109);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(15, 14);
            this.chkTodos.TabIndex = 42;
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // lblIncluirC
            // 
            this.lblIncluirC.AutoSize = true;
            this.lblIncluirC.BackColor = System.Drawing.Color.Transparent;
            this.lblIncluirC.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncluirC.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIncluirC.Location = new System.Drawing.Point(895, 89);
            this.lblIncluirC.Name = "lblIncluirC";
            this.lblIncluirC.Size = new System.Drawing.Size(99, 24);
            this.lblIncluirC.TabIndex = 43;
            this.lblIncluirC.Text = "Incluir clases y";
            // 
            // lblIncluirA
            // 
            this.lblIncluirA.AutoSize = true;
            this.lblIncluirA.BackColor = System.Drawing.Color.Transparent;
            this.lblIncluirA.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncluirA.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIncluirA.Location = new System.Drawing.Point(895, 114);
            this.lblIncluirA.Name = "lblIncluirA";
            this.lblIncluirA.Size = new System.Drawing.Size(144, 24);
            this.lblIncluirA.TabIndex = 44;
            this.lblIncluirA.Text = "alumnos dados de baja";
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarAlumno.BackgroundImage")));
            this.btnBuscarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAlumno.Location = new System.Drawing.Point(506, 113);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarAlumno.TabIndex = 45;
            this.toolTipfrmVisor.SetToolTip(this.btnBuscarAlumno, "Pulse para buscar Alumno");
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.btnBuscarAlumno_Click);
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAlumno.Location = new System.Drawing.Point(302, 113);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.ReadOnly = true;
            this.txtNombreAlumno.Size = new System.Drawing.Size(198, 30);
            this.txtNombreAlumno.TabIndex = 46;
            // 
            // btnBorrarAlumno
            // 
            this.btnBorrarAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrarAlumno.BackgroundImage")));
            this.btnBorrarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrarAlumno.Location = new System.Drawing.Point(464, 114);
            this.btnBorrarAlumno.Name = "btnBorrarAlumno";
            this.btnBorrarAlumno.Size = new System.Drawing.Size(36, 30);
            this.btnBorrarAlumno.TabIndex = 47;
            this.toolTipfrmVisor.SetToolTip(this.btnBorrarAlumno, "Pulse para limpiar el alumno seleccionado");
            this.btnBorrarAlumno.UseVisualStyleBackColor = true;
            this.btnBorrarAlumno.Click += new System.EventHandler(this.btnBorrarAlumno_Click);
            // 
            // nudFechaDesde
            // 
            this.nudFechaDesde.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFechaDesde.Location = new System.Drawing.Point(302, 63);
            this.nudFechaDesde.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudFechaDesde.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudFechaDesde.Name = "nudFechaDesde";
            this.nudFechaDesde.Size = new System.Drawing.Size(120, 30);
            this.nudFechaDesde.TabIndex = 48;
            this.nudFechaDesde.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // nudFechaHasta
            // 
            this.nudFechaHasta.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFechaHasta.Location = new System.Drawing.Point(749, 62);
            this.nudFechaHasta.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudFechaHasta.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudFechaHasta.Name = "nudFechaHasta";
            this.nudFechaHasta.Size = new System.Drawing.Size(120, 30);
            this.nudFechaHasta.TabIndex = 49;
            this.nudFechaHasta.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // frmVisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1212, 445);
            this.Controls.Add(this.nudFechaHasta);
            this.Controls.Add(this.nudFechaDesde);
            this.Controls.Add(this.btnBorrarAlumno);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.btnBuscarAlumno);
            this.Controls.Add(this.lblIncluirA);
            this.Controls.Add(this.lblIncluirC);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.cmbFormato);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.lblClase);
            this.Controls.Add(this.cmbClase);
            this.Controls.Add(this.tstBarraLateralReportes);
            this.Controls.Add(this.rpvVisor);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.cmbReporte);
            this.Controls.Add(this.btnGenerarReporte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVisor";
            this.Text = "Visor de Reportes";
            this.Load += new System.EventHandler(this.frmVisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vPlanPersonalizadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPlanPersonalizado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetEjercicioE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EjercicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaquinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipoEjercicioBindingSource)).EndInit();
            this.tstBarraLateralReportes.ResumeLayout(false);
            this.tstBarraLateralReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFechaDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFechaHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblReporte;
        private Microsoft.Reporting.WinForms.ReportViewer rpvVisor;
        private System.Windows.Forms.BindingSource EjercicioBindingSource;
        private DataSetEjercicioE DataSetEjercicioE;
        private System.Windows.Forms.BindingSource MaquinaBindingSource;
        private System.Windows.Forms.BindingSource TipoEjercicioBindingSource;
        private DataSetEjercicioETableAdapters.EjercicioTableAdapter EjercicioTableAdapter;
        private DataSetEjercicioETableAdapters.MaquinaTableAdapter MaquinaTableAdapter;
        private DataSetEjercicioETableAdapters.TipoEjercicioTableAdapter TipoEjercicioTableAdapter;
        private System.Windows.Forms.BindingSource vPlanPersonalizadoBindingSource;
        private DataSetPlanPersonalizado DataSetPlanPersonalizado;
        private DataSetPlanPersonalizadoTableAdapters.vPlanPersonalizadoTableAdapter vPlanPersonalizadoTableAdapter;
        private System.Windows.Forms.ToolStrip tstBarraLateralReportes;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.ToolTip toolTipfrmVisor;
        public System.Windows.Forms.ComboBox cmbReporte;
        public System.Windows.Forms.ComboBox cmbEstado;
        public System.Windows.Forms.Button btnGenerarReporte;
        public System.Windows.Forms.Label lblFiltro;
        public System.Windows.Forms.TextBox txtDNI;
        public System.Windows.Forms.ComboBox cmbClase;
        public System.Windows.Forms.Label lblClase;
        public System.Windows.Forms.Label lblProfesor;
        public System.Windows.Forms.ComboBox cmbProfesor;
        public System.Windows.Forms.Label lblFormato;
        public System.Windows.Forms.ComboBox cmbFormato;
        public System.Windows.Forms.Label lblAlumno;
        public System.Windows.Forms.CheckBox chkTodos;
        public System.Windows.Forms.Label lblIncluirC;
        public System.Windows.Forms.Label lblIncluirA;
        public System.Windows.Forms.Button btnBuscarAlumno;
        public System.Windows.Forms.TextBox txtNombreAlumno;
        public System.Windows.Forms.Button btnBorrarAlumno;
        public System.Windows.Forms.NumericUpDown nudFechaDesde;
        public System.Windows.Forms.NumericUpDown nudFechaHasta;
    }
}