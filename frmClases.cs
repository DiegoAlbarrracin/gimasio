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


    public partial class frmClases : Form
    {
       
        public frmClases()
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
                Form frmABMClase = new frmABMClase();

                frmABMClase.ShowDialog(); //Agregar el Dialog a todos los ABMnombre

                LlenarDgv(dgvClases/*,""*/); //borrar comillas
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        private void frmClases_Load(object sender, EventArgs e) //NUEVO
        {
            

            cmbEstado.DataSource = Enum.GetValues(typeof(enmEstado));
            cmbEstado.SelectedIndex = (int)enmEstado.Activo;

            //MessageBox.Show(cmbEstado.SelectedIndex.ToString());

            LlenarDgv(dgvClases/*,""*/);
            
           
        }
        

        void LlenarDgv(DataGridView dgvClases/*,string dato*/) 
        {
            try
            {
                //if (dato.Equals(""))
                //{
                    this.dgvClases.Rows.Clear();
                    clsClases oClases = new clsClases();                    
                    List<Clase> lista = oClases.Listar(txtBuscador.Text.Trim(), cmbEstado.SelectedIndex.ToString()); //NUEVO
                    foreach (Clase i in lista)
                    {
                        
                        if (cmbEstado.Text.Equals("Activa"))
                        {
                            dgvClases.Columns["colFechaHasta"].Visible = false;
                            this.dgvClases.Rows.Add(i.idClase.ToString(), i.nombre, i.fechaDesde.ToString(), i.cupoMaximo.ToString(), i.descripcion, i.estado);

                        }
                        else
                        {
                            dgvClases.Columns["colFechaHasta"].Visible = true;
                            this.dgvClases.Rows.Add(i.idClase.ToString(), i.nombre, i.fechaDesde.ToString(), (i.fechaHasta == null) ? string.Empty : i.fechaHasta.ToString() ,i.cupoMaximo.ToString(),i.descripcion ,i.estado);
                        }


                    }
                //}
                //else
                //{
                //    this.dgvClases.Rows.Clear();
                //    clsClases oClases = new clsClases();
                //    List<Clase> lista = oClases.Listar(txtBuscador.Text.Trim(), cmbEstado.SelectedIndex.ToString());//NUEVO
                //    foreach (Clase i in lista)
                //    {
                //        if (cmbEstado.Text.Equals("Activa"))
                //        {
                //            dgvClases.Columns["colFechaHasta"].Visible = false;
                //            this.dgvClases.Rows.Add(i.idClase.ToString(), i.nombre, i.fechaDesde.ToString(), i.cupoMaximo.ToString(), i.descripcion, i.estado);

                //        }
                //        else
                //        {
                //            dgvClases.Columns["colFechaHasta"].Visible = true;
                //            this.dgvClases.Rows.Add(i.idClase.ToString(), i.nombre, i.fechaDesde.ToString(), (i.fechaHasta == null) ? string.Empty : i.fechaHasta.ToString(), i.cupoMaximo.ToString(), i.descripcion, i.estado);
                //        }
                //    }
                //}


                
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
                if (dgvClases.SelectedRows.Count > 0 && dgvClases.CurrentRow.Cells[0].Value != null)
                {
                    

                    int id = Convert.ToInt32(dgvClases.CurrentRow.Cells[0].Value.ToString());

                    //MessageBox.Show(id.ToString());
                    frmABMClase frmABMClase = new frmABMClase(id); //sacar idciudad
                    frmABMClase.ShowDialog();
                    LlenarDgv(dgvClases/*,""*/); //borrar comillas


                    LlenarDGVProfesorxClase(dgvProfesorxClase);
                    LlenarDGVAlumnoxClase(dgvAlumnoxClase);


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
                LlenarDgv(dgvClases/*, txtBuscador.Text.Trim()*/);
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
                if (dgvClases.SelectedRows.Count > 0 && dgvClases.CurrentRow.Cells[0].Value != null) 
                {
                    int id = Convert.ToInt32(dgvClases.CurrentRow.Cells[0].Value.ToString());
                    clsClases oClases = new clsClases();
                    oClases.Delete(id);
                    LlenarDgv(dgvClases/*, ""*/);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        private void dgvClases_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dgvClases.Columns[e.ColumnIndex].Name == "colEstado")  //NUEVO TODO EL IF
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

                if (this.dgvClases.Columns[e.ColumnIndex].Name == "colEstado")
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

        private void dgvClases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClases.SelectedRows.Count > 0 && dgvClases.CurrentRow.Cells[0].Value != null)
            {

                LlenarDGVProfesorxClase(dgvProfesorxClase);
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila");

            }
        }

        public void LlenarDGVProfesorxClase (DataGridView dgv) 
        {
            int id = 0;
            if (dgvClases.CurrentRow != null)
            {
                 id = Convert.ToInt32(dgvClases.CurrentRow.Cells[0].Value.ToString());
            }
            
            this.dgvProfesorxClase.Rows.Clear();
            clsProfesorxClases oProfesorxClases = new clsProfesorxClases();
            ProfesorxClase oPxC = new ProfesorxClase();
            List<ProfesorxClase> lista = oProfesorxClases.Listar(id);

            foreach (ProfesorxClase item in lista)
            {
                this.dgvProfesorxClase.Rows.Add(item.idProfesorxClase.ToString(), item.Profesor.nombre +" "+item.Profesor.apellido, item.Clase.nombre, item.fechaDesde.ToString(), (item.fechaHasta == null) ? string.Empty : item.fechaHasta.ToString(), item.dia, item.horaInicio.ToString());
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1º) Seleccione la Clase haciendo click izquierdo sobre ella y luego presione el boton Modificar.\n (En caso de que no exista, cree una nueva Clase pulsando en Agregar).\n" +                
                "2ª) Se abrirá una pantalla donde podrá Agregar, Modificar o Dar de Baja las Diagramaciones de la Clase seleccionada. \n" +
                "3ª) Ademas en dicha pantalla podra modificar los datos de la propia Clase (nombre, fecha desde, fecha hasta, cupo maximo, estado y descripcion).\n" +
                "\n" +
                "Para agregar alumnos a una clase: simplemente en la pantalla Modificar de la clase seleccionada(2º paso), seleccione la diagramacion deseada y en agregue alumnos en la seccion  Alumnos de la Clase.", "¿Como agregar y/o modificar la diagramacion de la Clase?",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

        private void dgvProfesorxClase_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dgvProfesorxClase.Columns[e.ColumnIndex].Name == "colDia")
                {
                    if (Convert.ToString(e.Value).Equals("0"))
                    {
                        e.Value = "Lunes";
                    }
                    else if (Convert.ToString(e.Value).Equals("1"))
                    {
                        e.Value = "Martes";
                    }
                    else if (Convert.ToString(e.Value).Equals("2"))
                    {
                        e.Value = "Miercoles";
                    }
                    else if (Convert.ToString(e.Value).Equals("3"))
                    {
                        e.Value = "Jueves";
                    }
                    else if (Convert.ToString(e.Value).Equals("4"))
                    {
                        e.Value = "Viernes";
                    }
                    else if (Convert.ToString(e.Value).Equals("5"))
                    {
                        e.Value = "Sabado";
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }
             
                
        private void dgvProfesorxClase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProfesorxClase.SelectedRows.Count > 0 && dgvProfesorxClase.CurrentRow.Cells[0].Value != null)
            {

                LlenarDGVAlumnoxClase(dgvAlumnoxClase);
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila");

            }
        }

        public void LlenarDGVAlumnoxClase(DataGridView dgv)
        {
            int idPxC = 0;
            if (dgvProfesorxClase.CurrentRow != null)
            {
                idPxC = Convert.ToInt32(dgvProfesorxClase.CurrentRow.Cells[0].Value.ToString());
            }

            this.dgvAlumnoxClase.Rows.Clear();
            clsAlumnoxClases oAlumnoxClases = new clsAlumnoxClases();
            AlumnoxClase oAxC = new AlumnoxClase();
            List<AlumnoxClase> lista = oAlumnoxClases.Listar(idPxC);

            clsClases oC = new clsClases();
            clsProfesorxClases oPxC = new clsProfesorxClases();
            foreach (AlumnoxClase item in lista)
            {
                this.dgvAlumnoxClase.Rows.Add(item.idAlumnoxClase.ToString(),item.idAlumno.ToString() ,item.Alumno.nombre + " " + item.Alumno.apellido, (item.idProfesorxClase == null) ? string.Empty : oC.Obtener((int)oPxC.Obtener((int)item.idProfesorxClase).idClase).nombre /*item.ProfesorxClase.Clase.nombre*/, item.fechaDesde.ToString(), (item.fechaHasta == null) ? string.Empty : item.fechaHasta.ToString());
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                frmVisor frmVisor = new frmVisor(6, 0);
                frmVisor.Show();
                frmVisor.StartPosition = FormStartPosition.CenterScreen;
                frmVisor.FormBorderStyle = FormBorderStyle.Sizable;
                frmVisor.MinimumSize = new Size(1180, 500);
                frmVisor.lblFiltro.Visible = true;
                frmVisor.cmbEstado.Visible = true;

                frmVisor.lblClase.Visible = true;
                frmVisor.cmbClase.Visible = true;
                frmVisor.cmbProfesor.Visible = true;
                frmVisor.lblProfesor.Visible = true;
                //frmVisor.LlenarComboProfesor(cmbProfesor);
                //frmVisor.LlenarComboClase(cmbClase);
                frmVisor.cmbClase.SelectedValue = 0;
                frmVisor.cmbProfesor.SelectedValue = 0;

                frmVisor.lblAlumno.Visible = true;
                frmVisor.lblFormato.Visible = true;
                frmVisor.cmbFormato.Visible = true;
                frmVisor.chkTodos.Visible = true;
                frmVisor.lblIncluirA.Visible = true;
                frmVisor.lblIncluirC.Visible = true;

                frmVisor.txtNombreAlumno.Visible = true;
                frmVisor.btnBuscarAlumno.Visible = true;
                frmVisor.btnBorrarAlumno.Visible = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }
    }
}
