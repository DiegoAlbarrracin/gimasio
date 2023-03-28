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
    public partial class frmABMAsistenciaAdministrador : Form
    {
        int idAs = 0;
        bool boAccionModificar = false;
        public frmABMAsistenciaAdministrador()
        {
            InitializeComponent();
            lblAlumno.Visible = false;
            lblNombreAlumno.Visible = false;
            lblFechaAsistencia.Visible = false;
            dtpFechaAsistencia.Visible = false;
            dtpFechaAsistencia.Value = DateTime.Now;
        }

       
        public frmABMAsistenciaAdministrador(int idAsistencia) 
        {
            try
            {
                InitializeComponent();
                idAs = idAsistencia;
                clsAsistencias oAsistencias = new clsAsistencias();
                Asistencia oA = new Asistencia();
                oA = oAsistencias.Obtener(idAs);

                clsAlumnos oAlumnos = new clsAlumnos();
                Alumno oAl = new Alumno();
                oAl = oAlumnos.Obtener(Convert.ToInt32(oA.idAlumno));

                if (idAs != 0)
                {
                    boAccionModificar = true;
                   
                    lblNombreAlumno.Text = oAl.nombre + " " + oAl.apellido;                   
                    txtDNI.Text = oAl.dni.ToString();
                    dtpFechaAsistencia.Text = oA.fecha.ToString();        
                    
                }                               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }




        public void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                clsAsistencias oAsistencias = new clsAsistencias();
                Asistencia oA = new Asistencia();

                clsAlumnos oAlumnos = new clsAlumnos();
                Alumno oAl = new Alumno();
                oAl = oAlumnos.ObtenerPorDNI(txtDNI.Text);

                if (boAccionModificar == true)
                {
                    oA = oAsistencias.Obtener(idAs);
                    //oAl = oAlumnos.Obtener(Convert.ToInt32(oA.idAlumno));
                    oA.fecha = dtpFechaAsistencia.Value;
                }
                else
                {
                    oA.fecha = DateTime.Now;
                }

               
                
               

                
                if( txtDNI.Text.Trim().Equals(""))
                {
                   
                    lblDNI.Text = "*DNI:";
                    lblFechaAsistencia.Text = "*Fecha Asistencia:";
                  
                    MessageBox.Show("RELLENE LOS CAMPOS OBLIGATORIOS(*)");
                    return;
                }


                int Dev=-1;
                if (oAl != null)
                {
                    oA.idAlumno = oAl.idAlumno;
                    Dev = oAsistencias.Guardar(oA);
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el Alumno");
                }

               

                    if (Dev > 0)
                    {
                        MessageBox.Show("Alumno: " + oAl.nombre + " " + oAl.apellido + ". Se ha registrado su ASISTENCIA");
                        this.Close();
                    }
                    else if (Dev == 0)
                    {
                        MessageBox.Show("Asistencia ACTUALIZADA");
                        this.Close();
                    }
                     
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese SOLO NÚMEROS en DNI");
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }            

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

       
    }
}
