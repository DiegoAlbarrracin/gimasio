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
using Negocio;



namespace TPI_1
{
    //public enum enmEstado {Activo, Inactivo }; //NUEVO


    public partial class frmPlanesPersonalizados : Form
    {
        public frmPlanesPersonalizados()
        {
            InitializeComponent();
        }


        

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmAMBPlanesPersonalizados = new frmABMPlanesPersonalizados(); 

                frmAMBPlanesPersonalizados.ShowDialog(); 

                LlenarDgv(dgvPlanxAlumno,""); //borrar comillas
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        private void frmClases_Load(object sender, EventArgs e) //NUEVO
        {
            
            //MessageBox.Show(cmbEstado.SelectedIndex.ToString());

            LlenarDgv(dgvPlanxAlumno,"");
            
           
        }
        

        void LlenarDgv(DataGridView dgvPlanxAlumno,string dato) 
        {
            try
            {              
                    this.dgvPlanxAlumno.Rows.Clear();
                    clsPlanxAlumno oPlanesxAlumnos = new clsPlanxAlumno();
                    List<PlanxAlumno> lista = oPlanesxAlumnos.Listar(txtBuscador.Text.Trim()); //REVISAR
                    foreach (PlanxAlumno i in lista)
                    {
                        this.dgvPlanxAlumno.Rows.Add(i.idPlanxAlumno.ToString(), i.Alumno.nombre + " " + i.Alumno.apellido,i.Planes.nombre,i.Profesor.nombre+" "+i.Profesor.apellido,i.idPlan.ToString(),i.idAlumno.ToString(),i.idProfesor.ToString(), i.fechaDesde.ToString(), (i.fechaHasta == null) ? string.Empty : i.fechaHasta.ToString());
                                          
                    }               
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
            
        }
        
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPlanxAlumno.SelectedRows.Count > 0 && dgvPlanxAlumno.CurrentRow.Cells[0].Value != null)
                {
                    

                    int id = Convert.ToInt32(dgvPlanxAlumno.CurrentRow.Cells[0].Value.ToString());
                    //MessageBox.Show(id.ToString());

                    frmABMPlanesPersonalizados frmABMPlanesPersonalizados = new frmABMPlanesPersonalizados(id);

                    frmABMPlanesPersonalizados.ShowDialog(); 

                    LlenarDgv(dgvPlanxAlumno,""); //borrar comillas

                    LlenarDGVEjercicioPlanAlumno(dgvEjercicioPlanAlumno);
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una fila");


                }
            }
            catch (NullReferenceException) 
            {
                MessageBox.Show("Seleccione una Clase");
                return;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                LlenarDgv(dgvPlanxAlumno, txtBuscador.Text.Trim());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        
        private void tsbBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPlanxAlumno.SelectedRows.Count > 0 && dgvPlanxAlumno.CurrentRow.Cells[0].Value != null) 
                {
                    int id = Convert.ToInt32(dgvPlanxAlumno.CurrentRow.Cells[0].Value.ToString());
                    
                    clsPlanxAlumno oPxA = new clsPlanxAlumno();
                    oPxA.Delete(id);
                    LlenarDgv(dgvPlanxAlumno, "");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        private void dgvPlanxAlumno_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dgvPlanxAlumno.Columns[e.ColumnIndex].Name == "colEstado")  //NUEVO TODO EL IF
                {
                    if (Convert.ToString(e.Value).Equals("0"))
                    {
                        e.Value = "Activo";
                    }
                    else if (Convert.ToString(e.Value).Equals("1"))
                    {
                        e.Value = "Inactivo";
                    }
                }

