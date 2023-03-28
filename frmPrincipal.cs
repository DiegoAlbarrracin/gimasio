using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace TPI_1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }




        #region codigo funcionalidades formulario

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.pnlContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(0, 0, 0));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void pctCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Capturar posicion y tamaño antes de maximizar para restarurar
        int lx, ly;
        int sw, sh;


        private void pctMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            pctMaximizar.Visible = false;
            pctRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void pctRestaurar_Click(object sender, EventArgs e)
        {
            pctMaximizar.Visible = true;
            pctRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);

        }

        private void pnlBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pctMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Metodo para arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();



        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #endregion



        private void tsbProfesores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmProfesores>();
        }

        private void tsbMaquinas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmMaquinas>();
        }

        private void tsbClases_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmClases>();
        }

        private void tsbPlanes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmPlanes>();
        }

        private void tsbEjercicios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmEjercicios>();
        }

        private void tsbCiudades_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCiudades>();
        }

        private void tsbTitulos_Click(object sender, EventArgs e)
        {
           
        }

        private void tsbPlanesPersonalizados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmPlanesPersonalizados>();
        }

        private void asistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAsistenciaAdministrador>();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmVisor>();
        }

        private void tsbNotificaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmNotificaciones>();
        }

        private void tsbAlumno_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAlumnos>();
        }

        //Metodo para abrir forms dentro del panel

        private void AbrirFormulario<MiForm>() where MiForm : Form, new() 
        {
            try
            {
                Form formulario;
                formulario = pnlContenedor.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la coleccion el formulario
                                                                                      //si el form no existe
                if (formulario == null)
                {
                    formulario = new MiForm();
                    formulario.TopLevel = false;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.Dock = DockStyle.Fill;
                    pnlContenedor.Controls.Add(formulario);
                    pnlContenedor.Tag = formulario;
                    formulario.Show();
                    formulario.BringToFront();

                }
                else
                {
                    formulario.BringToFront();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
            
        }
    }
}
