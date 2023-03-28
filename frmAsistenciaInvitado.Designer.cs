
namespace TPI_1
{
    partial class frmAsistenciaInvitado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsistenciaInvitado));
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.toolTipAsistenciaInvitado = new System.Windows.Forms.ToolTip(this.components);
            this.tstBarraLateralAsistenciaInvitado = new System.Windows.Forms.ToolStrip();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.pnlNombrePantalla = new System.Windows.Forms.Panel();
            this.lblNombrePantalla = new System.Windows.Forms.Label();
            this.tstBarraLateralAsistenciaInvitado.SuspendLayout();
            this.pnlNombrePantalla.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblDNI.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.Silver;
            this.lblDNI.Location = new System.Drawing.Point(59, 125);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(145, 34);
            this.lblDNI.TabIndex = 29;
            this.lblDNI.Text = "Ingrese su DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNI.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.Color.Silver;
            this.txtDNI.Location = new System.Drawing.Point(249, 130);
            this.txtDNI.MaxLength = 10;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ShortcutsEnabled = false;
            this.txtDNI.Size = new System.Drawing.Size(251, 29);
            this.txtDNI.TabIndex = 2;
            this.toolTipAsistenciaInvitado.SetToolTip(this.txtDNI, "Ingrese DNI (sin puntos)");
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // tstBarraLateralAsistenciaInvitado
            // 
            this.tstBarraLateralAsistenciaInvitado.AutoSize = false;
            this.tstBarraLateralAsistenciaInvitado.BackColor = System.Drawing.Color.White;
            this.tstBarraLateralAsistenciaInvitado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tstBarraLateralAsistenciaInvitado.BackgroundImage")));
            this.tstBarraLateralAsistenciaInvitado.Dock = System.Windows.Forms.DockStyle.Right;
            this.tstBarraLateralAsistenciaInvitado.GripMargin = new System.Windows.Forms.Padding(0);
            this.tstBarraLateralAsistenciaInvitado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tstBarraLateralAsistenciaInvitado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAgregar,
            this.tsbCerrar});
            this.tstBarraLateralAsistenciaInvitado.Location = new System.Drawing.Point(585, 0);
            this.tstBarraLateralAsistenciaInvitado.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.tstBarraLateralAsistenciaInvitado.Name = "tstBarraLateralAsistenciaInvitado";
            this.tstBarraLateralAsistenciaInvitado.Padding = new System.Windows.Forms.Padding(0);
            this.tstBarraLateralAsistenciaInvitado.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tstBarraLateralAsistenciaInvitado.Size = new System.Drawing.Size(114, 361);
            this.tstBarraLateralAsistenciaInvitado.TabIndex = 30;
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
            // pnlNombrePantalla
            // 
            this.pnlNombrePantalla.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlNombrePantalla.BackColor = System.Drawing.Color.DimGray;
            this.pnlNombrePantalla.Controls.Add(this.lblNombrePantalla);
            this.pnlNombrePantalla.Location = new System.Drawing.Point(150, 0);
            this.pnlNombrePantalla.Name = "pnlNombrePantalla";
            this.pnlNombrePantalla.Size = new System.Drawing.Size(287, 35);
            this.pnlNombrePantalla.TabIndex = 31;
            // 
            // lblNombrePantalla
            // 
            this.lblNombrePantalla.AutoSize = true;
            this.lblNombrePantalla.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePantalla.Location = new System.Drawing.Point(92, -4);
            this.lblNombrePantalla.Name = "lblNombrePantalla";
            this.lblNombrePantalla.Size = new System.Drawing.Size(122, 39);
            this.lblNombrePantalla.TabIndex = 0;
            this.lblNombrePantalla.Text = "Asistencia";
            // 
            // frmAsistenciaInvitado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 361);
            this.Controls.Add(this.pnlNombrePantalla);
            this.Controls.Add(this.tstBarraLateralAsistenciaInvitado);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtDNI);
            this.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MinimumSize = new System.Drawing.Size(517, 400);
            this.Name = "frmAsistenciaInvitado";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencias";
            this.Load += new System.EventHandler(this.frmAsistenciaInvitado_Load);
            this.tstBarraLateralAsistenciaInvitado.ResumeLayout(false);
            this.tstBarraLateralAsistenciaInvitado.PerformLayout();
            this.pnlNombrePantalla.ResumeLayout(false);
            this.pnlNombrePantalla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDNI;
        public System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.ToolTip toolTipAsistenciaInvitado;
        private System.Windows.Forms.ToolStrip tstBarraLateralAsistenciaInvitado;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.Panel pnlNombrePantalla;
        private System.Windows.Forms.Label lblNombrePantalla;
    }
}