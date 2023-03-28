
namespace TPI_1
{
    partial class frmABMTitulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMTitulo));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pctRestaurar = new System.Windows.Forms.PictureBox();
            this.pctMaximizar = new System.Windows.Forms.PictureBox();
            this.pctMinimizar = new System.Windows.Forms.PictureBox();
            this.pctCerrar = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCerrar)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Silver;
            this.lblNombre.Location = new System.Drawing.Point(30, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(163, 34);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de Titulo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Silver;
            this.txtNombre.Location = new System.Drawing.Point(208, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(306, 33);
            this.txtNombre.TabIndex = 8;
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.Black;
            this.pnlBarraTitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBarraTitulo.BackgroundImage")));
            this.pnlBarraTitulo.Controls.Add(this.pctLogo);
            this.pnlBarraTitulo.Controls.Add(this.pctRestaurar);
            this.pnlBarraTitulo.Controls.Add(this.pctMaximizar);
            this.pnlBarraTitulo.Controls.Add(this.pctMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.pctCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(550, 40);
            this.pnlBarraTitulo.TabIndex = 9;
            this.pnlBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseMove);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(0, 0);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(40, 40);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 17;
            this.pctLogo.TabStop = false;
            // 
            // pctRestaurar
            // 
            this.pctRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pctRestaurar.Image")));
            this.pctRestaurar.Location = new System.Drawing.Point(473, 0);
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
            this.pctMaximizar.Location = new System.Drawing.Point(473, 0);
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
            this.pctMinimizar.Location = new System.Drawing.Point(436, 0);
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
            this.pctCerrar.Location = new System.Drawing.Point(510, 0);
            this.pctCerrar.Name = "pctCerrar";
            this.pctCerrar.Size = new System.Drawing.Size(40, 40);
            this.pctCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCerrar.TabIndex = 1;
            this.pctCerrar.TabStop = false;
            this.pctCerrar.Click += new System.EventHandler(this.pctCerrar_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.AutoScroll = true;
            this.pnlContenedor.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.pnlContenedor.AutoScrollMinSize = new System.Drawing.Size(50, 50);
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlContenedor.BackgroundImage")));
            this.pnlContenedor.Controls.Add(this.txtDescripcion);
            this.pnlContenedor.Controls.Add(this.lblDescripcion);
            this.pnlContenedor.Controls.Add(this.txtNombre);
            this.pnlContenedor.Controls.Add(this.lblNombre);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.MinimumSize = new System.Drawing.Size(550, 582);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(550, 582);
            this.pnlContenedor.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.txtDescripcion.Location = new System.Drawing.Point(208, 150);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(306, 33);
            this.txtDescripcion.TabIndex = 10;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.lblDescripcion.Location = new System.Drawing.Point(72, 149);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(121, 34);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // frmABMTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(550, 582);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.pnlContenedor);
            this.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MinimumSize = new System.Drawing.Size(550, 582);
            this.Name = "frmABMTitulo";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCerrar)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.PictureBox pctRestaurar;
        private System.Windows.Forms.PictureBox pctMaximizar;
        private System.Windows.Forms.PictureBox pctMinimizar;
        private System.Windows.Forms.PictureBox pctCerrar;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
    }
}