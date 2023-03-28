
namespace TPI_1
{
    partial class frmCiudades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCiudades));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tstBarraLateralAlumno = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.dgvCiudades = new System.Windows.Forms.DataGridView();
            this.colIDCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlNombrePantalla = new System.Windows.Forms.Panel();
            this.lblNombrePantalla = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tstBarraLateralAlumno.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).BeginInit();
            this.pnlNombrePantalla.SuspendLayout();
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
            this.pnlContenedor.Controls.Add(this.btnBuscar);
            this.pnlContenedor.Controls.Add(this.txtBuscador);
            this.pnlContenedor.Controls.Add(this.lblNombre);
            this.pnlContenedor.Controls.Add(this.dgvCiudades);
            this.pnlContenedor.Controls.Add(this.pnlNombrePantalla);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1228, 554);
            this.pnlContenedor.TabIndex = 2;
            // 
            // dgvCiudades
            // 
            this.dgvCiudades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCiudades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCiudades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCiudades.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvCiudades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCiudades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCiudades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCiudades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCiudades.ColumnHeadersHeight = 30;
            this.dgvCiudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCiudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDCiudad,
            this.colNombre,
            this.colProvincia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCiudades.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCiudades.EnableHeadersVisualStyles = false;
            this.dgvCiudades.GridColor = System.Drawing.Color.DimGray;
            this.dgvCiudades.Location = new System.Drawing.Point(132, 109);
            this.dgvCiudades.Name = "dgvCiudades";
            this.dgvCiudades.ReadOnly = true;
            this.dgvCiudades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCiudades.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCiudades.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCiudades.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCiudades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCiudades.Size = new System.Drawing.Size(954, 208);
            this.dgvCiudades.TabIndex = 3;
            this.dgvCiudades.DoubleClick += new System.EventHandler(this.dgvCiudades_DoubleClick);
            // 
            // colIDCiudad
            // 
            this.colIDCiudad.HeaderText = "ID Ciudad";
            this.colIDCiudad.Name = "colIDCiudad";
            this.colIDCiudad.ReadOnly = true;
            this.colIDCiudad.Width = 87;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 79;
            // 
            // colProvincia
            // 
            this.colProvincia.HeaderText = "Provincia";
            this.colProvincia.Name = "colProvincia";
            this.colProvincia.ReadOnly = true;
            this.colProvincia.Width = 88;
            // 
            // pnlNombrePantalla
            // 
            this.pnlNombrePantalla.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlNombrePantalla.BackColor = System.Drawing.Color.DimGray;
            this.pnlNombrePantalla.Controls.Add(this.lblNombrePantalla);
            this.pnlNombrePantalla.Location = new System.Drawing.Point(500, 0);
            this.pnlNombrePantalla.Name = "pnlNombrePantalla";
            this.pnlNombrePantalla.Size = new System.Drawing.Size(287, 35);
            this.pnlNombrePantalla.TabIndex = 2;
            // 
            // lblNombrePantalla
            // 
            this.lblNombrePantalla.AutoSize = true;
            this.lblNombrePantalla.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePantalla.Location = new System.Drawing.Point(94, -4);
            this.lblNombrePantalla.Name = "lblNombrePantalla";
            this.lblNombrePantalla.Size = new System.Drawing.Size(110, 39);
            this.lblNombrePantalla.TabIndex = 0;
            this.lblNombrePantalla.Text = "Ciudades";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(603, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 33);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscador
            // 
            this.txtBuscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscador.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscador.Location = new System.Drawing.Point(310, 55);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(287, 33);
            this.txtBuscador.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Silver;
            this.lblNombre.Location = new System.Drawing.Point(131, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(158, 31);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre de Ciudad:";
            // 
            // frmCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1228, 554);
            this.Controls.Add(this.tstBarraLateralAlumno);
            this.Controls.Add(this.pnlContenedor);
            this.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCiudades";
            this.Load += new System.EventHandler(this.frmCiudades_Load);
            this.tstBarraLateralAlumno.ResumeLayout(false);
            this.tstBarraLateralAlumno.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiudades)).EndInit();
            this.pnlNombrePantalla.ResumeLayout(false);
            this.pnlNombrePantalla.PerformLayout();
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
        public System.Windows.Forms.DataGridView dgvCiudades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvincia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Label lblNombre;
    }
}