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

     
    public partial class frmPlanes : Form
    {
        
        public frmPlanes()
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
                Form frmABMPlan = new frmABMPlan();

                frmABMPlan.ShowDialog(); //Agregar el Dialog a todos los ABMnombre

                LlenarDgv(dgvPlanes/*,""*/); //borrar comillas
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        private void frmPlanes_Load(object sender, EventArgs e) //NUEVO
        {
            try
            {
                cmbEstado.DataSource = Enum.GetValues(typeof(enmEstado));
                cmbEstado.SelectedIndex = (int)enmEstado.Activo;
                LlenarComboTipoPlan(cmbTipoPlan);
                //MessageBox.Show(cmbEstado.SelectedIndex.ToString());

                LlenarDgv(dgvPlanes/*, ""*/);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
            
            
           
        }
        public void LlenarComboTipoPlan(ComboBox cmb)
        {

            clsPlanes oTipoPlan = new clsPlanes();
            cmb.ValueMember = "idTipoPlan";
            cmb.DisplayMember = "nombre";
            cmb.DataSource = oTipoPlan.ListarTipoPlan();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            List<TipoPlan> lista = oTipoPlan.ListarTipoPlan();
            foreach (TipoPlan i in lista)
            {
                coleccion.Add(Convert.ToString(i.nombre));
            }
            cmb.AutoCompleteCustomSource = coleccion;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmb.Text = "";        

        }

        void LlenarDgv(DataGridView dgvPlanes/*,string dato*/) 
        {
            try
            {
                //if (dato.Equals(""))
                //{
                    this.dgvPlanes.Rows.Clear();
                    clsPlanes oPlanes = new clsPlanes();                    
                    List<Planes> lista = oPlanes.Listar(txtBuscador.Text.Trim(), cmbEstado.SelectedIndex.ToString(), cmbTipoPlan.Text); //NUEVO
                    foreach (Planes i in lista)
                    {
                        this.dgvPlanes.Rows.Add(i.idPlan.ToString(), i.nombre, i.TipoPlan.nombre.ToString(),i.descripcion ,i.estado);
                        
                    }
                //}
                //else
                //{
                //    this.dgvPlanes.Rows.Clear();
                //    clsPlanes oPlanes = new clsPlanes();
                //    List<Planes> lista = oPlanes.Listar(txtBuscador.Text.Trim(), cmbEstado.SelectedIndex.ToString(), cmbTipoPlan.Text);//NUEVO
                //    foreach (Planes i in lista)
                //    {
                //        this.dgvPlanes.Rows.Add(i.idPlan.ToString(), i.nombre, i.TipoPlan.nombre.ToString(), i.descripcion, i.estado);
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
                if (dgvPlanes.SelectedRows.Count > 0 && dgvPlanes.CurrentRow.Cells[0].Value != null)
                {
                    

                    int id = Convert.ToInt32(dgvPlanes.CurrentRow.Cells[0].Value.ToString());
                    //MessageBox.Show(id.ToString());
                    frmABMPlan frmABMPlan = new frmABMPlan(id); //sacar idciudad
                    frmABMPlan.ShowDialog();
                    LlenarDgv(dgvPlanes/*,""*/); //borrar comillas

                    if (dgvPlanes.SelectedRows.Count > 0 && dgvPlanes.CurrentRow.Cells[0].Value != null)
                    {

                        LlenarDGVEjercicioxPlan(dgvEjercicioxPlan);


                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una fila");


                }
            }
            catch (NullReferenceException) 
            {
                MessageBox.Show("Seleccione un Plan");
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
                LlenarDgv(dgvPlanes/*, txtBuscador.Text.Trim()*/);
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
                if (dgvPlanes.SelectedRows.Count > 0 && dgvPlanes.CurrentRow.Cells[0].Value != null) 
                {
                    int id = Convert.ToInt32(dgvPlanes.CurrentRow.Cells[0].Value.ToString());
                    clsPlanes oPlanes = new clsPlanes();
                    oPlanes.Delete(id);
                    LlenarDgv(dgvPlanes/*, ""*/);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        private void dgvPlanes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dgvPlanes.Columns[e.ColumnIndex].Name == "colEstado")  //NUEVO TODO EL IF
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

                if (this.dgvPlanes.Columns[e.ColumnIndex].Name == "colEstado")
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

        private void dgvPlanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPlanes.SelectedRows.Count > 0 && dgvPlanes.CurrentRow.Cells[0].Value != null)
            {

                LlenarDGVEjercicioxPlan(dgvEjercicioxPlan);


            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila");

            }
        }

        public void LlenarDGVEjercicioxPlan(DataGridView dgv) 
        {
            int id = Convert.ToInt32(dgvPlanes.CurrentRow.Cells[0].Value.ToString());
            this.dgvEjercicioxPlan.Rows.Clear();
            clsEjercicioxPlan oEjercicioxPlanes = new clsEjercicioxPlan();
            EjercicioxPlan oExP = new EjercicioxPlan();
            List<EjercicioxPlan> lista = oEjercicioxPlanes.Listar(id);

            clsMaquinas oM = new clsMaquinas();
            clsEjercicios oE = new clsEjercicios();
            foreach (EjercicioxPlan item in lista)
            {               
                
                this.dgvEjercicioxPlan.Rows.Add(item.idEjercicioxPlan.ToString(), item.Ejercicio.nombre, item.series.ToString(), item.repeticiones.ToString(), (item.Ejercicio.idMaquina == null) ? string.Empty : oM.Obtener((int)oE.Obtener(item.idEjercicio).idMaquina).nombre, item.dia, item.observaciones);

            }                                                                                                                                              
        } 
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1º) Seleccione el Plan haciendo click izquierdo sobre el y luego presione el boton Modificar.\n (En caso de que el plan no exista, cree un nuevo Plan pulsando en Agregar).\n" +                
                "2ª) Se abrira una pantalla donde podra Agregar, Modificar o Borrar los Ejercicios del Plan seleccionado. \n" +
                "3ª) Ademas en dicha pantalla podra modificar los datos del propio Plan (nombre, tipo, estado y descripcion).", "¿Como agregar y/o modificar los ejercicios del Plan?",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

        private void dgvEjercicioxPlan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {

                if (this.dgvEjercicioxPlan.Columns[e.ColumnIndex].Name == "colDia")
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
                frmVisor frmVisor = new frmVisor(4, cmbEstado.SelectedIndex);
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
