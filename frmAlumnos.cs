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
    public enum enmEstado {Activo, Inactivo }; //NUEVO


    public partial class frmAlumnos : Form
    {
        string frmPadre;

        public frmAlumnos()
        {
            InitializeComponent();
        }

        public frmAlumnos(string frmP)
        {
            InitializeComponent();
            frmPadre = frmP;
        }


        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Form frmABMAlumno = new frmABMAlumno();

                frmABMAlumno.ShowDialog(); //Agregar el Dialog a todos los ABMnombre

                LlenarDgv(dgvAlumnos/*,""*/); //borrar comillas
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        private void frmAlumnos_Load(object sender, EventArgs e) //NUEVO
        {
            cmbEstado.DataSource = Enum.GetValues(typeof(enmEstado));
            cmbEstado.SelectedIndex = (int)enmEstado.Activo;

            //MessageBox.Show(cmbEstado.SelectedIndex.ToString());

            LlenarDgv(dgvAlumnos/*,""*/);
           
        }
        

        void LlenarDgv(DataGridView dgvAlumnos/*,string dato*/) 
        {
            try
            {              
                    this.dgvAlumnos.Rows.Clear();
                    clsAlumnos oAlumnos = new clsAlumnos();                    
                    List<Alumno> lista = oAlumnos.Listar(txtBuscador.Text.Trim(), cmbEstado.SelectedIndex.ToString()); //NUEVO
                    foreach (Alumno i in lista)
                    {
                        this.dgvAlumnos.Rows.Add(i.idAlumno.ToString(), i.nombre, i.apellido, i.dni.ToString(), i.fechaNac.ToString(), i.telefono.ToString(), i.direccion, i.email, i.observaciones, i.Ciudad.nombre.ToString(), i.estado);
                        
                    }
             


                //dgvAlumnos.AutoGenerateColumns = false;
                //dgvAlumnos.Columns["colIDAlumno"].DataPropertyName = "idAlumno";
                //dgvAlumnos.Columns["colNombre"].DataPropertyName = "nombre";
                //dgvAlumnos.Columns["colApellido"].DataPropertyName = "apellido";
                //dgvAlumnos.Columns["colDNI"].DataPropertyName = "dni";
                //dgvAlumnos.Columns["colFechaNac"].DataPropertyName = "FechaNac";
                //dgvAlumnos.Columns["colTelefono"].DataPropertyName = "telefono";
                //dgvAlumnos.Columns["colDireccion"].DataPropertyName = "direccion";
                //dgvAlumnos.Columns["colEmail"].DataPropertyName = "email";
                //dgvAlumnos.Columns["colObservaciones"].DataPropertyName = "observaciones";
                //dgvAlumnos.Columns["colCiudad"].DataPropertyName = "idCiudad"; //item.Ciudad.nombre
                //dgvAlumnos.Columns["colEstado"].DataPropertyName = "estado";
                //clsAlumnos oAlumnos = new clsAlumnos();
                //dgvAlumnos.DataSource = oAlumnos.Listar();
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
                if (dgvAlumnos.SelectedRows.Count > 0 && dgvAlumnos.CurrentRow.Cells[0].Value != null)
                {
                    

                    int id = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value.ToString());
                    //MessageBox.Show(id.ToString());
                    frmABMAlumno frmABMAlumno = new frmABMAlumno(id); //sacar idciudad
                    frmABMAlumno.ShowDialog();
                    LlenarDgv(dgvAlumnos/*,""*/); //borrar comillas
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
                LlenarDgv(dgvAlumnos/*, txtBuscador.Text.Trim()*/);
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
                if (dgvAlumnos.SelectedRows.Count > 0 && dgvAlumnos.CurrentRow.Cells[0].Value != null) 
                {
                    int id = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value.ToString());
                    clsAlumnos oAlumnos = new clsAlumnos();
                    oAlumnos.Delete(id);
                    LlenarDgv(dgvAlumnos/*, ""*/);
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
                if (this.dgvAlumnos.Columns[e.ColumnIndex].Name == "colEstado")  //NUEVO TODO EL IF
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

                if (this.dgvAlumnos.Columns[e.ColumnIndex].Name == "colEstado")
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

        private void dgvAlumnos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnos.CurrentRow.Cells[0].Value == null)
                {
                    MessageBox.Show("Seleccione un Alumno", "Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (frmPadre.Equals("frmVisor"))
                {
                    frmVisor frmVisor = Owner as frmVisor;
                    frmVisor.IdAlumno = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value.ToString());
                    frmVisor.NombreAlumno = dgvAlumnos.CurrentRow.Cells[1].Value.ToString() + " " + dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
                }
                else if (frmPadre.Equals("frmABMClase"))
                {
                    frmABMClase frmABMClase = Owner as frmABMClase;
                    frmABMClase.IdAlumno = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value.ToString());
                    frmABMClase.NombreAlumno = dgvAlumnos.CurrentRow.Cells[1].Value.ToString() + " " + dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
                }
                else if (frmPadre.Equals("frmABMPlanesPersonalizados"))
                {
                    frmABMPlanesPersonalizados frmABMPlanesPersonalizados = Owner as frmABMPlanesPersonalizados;
                    frmABMPlanesPersonalizados.IdAlumno = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value.ToString());
                    frmABMPlanesPersonalizados.NombreAlumno = dgvAlumnos.CurrentRow.Cells[1].Value.ToString() + " " + dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
                }

                this.Close();
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
                
                frmVisor frmVisor = new frmVisor(0, cmbEstado.SelectedIndex);
                frmVisor.Show();
                frmVisor.StartPosition = FormStartPosition.CenterScreen;
                frmVisor.FormBorderStyle = FormBorderStyle.Sizable;
                frmVisor.MinimumSize = new Size(1180, 500);
                frmVisor.lblFiltro.Visible = true;
                frmVisor.cmbEstado.Visible = true;
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
