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
    
    public partial class frmEjercicios : Form
    {
        string frmPadre;
        public frmEjercicios()
        {
            InitializeComponent();
        }

        public frmEjercicios(string frmP)
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
                Form frmABMEjercicio = new frmABMEjercicio();

                frmABMEjercicio.ShowDialog(); 

                LlenarDgv(dgvEjercicios/*,""*/); 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        private void frmEjercicios_Load(object sender, EventArgs e) //NUEVO
        {
          
            cmbEstado.DataSource = Enum.GetValues(typeof(enmEstado));
            cmbEstado.SelectedIndex = (int)enmEstado.Activo;
            LlenarComboTipoEjercicio(cmbTipoEjercicio);
            LlenarDgv(dgvEjercicios/*,""*/);
        }

        public void LlenarComboTipoEjercicio(ComboBox cmb)
        {
                      
            clsEjercicios oTipoEjercico = new clsEjercicios();
            cmb.ValueMember = "idTipoEjercicio";
            cmb.DisplayMember = "nombre";
            cmb.DataSource = oTipoEjercico.ListarTipoEjercicio();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            List<TipoEjercicio> lista = oTipoEjercico.ListarTipoEjercicio();
            foreach (TipoEjercicio i in lista)
            {
                coleccion.Add(Convert.ToString(i.nombre));
            }
            cmb.AutoCompleteCustomSource = coleccion;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmb.Text = "";
            //if (idPl != 0)    //cuidado con esto por null
            //{
            //    clsPlanes oPlanes = new clsPlanes();
            //    Planes oP = new Planes();
            //    oP = oPlanes.Obtener(idPl);
            //    cmb.SelectedValue = oP.idTipoPlan;
            //}


        }



        void LlenarDgv(DataGridView dgvEjercicios/*,string dato*/) 
        {
            try
            {
                
                    this.dgvEjercicios.Rows.Clear();
                    clsEjercicios oEjercicios = new clsEjercicios();                    
                    List<Ejercicio> lista = oEjercicios.Listar(txtBuscador.Text.Trim(), cmbTipoEjercicio.Text, cmbEstado.SelectedIndex.ToString()); //MODIFICAR

                   
                    foreach (Ejercicio i in lista)
                    {
                        
                        this.dgvEjercicios.Rows.Add(i.idEjercicio.ToString(), i.nombre, i.descripcion, i.TipoEjercicio.nombre , (i.Maquina==null) ? string.Empty  : i.Maquina.nombre, i.estado);
                                                                       
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
                if (dgvEjercicios.SelectedRows.Count > 0 && dgvEjercicios.CurrentRow.Cells[0].Value != null)
                {
                    

                    int id = Convert.ToInt32(dgvEjercicios.CurrentRow.Cells[0].Value.ToString());
                    //MessageBox.Show(id.ToString());
                    frmABMEjercicio frmABMEjercicio = new frmABMEjercicio(id); //sacar idciudad
                    frmABMEjercicio.ShowDialog();
                    LlenarDgv(dgvEjercicios/*,""*/); //borrar comillas
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una fila");


                }
            }
            catch (NullReferenceException) 
            {
                MessageBox.Show("Seleccione un Ejercicio");
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
                LlenarDgv(dgvEjercicios/*, txtBuscador.Text.Trim()*/);
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
                if (dgvEjercicios.SelectedRows.Count > 0 && dgvEjercicios.CurrentRow.Cells[0].Value != null)
                {
                    int id = Convert.ToInt32(dgvEjercicios.CurrentRow.Cells[0].Value.ToString());
                    clsEjercicios oEjercicios = new clsEjercicios();
                    oEjercicios.Delete(id);
                    LlenarDgv(dgvEjercicios/*, txtBuscador.Text.Trim()*/);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        private void dgvEjercicios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dgvEjercicios.Columns[e.ColumnIndex].Name == "colEstado")  //NUEVO TODO EL IF
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

                if (this.dgvEjercicios.Columns[e.ColumnIndex].Name == "colEstado")
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

        private void dgvEjercicios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvEjercicios.CurrentRow.Cells[0].Value == null)
                {
                    MessageBox.Show("Seleccione un Ejercicio", "Ejercicios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (frmPadre.Equals("frmABMPlan"))
                {
                    frmABMPlan frmABMPlan = Owner as frmABMPlan;
                    frmABMPlan.IdEjercicio = Convert.ToInt32(dgvEjercicios.CurrentRow.Cells[0].Value.ToString());
                    frmABMPlan.NombreEjercicio = dgvEjercicios.CurrentRow.Cells[1].Value.ToString();
                }
                else if (frmPadre.Equals("frmABMPlanesPersonalizados"))
                {
                    frmABMPlanesPersonalizados frmABMPlanesPersonalizados = Owner as frmABMPlanesPersonalizados;
                    frmABMPlanesPersonalizados.IdEjercicio = Convert.ToInt32(dgvEjercicios.CurrentRow.Cells[0].Value.ToString());
                    frmABMPlanesPersonalizados.NombreEjercicio = dgvEjercicios.CurrentRow.Cells[1].Value.ToString();
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
                frmVisor frmVisor = new frmVisor(3, cmbEstado.SelectedIndex);
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
