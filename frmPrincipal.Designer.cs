
namespace TPI_1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tsbAlumno = new System.Windows.Forms.ToolStripButton();
            this.tstBarraLateral = new System.Windows.Forms.ToolStrip();
            this.tsbProfesores = new System.Windows.Forms.ToolStripButton();
            this.tsbClases = new System.Windows.Forms.ToolStripButton();
            this.tsbPlanes = new System.Windows.Forms.ToolStripButton();
            this.tsbOtros = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbMaquinas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbEjercicios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCiudades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPlanesPersonalizados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAsistencias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbNotificaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pctRestaurar = new System.Windows.Forms.PictureBox();
            this.pctMaximizar = new System.Windows.Forms.PictureBox();
            this.pctMinimizar = new System.Windows.Forms.PictureBox();
            this.pctCerrar = new System.Windows.Forms.PictureBox();
            this.tstBarraLateral.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tsbAlumno
            // 
            this.tsbAlumno.AutoSize = false;
            this.tsbAlumno.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbAlumno.ForeColor = System.Drawing.Color.Silver;
            this.tsbAlumno.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAlumno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlumno.Name = "tsbAlumno";
            this.tsbAlumno.Size = new System.Drawing.Size(105, 70);
            this.tsbAlumno.Text = "Alumnos";
            this.tsbAlumno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAlumno.Click += new System.EventHandler(this.tsbAlumno_Click);
            // 
            // tstBarraLateral
            // 
            this.tstBarraLateral.AutoSize = false;
            this.tstBarraLateral.BackColor = System.Drawing.Color.White;
            this.tstBarraLateral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tstBarraLateral.BackgroundImage")));
            this.tstBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.tstBarraLateral.GripMargin = new System.Windows.Forms.Padding(0);
            this.tstBarraLateral.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tstBarraLateral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAlumno,
            this.tsbProfesores,
            this.tsbClases,
            this.tsbPlanes,
            this.tsbOtros});
            this.tstBarraLateral.Location = new System.Drawing.Point(0, 0);
            this.tstBarraLateral.Margin = new System.Windows.Forms.Padding(4);
            this.tstBarraLateral.Name = "tstBarraLateral";
            this.tstBarraLateral.Padding = new System.Windows.Forms.Padding(0);
            this.tstBarraLateral.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tstBarraLateral.Size = new System.Drawing.Size(110, 700);
            this.tstBarraLateral.TabIndex = 0;
            // 
            // tsbProfesores
            // 
            this.tsbProfesores.AutoSize = false;
            this.tsbProfesores.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbProfesores.ForeColor = System.Drawing.Color.Silver;
            this.tsbProfesores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbProfesores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProfesores.Name = "tsbProfesores";
            this.tsbProfesores.Size = new System.Drawing.Size(105, 70);
            this.tsbProfesores.Text = "Profesores";
            this.tsbProfesores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbProfesores.Click += new System.EventHandler(this.tsbProfesores_Click);
            // 
            // tsbClases
            // 
            this.tsbClases.AutoSize = false;
            this.tsbClases.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbClases.ForeColor = System.Drawing.Color.Silver;
            this.tsbClases.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbClases.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClases.Name = "tsbClases";
            this.tsbClases.Size = new System.Drawing.Size(105, 70);
            this.tsbClases.Text = "Clases";
            this.tsbClases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbClases.Click += new System.EventHandler(this.tsbClases_Click);
            // 
            // tsbPlanes
            // 
            this.tsbPlanes.AutoSize = false;
            this.tsbPlanes.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbPlanes.ForeColor = System.Drawing.Color.Silver;
            this.tsbPlanes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPlanes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlanes.Name = "tsbPlanes";
            this.tsbPlanes.Size = new System.Drawing.Size(105, 70);
            this.tsbPlanes.Text = "Planes";
            this.tsbPlanes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPlanes.Click += new System.EventHandler(this.tsbPlanes_Click);
            // 
            // tsbOtros
            // 
            this.tsbOtros.AutoSize = false;
            this.tsbOtros.BackColor = System.Drawing.Color.Transparent;
            this.tsbOtros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMaquinas,
            this.tsbEjercicios,
            this.tsbCiudades,
            this.tsbPlanesPersonalizados,
            this.tsbAsistencias,
            this.tsbReportes,
            this.tsbNotificaciones});
            this.tsbOtros.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbOtros.ForeColor = System.Drawing.Color.Silver;
            this.tsbOtros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOtros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOtros.Name = "tsbOtros";
            this.tsbOtros.Size = new System.Drawing.Size(105, 70);
            this.tsbOtros.Text = "OTROS";
            this.tsbOtros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbMaquinas
            // 
            this.tsbMaquinas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbMaquinas.BackgroundImage")));
            this.tsbMaquinas.Name = "tsbMaquinas";
            this.tsbMaquinas.Size = new System.Drawing.Size(282, 38);
            this.tsbMaquinas.Text = "Maquinas";
            this.tsbMaquinas.Click += new System.EventHandler(this.tsbMaquinas_Click);
            // 
            // tsbEjercicios
            // 
            this.tsbEjercicios.BackColor = System.Drawing.Color.Transparent;
            this.tsbEjercicios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbEjercicios.BackgroundImage")));
            this.tsbEjercicios.ImageTransparentColor = System.Drawing.Color.Red;
            this.tsbEjercicios.Name = "tsbEjercicios";
            this.tsbEjercicios.Size = new System.Drawing.Size(282, 38);
            this.tsbEjercicios.Text = "Ejercicios";
            this.tsbEjercicios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbEjercicios.Click += new System.EventHandler(this.tsbEjercicios_Click);
            // 
            // tsbCiudades
            // 
            this.tsbCiudades.BackColor = System.Drawing.Color.Gray;
            this.tsbCiudades.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbCiudades.BackgroundImage")));
            this.tsbCiudades.Name = "tsbCiudades";
            this.tsbCiudades.Size = new System.Drawing.Size(282, 38);
            this.tsbCiudades.Text = "Ciudades";
            this.tsbCiudades.Click += new System.EventHandler(this.tsbCiudades_Click);
            // 
            // tsbPlanesPersonalizados
            // 
            this.tsbPlanesPersonalizados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbPlanesPersonalizados.BackgroundImage")));
            this.tsbPlanesPersonalizados.Name = "tsbPlanesPersonalizados";
            this.tsbPlanesPersonalizados.Size = new System.Drawing.Size(282, 38);
            this.tsbPlanesPersonalizados.Text = "Planes Personalizados";
            this.tsbPlanesPersonalizados.Click += new System.EventHandler(this.tsbPlanesPersonalizados_Click);
            // 
            // tsbAsistencias
            // 
            this.tsbAsistencias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbAsistencias.BackgroundImage")));
            this.tsbAsistencias.Name = "tsbAsistencias";
            this.tsbAsistencias.Size = new System.Drawing.Size(282, 38);
            this.tsbAsistencias.Text = "Asistencias";
            this.tsbAsistencias.Click += new System.EventHandler(this.asistenciasToolStripMenuItem_Click);
            // 
            // tsbReportes
            // 
            this.tsbReportes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbReportes.BackgroundImage")));
            this.tsbReportes.Name = "tsbReportes";
            this.tsbReportes.Size = new System.Drawing.Size(282, 38);
            this.tsbReportes.Text = "Reportes";
            this.tsbReportes.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // tsbNotificaciones
            // 
            this.tsbNotificaciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbNotificaciones.BackgroundImage")));
            this.tsbNotificaciones.Name = "tsbNotificaciones";
            this.tsbNotificaciones.Size = new System.Drawing.Size(282, 38);
            this.tsbNotificaciones.Text = "Notificaciones";
            this.tsbNotificaciones.Click += new System.EventHandler(this.tsbNotificaciones_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.AutoScroll = true;
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContenedor.BackgroundImage")));
            this.pnlContenedor.Controls.Add(this.pctLogo);
            this.pnlContenedor.Controls.Add(this.pnlBarraTitulo);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1160, 700);
            this.pnlContenedor.TabIndex = 1;
            // 
            // pctLogo
            // 
            this.pctLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctLogo.BackgroundImage")));
            this.pctLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(506, 236);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(249, 217);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 1;
            this.pctLogo.TabStop = false;
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.Black;
            this.pnlBarraTitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBarraTitulo.BackgroundImage")));
            this.pnlBarraTitulo.Controls.Add(this.pctRestaurar);
            this.pnlBarraTitulo.Controls.Add(this.pctMaximizar);
            this.pnlBarraTitulo.Controls.Add(this.pctMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.pctCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1160, 40);
            this.pnlBarraTitulo.TabIndex = 0;
            this.pnlBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseMove);
            // 
            // pctRestaurar
            // 
            this.pctRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pctRestaurar.Image")));
            this.pctRestaurar.Location = new System.Drawing.Point(1083, 0);
            this.pctRestaurar.Name = "pctRestaurar";
            this.pctRestaurar.Size = new System.Drawing.Size(40, 40);
            this.pctRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRestaurar.TabIndex = 3;
            this.pctRestaurar.TabStop = false;
            this.pctRestaurar.Visible = false;
            this.pctRestaurar.Click += new System.EventHandler(this.pctRestaurar_Click);
            // 
            // pctMaximizar
            // 
            this.pctMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pctMaximizar.Image")));
            this.pctMaximizar.Location = new System.Drawing.Point(1083, 0);
            this.pctMaximizar.Name = "pctMaximizar";
            this.pctMaximizar.Size = new System.Drawing.Size(40, 40);
            this.pctMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMaximizar.TabIndex = 2;
            this.pctMaximizar.TabStop = false;
            this.pctMaximizar.Click += new System.EventHandler(this.pctMaximizar_Click);
            // 
            // pctMinimizar
            // 
            this.pctMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pctMinimizar.Image")));
            this.pctMinimizar.Location = new System.Drawing.Point(1046, 0);
            this.pctMinimizar.Name = "pctMinimizar";
            this.pctMinimizar.Size = new System.Drawing.Size(40, 40);
            this.pctMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMinimizar.TabIndex = 2;
            this.pctMinimizar.TabStop = false;
            this.pctMinimizar.Click += new System.EventHandler(this.pctMinimizar_Click);
            // 
            // pctCerrar
            // 
            this.pctCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pctCerrar.Image")));
            this.pctCerrar.Location = new System.Drawing.Point(1120, 0);
            this.pctCerrar.Name = "pctCerrar";
            this.pctCerrar.Size = new System.Drawing.Size(40, 40);
            this.pctCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCerrar.TabIndex = 1;
            this.pctCerrar.TabStop = false;
            this.pctCerrar.Click += new System.EventHandler(this.pctCerrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1160, 700);
            this.Controls.Add(this.tstBarraLateral);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1160, 500);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tstBarraLateral.ResumeLayout(false);
            this.tstBarraLateral.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbAlumno;
        private System.Windows.Forms.ToolStrip tstBarraLateral;
        private System.Windows.Forms.ToolStripButton tsbProfesores;
        private System.Windows.Forms.ToolStripButton tsbClases;
        private System.Windows.Forms.ToolStripButton tsbPlanes;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.PictureBox pctCerrar;
        private System.Windows.Forms.PictureBox pctMaximizar;
        private System.Windows.Forms.PictureBox pctMinimizar;
        private System.Windows.Forms.PictureBox pctRestaurar;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.ToolStripDropDownButton tsbOtros;
        private System.Windows.Forms.ToolStripMenuItem tsbMaquinas;
        private System.Windows.Forms.ToolStripMenuItem tsbEjercicios;
        private System.Windows.Forms.ToolStripMenuItem tsbCiudades;
        private System.Windows.Forms.ToolStripMenuItem tsbPlanesPersonalizados;
        private System.Windows.Forms.ToolStripMenuItem tsbAsistencias;
        private System.Windows.Forms.ToolStripMenuItem tsbReportes;
        private System.Windows.Forms.ToolStripMenuItem tsbNotificaciones;
    }
}

