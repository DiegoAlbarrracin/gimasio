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
    public enum Dias
    {
        Lunes, Martes, Miercoles, Jueves, Viernes, Sabado
    }
    public partial class frmABMClase : Form
    {
        int idCl = 0;
        bool boAccionModificar = false;

        int cupoMaximoClase = 0;
        public frmABMClase()
        {
            InitializeComponent();
            //LlenarCombo(cmbTipoPlan, idCl);
            //LlenarComboEjercicios(cmbEjercicio, idCl);

            btnAgregarFila.Visible = false;
            btnBajaFila.Visible = false;
            btnModificarFila.Visible = false;
            //gbContenedor.Visible = false;
            dgvProfesorxClaseABM.Visible = false;
            lblProfesorxClase.Visible = false;
            lblProfesorPxC.Visible = false;
            cmbProfesor.Visible = false;
            //lblClasePxC.Visible = false;
            //cmbClase.Visible = false;
            lblFechaDesdePxC.Visible = false;
            dtpFechaDesdePxC.Visible = false;
            lblFechaHastaPxC.Visible = false;
            dtpFechaHastaPxC.Visible = false;
            lblDiaPxC.Visible = false;
            cmbDia.Visible = false;
            lblHoraInicioPxC.Visible = false;
            dtpHoraInicio.Visible = false;
            lblFechaHasta.Visible = false;
            dtpFechaHasta.Visible = false;
            txtNombreAlumno.Visible = false;
            btnBuscarAlumno.Visible = false;


            this.Size = new Size(560, 580);

        }

       
        public frmABMClase(int idClase) 
        {
            try
            {
                InitializeComponent();
                idCl = idClase;
                clsClases oClases = new clsClases();
                Clase oC = new Clase();

                //LlenarComboClase(cmbClase, idCl);
                LlenarComboProfesor(cmbProfesor, idCl);
                //LlenarComboAlumno(cmbAlumno);
                //cmbAlumno.SelectedValue = 0;
                //cmbEjercicio.SelectedValue = 0;
                if (idCl != 0)
                {
                    boAccionModificar = true;
                    oC = oClases.Obtener(idCl);

                    txtNombre.Text = oC.nombre;                   
                    dtpFechaDesde.Text= oC.fechaDesde.ToString();
                    if (oC.fechaHasta != null)
                    {
                        dtpFechaHasta.Text = oC.fechaHasta.Value.ToString();
                    }

                    cupoMaximoClase= (int)oC.cupoMaximo;//capturo el cupo maximo de la clase, cuando entro en la pantalla modificar, para usarlo para validar al agregar alumnos a las diagramaciones
                    txtCupoMaximo.Text = oC.cupoMaximo.ToString();
                    txtDescripcion.Text = oC.descripcion;
                    //cmbTipoPlan.SelectedValue = Convert.ToInt32(oC.idTipoPlan);                    
                    if (oC.estado.ToString().Equals("0"))
                    {
                        //NUEVO
                        cmbEstado.SelectedIndex = (int)enmEstado.Activo;
                    }
                    else
                    {                        
                        cmbEstado.SelectedIndex = (int)enmEstado.Inactivo;
                    }

                    // Lleno dgv de ProfesorxClase               

                    LlenarDGVPrxCl(idCl);
                    LlenarDGVAlumnoxClaseABM(dgvAlumnoxClaseABM);
                    
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

       

        private void DgvProfesorxClaseABM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void LlenarDGVPrxCl(int idCl)
        {
            this.dgvProfesorxClaseABM.Rows.Clear();
            clsProfesorxClases oProfesorxClase = new clsProfesorxClases();
            ProfesorxClase oExP = new ProfesorxClase();
            List<ProfesorxClase> lista = oProfesorxClase.Listar(idCl);

            foreach (ProfesorxClase item in lista)
            {
                this.dgvProfesorxClaseABM.Rows.Add(item.idProfesorxClase.ToString(), item.Profesor.nombre + " " + item.Profesor.apellido, item.Clase.nombre, item.fechaDesde.ToString(), (item.fechaHasta == null) ? string.Empty : item.fechaHasta.ToString(), item.dia, item.horaInicio.ToString(), item.idProfesor.ToString(), item.idClase.ToString());

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
                clsClases oClases = new clsClases();
                Clase oC = new Clase();
                if (boAccionModificar == true)
                {
                    oC = oClases.Obtener(idCl);
                }
                
                oC.nombre = txtNombre.Text.Trim();
                
                oC.fechaDesde = dtpFechaDesde.Value;

                if (dtpFechaHasta.Text.Equals("") || dtpFechaHasta.Text.Equals(" "))
                {
                    oC.fechaHasta = null;
                    
                }
                else
                {
                    oC.fechaHasta = dtpFechaHasta.Value;
                }

               
                oC.descripcion = txtDescripcion.Text.Trim();

                if (txtNombre.Text.Trim().Equals("") || dtpFechaDesde.Value.Equals("")  || txtCupoMaximo.Text.Trim().Equals(""))
                {
                    lblNombre.Text = "*Nombre de Clase:";
                    lblFechaDesde.Text = "*Fecha Desde:";                   
                    lblCupoMaximo.Text = "*Cupo Maximo:";

                    MessageBox.Show("RELLENE LOS CAMPOS OBLIGATORIOS(*)");
                    return;
                }
                oC.cupoMaximo = Convert.ToInt32(txtCupoMaximo.Text.Trim());



                if (cmbEstado.SelectedItem != null)
                {
                    oC.estado = cmbEstado.SelectedIndex.ToString(); 
                }
                else
                {
                    MessageBox.Show("Estado por defecto: Activo");
                    oC.estado = "0"; 
                }
                

                int Dev = oClases.Guardar(oC);

                    if (Dev > 0)
                    {
                        MessageBox.Show("Clase REGISTRADA");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Clase ACTUALIZADA");
                        this.Close();
                        LlenarDGVPrxCl(idCl);
                    }
                  
                
            }            
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
            



        }


        

        public void LlenarComboProfesor(ComboBox cmb, int idCl)
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

        }

        private void txtCupoMaximo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvProfesorxClaseABM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProfesorxClaseABM.SelectedRows.Count > 0 && dgvProfesorxClaseABM.CurrentRow.Cells[0].Value != null)
            {
                
                cmbProfesor.SelectedValue = Convert.ToInt32(this.dgvProfesorxClaseABM.CurrentRow.Cells[7].Value);
                //cmbClase.SelectedValue = Convert.ToInt32(this.dgvProfesorxClaseABM.CurrentRow.Cells[8].Value);
                cmbDia.SelectedIndex = Convert.ToInt32(this.dgvProfesorxClaseABM.CurrentRow.Cells[5].Value);
                dtpFechaDesdePxC.Text = this.dgvProfesorxClaseABM.CurrentRow.Cells[3].Value.ToString();
                if (this.dgvProfesorxClaseABM.CurrentRow.Cells["colFechaHastaa"].Value.ToString() == "")
                {
                    dtpFechaHastaPxC.CustomFormat = " ";
                }
                else
                {
                    dtpFechaHastaPxC.CustomFormat = "";
                    dtpFechaHastaPxC.Text = this.dgvProfesorxClaseABM.CurrentRow.Cells["colFechaHastaa"].Value.ToString();
                }
               
                dtpHoraInicio.Value = Convert.ToDateTime(this.dgvProfesorxClaseABM.CurrentRow.Cells[6].Value);

            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila");

            }

            //nuevo de aca para abajo
            if (dgvProfesorxClaseABM.SelectedRows.Count > 0 && dgvProfesorxClaseABM.CurrentRow.Cells[0].Value != null)
            {

                LlenarDGVAlumnoxClaseABM(dgvAlumnoxClaseABM);
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila");

            }

        }
        public void LlenarDGVAlumnoxClaseABM(DataGridView dgv)
        {

            int idPxC = 0;
            if (dgvProfesorxClaseABM.CurrentRow != null)
            {
                idPxC = Convert.ToInt32(dgvProfesorxClaseABM.CurrentRow.Cells[0].Value.ToString());
            }

            this.dgvAlumnoxClaseABM.Rows.Clear();
            clsAlumnoxClases oAlumnoxClases = new clsAlumnoxClases();
            AlumnoxClase oAxC = new AlumnoxClase();
            List<AlumnoxClase> lista = oAlumnoxClases.Listar(idPxC);

            clsClases oC = new clsClases();
            clsProfesorxClases oPxC = new clsProfesorxClases();
            foreach (AlumnoxClase item in lista)
            {
                this.dgvAlumnoxClaseABM.Rows.Add(item.idAlumnoxClase.ToString(), item.idAlumno.ToString(), item.Alumno.nombre + " " + item.Alumno.apellido, (item.idProfesorxClase == null) ? string.Empty : oC.Obtener((int)oPxC.Obtener((int)item.idProfesorxClase).idClase).nombre /*item.ProfesorxClase.Clase.nombre*/, item.fechaDesde.ToString(), (item.fechaHasta == null) ? string.Empty : item.fechaHasta.ToString());
            }
        }

        private void dtpFechaHastaPxC_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpFechaHastaPxC.CustomFormat = " ";
              
            }
        }

        private void dtpFechaHastaPxC_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaHastaPxC.CustomFormat = "dd/MM/yyyy";
          
        }



        private void btnModificarFila_Click(object sender, EventArgs e)
        {

            try
            {

                if (dgvProfesorxClaseABM.SelectedRows.Count > 0 && dgvProfesorxClaseABM.CurrentRow.Cells[0].Value != null && Convert.ToInt32(cmbDia.SelectedIndex) >= 0 && Convert.ToInt32(cmbProfesor.SelectedValue) > 0 && dtpFechaDesdePxC.Value != null && dtpHoraInicio.Value != null)
                {
                    clsProfesorxClases oProfesorxClase = new clsProfesorxClases();
                    ProfesorxClase oPrxC = new ProfesorxClase();

                    oPrxC = oProfesorxClase.Obtener(Convert.ToInt32(this.dgvProfesorxClaseABM.CurrentRow.Cells["colIDProfesorxClase"].Value));


                    oPrxC.idProfesor = Convert.ToInt32(cmbProfesor.SelectedValue); 
                    //oPrxC.idClase = Convert.ToInt32(cmbClase.SelectedValue);
                    oPrxC.dia = cmbDia.SelectedIndex.ToString();

                    clsClases oCls = new clsClases();
                    Clase oCl = new Clase();
                    oCl = oCls.Obtener(idCl);


                    if (dtpFechaDesdePxC.Value >= oCl.fechaDesde.Value)
                    {
                        oPrxC.fechaDesde = dtpFechaDesdePxC.Value;
                    }
                    else
                    {
                        MessageBox.Show("La fecha desde de la diagramacion, no puede ser menor a la de la Clase");
                        return;
                    }
                   

                    //oPrxC.horaInicio = dtpHoraInicio.Value.ToString(); 
                    oPrxC.horaInicio = dtpHoraInicio.Value.ToString("HH:mm:ss");
                    if (dtpFechaHastaPxC.Text != " ")
                    {
                        
                        oPrxC.fechaHasta = dtpFechaHastaPxC.Value;
                    }
                    else
                    {
                        oPrxC.fechaHasta = null;
                    }


                    //int Dev = oProfesorxClase.Guardar(oPrxC);
                    int Dev = oProfesorxClase.Modificar(oPrxC);
                    LlenarDGVPrxCl(idCl);
                    if (Dev > 0)
                    {
                        MessageBox.Show("Diagramacion ACTUALIZADA");
                        LlenarDGVPrxCl(idCl);
                        lblProfesorPxC.Text = "Profesor:";
                        //lblClasePxC.Text = "Clase:";
                        lblFechaDesdePxC.Text = "FechaDesde:";
                        lblDiaPxC.Text = "Dia:";
                        lblHoraInicioPxC.Text = "Hora de Inicio:";
                    }

                }
                else
                {
                   
                    lblProfesorPxC.Text = "*Profesor:";                    
                    //lblClasePxC.Text= "*Clase:";                    
                    lblFechaDesdePxC.Text = "*FechaDesde:";                 
                    lblDiaPxC.Text = "*Dia:";                    
                    lblHoraInicioPxC.Text= "*Hora de Inicio:";
                    MessageBox.Show("Rellene los campos solicitados(*)");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }


        }

        private void btnAgregarFila_Click(object sender, EventArgs e)
        {
            try
            {
                
                if ( Convert.ToInt32(cmbDia.SelectedIndex) >= 0 && Convert.ToInt32(cmbProfesor.SelectedValue) > 0 && dtpFechaDesdePxC.Value != null && dtpHoraInicio.Value != null)
                {
                    clsProfesorxClases oProfesorxClase = new clsProfesorxClases();
                    ProfesorxClase oPrxC = new ProfesorxClase();                   

                    
                    oPrxC.idProfesor = Convert.ToInt32(cmbProfesor.SelectedValue);
                    oPrxC.idClase = idCl;
                    oPrxC.dia = cmbDia.SelectedIndex.ToString();

                    clsClases oCls = new clsClases();
                    Clase oCl = new Clase();
                    oCl= oCls.Obtener(idCl);


                    if (dtpFechaDesdePxC.Value >= oCl.fechaDesde.Value )
                    {
                        oPrxC.fechaDesde = dtpFechaDesdePxC.Value;
                    }
                    else
                    {
                        MessageBox.Show("La fecha desde de la diagramacion, no puede ser menor a la de la Clase");
                        return;
                    }
                    

                    oPrxC.horaInicio = dtpHoraInicio.Value.ToString("HH:mm:ss");
                    if (dtpFechaHastaPxC.Text != " ")
                    {

                        oPrxC.fechaHasta = dtpFechaHastaPxC.Value;
                    }
                    else
                    {
                        oPrxC.fechaHasta = null;
                    }


                    int Dev = oProfesorxClase.Guardar(oPrxC);
                    if (Dev > 0)
                    {
                        MessageBox.Show("Diagramacion de Clase REGISTRADA");
                        LlenarDGVPrxCl(idCl);
                        lblProfesorPxC.Text = "Profesor:";
                        //lblClasePxC.Text = "Clase:";
                        lblFechaDesdePxC.Text = "Fecha Desde:";
                        lblDiaPxC.Text = "Dia:";
                        lblHoraInicioPxC.Text = "Hora de Inicio:";
                    }
                }
                else
                {
                    lblProfesorPxC.Text = "*Profesor:";
                    //lblClasePxC.Text = "*Clase:";
                    lblFechaDesdePxC.Text = "*FechaDesde:";
                    lblDiaPxC.Text = "*Dia:";
                    lblHoraInicioPxC.Text = "*Hora de Inicio:";
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
                if (dgvProfesorxClaseABM.SelectedRows.Count > 0 && dgvProfesorxClaseABM.CurrentRow.Cells[0].Value != null)
                {
                    clsProfesorxClases oProfesorxClase = new clsProfesorxClases();
                    ProfesorxClase oPrxC = new ProfesorxClase();
                    oPrxC = oProfesorxClase.Obtener(Convert.ToInt32(this.dgvProfesorxClaseABM.CurrentRow.Cells["colIDProfesorxClase"].Value));

                    int Dev = oProfesorxClase.Delete(oPrxC.idProfesorxClase);
                    LlenarDGVPrxCl(idCl);

                    if (Dev > 0)
                    {
                        //MessageBox.Show("La fila de diagramacion de Clase seleccionada ha sido ELIMINADA");
                        LlenarDGVPrxCl(idCl);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        private void frmABMClase_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFechaDesdeAxC.Value = DateTime.Now;
                cmbProfesor.SelectedItem = null;
                //cmbClase.SelectedItem = null;
                cmbDia.SelectedItem = null;
                dtpFechaDesdePxC.Value = DateTime.Now;
                if (boAccionModificar==false)
                {
                    dtpFechaDesde.Value = DateTime.Now;
                }
                
                //dtpHoraInicio.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        

        private void dgvProfesorxClaseABM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dgvProfesorxClaseABM.Columns[e.ColumnIndex].Name == "colDia")
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

        private void dtpHoraInicio_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpFechaHastaPxC.CustomFormat = "H/mm/ss";
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

        private void cmbProfesor_Format(object sender, ListControlConvertEventArgs e)
        {
            // Codigo para que aparezca tanto nombre como apellido en el displaymember del cmbProfesor
            string nombre = ((Profesor)e.ListItem).nombre;
            string apellido = ((Profesor)e.ListItem).apellido;
            e.Value = nombre + " " + apellido;

        }

        private void dgvAlumnoxClaseABM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlumnoxClaseABM.SelectedRows.Count > 0 && dgvAlumnoxClaseABM.CurrentRow.Cells[0].Value != null)
            {
                IdAlumno = Convert.ToInt32(this.dgvAlumnoxClaseABM.CurrentRow.Cells[1].Value);

                //cmbAlumno.SelectedValue = Convert.ToInt32(this.dgvAlumnoxClaseABM.CurrentRow.Cells[1].Value);
                txtNombreAlumno.Text = this.dgvAlumnoxClaseABM.CurrentRow.Cells[2].Value.ToString();

                dtpFechaDesdeAxC.Text = this.dgvAlumnoxClaseABM.CurrentRow.Cells[4].Value.ToString();
                if (this.dgvAlumnoxClaseABM.CurrentRow.Cells[5].Value.ToString() == "")
                {
                    dtpFechaHastaAxC.CustomFormat = " ";
                }
                else
                {
                    dtpFechaHastaAxC.CustomFormat = "";
                    dtpFechaHastaAxC.Text = this.dgvAlumnoxClaseABM.CurrentRow.Cells[4].Value.ToString();
                }                

            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila");

            }
        }

        public void LlenarComboAlumno(ComboBox cmb)
        {
            clsAlumnos oAlumnos = new clsAlumnos();

            cmb.ValueMember = "idAlumno";
            //cmb.DisplayMember = "nombre";            
            cmb.DataSource = oAlumnos.Listar();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            List<Alumno> lista = oAlumnos.Listar();
            foreach (Alumno i in lista)
            {
                coleccion.Add(Convert.ToString(i.nombre + " " + i.apellido));
            }
            cmb.AutoCompleteCustomSource = coleccion;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void cmbAlumno_Format(object sender, ListControlConvertEventArgs e)
        {
            // Codigo para que aparezca tanto nombre como apellido en el displaymember del cmbProfesor
            string nombre = ((Alumno)e.ListItem).nombre;
            string apellido = ((Alumno)e.ListItem).apellido;
            e.Value = nombre + " " + apellido;
        }

        private void btnAgregarFilaAxC_Click(object sender, EventArgs e)
        {
            try
            {
                clsAlumnoxClases oAxC = new clsAlumnoxClases();
                AlumnoxClase oAlxCl = new AlumnoxClase();

                //idProfesorxClase == idPxC && AC.fechaHasta == null

                if (dgvAlumnoxClaseABM.Rows.Count-1 == cupoMaximoClase) //valida no superar el cupo maximo
                {
                    MessageBox.Show("Cupo Maximo de la clase alcanzado", "Clases", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if ( IdAlumno > 0 && dtpFechaDesdeAxC.Value != null )
                {
                    //clsProfesorxClases oProfesorxClase = new clsProfesorxClases();
                    //ProfesorxClase oPrxC = new ProfesorxClase();
                    clsAlumnoxClases oAlumnoxClase = new clsAlumnoxClases();
                    AlumnoxClase oAlxC = new AlumnoxClase();


                    oAlxC.idAlumno = IdAlumno;
                    oAlxC.idProfesorxClase = Convert.ToInt32(dgvProfesorxClaseABM.CurrentRow.Cells["colIDProfesorxClase"].Value); //a

                    //clsClases oCls = new clsClases();
                    //Clase oCl = new Clase();
                    //oCl = oCls.Obtener(idCl);
                    clsProfesorxClases oProfesorxClase = new clsProfesorxClases();
                    ProfesorxClase oPrxC = new ProfesorxClase();
                    oPrxC = oProfesorxClase.Obtener(Convert.ToInt32(dgvProfesorxClaseABM.CurrentRow.Cells["colIDProfesorxClase"].Value));

                    if (dtpFechaDesdeAxC.Value >= oPrxC.fechaDesde.Value)
                    {
                        oAlxC.fechaDesde = dtpFechaDesdeAxC.Value;
                    }
                    else
                    {
                        MessageBox.Show("La fecha desde del alumno, no puede ser menor a la de la Diagramacion");
                        return;
                    }


                    
                    //if (dtpFechaHastaAxC.Text != " ")
                    //{

                    //    oAlxC.fechaHasta = dtpFechaHastaAxC.Value;
                    //}
                    //else
                    //{
                    //    oAlxC.fechaHasta = null;
                    //}


                    //int Dev = oProfesorxClase.Guardar(oPrxC);
                    int Dev = oAlumnoxClase.Guardar(oAlxC);
                    if (Dev > 0)
                    {
                        MessageBox.Show("Alumno en Clase REGISTRADO");
                        //LlenarDGVPrxCl(idCl);
                        LlenarDGVAlumnoxClaseABM(dgvAlumnoxClaseABM);
                        lblAlumno.Text = "Alumno:";
                        lblFechaDesdeAxC.Text = "Fecha Desde:";
                        //lblFechaHastaAxC.Text = "Fecha Hasta";
                       
                    }
                }
                else
                {
                    lblAlumno.Text = "*Alumno:";
                    lblFechaDesdeAxC.Text = "*Fecha Desde:";
                    //lblFechaHastaAxC.Text = "*Fecha Hasta";
                    MessageBox.Show("Rellene los campos solicitados(*)");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        private void btnModificarFilaAxC_Click(object sender, EventArgs e)
        {
            try
            {

                if (idAlumno > 0 && dtpFechaDesdeAxC.Value != null)
                {
                    clsAlumnoxClases oAlumnoxClase = new clsAlumnoxClases();
                    AlumnoxClase oAlxC = new AlumnoxClase();

                    //oPrxC = oProfesorxClase.Obtener(Convert.ToInt32(this.dgvProfesorxClaseABM.CurrentRow.Cells["colIDProfesorxClase"].Value));
                    oAlxC = oAlumnoxClase.Obtener(Convert.ToInt32(dgvAlumnoxClaseABM.CurrentRow.Cells["colIDAxCABM"].Value));


                    //oPrxC.idProfesor = Convert.ToInt32(cmbProfesor.SelectedValue);                 
                    
                    oAlxC.idAlumno = idAlumno;

                    clsClases oCls = new clsClases();
                    Clase oCl = new Clase();
                    oCl = oCls.Obtener(idCl);


                    clsProfesorxClases oProfesorxClase = new clsProfesorxClases();
                    ProfesorxClase oPrxC = new ProfesorxClase();
                    oPrxC = oProfesorxClase.Obtener(Convert.ToInt32(dgvProfesorxClaseABM.CurrentRow.Cells["colIDProfesorxClase"].Value));

                    if (dtpFechaDesdeAxC.Value >= oPrxC.fechaDesde.Value)
                    {
                        oAlxC.fechaDesde = dtpFechaDesdeAxC.Value;
                    }
                    else
                    {
                        MessageBox.Show("La fecha desde del alumno, no puede ser menor a la de la Diagramacion");
                        return;
                    }



                    //if (dtpFechaHastaAxC.Text != " ")
                    //{

                    //    oAlxC.fechaHasta = dtpFechaHastaAxC.Value;
                    //}
                    //else
                    //{
                    //    oAlxC.fechaHasta = null;
                    //}


                    
                    int Dev = oAlumnoxClase.Modificar(oAlxC);
                    LlenarDGVAlumnoxClaseABM(dgvAlumnoxClaseABM);
                    if (Dev > 0)
                    {
                        MessageBox.Show("Alumno en Clase MODIFICADO");
                        //LlenarDGVPrxCl(idCl);
                        LlenarDGVAlumnoxClaseABM(dgvAlumnoxClaseABM);
                        lblAlumno.Text = "Alumno:";
                        lblFechaDesdeAxC.Text = "Fecha Desde:";
                        //lblFechaHastaAxC.Text = "Fecha Hasta";
                    }

                }
                else
                {

                    lblAlumno.Text = "*Alumno:";
                    lblFechaDesdeAxC.Text = "*Fecha Desde:";
                    //lblFechaHastaAxC.Text = "*Fecha Hasta";
                    MessageBox.Show("Rellene los campos solicitados(*)");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        private void btnBajaFilaAxC_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAlumnoxClaseABM.SelectedRows.Count > 0 && dgvAlumnoxClaseABM.CurrentRow.Cells[0].Value != null)
                {
                    //clsProfesorxClases oProfesorxClase = new clsProfesorxClases();
                    //ProfesorxClase oPrxC = new ProfesorxClase();
                    //oPrxC = oProfesorxClase.Obtener(Convert.ToInt32(this.dgvProfesorxClaseABM.CurrentRow.Cells["colIDProfesorxClase"].Value));

                    clsAlumnoxClases oAlumnoxClase = new clsAlumnoxClases();
                    AlumnoxClase oAlxC = new AlumnoxClase();
                    oAlxC = oAlumnoxClase.Obtener(Convert.ToInt32(dgvAlumnoxClaseABM.CurrentRow.Cells["colIDAxCABM"].Value));

                    int Dev = oAlumnoxClase.Delete(oAlxC.idAlumnoxClase);
                    LlenarDGVAlumnoxClaseABM(dgvAlumnoxClaseABM);

                    if (Dev > 0)
                    {
                        //MessageBox.Show("La fila de diagramacion de Clase seleccionada ha sido ELIMINADA");
                        LlenarDGVAlumnoxClaseABM(dgvAlumnoxClaseABM);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        private void dtpFechaHastaAxC_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpFechaHastaAxC.CustomFormat = " ";

            }
        }

        private void dtpFechaHastaAxC_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaHastaAxC.CustomFormat = "dd/MM/yyyy";
        }

        //Prueba para hacer buscador
        private int idAlumno;
        private string nombreAlumno;
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public int IdAlumno { get => idAlumno; set => idAlumno = value; }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            frmAlumnos frmAlumno = new frmAlumnos("frmABMClase");
            AddOwnedForm(frmAlumno);

            frmAlumno.StartPosition = FormStartPosition.CenterScreen;
            frmAlumno.FormBorderStyle = FormBorderStyle.Sizable;
            frmAlumno.MinimumSize = new Size(1160, 500);
            frmAlumno.ShowDialog();


            txtNombreAlumno.Text = NombreAlumno;
        }
        // Fin prueba para hacer buscador
    }
}
