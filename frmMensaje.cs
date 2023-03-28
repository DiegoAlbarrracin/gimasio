using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_1
{
    public partial class frmMensaje : Form
    {
        int idAxC = 0;
        int idPxC = 0;
        string GrupoAlumno ;
        string nroTelefonoAl;
        public frmMensaje()
        {
            InitializeComponent();
        }

        public frmMensaje(int idPrxCl, int idAlxCl ,  string grupoAlumno, string nombreDia)
        {
            try
            {
                InitializeComponent();
                GrupoAlumno = grupoAlumno;
                idPxC = idPrxCl;
                clsProfesorxClases oProfesorxClases = new clsProfesorxClases();
                ProfesorxClase oPxC = new ProfesorxClase();
                oPxC = oProfesorxClases.Obtener(idPxC); 


                if (grupoAlumno.Equals("Grupo"))
                {
                    
                    lblNombreDestinatario.Text = "Grupo de " + oPxC.Clase.nombre; 
                    lblNombreClase.Text = oPxC.Clase.nombre;
                    lblNombreDia.Text = nombreDia;
                    lblHora.Text = oPxC.horaInicio+" hs";
                    lblNombreProfesor.Text = oPxC.Profesor.nombre + " " + oPxC.Profesor.apellido;

                    //Mensaje a Grupo
                    txtMensaje.Text = "Hola grupo de " + lblNombreClase.Text + "! Recuerden que los dias "+ lblNombreDia.Text + " tienen clases de " + lblNombreClase.Text + ", con el profesor " + lblNombreProfesor.Text + " a las " + lblHora.Text + ". Los esperamos! \n-TechGYM";



                }
                else if (grupoAlumno.Equals("Alumno"))
                {
                    idAxC = idAlxCl;
                    clsAlumnoxClases oAlumnoxClases = new clsAlumnoxClases();
                    AlumnoxClase oAxC = new AlumnoxClase();
                    oAxC = oAlumnoxClases.Obtener(idAxC);                

                    lblNombreDestinatario.Text = oAxC.Alumno.nombre + " " + oAxC.Alumno.apellido;
                    lblNombreClase.Text = oPxC.Clase.nombre;
                    lblNombreDia.Text = nombreDia;
                    lblHora.Text = oPxC.horaInicio+" hs";
                    lblNombreProfesor.Text = oPxC.Profesor.nombre + " " + oPxC.Profesor.apellido;
                    nroTelefonoAl = oAxC.Alumno.telefono;

                    //Mensaje a Alumno
                    txtMensaje.Text = "Hola " + lblNombreDestinatario.Text + "! Te recordamos que los dias " + lblNombreDia.Text + " tenes clases de " + lblNombreClase.Text + ", con el profesor " + lblNombreProfesor.Text + " a las " + lblHora.Text + ". Te esperamos! \n-TechGYM";
                }             

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }




        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                string link = "";
                
                if (!txtMensaje.Text.Trim().Equals(""))
                {
                    if (GrupoAlumno.Equals("Grupo"))
                    {
                        string restoLink = txtMensaje.Text.Replace(" ", "%20");

                        link = "https://api.whatsapp.com/send/?phone&text=" + restoLink;
                    }
                    else if (GrupoAlumno.Equals("Alumno"))
                    {
                        string restoLink = txtMensaje.Text.Replace(" ", "%20");

                        link = "https://wa.me/549"+nroTelefonoAl+"/?text="+ restoLink;
                    }
                    System.Diagnostics.Process.Start(link);
                    //MessageBox.Show(link.ToString());
                }
                else
                {
                    MessageBox.Show("Ingrese un mensaje.", "Notificaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