                if (this.dgvPlanxAlumno.Columns[e.ColumnIndex].Name == "colEstado")
                {
                    if (Convert.ToString(e.Value).Equals("Activo"))
                    {
                        e.CellStyle.BackColor = Color.Green;
                    }
                    else if (Convert.ToString(e.Value).Equals("Inactivo"))
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }

                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        private void dgvPlanxAlumno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPlanxAlumno.SelectedRows.Count > 0 && dgvPlanxAlumno.CurrentRow.Cells[0].Value != null)
            {
                LlenarDGVEjercicioPlanAlumno(dgvEjercicioPlanAlumno);
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila");

            }
        }
        public void LlenarDGVEjercicioPlanAlumno(DataGridView dgv)
        {
            int id = Convert.ToInt32(dgvPlanxAlumno.CurrentRow.Cells[0].Value.ToString());
            this.dgvEjercicioPlanAlumno.Rows.Clear();
            clsEjercicioPlanAlumno oEjercicioPlanAlumno = new clsEjercicioPlanAlumno();
            EjercicioPlanAlumno oEPA = new EjercicioPlanAlumno();
            List<EjercicioPlanAlumno> lista = oEjercicioPlanAlumno.Listar(id);

            clsMaquinas oM = new clsMaquinas();
            clsEjercicios oE = new clsEjercicios();
            foreach (EjercicioPlanAlumno item in lista)
            {
                this.dgvEjercicioPlanAlumno.Rows.Add(item.idEjercicioPlanAlumno.ToString(), item.idEjercicio.ToString(), item.Ejercicio.nombre, item.idPlanxAlumno.ToString(), item.series.ToString(), item.repeticiones.ToString(), (item.Ejercicio.idMaquina == null) ? string.Empty : oM.Obtener((int)oE.Obtener(item.idEjercicio).idMaquina).nombre, item.dia, item.observaciones);
            }

        }





        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1º) Seleccione el Plan Personalizado haciendo click izquierdo sobre el y luego presione el boton Modificar.\n (En caso de que el plan no exista, cree un nuevo Plan Personalizado pulsando en Agregar).\n" +
                "2ª) Se abrira una pantalla donde podra Agregar, Modificar o Borrar los Ejercicios del Plan Personalizado seleccionado. \n" +
                "3ª) Ademas en dicha pantalla podra modificar los datos del propio Plan de Alumno (nombre del alumno, plan base, profesor, fecha desde y fecha hasta).", "¿Como agregar y/o modificar los ejercicios del Plan Personalizado?", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void dgvProfesorxClase_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dgvEjercicioPlanAlumno.Columns[e.ColumnIndex].Name == "colDia")
                {
                    if (Convert.ToString(e.Value).Equals("1"))
                    {
                        e.CellStyle.BackColor = Color.SlateGray;
                    }
                    else if (Convert.ToString(e.Value).Equals("2"))
                    {
                        e.CellStyle.BackColor = Color.Gray;
                    }
                    else if (Convert.ToString(e.Value).Equals("3"))
                    {
                        e.CellStyle.BackColor = Color.SlateGray;
                    }
                    else if (Convert.ToString(e.Value).Equals("4"))
                    {
                        e.CellStyle.BackColor = Color.Gray;
                    }
                    else if (Convert.ToString(e.Value).Equals("5"))
                    {
                        e.CellStyle.BackColor = Color.SlateGray;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPlanxAlumno.CurrentRow.Cells[0].Value == null)
                {
                    MessageBox.Show("Seleccione un Alumno", "Planes Personalizados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idPxA = Convert.ToInt32(this.dgvPlanxAlumno.CurrentRow.Cells[0].Value);
                clsPlanxAlumno oPlanxAlumno = new clsPlanxAlumno();
                PlanxAlumno oPxA = oPlanxAlumno.Obtener(idPxA);

                frmVisor frmVisor = new frmVisor(5, Convert.ToInt32(oPxA.Alumno.dni));
                frmVisor.Show();
                frmVisor.StartPosition = FormStartPosition.CenterScreen;
                frmVisor.FormBorderStyle = FormBorderStyle.Sizable;
                frmVisor.MinimumSize = new Size(1180, 500);

                frmVisor.lblFiltro.Location = new Point(530, 10);
                frmVisor.lblFiltro.Visible = true;
                frmVisor.txtDNI.Visible = true;
                frmVisor.lblFiltro.Text = "Ingrese DNI:";
                frmVisor.cmbEstado.Visible = false;

                frmVisor.btnGenerarReporte.PerformClick();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }
    }
}
