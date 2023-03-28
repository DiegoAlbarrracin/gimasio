
namespace TPI_1
{
    partial class frmABMClase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMClase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.toolTipABMClase = new System.Windows.Forms.ToolTip(this.components);
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.btnModificarFila = new System.Windows.Forms.Button();
            this.btnAgregarFila = new System.Windows.Forms.Button();
            this.btnBajaFila = new System.Windows.Forms.Button();
            this.txtCupoMaximo = new System.Windows.Forms.TextBox();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.btnModificarFilaAxC = new System.Windows.Forms.Button();
            this.btnAgregarFilaAxC = new System.Windows.Forms.Button();
            this.btnBajaFilaAxC = new System.Windows.Forms.Button();
            this.lblProfesorxClase = new System.Windows.Forms.Label();
            this.lblProfesorPxC = new System.Windows.Forms.Label();
            this.lblCupoMaximo = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dgvProfesorxClaseABM = new System.Windows.Forms.DataGridView();
            this.colIDProfesorxClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClasee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaDesdee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaHastaa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDiaPxC = new System.Windows.Forms.Label();
            this.lblFechaDesdePxC = new System.Windows.Forms.Label();
            this.lblFechaHastaPxC = new System.Windows.Forms.Label();
            this.lblHoraInicioPxC = new System.Windows.Forms.Label();
            this.dtpFechaHastaPxC = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesdePxC = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.gbAlumnoxClase = new System.Windows.Forms.GroupBox();
            this.dtpFechaDesdeAxC = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHastaAxC = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHastaAxC = new System.Windows.Forms.Label();
            this.lblFechaDesdeAxC = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.dgvAlumnoxClaseABM = new System.Windows.Forms.DataGridView();
            this.colIDAxCABM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDAlumnoAxCABM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlumnoAxCABM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClaseAxCABM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaDesdeAxCABM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaHastaAxCABM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesorxClaseABM)).BeginInit();
            this.gbAlumnoxClase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoxClaseABM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(366, 487);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 39);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.toolTipABMClase.SetToolTip(this.btnCancelar, "Pulse para Cancelar ");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(177, 487);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 39);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.toolTipABMClase.SetToolTip(this.btnGuardar, "Pulse para Guardar");
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
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(202, 246);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(150, 39);
            this.cmbEstado.TabIndex = 4;
            this.toolTipABMClase.SetToolTip(this.cmbEstado, "Seleccione un Estado ");
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Silver;
            this.lblEstado.Location = new System.Drawing.Point(93, 247);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(75, 34);
            this.lblEstado.TabIndex = 43;
            this.lblEstado.Text = "Estado:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.lblDescripcion.Location = new System.Drawing.Point(49, 301);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(121, 34);
            this.lblDescripcion.TabIndex = 32;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Silver;
            this.txtNombre.Location = new System.Drawing.Point(202, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(287, 26);
            this.txtNombre.TabIndex = 0;
            this.toolTipABMClase.SetToolTip(this.txtNombre, "Ingrese nombre de la nueva Clase");
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.txtDescripcion.Location = new System.Drawing.Point(177, 309);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(306, 163);
            this.txtDescripcion.TabIndex = 5;
            this.toolTipABMClase.SetToolTip(this.txtDescripcion, "Ingrese aqui una breve descripcion");
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Silver;
            this.lblNombre.Location = new System.Drawing.Point(12, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(165, 34);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre de Clase:";
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(709, 90);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(206, 33);
            this.cmbProfesor.TabIndex = 6;
            this.toolTipABMClase.SetToolTip(this.cmbProfesor, "Escribe aqui el nombre de Profesor y luego seleccionelo (Buscador Dinamico)");
            this.cmbProfesor.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbProfesor_Format);
            // 
            // btnModificarFila
            // 
            this.btnModificarFila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarFila.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarFila.ForeColor = System.Drawing.Color.White;
            this.btnModificarFila.Location = new System.Drawing.Point(1305, 342);
            this.btnModificarFila.Name = "btnModificarFila";
            this.btnModificarFila.Size = new System.Drawing.Size(90, 90);
            this.btnModificarFila.TabIndex = 12;
            this.btnModificarFila.Text = "Modificar";
            this.toolTipABMClase.SetToolTip(this.btnModificarFila, "Pulse para Guardar los cambios realizados en la fila seleccionada");
            this.btnModificarFila.UseVisualStyleBackColor = false;
            this.btnModificarFila.Click += new System.EventHandler(this.btnModificarFila_Click);
            // 
            // btnAgregarFila
            // 
            this.btnAgregarFila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFila.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFila.ForeColor = System.Drawing.Color.White;
            this.btnAgregarFila.Location = new System.Drawing.Point(1305, 246);
            this.btnAgregarFila.Name = "btnAgregarFila";
            this.btnAgregarFila.Size = new System.Drawing.Size(90, 90);
            this.btnAgregarFila.TabIndex = 11;
            this.btnAgregarFila.Text = "Agregar";
            this.toolTipABMClase.SetToolTip(this.btnAgregarFila, "Pulse para Agregar un nuevo ejercicio con sus correspondientes series y repeticio" +
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
            this.btnBajaFila.Location = new System.Drawing.Point(1305, 436);
            this.btnBajaFila.Name = "btnBajaFila";
            this.btnBajaFila.Size = new System.Drawing.Size(90, 90);
            this.btnBajaFila.TabIndex = 13;
            this.btnBajaFila.Text = "Dar de Baja";
            this.toolTipABMClase.SetToolTip(this.btnBajaFila, "Pulse para Eliminar la fila seleccionada");
            this.btnBajaFila.UseVisualStyleBackColor = false;
            this.btnBajaFila.Click += new System.EventHandler(this.btnBajaFila_Click);
            // 
            // txtCupoMaximo
            // 
            this.txtCupoMaximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCupoMaximo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCupoMaximo.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCupoMaximo.ForeColor = System.Drawing.Color.Silver;
            this.txtCupoMaximo.Location = new System.Drawing.Point(201, 90);
            this.txtCupoMaximo.MaxLength = 10;
            this.txtCupoMaximo.Name = "txtCupoMaximo";
            this.txtCupoMaximo.ShortcutsEnabled = false;
            this.txtCupoMaximo.Size = new System.Drawing.Size(102, 26);
            this.txtCupoMaximo.TabIndex = 1;
            this.toolTipABMClase.SetToolTip(this.txtCupoMaximo, "Ingrese numero de series");
            this.txtCupoMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCupoMaximo_KeyPress);
            // 
            // cmbDia
            // 
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.cmbDia.Location = new System.Drawing.Point(709, 138);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(206, 33);
            this.cmbDia.TabIndex = 7;
            this.toolTipABMClase.SetToolTip(this.cmbDia, "Seleccione el Dia");
            // 
            // btnModificarFilaAxC
            // 
            this.btnModificarFilaAxC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarFilaAxC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarFilaAxC.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarFilaAxC.ForeColor = System.Drawing.Color.White;
            this.btnModificarFilaAxC.Location = new System.Drawing.Point(380, 278);
            this.btnModificarFilaAxC.Name = "btnModificarFilaAxC";
            this.btnModificarFilaAxC.Size = new System.Drawing.Size(70, 74);
            this.btnModificarFilaAxC.TabIndex = 19;
            this.btnModificarFilaAxC.Text = "Modificar";
            this.toolTipABMClase.SetToolTip(this.btnModificarFilaAxC, "Pulse para Guardar los cambios realizados en la fila seleccionada");
            this.btnModificarFilaAxC.UseVisualStyleBackColor = false;
            this.btnModificarFilaAxC.Click += new System.EventHandler(this.btnModificarFilaAxC_Click);
            // 
            // btnAgregarFilaAxC
            // 
            this.btnAgregarFilaAxC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarFilaAxC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFilaAxC.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFilaAxC.ForeColor = System.Drawing.Color.White;
            this.btnAgregarFilaAxC.Location = new System.Drawing.Point(380, 198);
            this.btnAgregarFilaAxC.Name = "btnAgregarFilaAxC";
            this.btnAgregarFilaAxC.Size = new System.Drawing.Size(70, 74);
            this.btnAgregarFilaAxC.TabIndex = 18;
            this.btnAgregarFilaAxC.Text = "Agregar";
            this.toolTipABMClase.SetToolTip(this.btnAgregarFilaAxC, "Pulse para Agregar un nuevo ejercicio con sus correspondientes series y repeticio" +
        "nes");
            this.btnAgregarFilaAxC.UseVisualStyleBackColor = false;
            this.btnAgregarFilaAxC.Click += new System.EventHandler(this.btnAgregarFilaAxC_Click);
            // 
            // btnBajaFilaAxC
            // 
            this.btnBajaFilaAxC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBajaFilaAxC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaFilaAxC.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaFilaAxC.ForeColor = System.Drawing.Color.White;
            this.btnBajaFilaAxC.Location = new System.Drawing.Point(380, 360);
            this.btnBajaFilaAxC.Name = "btnBajaFilaAxC";
            this.btnBajaFilaAxC.Size = new System.Drawing.Size(70, 75);
            this.btnBajaFilaAxC.TabIndex = 20;
            this.btnBajaFilaAxC.Text = "Dar de Baja";
            this.toolTipABMClase.SetToolTip(this.btnBajaFilaAxC, "Pulse para Eliminar la fila seleccionada");
            this.btnBajaFilaAxC.UseVisualStyleBackColor = false;
            this.btnBajaFilaAxC.Click += new System.EventHandler(this.btnBajaFilaAxC_Click);
            // 
            // lblProfesorxClase
            // 
            this.lblProfesorxClase.AutoSize = true;
            this.lblProfesorxClase.BackColor = System.Drawing.Color.Transparent;
            this.lblProfesorxClase.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesorxClase.ForeColor = System.Drawing.Color.Silver;
            this.lblProfesorxClase.Location = new System.Drawing.Point(548, 39);
            this.lblProfesorxClase.Name = "lblProfesorxClase";
            this.lblProfesorxClase.Size = new System.Drawing.Size(225, 34);
            this.lblProfesorxClase.TabIndex = 49;
            this.lblProfesorxClase.Text = "Diagramacion de Clases:";
            // 
            // lblProfesorPxC
            // 
            this.lblProfesorPxC.AutoSize = true;
            this.lblProfesorPxC.BackColor = System.Drawing.Color.Transparent;
            this.lblProfesorPxC.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesorPxC.ForeColor = System.Drawing.Color.Silver;
            this.lblProfesorPxC.Location = new System.Drawing.Point(607, 86);
            this.lblProfesorPxC.Name = "lblProfesorPxC";
            this.lblProfesorPxC.Size = new System.Drawing.Size(96, 34);
            this.lblProfesorPxC.TabIndex = 51;
            this.lblProfesorPxC.Text = "Profesor:";
            // 
            // lblCupoMaximo
            // 
            this.lblCupoMaximo.AutoSize = true;
            this.lblCupoMaximo.BackColor = System.Drawing.Color.Transparent;
            this.lblCupoMaximo.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCupoMaximo.ForeColor = System.Drawing.Color.Silver;
            this.lblCupoMaximo.Location = new System.Drawing.Point(39, 84);
            this.lblCupoMaximo.Name = "lblCupoMaximo";
            this.lblCupoMaximo.Size = new System.Drawing.Size(133, 34);
            this.lblCupoMaximo.TabIndex = 61;
            this.lblCupoMaximo.Text = "Cupo Maximo:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpFechaDesde.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(202, 139);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(150, 32);
            this.dtpFechaDesde.TabIndex = 2;
            this.dtpFechaDesde.Value = new System.DateTime(2021, 8, 24, 0, 0, 0, 0);
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaDesde.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.ForeColor = System.Drawing.Color.Silver;
            this.lblFechaDesde.Location = new System.Drawing.Point(46, 140);
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
            this.lblFechaHasta.Location = new System.Drawing.Point(46, 194);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(122, 34);
            this.lblFechaHasta.TabIndex = 63;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // dgvProfesorxClaseABM
            // 
            this.dgvProfesorxClaseABM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProfesorxClaseABM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProfesorxClaseABM.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvProfesorxClaseABM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProfesorxClaseABM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProfesorxClaseABM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfesorxClaseABM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProfesorxClaseABM.ColumnHeadersHeight = 30;
            this.dgvProfesorxClaseABM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProfesorxClaseABM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDProfesorxClase,
            this.colProfesor,
            this.colClasee,
            this.colFechaDesdee,
            this.colFechaHastaa,
            this.colDia,
            this.colHoraInicio,
            this.colIDProfesor,
            this.colIDClase});
            this.dgvProfesorxClaseABM.EnableHeadersVisualStyles = false;
            this.dgvProfesorxClaseABM.GridColor = System.Drawing.Color.DimGray;
            this.dgvProfesorxClaseABM.Location = new System.Drawing.Point(537, 247);
            this.dgvProfesorxClaseABM.Name = "dgvProfesorxClaseABM";
            this.dgvProfesorxClaseABM.ReadOnly = true;
            this.dgvProfesorxClaseABM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfesorxClaseABM.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProfesorxClaseABM.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProfesorxClaseABM.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProfesorxClaseABM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfesorxClaseABM.Size = new System.Drawing.Size(762, 279);
            this.dgvProfesorxClaseABM.TabIndex = 14;
            this.dgvProfesorxClaseABM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesorxClaseABM_CellClick);
            this.dgvProfesorxClaseABM.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProfesorxClaseABM_CellFormatting);
            // 
            // colIDProfesorxClase
            // 
            this.colIDProfesorxClase.HeaderText = "ID PxC";
            this.colIDProfesorxClase.Name = "colIDProfesorxClase";
            this.colIDProfesorxClase.ReadOnly = true;
            this.colIDProfesorxClase.Visible = false;
            this.colIDProfesorxClase.Width = 92;
            // 
            // colProfesor
            // 
            this.colProfesor.HeaderText = "Profesor";
            this.colProfesor.Name = "colProfesor";
            this.colProfesor.ReadOnly = true;
            this.colProfesor.Width = 105;
            // 
            // colClasee
            // 
            this.colClasee.HeaderText = "Clase";
            this.colClasee.Name = "colClasee";
            this.colClasee.ReadOnly = true;
            this.colClasee.Width = 79;
            // 
            // colFechaDesdee
            // 
            this.colFechaDesdee.HeaderText = "Fecha Desde";
            this.colFechaDesdee.Name = "colFechaDesdee";
            this.colFechaDesdee.ReadOnly = true;
            this.colFechaDesdee.Width = 132;
            // 
            // colFechaHastaa
            // 
            this.colFechaHastaa.HeaderText = "Fecha Hasta";
            this.colFechaHastaa.Name = "colFechaHastaa";
            this.colFechaHastaa.ReadOnly = true;
            this.colFechaHastaa.Width = 128;
            // 
            // colDia
            // 
            this.colDia.HeaderText = "Dia";
            this.colDia.Name = "colDia";
            this.colDia.ReadOnly = true;
            this.colDia.Width = 61;
            // 
            // colHoraInicio
            // 
            this.colHoraInicio.HeaderText = "Hora Inicio";
            this.colHoraInicio.Name = "colHoraInicio";
            this.colHoraInicio.ReadOnly = true;
            this.colHoraInicio.Width = 119;
            // 
            // colIDProfesor
            // 
            this.colIDProfesor.HeaderText = "ID Profesor";
            this.colIDProfesor.Name = "colIDProfesor";
            this.colIDProfesor.ReadOnly = true;
            this.colIDProfesor.Visible = false;
            this.colIDProfesor.Width = 128;
            // 
            // colIDClase
            // 
            this.colIDClase.HeaderText = "ID Clase";
            this.colIDClase.Name = "colIDClase";
            this.colIDClase.ReadOnly = true;
            this.colIDClase.Visible = false;
            this.colIDClase.Width = 102;
            // 
            // lblDiaPxC
            // 
            this.lblDiaPxC.AutoSize = true;
            this.lblDiaPxC.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaPxC.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaPxC.ForeColor = System.Drawing.Color.Silver;
            this.lblDiaPxC.Location = new System.Drawing.Point(652, 136);
            this.lblDiaPxC.Name = "lblDiaPxC";
            this.lblDiaPxC.Size = new System.Drawing.Size(47, 34);
            this.lblDiaPxC.TabIndex = 71;
            this.lblDiaPxC.Text = "Dia:";
            // 
            // lblFechaDesdePxC
            // 
            this.lblFechaDesdePxC.AutoSize = true;
            this.lblFechaDesdePxC.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaDesdePxC.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesdePxC.ForeColor = System.Drawing.Color.Silver;
            this.lblFechaDesdePxC.Location = new System.Drawing.Point(1017, 85);
            this.lblFechaDesdePxC.Name = "lblFechaDesdePxC";
            this.lblFechaDesdePxC.Size = new System.Drawing.Size(126, 34);
            this.lblFechaDesdePxC.TabIndex = 73;
            this.lblFechaDesdePxC.Text = "Fecha Desde:";
            // 
            // lblFechaHastaPxC
            // 
            this.lblFechaHastaPxC.AutoSize = true;
            this.lblFechaHastaPxC.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaHastaPxC.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHastaPxC.ForeColor = System.Drawing.Color.Silver;
            this.lblFechaHastaPxC.Location = new System.Drawing.Point(1017, 133);
            this.lblFechaHastaPxC.Name = "lblFechaHastaPxC";
            this.lblFechaHastaPxC.Size = new System.Drawing.Size(122, 34);
            this.lblFechaHastaPxC.TabIndex = 74;
            this.lblFechaHastaPxC.Text = "Fecha Hasta:";
            // 
            // lblHoraInicioPxC
            // 
            this.lblHoraInicioPxC.AutoSize = true;
            this.lblHoraInicioPxC.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraInicioPxC.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicioPxC.ForeColor = System.Drawing.Color.Silver;
            this.lblHoraInicioPxC.Location = new System.Drawing.Point(1001, 175);
            this.lblHoraInicioPxC.Name = "lblHoraInicioPxC";
            this.lblHoraInicioPxC.Size = new System.Drawing.Size(138, 34);
            this.lblHoraInicioPxC.TabIndex = 75;
            this.lblHoraInicioPxC.Text = "Hora de Inicio:";
            // 
            // dtpFechaHastaPxC
            // 
            this.dtpFechaHastaPxC.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHastaPxC.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpFechaHastaPxC.CustomFormat = " ";
            this.dtpFechaHastaPxC.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHastaPxC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHastaPxC.Location = new System.Drawing.Point(1149, 135);
            this.dtpFechaHastaPxC.Name = "dtpFechaHastaPxC";
            this.dtpFechaHastaPxC.Size = new System.Drawing.Size(150, 32);
            this.dtpFechaHastaPxC.TabIndex = 9;
            this.dtpFechaHastaPxC.Value = new System.DateTime(2021, 8, 24, 0, 0, 0, 0);
            this.dtpFechaHastaPxC.ValueChanged += new System.EventHandler(this.dtpFechaHastaPxC_ValueChanged);
            this.dtpFechaHastaPxC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFechaHastaPxC_KeyDown);
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.CustomFormat = " ";
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(1149, 173);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(150, 36);
            this.dtpHoraInicio.TabIndex = 10;
            this.dtpHoraInicio.Value = new System.DateTime(2021, 9, 17, 0, 0, 0, 0);
            this.dtpHoraInicio.ValueChanged += new System.EventHandler(this.dtpHoraInicio_ValueChanged);
            // 
            // dtpFechaDesdePxC
            // 
            this.dtpFechaDesdePxC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesdePxC.Location = new System.Drawing.Point(1150, 90);
            this.dtpFechaDesdePxC.Name = "dtpFechaDesdePxC";
            this.dtpFechaDesdePxC.Size = new System.Drawing.Size(149, 36);
            this.dtpFechaDesdePxC.TabIndex = 8;
            this.dtpFechaDesdePxC.Value = new System.DateTime(2021, 9, 23, 0, 0, 0, 0);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CustomFormat = " ";
            this.dtpFechaHasta.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Location = new System.Drawing.Point(202, 194);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(149, 30);
            this.dtpFechaHasta.TabIndex = 3;
            this.dtpFechaHasta.Value = new System.DateTime(1753, 1, 1, 3, 28, 0, 0);
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged_1);
            this.dtpFechaHasta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFechaHasta_KeyDown_1);
            // 
            // gbAlumnoxClase
            // 
            this.gbAlumnoxClase.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbAlumnoxClase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbAlumnoxClase.BackgroundImage")));
            this.gbAlumnoxClase.Controls.Add(this.txtNombreAlumno);
            this.gbAlumnoxClase.Controls.Add(this.btnBuscarAlumno);
            this.gbAlumnoxClase.Controls.Add(this.dtpFechaDesdeAxC);
            this.gbAlumnoxClase.Controls.Add(this.dtpFechaHastaAxC);
            this.gbAlumnoxClase.Controls.Add(this.lblFechaHastaAxC);
            this.gbAlumnoxClase.Controls.Add(this.lblFechaDesdeAxC);
            this.gbAlumnoxClase.Controls.Add(this.lblAlumno);
            this.gbAlumnoxClase.Controls.Add(this.btnModificarFilaAxC);
            this.gbAlumnoxClase.Controls.Add(this.btnAgregarFilaAxC);
            this.gbAlumnoxClase.Controls.Add(this.btnBajaFilaAxC);
            this.gbAlumnoxClase.Controls.Add(this.dgvAlumnoxClaseABM);
            this.gbAlumnoxClase.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlumnoxClase.ForeColor = System.Drawing.Color.White;
            this.gbAlumnoxClase.Location = new System.Drawing.Point(1425, 85);
            this.gbAlumnoxClase.Name = "gbAlumnoxClase";
            this.gbAlumnoxClase.Size = new System.Drawing.Size(456, 441);
            this.gbAlumnoxClase.TabIndex = 76;
            this.gbAlumnoxClase.TabStop = false;
            this.gbAlumnoxClase.Text = "Alumnos de la Clase";
            // 
            // dtpFechaDesdeAxC
            // 
            this.dtpFechaDesdeAxC.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesdeAxC.Location = new System.Drawing.Point(146, 71);
            this.dtpFechaDesdeAxC.Name = "dtpFechaDesdeAxC";
            this.dtpFechaDesdeAxC.Size = new System.Drawing.Size(149, 33);
            this.dtpFechaDesdeAxC.TabIndex = 16;
            this.dtpFechaDesdeAxC.Value = new System.DateTime(2021, 9, 23, 0, 0, 0, 0);
            // 
            // dtpFechaHastaAxC
            // 
            this.dtpFechaHastaAxC.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHastaAxC.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpFechaHastaAxC.CustomFormat = " ";
            this.dtpFechaHastaAxC.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHastaAxC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHastaAxC.Location = new System.Drawing.Point(146, 111);
            this.dtpFechaHastaAxC.Name = "dtpFechaHastaAxC";
            this.dtpFechaHastaAxC.Size = new System.Drawing.Size(150, 32);
            this.dtpFechaHastaAxC.TabIndex = 17;
            this.dtpFechaHastaAxC.Value = new System.DateTime(2021, 8, 24, 0, 0, 0, 0);
            this.dtpFechaHastaAxC.Visible = false;
            this.dtpFechaHastaAxC.ValueChanged += new System.EventHandler(this.dtpFechaHastaAxC_ValueChanged);
            this.dtpFechaHastaAxC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFechaHastaAxC_KeyDown);
            // 
            // lblFechaHastaAxC
            // 
            this.lblFechaHastaAxC.AutoSize = true;
            this.lblFechaHastaAxC.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaHastaAxC.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHastaAxC.ForeColor = System.Drawing.Color.Silver;
            this.lblFechaHastaAxC.Location = new System.Drawing.Point(13, 111);
            this.lblFechaHastaAxC.Name = "lblFechaHastaAxC";
            this.lblFechaHastaAxC.Size = new System.Drawing.Size(122, 34);
            this.lblFechaHastaAxC.TabIndex = 78;
            this.lblFechaHastaAxC.Text = "Fecha Hasta:";
            this.lblFechaHastaAxC.Visible = false;
            // 
            // lblFechaDesdeAxC
            // 
            this.lblFechaDesdeAxC.AutoSize = true;
            this.lblFechaDesdeAxC.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaDesdeAxC.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesdeAxC.ForeColor = System.Drawing.Color.Silver;
            this.lblFechaDesdeAxC.Location = new System.Drawing.Point(9, 70);
            this.lblFechaDesdeAxC.Name = "lblFechaDesdeAxC";
            this.lblFechaDesdeAxC.Size = new System.Drawing.Size(126, 34);
            this.lblFechaDesdeAxC.TabIndex = 77;
            this.lblFechaDesdeAxC.Text = "Fecha Desde:";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumno.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.ForeColor = System.Drawing.Color.Silver;
            this.lblAlumno.Location = new System.Drawing.Point(54, 36);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(81, 34);
            this.lblAlumno.TabIndex = 53;
            this.lblAlumno.Text = "Alumno:";
            // 
            // dgvAlumnoxClaseABM
            // 
            this.dgvAlumnoxClaseABM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlumnoxClaseABM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlumnoxClaseABM.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvAlumnoxClaseABM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlumnoxClaseABM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAlumnoxClaseABM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnoxClaseABM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAlumnoxClaseABM.ColumnHeadersHeight = 30;
            this.dgvAlumnoxClaseABM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlumnoxClaseABM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDAxCABM,
            this.colIDAlumnoAxCABM,
            this.colAlumnoAxCABM,
            this.colClaseAxCABM,
            this.colFechaDesdeAxCABM,
            this.colFechaHastaAxCABM});
            this.dgvAlumnoxClaseABM.EnableHeadersVisualStyles = false;
            this.dgvAlumnoxClaseABM.GridColor = System.Drawing.Color.DimGray;
            this.dgvAlumnoxClaseABM.Location = new System.Drawing.Point(6, 198);
            this.dgvAlumnoxClaseABM.Name = "dgvAlumnoxClaseABM";
            this.dgvAlumnoxClaseABM.ReadOnly = true;
            this.dgvAlumnoxClaseABM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnoxClaseABM.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAlumnoxClaseABM.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAlumnoxClaseABM.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAlumnoxClaseABM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnoxClaseABM.Size = new System.Drawing.Size(368, 237);
            this.dgvAlumnoxClaseABM.TabIndex = 21;
            this.dgvAlumnoxClaseABM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnoxClaseABM_CellClick);
            // 
            // colIDAxCABM
            // 
            this.colIDAxCABM.HeaderText = "ID AxC";
            this.colIDAxCABM.Name = "colIDAxCABM";
            this.colIDAxCABM.ReadOnly = true;
            this.colIDAxCABM.Visible = false;
            this.colIDAxCABM.Width = 78;
            // 
            // colIDAlumnoAxCABM
            // 
            this.colIDAlumnoAxCABM.HeaderText = "ID Alumno";
            this.colIDAlumnoAxCABM.Name = "colIDAlumnoAxCABM";
            this.colIDAlumnoAxCABM.ReadOnly = true;
            this.colIDAlumnoAxCABM.Visible = false;
            this.colIDAlumnoAxCABM.Width = 97;
            // 
            // colAlumnoAxCABM
            // 
            this.colAlumnoAxCABM.HeaderText = "Alumno";
            this.colAlumnoAxCABM.Name = "colAlumnoAxCABM";
            this.colAlumnoAxCABM.ReadOnly = true;
            this.colAlumnoAxCABM.Width = 78;
            // 
            // colClaseAxCABM
            // 
            this.colClaseAxCABM.HeaderText = "Clase";
            this.colClaseAxCABM.Name = "colClaseAxCABM";
            this.colClaseAxCABM.ReadOnly = true;
            this.colClaseAxCABM.Width = 68;
            // 
            // colFechaDesdeAxCABM
            // 
            this.colFechaDesdeAxCABM.HeaderText = "Fecha Desde";
            this.colFechaDesdeAxCABM.Name = "colFechaDesdeAxCABM";
            this.colFechaDesdeAxCABM.ReadOnly = true;
            this.colFechaDesdeAxCABM.Width = 110;
            // 
            // colFechaHastaAxCABM
            // 
            this.colFechaHastaAxCABM.HeaderText = "Fecha Hasta";
            this.colFechaHastaAxCABM.Name = "colFechaHastaAxCABM";
            this.colFechaHastaAxCABM.ReadOnly = true;
            this.colFechaHastaAxCABM.Visible = false;
            this.colFechaHastaAxCABM.Width = 109;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAlumno.Location = new System.Drawing.Point(146, 35);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.ReadOnly = true;
            this.txtNombreAlumno.Size = new System.Drawing.Size(204, 30);
            this.txtNombreAlumno.TabIndex = 80;
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarAlumno.BackgroundImage")));
            this.btnBuscarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAlumno.Location = new System.Drawing.Point(356, 35);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarAlumno.TabIndex = 15;
            this.toolTipABMClase.SetToolTip(this.btnBuscarAlumno, "Presione para buscar Alumno");
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.btnBuscarAlumno_Click);
            // 
            // frmABMClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1893, 580);
            this.Controls.Add(this.gbAlumnoxClase);
            this.Controls.Add(this.btnModificarFila);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.btnAgregarFila);
            this.Controls.Add(this.btnBajaFila);
            this.Controls.Add(this.dtpFechaDesdePxC);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.dtpFechaHastaPxC);
            this.Controls.Add(this.lblHoraInicioPxC);
            this.Controls.Add(this.lblFechaHastaPxC);
            this.Controls.Add(this.lblFechaDesdePxC);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.lblDiaPxC);
            this.Controls.Add(this.dgvProfesorxClaseABM);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.txtCupoMaximo);
            this.Controls.Add(this.lblCupoMaximo);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.lblProfesorPxC);
            this.Controls.Add(this.lblProfesorxClase);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MinimumSize = new System.Drawing.Size(517, 400);
            this.Name = "frmABMClase";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clases";
            this.Load += new System.EventHandler(this.frmABMClase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesorxClaseABM)).EndInit();
            this.gbAlumnoxClase.ResumeLayout(false);
            this.gbAlumnoxClase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoxClaseABM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDescripcion;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolTip toolTipABMClase;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblProfesorxClase;
        private System.Windows.Forms.Label lblProfesorPxC;
        private System.Windows.Forms.ComboBox cmbProfesor;
        public System.Windows.Forms.Button btnModificarFila;
        public System.Windows.Forms.Button btnAgregarFila;
        public System.Windows.Forms.Button btnBajaFila;
        private System.Windows.Forms.Label lblCupoMaximo;
        public System.Windows.Forms.TextBox txtCupoMaximo;
        public System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        public System.Windows.Forms.DataGridView dgvProfesorxClaseABM;
        private System.Windows.Forms.Label lblDiaPxC;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Label lblFechaDesdePxC;
        private System.Windows.Forms.Label lblFechaHastaPxC;
        private System.Windows.Forms.Label lblHoraInicioPxC;
        public System.Windows.Forms.DateTimePicker dtpFechaHastaPxC;
        public System.Windows.Forms.DateTimePicker dtpHoraInicio;
        public System.Windows.Forms.DateTimePicker dtpFechaDesdePxC;
        public System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDProfesorxClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClasee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaDesdee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaHastaa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDClase;
        private System.Windows.Forms.GroupBox gbAlumnoxClase;
        public System.Windows.Forms.DataGridView dgvAlumnoxClaseABM;
        public System.Windows.Forms.Button btnModificarFilaAxC;
        public System.Windows.Forms.Button btnAgregarFilaAxC;
        public System.Windows.Forms.Button btnBajaFilaAxC;
        public System.Windows.Forms.DateTimePicker dtpFechaDesdeAxC;
        public System.Windows.Forms.DateTimePicker dtpFechaHastaAxC;
        private System.Windows.Forms.Label lblFechaHastaAxC;
        private System.Windows.Forms.Label lblFechaDesdeAxC;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDAxCABM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDAlumnoAxCABM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlumnoAxCABM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClaseAxCABM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaDesdeAxCABM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaHastaAxCABM;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Button btnBuscarAlumno;
    }
}