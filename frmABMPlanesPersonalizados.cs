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
    //public enum Dias
    //{
    //    Lunes, Martes, Miercoles, Jueves, Viernes, Sabado
    //}
    public partial class frmABMPlanesPersonalizados : Form
    {
        int idPxA = 0;
        bool boAccionModificar = false;
        public frmABMPlanesPersonalizados()
        {
            InitializeComponent();
            //LlenarComboAlumno(cmbAlumno, idPxA);
            //cmbAlumno.SelectedValue = 0;
            LlenarComboPlan(cmbPlan, idPxA);
            cmbPlan.SelectedValue = 0;
            LlenarComboProfesor(cmbProfesor, idPxA);
            cmbProfesor.SelectedValue = 0;
            lblFechaHasta.Visible = false;
            dtpFechaHasta.Visible = false;
            lblDia.Visible = false;
            lblObservaciones.Visible = false;

            cmbDia.Visible = false;
            txtObservaciones.Visible = false;
            btnAgregarFila.Visible = false;
            btnBajaFila.Visible = false;
            btnModificarFila.Visible = false;   
            dgvEjercicioPlanAlumnoABM.Visible = false;
            lblEjercicioPlanAlumno.Visible = false;
            lblEjercicioEPA.Visible = false;
            txtEjercicio.Visible = false;
            btnBuscarEjercicio.Visible = false;
            lblSeriesEPA.Visible = false;
            txtSeriesEPA.Visible = false;
            lblRepeticionesEPA.Visible = false;
            txtRepeticionesEPA.Visible = false;
            
            
            this.Size = new Size(560, 580);

        }

       
        public frmABMPlanesPersonalizados(int idPlxAl) 
        {
            try
            {
                InitializeComponent();
                idPxA = idPlxAl;
                clsPlanxAlumno oPlanesxAlumnos = new clsPlanxAlumno();
                PlanxAlumno oPlxAl = new PlanxAlumno();

                //LlenarComboAlumno(cmbAlumno, idPxA);
                LlenarComboPlan(cmbPlan, idPxA);
                LlenarComboProfesor(cmbProfesor, idPxA);
                //LlenarComboEjercicios(cmbEjercicioEPA, idPxA);

                //cmbEjercicio.SelectedValue = 0;
                if (idPxA != 0)
                {
                    boAccionModificar = true;
                    oPlxAl = oPlanesxAlumnos.Obtener(idPxA);

                    //cmbAlumno.SelectedValue = Convert.ToInt32(oPlxAl.idAlumno);




                    //clsCiudades oCiudades = new clsCiudades();
                    //Ciudad oC = new Ciudad();
                    //oC = oCiudades.Obtener(Convert.ToInt32(oA.idCiudad));                
                    //txtCiudad.Text = oC.nombre;
                    //IdCiudad = oC.idCiudad;
                    clsAlumnos oAlumnos = new clsAlumnos();
                    Alumno oA = new Alumno();
                    oA = oAlumnos.Obtener(Convert.ToInt32(oPlxAl.idAlumno));
                    txtNombreAlumno.Text = oA.nombre + " " + oA.apellido;
                    IdAlumno = oA.idAlumno;


                    cmbPlan.SelectedValue = Convert.ToInt32(oPlxAl.idPlan);
                    cmbProfesor.SelectedValue = Convert.ToInt32(oPlxAl.idProfesor);
                    dtpFechaDesde.Text= oPlxAl.fechaDesde.ToString();
                    if (oPlxAl.fechaHasta != null)
                    {
                        dtpFechaHasta.Text = oPlxAl.fechaHasta.Value.ToString();
                    }
                                               

                    // Lleno dgv de cada ejercicio                   

                    LlenarDGVEPA(idPxA);  //MODIFICAR
                    

                }
                lblPlanBase.Visible = false;
                cmbPlan.Visible = false;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        public void LlenarDGVEPA(int idPxA)
        {
            this.dgvEjercicioPlanAlumnoABM.Rows.Clear();
            clsEjercicioPlanAlumno oEjercicioPlanAlumno = new clsEjercicioPlanAlumno();
            EjercicioPlanAlumno oExP = new EjercicioPlanAlumno();
            List<EjercicioPlanAlumno> lista = oEjercicioPlanAlumno.Listar(idPxA);

            clsMaquinas oM = new clsMaquinas();
            clsEjercicios oE = new clsEjercicios();
            foreach (EjercicioPlanAlumno item in lista)
            {
                this.dgvEjercicioPlanAlumnoABM.Rows.Add(item.idEjercicioPlanAlumno.ToString(), item.idEjercicio.ToString(), item.Ejercicio.nombre, item.idPlanxAlumno.ToString(), item.series.ToString(), item.repeticiones.ToString(), (item.Ejercicio.idMaquina == null) ? string.Empty : oM.Obtener((int)oE.Obtener(item.idEjercicio).idMaquina).nombre, item.dia, item.observaciones);
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
                //clsPlanxAlumno oPlanesxAlumnos = new clsPlanxAlumno();
                clsPlanxAlumno oPlanesxAlumnos = new clsPlanxAlumno();
                PlanxAlumno oPxA = new PlanxAlumno();
                if (boAccionModificar == true)
                {
                    oPxA = oPlanesxAlumnos.Obtener(idPxA);
                }
               
                oPxA.idPlan = Convert.ToInt32(cmbPlan.SelectedValue);
                oPxA.idAlumno = IdAlumno;
                oPxA.idProfesor = Convert.ToInt32(cmbProfesor.SelectedValue);
                //oPxA.nro = ;               
                oPxA.fechaDesde = dtpFechaDesde.Value;

                if (dtpFechaHasta.Text.Equals("") || dtpFechaHasta.Text.Equals(" "))
                {
                    oPxA.fechaHasta = null;

                }
                else
                {
                    oPxA.fechaHasta = dtpFechaHasta.Value;
                }


                if (IdAlumno > 0 && Convert.ToInt32(cmbPlan.SelectedValue) > 0 && Convert.ToInt32(cmbProfesor.SelectedValue) > 0  && dtpFechaDesde.Value != null ) 
                {
                    lblAlumno.Text = "Alumno:";
                    lblPlanBase.Text = "Plan Base:";
                    lblProfesor.Text = "Profesor";
                    lblFechaDesde.Text = "Fecha Desde:";
                }
                else
                {
                    lblAlumno.Text = "*Alumno:";
                    lblPlanBase.Text = "*Plan Base:";
                    lblProfesor.Text = "*Profesor";
                    lblFechaDesde.Text = "*Fecha Desde:";
                    
                    MessageBox.Show("RELLENE LOS CAMPOS OBLIGATORIOS(*)");
                    return;
                }



                int Dev = 0;
                if (boAccionModificar == true)
                {
                     Dev = oPlanesxAlumnos.Modificar(oPxA);
                }
                else
                {
                    Dev = oPlanesxAlumnos.Guardar(oPxA);
                }

                if (Dev == 0)
                {
                    MessageBox.Show("Plan Personalizado ACTUALIZADO");
                    this.Close();
                }
                else
                {
                      
                    MessageBox.Show("Plan Personalizado REGISTRADO. Ahora personalice sus ejercicios.");
                    this.Close();
                    LlenarDGVEPA(idPxA);

                    //DUPLICA EJERCICIOS DE PLAN BASE A EjercicioPlanAlumno
                    int idPlanBase = Convert.ToInt32(cmbPlan.SelectedValue);
                    //this.dgvEjercicioxPlan.Rows.Clear();
                    clsEjercicioxPlan oEjercicioxPlanes = new clsEjercicioxPlan();
                    EjercicioxPlan oExP = new EjercicioxPlan();
                    List<EjercicioxPlan> lista = oEjercicioxPlanes.Listar(idPlanBase);

                    foreach (EjercicioxPlan item in lista)
                    {

                        clsEjercicioPlanAlumno oEjercicioPlanAlumno = new clsEjercicioPlanAlumno();
                        EjercicioPlanAlumno oEPA = new EjercicioPlanAlumno();

                        oEPA.idEjercicio = item.idEjercicio;
                        oEPA.series = item.series;
                        oEPA.repeticiones = item.repeticiones;
                        oEPA.dia = item.dia;
                        oEPA.observaciones = item.observaciones;
                        oEPA.idPlanxAlumno = Dev;
                        oEjercicioPlanAlumno.Guardar(oEPA);

                    }
                    //DUPLICA EJERCICIOS DE PLAN BASE A EjercicioPlanAlumno

                    frmABMPlanesPersonalizados frmABMPlanesPersonalizados = new frmABMPlanesPersonalizados(Dev);
                    frmABMPlanesPersonalizados.ShowDialog();
                }





            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
            



        }


        public void LlenarComboAlumno(ComboBox cmb, int idPxA)
        {
            
            clsAlumnos oAlumno = new clsAlumnos();
            cmb.ValueMember = "idAlumno";
            cmb.DisplayMember = "nombre"; 
            cmb.DataSource = oAlumno.Listar();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            List<Alumno> lista = oAlumno.Listar();
            foreach (Alumno i in lista)
            {
                coleccion.Add(Convert.ToString(i.nombre +" "+ i.apellido));
            }
            cmb.AutoCompleteCustomSource = coleccion;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
            
        }

        public void LlenarComboPlan(ComboBox cmb, int idPxA)
        {
            //clsTipoClase oTipoClase = new clsTipoClase();
            clsPlanes oPlanes = new clsPlanes();
            cmb.ValueMember = "idPlan";
            cmb.DisplayMember = "nombre";
            cmb.DataSource = oPlanes.Listar();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            List<Planes> lista = oPlanes.Listar();
            foreach (Planes i in lista)
            {
                coleccion.Add(Convert.ToString(i.nombre));
            }
            cmb.AutoCompleteCustomSource = coleccion;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmb.Text = "";
        }

        public void LlenarComboProfesor(ComboBox cmb, int idPxA)
        {
           
            clsProfesores oProfesores = new clsProfesores();
            cmb.ValueMember = "idProfesor";
            //cmb.DisplayMember = "nombre";
            cmb.DataSource = oProfesores.Listar();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            List<Profesor> lista = oProfesores.Listar();
            foreach (Profesor i in lista)
            {
                coleccion.Add(Convert.ToString(i.nombre + " " + i.apellido));
            }
            cmb.AutoCompleteCustomSource = coleccion;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmb.Text = "";
        }

        public void LlenarComboEjercicios(ComboBox cmb, int idPxA)
        {
            //clsTipoPlanes oTipoPlanes = new clsTipoPlanes();
            clsEjercicios oEjercicios = new clsEjercicios();
            cmb.ValueMember = "idEjercicio";
            cmb.DisplayMember = "nombre";
            cmb.DataSource = oEjercicios.Listar();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            List<Ejercicio> lista = oEjercicios.Listar();
            foreach (Ejercicio i in lista)
            {
                coleccion.Add(Convert.ToString(i.nombre));
            }
            cmb.AutoCompleteCustomSource = coleccion;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //if (idPl != 0)    //cuidado con esto por null
            //{
            //    clsPlanes oPlanes = new clsPlanes();
            //    Planes oP = new Planes();
            //    oP = oPlanes.Obtener(idPl);
            //    cmb.SelectedValue = oP.idTipoPlan;
            //}


        }

      
        

      



        private void btnModificarFila_Click(object sender, EventArgs e)
        {

            try
            {

                if (dgvEjercicioPlanAlumnoABM.SelectedRows.Count > -1 && IdEjercicio > 0 && !txtSeriesEPA.Text.Equals("") && !txtRepeticionesEPA.Text.Equals(""))
                {
                    clsEjercicioPlanAlumno oEjercicioPlanAlumno = new clsEjercicioPlanAlumno();
                    EjercicioPlanAlumno oEPA = new EjercicioPlanAlumno();

                    oEPA = oEjercicioPlanAlumno.Obtener(Convert.ToInt32(this.dgvEjercicioPlanAlumnoABM.CurrentRow.Cells["colIDEjercicioPlanAlumno"].Value));

                    oEPA.idEjercicio = IdEjercicio;
                    //oEPA.idPlanxAlumno = idPxA;
                    oEPA.series = Convert.ToInt32(txtSeriesEPA.Text);
                    oEPA.repeticiones = Convert.ToInt32(txtRepeticionesEPA.Text);
                    oEPA.observaciones = txtObservaciones.Text.Trim();
                    oEPA.dia = cmbDia.Text;

                    //int Dev = oEjercicioPlanAlumno.Guardar(oEPA);
                    int Dev = oEjercicioPlanAlumno.Modificar(oEPA);
                    LlenarDGVEPA(idPxA);
                    if (Dev > 0)
                    {
                        MessageBox.Show("Diagramacion ACTUALIZADA");
                        LlenarDGVEPA(idPxA);
                        lblEjercicioEPA.Text = "Ejercicio:";
                        lblSeriesEPA.Text = "Series:";
                        lblRepeticionesEPA.Text = "Repeticiones:";
                        lblDia.Text = "Dia:";

                        
                    }

                }
                else
                {

                    lblEjercicioEPA.Text = "*Ejercicio:";
                    lblSeriesEPA.Text = "*Series:";
                    lblRepeticionesEPA.Text = "*Repeticiones:";
                    lblDia.Text = "*Dia:";
                    MessageBox.Show("Rellene los campos solicitados(*)");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                //throw ex;
            }


        }

        private void btnAgregarFila_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dgvEjercicioPlanAlumnoABM.SelectedRows.Count > -1 && IdEjercicio > 0 && !txtSeriesEPA.Text.Equals("") && !txtRepeticionesEPA.Text.Equals(""))
                {
                    clsEjercicioPlanAlumno oEjercicioPlanAlumno = new clsEjercicioPlanAlumno();
                    EjercicioPlanAlumno oEPA = new EjercicioPlanAlumno();                   

                    oEPA.idEjercicio = IdEjercicio;
                    oEPA.idPlanxAlumno = idPxA;
                    oEPA.series = Convert.ToInt32(txtSeriesEPA.Text);
                    oEPA.repeticiones = Convert.ToInt32(txtRepeticionesEPA.Text);
                    oEPA.observaciones = txtObservaciones.Text.Trim();
                    oEPA.dia = cmbDia.Text;


                    int Dev = oEjercicioPlanAlumno.Guardar(oEPA);
                    if (Dev > 0)
                    {
                        MessageBox.Show("Diagramacion de Plan Personalizado REGISTRADO");
                        LlenarDGVEPA(idPxA);                 
                        lblEjercicioEPA.Text = "Ejercicio:";
                        lblSeriesEPA.Text = "Series:";
                        lblRepeticionesEPA.Text = "Repeticiones:";
                    }
                }
                else
                {
                    lblEjercicioEPA.Text = "*Ejercicio:";
                    lblSeriesEPA.Text = "*Series:";
                    lblRepeticionesEPA.Text = "*Repeticiones:";
                  
                    MessageBox.Show("Rellene los campos solicitados(*)");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }


        }

        private void btnBajaFila_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEjercicioPlanAlumnoABM.SelectedRows.Count > 0 && dgvEjercicioPlanAlumnoABM.CurrentRow.Cells[0].Value != null)
                {
                    clsEjercicioPlanAlumno oEjercicioPlanAlumno = new clsEjercicioPlanAlumno();
                    EjercicioPlanAlumno oEPA = new EjercicioPlanAlumno();
                    oEPA = oEjercicioPlanAlumno.Obtener(Convert.ToInt32(this.dgvEjercicioPlanAlumnoABM.CurrentRow.Cells["colIDEjercicioPlanAlumno"].Value));

                    int Dev = oEjercicioPlanAlumno.Delete(oEPA.idEjercicioPlanAlumno);
                    LlenarDGVEPA(idPxA);

                    if (Dev > 0)
                    {
                        //MessageBox.Show("La fila de diagramacion de Clase seleccionada ha sido ELIMINADA");
                        LlenarDGVEPA(idPxA);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        private void frmABMPlanesPersonalizados_Load(object sender, EventArgs e)
        {
            try
            {
                
                //cmbEjercicioEPA.SelectedItem = null;               
                
                if (boAccionModificar==false)
                {
                    dtpFechaDesde.Value = DateTime.Now;
                }
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        //public void LlenarComboDia(ComboBox cmb, int idPxA)
        //{

        //    cmbDia.DataSource = Enum.GetValues(typeof(Dias));

        //    cmbDia.SelectedIndex = Convert.ToInt32(this.dgvEjercicioPlanAlumnoABM.CurrentRow.Cells["colDia"].Value);

        //    cmb.ValueMember = "(Enum.GetValues(typeof(Dias))";
        //    cmb.DisplayMember = "(Enum.GetNames(typeof(Dias))";
        //    //cmb.DataSource = oProfesores.Listar();
        //    cmbDia.DataSource = Enum.GetValues(typeof(Dias));

        //    //AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
        //    //List<Profesor> lista = oProfesores.Listar();
        //    //foreach (Profesor i in lista)
        //    //{
        //    //    coleccion.Add(Convert.ToString(i.nombre));
        //    //}
        //    //cmb.AutoCompleteCustomSource = coleccion;
        //    //cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //    //cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;

        //    //if (idPxA != 0)    //cuidado con esto por null
        //    //{
        //    //    clsPlanxAlumno oClase = new clsPlanxAlumno();
        //    //    Clase oC = new Clase();
        //    //    oC = oClase.Obtener(idPxA);
        //    //    cmb.SelectedValue = oC.idClase;
        //    //}

        //}

        private void dgvEjercicioPlanAlumnoABM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dgvEjercicioPlanAlumnoABM.Columns[e.ColumnIndex].Name == "colDia")
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

       

        
        private void dtpFechaHasta_ValueChanged_1(object sender, EventArgs e)
        {
            dtpFechaHasta.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpFechaHasta_KeyDown_1(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpFechaHasta.CustomFormat = " ";

            }
        }

        private void dtpHoraInicio_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtSeriesEPA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRepeticionesEPA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvEjercicioPlanAlumnoABM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEjercicioPlanAlumnoABM.SelectedRows.Count > 0 && dgvEjercicioPlanAlumnoABM.CurrentRow.Cells[0].Value != null)
            {
                IdEjercicio = Convert.ToInt32(this.dgvEjercicioPlanAlumnoABM.CurrentRow.Cells[1].Value);

                //cmbEjercicioEPA.SelectedValue = Convert.ToInt32(this.dgvEjercicioPlanAlumnoABM.CurrentRow.Cells[1].Value);
                txtEjercicio.Text = this.dgvEjercicioPlanAlumnoABM.CurrentRow.Cells[2].Value.ToString();
                txtSeriesEPA.Text = this.dgvEjercicioPlanAlumnoABM.CurrentRow.Cells[4].Value.ToString();
                txtRepeticionesEPA.Text = this.dgvEjercicioPlanAlumnoABM.CurrentRow.Cells[5].Value.ToString();
                cmbDia.SelectedIndex = Convert.ToInt32(this.dgvEjercicioPlanAlumnoABM.CurrentRow.Cells["colDia"].Value) - 1;
                txtObservaciones.Text = this.dgvEjercicioPlanAlumnoABM.CurrentRow.Cells["colObservaciones"].Value.ToString();
               
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila");

            }
        }

        private void dgvEjercicioPlanAlumnoABM_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dgvEjercicioPlanAlumnoABM.Columns[e.ColumnIndex].Name == "colDia")
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

        private void cmbAlumno_Format(object sender, ListControlConvertEventArgs e)
        {
            // Codigo para que aparezca tanto nombre como apellido en el displaymember del cmbProfesor
            string nombre = ((Alumno)e.ListItem).nombre;
            string apellido = ((Alumno)e.ListItem).apellido;
            e.Value = nombre + " " + apellido;
        }

        private void cmbProfesor_Format(object sender, ListControlConvertEventArgs e)
        {
            // Codigo para que aparezca tanto nombre como apellido en el displaymember del cmbProfesor
            string nombre = ((Profesor)e.ListItem).nombre;
            string apellido = ((Profesor)e.ListItem).apellido;
            e.Value = nombre + " " + apellido;
        }



        //Prueba para hacer buscador Ejercicio
        private int idEjercicio;
        private string nombreEjercicio;

        public int IdEjercicio { get => idEjercicio; set => idEjercicio = value; }
        public string NombreEjercicio { get => nombreEjercicio; set => nombreEjercicio = value; }

        private void btnBuscarEjercicio_Click(object sender, EventArgs e)
        {
            frmEjercicios frmEjercicios = new frmEjercicios("frmABMPlanesPersonalizados");
            AddOwnedForm(frmEjercicios);

            frmEjercicios.StartPosition = FormStartPosition.CenterScreen;
            frmEjercicios.FormBorderStyle = FormBorderStyle.Sizable;
            frmEjercicios.MinimumSize = new Size(1160, 500);
            frmEjercicios.ShowDialog();
            txtEjercicio.Text = NombreEjercicio;
        }
        // Fin prueba para hacer buscador Ejercicio

        //Prueba para hacer buscador Alumno
        private int idAlumno;
        private string nombreAlumno;
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public int IdAlumno { get => idAlumno; set => idAlumno = value; }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            frmAlumnos frmAlumno = new frmAlumnos("frmABMPlanesPersonalizados");
            AddOwnedForm(frmAlumno);

            frmAlumno.StartPosition = FormStartPosition.CenterScreen;
            frmAlumno.FormBorderStyle = FormBorderStyle.Sizable;
            frmAlumno.MinimumSize = new Size(1160, 500);
            frmAlumno.ShowDialog();


            txtNombreAlumno.Text = NombreAlumno;
        }
        // Fin prueba para hacer buscador Alumno
    }
}
