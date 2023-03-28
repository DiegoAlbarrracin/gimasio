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


    public partial class frmAsistenciaAdministrador : Form
    {
        public frmAsistenciaAdministrador()
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
                Form frmABMAsistenciaAdministrador = new frmABMAsistenciaAdministrador();

                frmABMAsistenciaAdministrador.ShowDialog(); //Agregar el Dialog a todos los ABMnombre

                dtpFecha.Value = Convert.ToDateTime("1/1/1753");
                LlenarDgv(dgvAsisencias, dtpFecha.Value);
                dtpFecha.Value = DateTime.Now;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        private void frmAsistencias_Load(object sender, EventArgs e) //NUEVO
        {
            //cmbEstado.DataSource = Enum.GetValues(typeof(enmEstado));
            //cmbEstado.SelectedIndex = (int)enmEstado.Activo;

            //MessageBox.Show(cmbEstado.SelectedIndex.ToString());
            dtpFecha.Value = Convert.ToDateTime("1/1/1753");
            LlenarDgv(dgvAsisencias, dtpFecha.Value);
            dtpFecha.Value = DateTime.Now;
        }
        

        void LlenarDgv(DataGridView dgvAsistencias, DateTime dato)
        {
            try
            {              
                this.dgvAsisencias.Rows.Clear();                      
                clsAsistencias oAsistencias = new clsAsistencias();
                List<Asistencia> lista;
                if (!dato.Equals("1/1/1753"))
                {
                     lista = oAsistencias.Listar(dtpFecha.Value);
                }
                else
                {
                     lista = oAsistencias.Listar(dato);
                }
               

                foreach (Asistencia i in lista)
                {
                        this.dgvAsisencias.Rows.Add(i.idAsistencia.ToString(), i.Alumno.nombre + " " + i.Alumno.apellido, i.fecha.ToString());                        
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
                if (dgvAsisencias.SelectedRows.Count > 0 && dgvAsisencias.CurrentRow.Cells[0].Value != null)
                {
                    

                    int id = Convert.ToInt32(dgvAsisencias.CurrentRow.Cells[0].Value.ToString());
                    Form frmABMAsistenciaAdministrador = new frmABMAsistenciaAdministrador(id);
                    frmABMAsistenciaAdministrador.ShowDialog(); 

                    dtpFecha.Value = Convert.ToDateTime("1/1/1753");
                    LlenarDgv(dgvAsisencias, dtpFecha.Value);
                    dtpFecha.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una fila");


                }
            }
            catch (NullReferenceException) 
            {
                MessageBox.Show("Seleccione un Alumno");
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
            
                LlenarDgv(dgvAsisencias, dtpFecha.Value);
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
                if (dgvAsisencias.SelectedRows.Count > 0 && dgvAsisencias.CurrentRow.Cells[0].Value != null) 
                {
                    int id = Convert.ToInt32(dgvAsisencias.CurrentRow.Cells[0].Value.ToString());
                    clsAsistencias oAsistencias = new clsAsistencias();
                    oAsistencias.Delete(id);

                    dtpFecha.Value = Convert.ToDateTime("1/1/1753");
                    LlenarDgv(dgvAsisencias, dtpFecha.Value);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        private void dgvAlumnos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dgvAsisencias.Columns[e.ColumnIndex].Name == "colEstado")  //NUEVO TODO EL IF
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

                if (this.dgvAsisencias.Columns[e.ColumnIndex].Name == "colEstado")
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

        private void dtpFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpFecha.CustomFormat = " ";

            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = "dd/MM/yyyy";
        }

        private void btnTraerTodas_Click(object sender, EventArgs e)
        {
            try
            {
                dtpFecha.Value = Convert.ToDateTime("1/1/1753");
                LlenarDgv(dgvAsisencias, dtpFecha.Value);
                dtpFecha.Value = DateTime.Now;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
           
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                int idAlumno = 0;
                clsAlumnos oAlumnos = new clsAlumnos();
                Alumno oA = oAlumnos.ObtenerPorDNI(txtDNI.Text.Trim());
                if (oA != null)
                {
                    idAlumno = oA.idAlumno;
                }
                else
                {
                    MessageBox.Show("Alumno no existente. Ingrese otro DNI", "Asistencias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LlenarDgvXAlumno(dgvAsisencias, idAlumno);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        void LlenarDgvXAlumno(DataGridView dgvAsistencias, int idAlumno)
        {
            try
            {
                this.dgvAsisencias.Rows.Clear();
                clsAsistencias oAsistencias = new clsAsistencias();
                List<Asistencia> lista;
                if (idAlumno != 0)
                {
                    lista = oAsistencias.ListarporDNI(idAlumno);
                }
                else
                {
                    lista = oAsistencias.Listar();
                }


                foreach (Asistencia i in lista)
                {
                    this.dgvAsisencias.Rows.Add(i.idAsistencia.ToString(), i.Alumno.nombre + " " + i.Alumno.apellido, i.fecha.ToString());
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

                frmVisor frmVisor = new frmVisor(7, 0);
                frmVisor.Show();
                frmVisor.StartPosition = FormStartPosition.CenterScreen;
                frmVisor.FormBorderStyle = FormBorderStyle.Sizable;
                frmVisor.MinimumSize = new Size(1180, 500);



                frmVisor.nudFechaDesde.Visible = true;
                frmVisor.nudFechaHasta.Visible = true;
                frmVisor.lblClase.Visible = true;
                frmVisor.lblProfesor.Visible = true;
                frmVisor.btnBorrarAlumno.Visible = true;

                frmVisor.lblClase.Text = "Año Desde:";
                frmVisor.lblProfesor.Text = "Año Hasta:";

                frmVisor.cmbClase.Visible = false;
                frmVisor.cmbProfesor.Visible = false;
                frmVisor.lblFiltro.Visible = false;
                frmVisor.cmbEstado.Visible = false;
                frmVisor.txtDNI.Visible = false;

                frmVisor.lblFormato.Visible = false;
                frmVisor.cmbFormato.Visible = false;

                frmVisor.chkTodos.Visible = false;
                frmVisor.lblIncluirA.Visible = false;
                frmVisor.lblIncluirC.Visible = false;

                frmVisor.lblAlumno.Visible = true;
                frmVisor.txtNombreAlumno.Visible = true;
                frmVisor.btnBorrarAlumno.Visible = true;
                frmVisor.btnBuscarAlumno.Visible = true;

                frmVisor.nudFechaDesde.Value = 2000;
                frmVisor.nudFechaHasta.Value = 2022;
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
