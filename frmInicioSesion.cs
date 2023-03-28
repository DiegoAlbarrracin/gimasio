using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices; //para poder mover mi barra personalizada
using Negocio;
using Datos;

namespace TPI_1
{
    public partial class frmInicioSesion : Form
    {

        public frmInicioSesion()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]  // Codigo necesario para mover mi barra personalizada
        private extern static void ReleaseCapture();              // 
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]     //
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);//


        

      

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                //clsUsuarios oUsuarios = new clsUsuarios();
                //Usuario oUsuario = oUsuarios.Obtener(txtUsuario.Text.Trim(), txtContraseña.Text.Trim());

                //if (oUsuario== null)
                //{
                //    MessageBox.Show("Usuario o contraseña incorrectas", "Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                this.Hide();
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.FormClosed += (s, args) => this.Close();
                frmPrincipal.Show();
                
                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }


        }


        //private void EscribirLogExcel(string stUsuario, DateTime dtFechaIngreso, string stEstadoSesion) 
        //{

        //    try
        //    {
        //        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Application.StartupPath + @"\Usuarios_Log.xlsx;Extended Properties = Excel 12.0 Xml");
        //        string stInsert = string.Format("INSERT INTO [Log$] ([FechayHora],Usuario,Estado) VALUES ('{0}','{1}','{2}')",
        //            dtFechaIngreso.ToString(),
        //            stUsuario.ToString(),
        //            stEstadoSesion.ToString());

        //        OleDbCommand insertCommand = new OleDbCommand(stInsert, conn);
        //        try
        //        {
        //            insertCommand.Parameters.Add("FechayHora", OleDbType.Char).Value = dtFechaIngreso.ToString();
        //            insertCommand.Parameters.Add("Usuario", OleDbType.Char).Value = stUsuario.ToString();
        //            insertCommand.Parameters.Add("Estado", OleDbType.Char).Value = stEstadoSesion.ToString();
        //            conn.Open();
        //            insertCommand.ExecuteNonQuery();
        //        }
        //        catch (OleDbException ex)
        //        {
        //            conn.Close();
        //            throw ex;
        //        }
        //    }
        //    catch (Exception msj)
        //    {

        //        throw msj;
        //    }
            
        //}




        private void pnlBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();                             //    Mover barra personalizada
            SendMessage(this.Handle, 0x112, 0xf012, 0);   //
        }

       

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            } 
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Gray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void pctCerrar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void pctMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void pctVer_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar == true)
            {
                pctNoVer.BringToFront();
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void pctNoVer_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar == false) 
            {
                pctVer.BringToFront();
                txtContraseña.UseSystemPasswordChar = true;
            }

        }

        private void btnSoyAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmAsistenciaInvitado = new frmAsistenciaInvitado();
                frmAsistenciaInvitado.Show();                

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
