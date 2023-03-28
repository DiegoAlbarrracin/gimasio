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
    public partial class frmABMPlan : Form
    {
        int idPl = 0;
        bool boAccionModificar = false;
        public frmABMPlan()
        {
            InitializeComponent();
            LlenarCombo(cmbTipoPlan, idPl);
            //LlenarComboEjercicios(cmbEjercicio, idPl);

            lblEjerciciosDelPlan.Visible = false;
            lblEjercicio.Visible = false;
            lblSeries.Visible = false;
            lblRepeticiones.Visible = false;
            lblObservaciones.Visible = false;
            txtObservaciones.Visible = false;
            lblDia.Visible = false;
            cmbDia.Visible = false;
            //cmbEjercicio.Visible = false;
            txtEjercicio.Visible = false;
            btnBuscarEjercicio.Visible = false;
            txtSeries.Visible = false;
            txtRepeticiones.Visible = false;
            dgvEjercicioxPlanABM.Visible = false;
            //gbContenedor.Visible = false;
            btnAgregarFila.Visible = false;
            btnBajaFila.Visible = false;
            btnModificarFila.Visible = false;

            this.Size = new Size(550, 570);

        }

       
        public frmABMPlan(int idPlan) 
        {
            try
            {
                InitializeComponent();
                idPl = idPlan;
                clsPlanes oPlanes = new clsPlanes();
                Planes oP = new Planes();
                LlenarCombo(cmbTipoPlan, idPl);
                //LlenarComboEjercicios(cmbEjercicio, idPl);
                //cmbEjercicio.SelectedValue = 0;
                if (idPl != 0)
                {
                    boAccionModificar = true;
                    oP = oPlanes.Obtener(idPl);
                    txtNombre.Text = oP.nombre;                    
                    txtDescripcion.Text = oP.descripcion;
                    cmbTipoPlan.SelectedValue = Convert.ToInt32(oP.idTipoPlan);
                    
                    if (oP.estado.ToString().Equals("0"))
                    {
                        //NUEVO
                        cmbEstado.SelectedIndex = (int)enmEstado.Activo;
                    }
                    else
                    {                        
                        cmbEstado.SelectedIndex = (int)enmEstado.Inactivo;
                    }

                    // Lleno dgv de cada ejercicio                   

                    LlenarDGVEjxPl(idPl);
                    //this.dgvEjercicioxPlanABM.Rows.Clear();
                    //clsEjercicioxPlan oEjercicioxPlanes = new clsEjercicioxPlan();
                    //EjercicioxPlan oExP = new EjercicioxPlan();
                    //List<EjercicioxPlan> lista = oEjercicioxPlanes.Listar(idPl);

                    //foreach (EjercicioxPlan item in lista)
                    //{
                    //    this.dgvEjercicioxPlanABM.Rows.Add(item.idEjercicioxPlan.ToString(), item.Ejercicio.nombre, item.series.ToString(), item.repeticiones.ToString(), item.idEjercicio.ToString(), item.idPlan.ToString());

                    //}


                }
               
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }
        public void LlenarDGVEjxPl(int idPl)
        {
            this.dgvEjercicioxPlanABM.Rows.Clear();
            clsEjercicioxPlan oEjercicioxPlanes = new clsEjercicioxPlan();
            EjercicioxPlan oExP = new EjercicioxPlan();
            List<EjercicioxPlan> lista = oEjercicioxPlanes.Listar(idPl);


            clsMaquinas oM = new clsMaquinas();
            clsEjercicios oE = new clsEjercicios();
            foreach (EjercicioxPlan item in lista)
            {
                dgvEjercicioxPlanABM.Rows.Add(item.idEjercicioxPlan.ToString(), item.Ejercicio.nombre, item.series.ToString(), item.repeticiones.ToString(), item.idEjercicio.ToString(), item.idPlan.ToString() , (item.Ejercicio.idMaquina == null) ? string.Empty : oM.Obtener((int)oE.Obtener(item.idEjercicio).idMaquina).nombre, item.dia, item.observaciones);
                //this.dgvEjercicioxPlanABM.Rows.Add(item.idEjercicioxPlan.ToString(), item.Ejercicio.nombre, item.series.ToString(), item.repeticiones.ToString(), (item.Ejercicio.idMaquina == null) ? string.Empty : oM.Obtener((int)oE.Obtener(item.idEjercicio).idMaquina).nombre, item.observaciones, item.dia);

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
                clsPlanes oPlanes = new clsPlanes();
                Planes oP = new Planes();
                if (boAccionModificar == true)
                {
                    oP = oPlanes.Obtener(idPl);
                }
                //MessageBox.Show(boPccionModificar.ToString());
                //MessageBox.Show(idPl.ToString());
                oP.nombre = txtNombre.Text.Trim();
                oP.descripcion = txtDescripcion.Text.Trim();


                if (Convert.ToInt32(cmbTipoPlan.SelectedValue)>0)
                {
                    oP.idTipoPlan = Convert.ToInt32(cmbTipoPlan.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("SELECCIONE UN TIPO DE PLAN");
                    return;
                }
                if (Convert.ToInt32(cmbTipoPlan.SelectedValue) < 1 || txtNombre.Text.Trim().Equals(""))
                {
                    lblNombre.Text = "*Nombre:";
                    lblTipoPlan.Text = "*Tipo Plan:";
                    
                    MessageBox.Show("RELLENE LOS CAMPOS OBLIGATORIOS(*)");
                    return;
                }

                if (cmbEstado.SelectedItem != null)
                {
                    oP.estado = cmbEstado.SelectedIndex.ToString(); //NUEVO
                }
                else
                {
                    MessageBox.Show("Estado por defecto: Activo");
                    oP.estado = "0"; //NUEVO
                }
                

                int Dev = oPlanes.Guardar(oP);

                    if (Dev > 0)
                    {
                        MessageBox.Show("Plan REGISTRADO");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Plan ACTUALIZADO");
                        this.Close();
                        LlenarDGVEjxPl(idPl);
                    }
                  
                
            }            
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
            



        }
        

        public void LlenarCombo(ComboBox cmb,int idPl) 
        {
            clsTipoPlanes oTipoPlanes = new clsTipoPlanes();
            cmb.ValueMember = "idTipoPlan";
            cmb.DisplayMember = "nombre";
            cmb.DataSource = oTipoPlanes.Listar();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            List<TipoPlan> lista = oTipoPlanes.Listar();
            foreach (TipoPlan i in lista)
            {
                coleccion.Add(Convert.ToString(i.nombre));
            }
            cmb.AutoCompleteCustomSource = coleccion;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;

            if (idPl != 0)
            {
                clsPlanes oPlanes = new clsPlanes();
                Planes oP = new Planes();
                oP = oPlanes.Obtener(idPl);
                cmb.SelectedValue = oP.idTipoPlan;
            }
            
            
        }

        public void LlenarComboEjercicios(ComboBox cmb, int idPl)
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

            if (idPl != 0)    //cuidado con esto por null
            {
                clsPlanes oPlanes = new clsPlanes();
                Planes oP = new Planes();
                oP = oPlanes.Obtener(idPl);
                cmb.SelectedValue = oP.idTipoPlan;
            }


        }

        private void txtSeries_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvEjercicioxPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEjercicioxPlanABM.SelectedRows.Count > 0 && dgvEjercicioxPlanABM.CurrentRow.Cells[0].Value != null)
            {
                
                IdEjercicio = Convert.ToInt32(this.dgvEjercicioxPlanABM.CurrentRow.Cells[4].Value);
                //cmbEjercicio.SelectedValue = Convert.ToInt32(this.dgvEjercicioxPlanABM.CurrentRow.Cells[4].Value);
                txtEjercicio.Text = this.dgvEjercicioxPlanABM.CurrentRow.Cells[1].Value.ToString();

                txtSeries.Text = this.dgvEjercicioxPlanABM.CurrentRow.Cells["colSeries"].Value.ToString();
                txtRepeticiones.Text = this.dgvEjercicioxPlanABM.CurrentRow.Cells["colRepeticiones"].Value.ToString();
                txtObservaciones.Text = this.dgvEjercicioxPlanABM.CurrentRow.Cells["colObservaciones"].Value.ToString();
                cmbDia.SelectedIndex = Convert.ToInt32(this.dgvEjercicioxPlanABM.CurrentRow.Cells["colDia"].Value) - 1;
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila");

            }

        }

        private void btnModificarFila_Click(object sender, EventArgs e)
        {

            try
            {

                if (dgvEjercicioxPlanABM.SelectedRows.Count > 0 && dgvEjercicioxPlanABM.CurrentRow.Cells[0].Value != null && txtSeries.Text.Trim() !="" && txtRepeticiones.Text.Trim() !="" && IdEjercicio >0)
                {
                    clsEjercicioxPlan oEjercicioxPlanes = new clsEjercicioxPlan();
                    EjercicioxPlan oEjxP = new EjercicioxPlan();

                    oEjxP = oEjercicioxPlanes.Obtener(Convert.ToInt32(this.dgvEjercicioxPlanABM.CurrentRow.Cells[0].Value));


                    oEjxP.idEjercicio = IdEjercicio; ////////////
                    oEjxP.idPlan = Convert.ToInt32(idPl);
                    oEjxP.series = Convert.ToInt32(txtSeries.Text.Trim());
                    oEjxP.repeticiones = Convert.ToInt32(txtRepeticiones.Text.Trim());
                    oEjxP.observaciones = txtObservaciones.Text.Trim();
                    oEjxP.dia = cmbDia.Text;
                    //int Dev = oEjercicioxPlanes.Guardar(oEjxP);
                    int Dev = oEjercicioxPlanes.Modificar(oEjxP);
                    LlenarDGVEjxPl(idPl);
                    if (Dev > 0)
                    {
                        MessageBox.Show("Ejercicio del Plan ACTUALIZADO");
                        LlenarDGVEjxPl(idPl);
                        lblEjercicio.Text = "Ejercicio:";
                        lblSeries.Text = "Series:";
                        lblRepeticiones.Text = "Repeticiones:";
                    }
                    
                }
                else
                {
                    lblEjercicio.Text = "*Ejercicio:";
                    lblSeries.Text = "*Series:";
                    lblRepeticiones.Text = "*Repeticiones:";
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
                if (txtSeries.Text.Trim() != "" && txtRepeticiones.Text.Trim() !="" && IdEjercicio > 0)
                {
                    clsEjercicioxPlan oEjercicioxPlanes = new clsEjercicioxPlan();
                    EjercicioxPlan oEjxP = new EjercicioxPlan();

                    oEjxP.idEjercicio = IdEjercicio;
                    oEjxP.idPlan = Convert.ToInt32(idPl);
                    oEjxP.series = Convert.ToInt32(txtSeries.Text.Trim());
                    oEjxP.repeticiones = Convert.ToInt32(txtRepeticiones.Text.Trim());
                    oEjxP.observaciones = txtObservaciones.Text.Trim();
                    oEjxP.dia = cmbDia.Text;


                    int Dev = oEjercicioxPlanes.Guardar(oEjxP);
                    if (Dev > 0)
                    {
                        MessageBox.Show("Ejercicio del Plan REGISTRADO");
                        LlenarDGVEjxPl(idPl);
                        lblEjercicio.Text = "Ejercicio:";
                        lblSeries.Text = "Series:";
                        lblRepeticiones.Text = "Repeticiones:";
                        lblDia.Text = "Dia:";
                    }
                }
                else
                {
                    lblEjercicio.Text = "*Ejercicio:";
                    lblSeries.Text = "*Series:";
                    lblRepeticiones.Text = "*Repeticiones:";
                    lblDia.Text = "*Dia:";
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
                if (dgvEjercicioxPlanABM.SelectedRows.Count > 0 && dgvEjercicioxPlanABM.CurrentRow.Cells[0].Value != null)
                {
                    clsEjercicioxPlan oEjercicioxPlanes = new clsEjercicioxPlan();
                    EjercicioxPlan oEjxP = new EjercicioxPlan();
                    oEjxP = oEjercicioxPlanes.Obtener(Convert.ToInt32(this.dgvEjercicioxPlanABM.CurrentRow.Cells[0].Value));

                    int Dev = oEjercicioxPlanes.Delete(oEjxP.idEjercicioxPlan);
                    LlenarDGVEjxPl(idPl);

                    if (Dev > 0)
                    {
                        MessageBox.Show("Ejercicio del Plan ELIMINADO");
                        LlenarDGVEjxPl(idPl);
                     
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        private void frmABMPlan_Load(object sender, EventArgs e)
        {

        }

        private void dgvEjercicioxPlanABM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {


                if (this.dgvEjercicioxPlanABM.Columns[e.ColumnIndex].Name == "colDia")
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


        //Prueba para hacer buscador
        private int idEjercicio;
        private string nombreEjercicio;

        public int IdEjercicio { get => idEjercicio; set => idEjercicio = value; }
        public string NombreEjercicio { get => nombreEjercicio; set => nombreEjercicio = value; }

        private void btnBuscarEjercicio_Click(object sender, EventArgs e)
        {
            frmEjercicios frmEjercicios = new frmEjercicios("frmABMPlan");
            AddOwnedForm(frmEjercicios);

            frmEjercicios.StartPosition = FormStartPosition.CenterScreen;
            frmEjercicios.FormBorderStyle = FormBorderStyle.Sizable;
            frmEjercicios.MinimumSize = new Size(1160, 500);
            frmEjercicios.ShowDialog();
            txtEjercicio.Text = NombreEjercicio;
        }
        // Fin prueba para hacer buscador
    }
}
