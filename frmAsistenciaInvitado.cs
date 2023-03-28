using Negocio;
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
using Datos; 

namespace TPI_1
{
    public partial class frmAsistenciaInvitado : Form
    {
       
        public frmAsistenciaInvitado()
        {
            InitializeComponent();            
                        
        }
      

                       
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!txtDNI.Text.Equals(""))
                {
                    clsAlumnos oAlumnos = new clsAlumnos();
                    Alumno oAl = new Alumno();
                    oAl = oAlumnos.ObtenerPorDNI(txtDNI.Text);

                    if (oAl != null)
                    {
                        clsAsistencias oAsc = new clsAsistencias();
                        Asistencia oAs = new Asistencia();
                        oAs.idAlumno = oAl.idAlumno;
                        oAs.fecha = DateTime.Now;
                        oAsc.Guardar(oAs);
                        lblDNI.Text = "Ingrese su DNI";
                        MessageBox.Show("Alumno: " + oAl.nombre + " " + oAl.apellido + ". Se ha registrado su ASISTENCIA");
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado el Alumno");
                    }
                   
                }
                else
                {
                    lblDNI.Text = "*Ingrese su DNI";
                    MessageBox.Show("RELLENE LOS CAMPOS OBLIGATORIOS(*)");
                }
                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        private void frmAsistenciaInvitado_Load(object sender, EventArgs e)
        {
           
        }
    }
}
