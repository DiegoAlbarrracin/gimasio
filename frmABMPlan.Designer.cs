
namespace TPI_1
{
    partial class frmABMPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMPlan));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTipoPlan = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbTipoPlan = new System.Windows.Forms.ComboBox();
            this.toolTipABMPlan = new System.Windows.Forms.ToolTip(this.components);
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.txtRepeticiones = new System.Windows.Forms.TextBox();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.lblEjerciciosDelPlan = new System.Windows.Forms.Label();
            this.dgvEjercicioxPlanABM = new System.Windows.Forms.DataGridView();
            this.colIDEjercicioxPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEjercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepeticiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDEjercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEjercicio = new System.Windows.Forms.Label();
            this.lblSeries = new System.Windows.Forms.Label();
            this.lblRepeticiones = new System.Windows.Forms.Label();
            this.btnModificarFila = new System.Windows.Forms.Button();
            this.btnAgregarFila = new System.Windows.Forms.Button();
            this.btnBajaFila = new System.Windows.Forms.Button();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.txtEjercicio = new System.Windows.Forms.TextBox();
            this.btnBuscarEjercicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjercicioxPlanABM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(367, 451);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 39);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.toolTipABMPlan.SetToolTip(this.btnCancelar, "Pulse para Cancelar ");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(178, 451);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 39);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.toolTipABMPlan.SetToolTip(this.btnGuardar, "Pulse para Guardar");
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
            this.cmbEstado.Location = new System.Drawing.Point(179, 167);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(150, 39);
            this.cmbEstado.TabIndex = 2;
            this.toolTipABMPlan.SetToolTip(this.cmbEstado, "Seleccione un Estado ");
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Silver;
            this.lblEstado.Location = new System.Drawing.Point(97, 172);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(75, 34);
            this.lblEstado.TabIndex = 43;
            this.lblEstado.Text = "Estado:";
            // 
            // lblTipoPlan
            // 
            this.lblTipoPlan.AutoSize = true;
            this.lblTipoPlan.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoPlan.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPlan.ForeColor = System.Drawing.Color.Silver;
            this.lblTipoPlan.Location = new System.Drawing.Point(75, 101);
            this.lblTipoPlan.Name = "lblTipoPlan";
            this.lblTipoPlan.Size = new System.Drawing.Size(97, 34);
            this.lblTipoPlan.TabIndex = 41;
            this.lblTipoPlan.Text = "Tipo Plan:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.lblDescripcion.Location = new System.Drawing.Point(51, 229);
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
            this.txtNombre.Location = new System.Drawing.Point(178, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(306, 26);
            this.txtNombre.TabIndex = 0;
            this.toolTipABMPlan.SetToolTip(this.txtNombre, "Ingrese nombre del nuevo Plan");
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.txtDescripcion.Location = new System.Drawing.Point(179, 237);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(305, 163);
            this.txtDescripcion.TabIndex = 3;
            this.toolTipABMPlan.SetToolTip(this.txtDescripcion, "Ingrese aqui una breve descripcion");
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Silver;
            this.lblNombre.Location = new System.Drawing.Point(12, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(160, 34);
            this.lblNombre.TabIndex = 25;
            this.lblNombre.Text = "Nombre del Plan:";
            // 
            // cmbTipoPlan
            // 
            this.cmbTipoPlan.FormattingEnabled = true;
            this.cmbTipoPlan.Location = new System.Drawing.Point(178, 100);
            this.cmbTipoPlan.Name = "cmbTipoPlan";
            this.cmbTipoPlan.Size = new System.Drawing.Size(251, 39);
            this.cmbTipoPlan.TabIndex = 1;
            this.toolTipABMPlan.SetToolTip(this.cmbTipoPlan, "Escribe aqui el tipo de plan y luego seleccionelo (Buscador Dinamico)");
            // 
            // txtSeries
            // 
            this.txtSeries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSeries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeries.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeries.ForeColor = System.Drawing.Color.Silver;
            this.txtSeries.Location = new System.Drawing.Point(633, 132);
            this.txtSeries.MaxLength = 10;
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.ShortcutsEnabled = false;
            this.txtSeries.Size = new System.Drawing.Size(81, 23);
            this.txtSeries.TabIndex = 5;
            this.toolTipABMPlan.SetToolTip(this.txtSeries, "Ingrese numero de series");
            this.txtSeries.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeries_KeyPress);
            // 
            // txtRepeticiones
            // 
            this.txtRepeticiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRepeticiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRepeticiones.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeticiones.ForeColor = System.Drawing.Color.Silver;
            this.txtRepeticiones.Location = new System.Drawing.Point(849, 134);
            this.txtRepeticiones.MaxLength = 10;
            this.txtRepeticiones.Name = "txtRepeticiones";
            this.txtRepeticiones.ShortcutsEnabled = false;
            this.txtRepeticiones.Size = new System.Drawing.Size(102, 23);
            this.txtRepeticiones.TabIndex = 6;
            this.toolTipABMPlan.SetToolTip(this.txtRepeticiones, "Ingrese numero de series");
            this.txtRepeticiones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeries_KeyPress);
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
            this.cmbDia.Location = new System.Drawing.Point(633, 164);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(150, 33);
            this.cmbDia.TabIndex = 7;
            this.toolTipABMPlan.SetToolTip(this.cmbDia, "Seleccione un Estado ");
            // 
            // lblEjerciciosDelPlan
            // 
            this.lblEjerciciosDelPlan.AutoSize = true;
            this.lblEjerciciosDelPlan.BackColor = System.Drawing.Color.Transparent;
            this.lblEjerciciosDelPlan.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjerciciosDelPlan.ForeColor = System.Drawing.Color.Silver;
            this.lblEjerciciosDelPlan.Location = new System.Drawing.Point(537, 33);
            this.lblEjerciciosDelPlan.Name = "lblEjerciciosDelPlan";
            this.lblEjerciciosDelPlan.Size = new System.Drawing.Size(177, 34);
            this.lblEjerciciosDelPlan.TabIndex = 49;
            this.lblEjerciciosDelPlan.Text = "Ejercicios del Plan:";
            // 
            // dgvEjercicioxPlanABM
            // 
            this.dgvEjercicioxPlanABM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEjercicioxPlanABM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEjercicioxPlanABM.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvEjercicioxPlanABM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEjercicioxPlanABM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEjercicioxPlanABM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEjercicioxPlanABM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEjercicioxPlanABM.ColumnHeadersHeight = 30;
            this.dgvEjercicioxPlanABM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEjercicioxPlanABM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDEjercicioxPlan,
            this.colEjercicio,
            this.colSeries,
            this.colRepeticiones,
            this.colIDEjercicio,
            this.colIDPlan,
            this.colMaquina,
            this.colDia,
            this.colObservaciones});
            this.dgvEjercicioxPlanABM.EnableHeadersVisualStyles = false;
            this.dgvEjercicioxPlanABM.GridColor = System.Drawing.Color.DimGray;
            this.dgvEjercicioxPlanABM.Location = new System.Drawing.Point(543, 210);
            this.dgvEjercicioxPlanABM.Name = "dgvEjercicioxPlanABM";
            this.dgvEjercicioxPlanABM.ReadOnly = true;
            this.dgvEjercicioxPlanABM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEjercicioxPlanABM.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEjercicioxPlanABM.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEjercicioxPlanABM.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEjercicioxPlanABM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEjercicioxPlanABM.Size = new System.Drawing.Size(766, 280);
            this.dgvEjercicioxPlanABM.TabIndex = 12;
            this.dgvEjercicioxPlanABM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEjercicioxPlan_CellClick);
            this.dgvEjercicioxPlanABM.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEjercicioxPlanABM_CellFormatting);
            // 
            // colIDEjercicioxPlan
            // 
            this.colIDEjercicioxPlan.HeaderText = "ID EjxPl";
            this.colIDEjercicioxPlan.Name = "colIDEjercicioxPlan";
            this.colIDEjercicioxPlan.ReadOnly = true;
            this.colIDEjercicioxPlan.Visible = false;
            this.colIDEjercicioxPlan.Width = 97;
            // 
            // colEjercicio
            // 
            this.colEjercicio.HeaderText = "Ejercicio";
            this.colEjercicio.Name = "colEjercicio";
            this.colEjercicio.ReadOnly = true;
            this.colEjercicio.Width = 101;
            // 
            // colSeries
            // 
            this.colSeries.HeaderText = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.ReadOnly = true;
            this.colSeries.Width = 87;
            // 
            // colRepeticiones
            // 
            this.colRepeticiones.HeaderText = "Repeticiones";
            this.colRepeticiones.Name = "colRepeticiones";
            this.colRepeticiones.ReadOnly = true;
            this.colRepeticiones.Width = 133;
            // 
            // colIDEjercicio
            // 
            this.colIDEjercicio.HeaderText = "ID Ejercicio";
            this.colIDEjercicio.Name = "colIDEjercicio";
            this.colIDEjercicio.ReadOnly = true;
            this.colIDEjercicio.Visible = false;
            this.colIDEjercicio.Width = 124;
            // 
            // colIDPlan
            // 
            this.colIDPlan.HeaderText = "ID Plan";
            this.colIDPlan.Name = "colIDPlan";
            this.colIDPlan.ReadOnly = true;
            this.colIDPlan.Visible = false;
            this.colIDPlan.Width = 93;
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
            // lblEjercicio
            // 
            this.lblEjercicio.AutoSize = true;
            this.lblEjercicio.BackColor = System.Drawing.Color.Transparent;
            this.lblEjercicio.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjercicio.ForeColor = System.Drawing.Color.Silver;
            this.lblEjercicio.Location = new System.Drawing.Point(537, 88);
            this.lblEjercicio.Name = "lblEjercicio";
            this.lblEjercicio.Size = new System.Drawing.Size(83, 31);
            this.lblEjercicio.TabIndex = 51;
            this.lblEjercicio.Text = "Ejercicio:";
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.BackColor = System.Drawing.Color.Transparent;
            this.lblSeries.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeries.ForeColor = System.Drawing.Color.Silver;
            this.lblSeries.Location = new System.Drawing.Point(538, 132);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(69, 31);
            this.lblSeries.TabIndex = 53;
            this.lblSeries.Text = "Series:";
            // 
            // lblRepeticiones
            // 
            this.lblRepeticiones.AutoSize = true;
            this.lblRepeticiones.BackColor = System.Drawing.Color.Transparent;
            this.lblRepeticiones.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeticiones.ForeColor = System.Drawing.Color.Silver;
            this.lblRepeticiones.Location = new System.Drawing.Point(737, 126);
            this.lblRepeticiones.Name = "lblRepeticiones";
            this.lblRepeticiones.Size = new System.Drawing.Size(115, 31);
            this.lblRepeticiones.TabIndex = 54;
            this.lblRepeticiones.Text = "Repeticiones:";
            // 
            // btnModificarFila
            // 
            this.btnModificarFila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModificarFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarFila.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarFila.ForeColor = System.Drawing.Color.White;
            this.btnModificarFila.Location = new System.Drawing.Point(1315, 306);
            this.btnModificarFila.Name = "btnModificarFila";
            this.btnModificarFila.Size = new System.Drawing.Size(90, 90);
            this.btnModificarFila.TabIndex = 10;
            this.btnModificarFila.Text = "Modificar";
            this.btnModificarFila.UseVisualStyleBackColor = false;
            this.btnModificarFila.Click += new System.EventHandler(this.btnModificarFila_Click);
            // 
            // btnAgregarFila
            // 
            this.btnAgregarFila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFila.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFila.ForeColor = System.Drawing.Color.White;
            this.btnAgregarFila.Location = new System.Drawing.Point(1315, 210);
            this.btnAgregarFila.Name = "btnAgregarFila";
            this.btnAgregarFila.Size = new System.Drawing.Size(90, 90);
            this.btnAgregarFila.TabIndex = 9;
            this.btnAgregarFila.Text = "Agregar";
            this.btnAgregarFila.UseVisualStyleBackColor = false;
            this.btnAgregarFila.Click += new System.EventHandler(this.btnAgregarFila_Click);
            // 
            // btnBajaFila
            // 
            this.btnBajaFila.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBajaFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaFila.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaFila.ForeColor = System.Drawing.Color.White;
            this.btnBajaFila.Location = new System.Drawing.Point(1315, 400);
            this.btnBajaFila.Name = "btnBajaFila";
            this.btnBajaFila.Size = new System.Drawing.Size(90, 90);
            this.btnBajaFila.TabIndex = 11;
            this.btnBajaFila.Text = "Eliminar";
            this.btnBajaFila.UseVisualStyleBackColor = false;
            this.btnBajaFila.Click += new System.EventHandler(this.btnBajaFila_Click);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblObservaciones.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.Color.Silver;
            this.lblObservaciones.Location = new System.Drawing.Point(961, 83);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(133, 31);
            this.lblObservaciones.TabIndex = 56;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservaciones.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.Silver;
            this.txtObservaciones.Location = new System.Drawing.Point(1100, 84);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(305, 117);
            this.txtObservaciones.TabIndex = 8;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.lblDia.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.Silver;
            this.lblDia.Location = new System.Drawing.Point(538, 167);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(43, 31);
            this.lblDia.TabIndex = 58;
            this.lblDia.Text = "Dia:";
            // 
            // txtEjercicio
            // 
            this.txtEjercicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEjercicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEjercicio.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEjercicio.ForeColor = System.Drawing.Color.Silver;
            this.txtEjercicio.Location = new System.Drawing.Point(633, 90);
            this.txtEjercicio.MaxLength = 10;
            this.txtEjercicio.Name = "txtEjercicio";
            this.txtEjercicio.ReadOnly = true;
            this.txtEjercicio.ShortcutsEnabled = false;
            this.txtEjercicio.Size = new System.Drawing.Size(251, 29);
            this.txtEjercicio.TabIndex = 60;
            // 
            // btnBuscarEjercicio
            // 
            this.btnBuscarEjercicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarEjercicio.BackgroundImage")));
            this.btnBuscarEjercicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarEjercicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEjercicio.Location = new System.Drawing.Point(903, 89);
            this.btnBuscarEjercicio.Name = "btnBuscarEjercicio";
            this.btnBuscarEjercicio.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarEjercicio.TabIndex = 4;
            this.toolTipABMPlan.SetToolTip(this.btnBuscarEjercicio, "Presione para buscar Ejercicio");
            this.btnBuscarEjercicio.UseVisualStyleBackColor = true;
            this.btnBuscarEjercicio.Click += new System.EventHandler(this.btnBuscarEjercicio_Click);
            // 
            // frmABMPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1433, 524);
            this.Controls.Add(this.txtEjercicio);
            this.Controls.Add(this.btnBuscarEjercicio);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnModificarFila);
            this.Controls.Add(this.btnAgregarFila);
            this.Controls.Add(this.btnBajaFila);
            this.Controls.Add(this.txtRepeticiones);
            this.Controls.Add(this.txtSeries);
            this.Controls.Add(this.lblRepeticiones);
            this.Controls.Add(this.lblSeries);
            this.Controls.Add(this.lblEjercicio);
            this.Controls.Add(this.dgvEjercicioxPlanABM);
            this.Controls.Add(this.lblEjerciciosDelPlan);
            this.Controls.Add(this.cmbTipoPlan);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTipoPlan);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MinimumSize = new System.Drawing.Size(517, 400);
            this.Name = "frmABMPlan";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjercicioxPlanABM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTipoPlan;
        private System.Windows.Forms.Label lblDescripcion;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbTipoPlan;
        private System.Windows.Forms.ToolTip toolTipABMPlan;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblEjerciciosDelPlan;
        public System.Windows.Forms.DataGridView dgvEjercicioxPlanABM;
        private System.Windows.Forms.Label lblEjercicio;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.Label lblRepeticiones;
        public System.Windows.Forms.TextBox txtSeries;
        public System.Windows.Forms.TextBox txtRepeticiones;
        public System.Windows.Forms.Button btnModificarFila;
        public System.Windows.Forms.Button btnAgregarFila;
        public System.Windows.Forms.Button btnBajaFila;
        private System.Windows.Forms.Label lblObservaciones;
        public System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDEjercicioxPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEjercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeries;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepeticiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDEjercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservaciones;
        public System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Label lblDia;
        public System.Windows.Forms.TextBox txtEjercicio;
        private System.Windows.Forms.Button btnBuscarEjercicio;
    }
}