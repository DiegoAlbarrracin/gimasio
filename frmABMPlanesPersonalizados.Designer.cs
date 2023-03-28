
namespace TPI_1
{
    partial class frmABMPlanesPersonalizados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMPlanesPersonalizados));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.toolTipABMPlanesPersonalizados = new System.Windows.Forms.ToolTip(this.components);
            this.btnModificarFila = new System.Windows.Forms.Button();
            this.btnAgregarFila = new System.Windows.Forms.Button();
            this.btnBajaFila = new System.Windows.Forms.Button();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.lblEjercicioPlanAlumno = new System.Windows.Forms.Label();
            this.lblEjercicioEPA = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblPlanBase = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.txtRepeticionesEPA = new System.Windows.Forms.TextBox();
            this.txtSeriesEPA = new System.Windows.Forms.TextBox();
            this.lblRepeticionesEPA = new System.Windows.Forms.Label();
            this.lblSeriesEPA = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.dgvEjercicioPlanAlumnoABM = new System.Windows.Forms.DataGridView();
            this.colIDEjercicioPlanAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDEjercicioEPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreEjercicioEPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDPlanxAlumnoEPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeriesEPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepeticionesEPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEjercicio = new System.Windows.Forms.TextBox();
            this.btnBuscarEjercicio = new System.Windows.Forms.Button();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjercicioPlanAlumnoABM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(366, 487);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 39);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.toolTipABMPlanesPersonalizados.SetToolTip(this.btnCancelar, "Pulse para Cancelar ");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(177, 487);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 39);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.toolTipABMPlanesPersonalizados.SetToolTip(this.btnGuardar, "Pulse para Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificarFila
            // 
            this.btnModificarFila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarFila.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarFila.ForeColor = System.Drawing.Color.White;
            this.btnModificarFila.Location = new System.Drawing.Point(1369, 342);
            this.btnModificarFila.Name = "btnModificarFila";
            this.btnModificarFila.Size = new System.Drawing.Size(90, 90);
            this.btnModificarFila.TabIndex = 13;
            this.btnModificarFila.Text = "Modificar";
            this.toolTipABMPlanesPersonalizados.SetToolTip(this.btnModificarFila, "Pulse para Guardar los cambios realizados en la fila seleccionada");
            this.btnModificarFila.UseVisualStyleBackColor = false;
            this.btnModificarFila.Click += new System.EventHandler(this.btnModificarFila_Click);
            // 
            // btnAgregarFila
            // 
            this.btnAgregarFila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFila.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFila.ForeColor = System.Drawing.Color.White;
            this.btnAgregarFila.Location = new System.Drawing.Point(1369, 246);
            this.btnAgregarFila.Name = "btnAgregarFila";
            this.btnAgregarFila.Size = new System.Drawing.Size(90, 90);
            this.btnAgregarFila.TabIndex = 12;
            this.btnAgregarFila.Text = "Agregar";
            this.toolTipABMPlanesPersonalizados.SetToolTip(this.btnAgregarFila, "Pulse para Agregar un nuevo ejercicio con sus correspondientes series y repeticio" +
        "nes");
            this.btnAgregarFila.UseVisualStyleBackColor = false;
            this.btnAgregarFila.Click += new System.EventHandler(this.btnAgregarFila_Click);
            // 
            // btnBajaFila
            // 
            this.btnBajaFila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBajaFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaFila.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaFila.ForeColor = System.Drawing.Color.White;
            this.btnBajaFila.Location = new System.Drawing.Point(1369, 436);
            this.btnBajaFila.Name = "btnBajaFila";
            this.btnBajaFila.Size = new System.Drawing.Size(90, 90);
            this.btnBajaFila.TabIndex = 14;
            this.btnBajaFila.Text = "Dar de Baja";
            this.toolTipABMPlanesPersonalizados.SetToolTip(this.btnBajaFila, "Pulse para Eliminar la fila seleccionada");
            this.btnBajaFila.UseVisualStyleBackColor = false;
            this.btnBajaFila.Click += new System.EventHandler(this.btnBajaFila_Click);
            // 
            // cmbPlan
            // 
            this.cmbPlan.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Location = new System.Drawing.Point(199, 114);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(206, 32);
            this.cmbPlan.TabIndex = 1;
            this.toolTipABMPlanesPersonalizados.SetToolTip(this.cmbPlan, "Escribe aqui el nombre del Plan y luego seleccionelo (Buscador Dinamico)");
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(200, 204);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(206, 32);
            this.cmbProfesor.TabIndex = 2;
            this.toolTipABMPlanesPersonalizados.SetToolTip(this.cmbProfesor, "Escribe aqui el nombre de Profesor y luego seleccionelo (Buscador Dinamico)");
            this.cmbProfesor.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbProfesor_Format);
            // 
            // lblEjercicioPlanAlumno
            // 
            this.lblEjercicioPlanAlumno.AutoSize = true;
            this.lblEjercicioPlanAlumno.BackColor = System.Drawing.Color.Transparent;
            this.lblEjercicioPlanAlumno.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjercicioPlanAlumno.ForeColor = System.Drawing.Color.Silver;
            this.lblEjercicioPlanAlumno.Location = new System.Drawing.Point(548, 39);
            this.lblEjercicioPlanAlumno.Name = "lblEjercicioPlanAlumno";
            this.lblEjercicioPlanAlumno.Size = new System.Drawing.Size(330, 34);
            this.lblEjercicioPlanAlumno.TabIndex = 49;
            this.lblEjercicioPlanAlumno.Text = "Diagramacion de Plan Personalizado:";
            // 
            // lblEjercicioEPA
            // 
            this.lblEjercicioEPA.AutoSize = true;
            this.lblEjercicioEPA.BackColor = System.Drawing.Color.Transparent;
            this.lblEjercicioEPA.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjercicioEPA.ForeColor = System.Drawing.Color.Silver;
            this.lblEjercicioEPA.Location = new System.Drawing.Point(575, 107);
            this.lblEjercicioEPA.Name = "lblEjercicioEPA";
            this.lblEjercicioEPA.Size = new System.Drawing.Size(83, 31);
            this.lblEjercicioEPA.TabIndex = 51;
            this.lblEjercicioEPA.Text = "Ejercicio:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpFechaDesde.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(200, 284);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(150, 32);
            this.dtpFechaDesde.TabIndex = 3;
            this.dtpFechaDesde.Value = new System.DateTime(2021, 8, 24, 0, 0, 0, 0);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaDesde.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.ForeColor = System.Drawing.Color.Silver;
            this.lblFechaDesde.Location = new System.Drawing.Point(48, 284);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(126, 34);
            this.lblFechaDesde.TabIndex = 65;
            this.lblFechaDesde.Text = "Fecha Desde:";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaHasta.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHasta.ForeColor = System.Drawing.Color.Silver;
            this.lblFechaHasta.Location = new System.Drawing.Point(48, 368);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(122, 34);
            this.lblFechaHasta.TabIndex = 63;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CustomFormat = " ";
            this.dtpFechaHasta.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Location = new System.Drawing.Point(201, 371);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(149, 30);
            this.dtpFechaHasta.TabIndex = 4;
            this.dtpFechaHasta.Value = new System.DateTime(1753, 1, 1, 3, 28, 0, 0);
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged_1);
            this.dtpFechaHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFechaHasta_KeyDown_1);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumno.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.ForeColor = System.Drawing.Color.Silver;
            this.lblAlumno.Location = new System.Drawing.Point(89, 30);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(81, 34);
            this.lblAlumno.TabIndex = 82;
            this.lblAlumno.Text = "Alumno:";
            // 
            // lblPlanBase
            // 
            this.lblPlanBase.AutoSize = true;
            this.lblPlanBase.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanBase.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanBase.ForeColor = System.Drawing.Color.Silver;
            this.lblPlanBase.Location = new System.Drawing.Point(65, 114);
            this.lblPlanBase.Name = "lblPlanBase";
            this.lblPlanBase.Size = new System.Drawing.Size(105, 34);
            this.lblPlanBase.TabIndex = 84;
            this.lblPlanBase.Text = "Plan Base:";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.BackColor = System.Drawing.Color.Transparent;
            this.lblProfesor.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor.ForeColor = System.Drawing.Color.Silver;
            this.lblProfesor.Location = new System.Drawing.Point(78, 200);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(96, 34);
            this.lblProfesor.TabIndex = 86;
            this.lblProfesor.Text = "Profesor:";
            // 
            // txtRepeticionesEPA
            // 
            this.txtRepeticionesEPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRepeticionesEPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRepeticionesEPA.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeticionesEPA.ForeColor = System.Drawing.Color.Silver;
            this.txtRepeticionesEPA.Location = new System.Drawing.Point(884, 156);
            this.txtRepeticionesEPA.MaxLength = 10;
            this.txtRepeticionesEPA.Name = "txtRepeticionesEPA";
            this.txtRepeticionesEPA.ShortcutsEnabled = false;
            this.txtRepeticionesEPA.Size = new System.Drawing.Size(106, 23);
            this.txtRepeticionesEPA.TabIndex = 9;
            this.txtRepeticionesEPA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRepeticionesEPA_KeyPress);
            // 
            // txtSeriesEPA
            // 
            this.txtSeriesEPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSeriesEPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeriesEPA.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeriesEPA.ForeColor = System.Drawing.Color.Silver;
            this.txtSeriesEPA.Location = new System.Drawing.Point(672, 156);
            this.txtSeriesEPA.MaxLength = 10;
            this.txtSeriesEPA.Name = "txtSeriesEPA";
            this.txtSeriesEPA.ShortcutsEnabled = false;
            this.txtSeriesEPA.Size = new System.Drawing.Size(86, 23);
            this.txtSeriesEPA.TabIndex = 8;
            this.txtSeriesEPA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeriesEPA_KeyPress);
            // 
            // lblRepeticionesEPA
            // 
            this.lblRepeticionesEPA.AutoSize = true;
            this.lblRepeticionesEPA.BackColor = System.Drawing.Color.Transparent;
            this.lblRepeticionesEPA.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeticionesEPA.ForeColor = System.Drawing.Color.Silver;
            this.lblRepeticionesEPA.Location = new System.Drawing.Point(764, 148);
            this.lblRepeticionesEPA.Name = "lblRepeticionesEPA";
            this.lblRepeticionesEPA.Size = new System.Drawing.Size(115, 31);
            this.lblRepeticionesEPA.TabIndex = 90;
            this.lblRepeticionesEPA.Text = "Repeticiones:";
            // 
            // lblSeriesEPA
            // 
            this.lblSeriesEPA.AutoSize = true;
            this.lblSeriesEPA.BackColor = System.Drawing.Color.Transparent;
            this.lblSeriesEPA.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeriesEPA.ForeColor = System.Drawing.Color.Silver;
            this.lblSeriesEPA.Location = new System.Drawing.Point(575, 152);
            this.lblSeriesEPA.Name = "lblSeriesEPA";
            this.lblSeriesEPA.Size = new System.Drawing.Size(69, 31);
            this.lblSeriesEPA.TabIndex = 89;
            this.lblSeriesEPA.Text = "Series:";
            // 
            // cmbDia
            // 
            this.cmbDia.DisplayMember = "(ninguno)";
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbDia.Location = new System.Drawing.Point(672, 191);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(150, 33);
            this.cmbDia.TabIndex = 10;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.lblDia.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.Silver;
            this.lblDia.Location = new System.Drawing.Point(575, 193);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(43, 31);
            this.lblDia.TabIndex = 96;
            this.lblDia.Text = "Dia:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblObservaciones.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.Color.Silver;
            this.lblObservaciones.Location = new System.Drawing.Point(1015, 109);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(133, 31);
            this.lblObservaciones.TabIndex = 94;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservaciones.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.Silver;
            this.txtObservaciones.Location = new System.Drawing.Point(1154, 107);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(305, 117);
            this.txtObservaciones.TabIndex = 11;
            // 
            // dgvEjercicioPlanAlumnoABM
            // 
            this.dgvEjercicioPlanAlumnoABM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEjercicioPlanAlumnoABM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEjercicioPlanAlumnoABM.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvEjercicioPlanAlumnoABM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEjercicioPlanAlumnoABM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEjercicioPlanAlumnoABM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEjercicioPlanAlumnoABM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEjercicioPlanAlumnoABM.ColumnHeadersHeight = 30;
            this.dgvEjercicioPlanAlumnoABM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEjercicioPlanAlumnoABM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDEjercicioPlanAlumno,
            this.colIDEjercicioEPA,
            this.colNombreEjercicioEPA,
            this.colIDPlanxAlumnoEPA,
            this.colSeriesEPA,
            this.colRepeticionesEPA,
            this.colMaquina,
            this.colDia,
            this.colObservaciones});
            this.dgvEjercicioPlanAlumnoABM.EnableHeadersVisualStyles = false;
            this.dgvEjercicioPlanAlumnoABM.GridColor = System.Drawing.Color.DimGray;
            this.dgvEjercicioPlanAlumnoABM.Location = new System.Drawing.Point(581, 246);
            this.dgvEjercicioPlanAlumnoABM.Name = "dgvEjercicioPlanAlumnoABM";
            this.dgvEjercicioPlanAlumnoABM.ReadOnly = true;
            this.dgvEjercicioPlanAlumnoABM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEjercicioPlanAlumnoABM.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEjercicioPlanAlumnoABM.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEjercicioPlanAlumnoABM.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEjercicioPlanAlumnoABM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEjercicioPlanAlumnoABM.Size = new System.Drawing.Size(782, 280);
            this.dgvEjercicioPlanAlumnoABM.TabIndex = 15;
            this.dgvEjercicioPlanAlumnoABM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEjercicioPlanAlumnoABM_CellClick);
            this.dgvEjercicioPlanAlumnoABM.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEjercicioPlanAlumnoABM_CellFormatting_1);
            // 
            // colIDEjercicioPlanAlumno
            // 
            this.colIDEjercicioPlanAlumno.HeaderText = "ID EjPlAl";
            this.colIDEjercicioPlanAlumno.Name = "colIDEjercicioPlanAlumno";
            this.colIDEjercicioPlanAlumno.ReadOnly = true;
            this.colIDEjercicioPlanAlumno.Visible = false;
            this.colIDEjercicioPlanAlumno.Width = 102;
            // 
            // colIDEjercicioEPA
            // 
            this.colIDEjercicioEPA.HeaderText = "ID Ejercicio";
            this.colIDEjercicioEPA.Name = "colIDEjercicioEPA";
            this.colIDEjercicioEPA.ReadOnly = true;
            this.colIDEjercicioEPA.Visible = false;
            this.colIDEjercicioEPA.Width = 124;
            // 
            // colNombreEjercicioEPA
            // 
            this.colNombreEjercicioEPA.HeaderText = "Ejercicio";
            this.colNombreEjercicioEPA.Name = "colNombreEjercicioEPA";
            this.colNombreEjercicioEPA.ReadOnly = true;
            this.colNombreEjercicioEPA.Width = 101;
            // 
            // colIDPlanxAlumnoEPA
            // 
            this.colIDPlanxAlumnoEPA.HeaderText = "ID PxA";
            this.colIDPlanxAlumnoEPA.Name = "colIDPlanxAlumnoEPA";
            this.colIDPlanxAlumnoEPA.ReadOnly = true;
            this.colIDPlanxAlumnoEPA.Visible = false;
            this.colIDPlanxAlumnoEPA.Width = 92;
            // 
            // colSeriesEPA
            // 
            this.colSeriesEPA.HeaderText = "Series";
            this.colSeriesEPA.Name = "colSeriesEPA";
            this.colSeriesEPA.ReadOnly = true;
            this.colSeriesEPA.Width = 87;
            // 
            // colRepeticionesEPA
            // 
            this.colRepeticionesEPA.HeaderText = "Repeticiones";
            this.colRepeticionesEPA.Name = "colRepeticionesEPA";
            this.colRepeticionesEPA.ReadOnly = true;
            this.colRepeticionesEPA.Width = 133;
            // 
            // colMaquina
            // 
            this.colMaquina.HeaderText = "Maquina";
            this.colMaquina.Name = "colMaquina";
            this.colMaquina.ReadOnly = true;
            this.colMaquina.Width = 99;
            // 
            // colDia
            // 
            this.colDia.HeaderText = "Dia";
            this.colDia.Name = "colDia";
            this.colDia.ReadOnly = true;
            this.colDia.Width = 61;
            // 
            // colObservaciones
            // 
            this.colObservaciones.HeaderText = "Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            this.colObservaciones.ReadOnly = true;
            this.colObservaciones.Width = 151;
            // 
            // txtEjercicio
            // 
            this.txtEjercicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEjercicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEjercicio.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEjercicio.ForeColor = System.Drawing.Color.Silver;
            this.txtEjercicio.Location = new System.Drawing.Point(672, 107);
            this.txtEjercicio.MaxLength = 10;
            this.txtEjercicio.Name = "txtEjercicio";
            this.txtEjercicio.ReadOnly = true;
            this.txtEjercicio.ShortcutsEnabled = false;
            this.txtEjercicio.Size = new System.Drawing.Size(251, 29);
            this.txtEjercicio.TabIndex = 98;
            // 
            // btnBuscarEjercicio
            // 
            this.btnBuscarEjercicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarEjercicio.BackgroundImage")));
            this.btnBuscarEjercicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEjercicio.Location = new System.Drawing.Point(942, 106);
            this.btnBuscarEjercicio.Name = "btnBuscarEjercicio";
            this.btnBuscarEjercicio.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarEjercicio.TabIndex = 7;
            this.toolTipABMPlanesPersonalizados.SetToolTip(this.btnBuscarEjercicio, "Presione para buscar Ejercicio");
            this.btnBuscarEjercicio.UseVisualStyleBackColor = true;
            this.btnBuscarEjercicio.Click += new System.EventHandler(this.btnBuscarEjercicio_Click);
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAlumno.Location = new System.Drawing.Point(199, 39);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.ReadOnly = true;
            this.txtNombreAlumno.Size = new System.Drawing.Size(204, 30);
            this.txtNombreAlumno.TabIndex = 100;
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarAlumno.BackgroundImage")));
            this.btnBuscarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAlumno.Location = new System.Drawing.Point(409, 39);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarAlumno.TabIndex = 0;
            this.toolTipABMPlanesPersonalizados.SetToolTip(this.btnBuscarAlumno, "Presione para buscar Alumno");
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.btnBuscarAlumno_Click);
            // 
            // frmABMPlanesPersonalizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1507, 580);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.btnBuscarAlumno);
            this.Controls.Add(this.txtEjercicio);
            this.Controls.Add(this.btnBuscarEjercicio);
            this.Controls.Add(this.dgvEjercicioPlanAlumnoABM);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtRepeticionesEPA);
            this.Controls.Add(this.txtSeriesEPA);
            this.Controls.Add(this.lblRepeticionesEPA);
            this.Controls.Add(this.lblSeriesEPA);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.cmbPlan);
            this.Controls.Add(this.lblPlanBase);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.btnModificarFila);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.btnAgregarFila);
            this.Controls.Add(this.btnBajaFila);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblEjercicioEPA);
            this.Controls.Add(this.lblEjercicioPlanAlumno);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MinimumSize = new System.Drawing.Size(517, 400);
            this.Name = "frmABMPlanesPersonalizados";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planes Personalizados";
            this.Load += new System.EventHandler(this.frmABMPlanesPersonalizados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjercicioPlanAlumnoABM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTipABMPlanesPersonalizados;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblEjercicioPlanAlumno;
        private System.Windows.Forms.Label lblEjercicioEPA;
        public System.Windows.Forms.Button btnModificarFila;
        public System.Windows.Forms.Button btnAgregarFila;
        public System.Windows.Forms.Button btnBajaFila;
        public System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        public System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.Label lblPlanBase;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.Label lblProfesor;
        public System.Windows.Forms.TextBox txtRepeticionesEPA;
        public System.Windows.Forms.TextBox txtSeriesEPA;
        private System.Windows.Forms.Label lblRepeticionesEPA;
        private System.Windows.Forms.Label lblSeriesEPA;
        public System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblObservaciones;
        public System.Windows.Forms.TextBox txtObservaciones;
        public System.Windows.Forms.DataGridView dgvEjercicioPlanAlumnoABM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDEjercicioPlanAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDEjercicioEPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreEjercicioEPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPlanxAlumnoEPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeriesEPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepeticionesEPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservaciones;
        public System.Windows.Forms.TextBox txtEjercicio;
        private System.Windows.Forms.Button btnBuscarEjercicio;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Button btnBuscarAlumno;
    }
}