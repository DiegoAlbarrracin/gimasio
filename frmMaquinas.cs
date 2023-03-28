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
    public enum EstadoMaquina {Activa, Inactiva, Reparacion }; 


    public partial class frmMaquinas : Form
    {
        string frmPadre;
        public frmMaquinas()
        {
            InitializeComponent();
        }

        public frmMaquinas(string frmP)
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
                Form frmABMMaquina = new frmABMMaquina();

                frmABMMaquina.ShowDialog(); //Agregar el Dialog a todos los ABMnombre

                LlenarDgv(dgvMaquinas/*,""*/); //borrar comillas
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        private void frmMaquinas_Load(object sender, EventArgs e) //NUEVO
        {
            cmbEstado.DataSource = Enum.GetValues(typeof(EstadoMaquina));
            cmbEstado.SelectedIndex = (int)EstadoMaquina.Activa;

            //MessageBox.Show(cmbEstado.SelectedIndex.ToString());

            LlenarDgv(dgvMaquinas/*,""*/);
           
        }
        

        void LlenarDgv(DataGridView dgvMaquinas/*,string dato*/) 
        {
            try
            {
                
                    this.dgvMaquinas.Rows.Clear();
                    clsMaquinas oMaquinas = new clsMaquinas();                    
                    List<Maquina> lista = oMaquinas.Listar(txtBuscador.Text.Trim(), cmbEstado.SelectedIndex.ToString()); //NUEVO
                    foreach (Maquina i in lista)
                    {
                        if (cmbEstado.Text.Equals("Activa")  || cmbEstado.Text.Equals("Reparacion"))
                        {
                            dgvMaquinas.Columns["colFechaBaja"].Visible = false;
                            this.dgvMaquinas.Rows.Add(i.idMaquina.ToString(), i.nombre, i.descripcion, i.fechaAlta, i.estado, (i.fechaBaja == null) ? string.Empty : i.fechaBaja.ToString());
                        }
                        else
                        {
                            dgvMaquinas.Columns["colFechaBaja"].Visible = true;
                            this.dgvMaquinas.Rows.Add(i.idMaquina.ToString(), i.nombre, i.descripcion, i.fechaAlta, i.estado, (i.fechaBaja == null) ? string.Empty : i.fechaBaja.ToString());
                        }
                                                
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
                if (dgvMaquinas.SelectedRows.Count > 0 && dgvMaquinas.CurrentRow.Cells[0].Value != null)
                {
                    

                    int id = Convert.ToInt32(dgvMaquinas.CurrentRow.Cells[0].Value.ToString());
                    //MessageBox.Show(id.ToString());
                    frmABMMaquina frmABMMaquina = new frmABMMaquina(id); //sacar idciudad
                    frmABMMaquina.ShowDialog();
                    LlenarDgv(dgvMaquinas/*,""*/); //borrar comillas
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una fila");


                }
            }
            catch (NullReferenceException) 
            {
                MessageBox.Show("Seleccione un Maquina");
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
                LlenarDgv(dgvMaquinas/*, txtBuscador.Text.Trim()*/);
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
                if (dgvMaquinas.SelectedRows.Count > 0 && dgvMaquinas.CurrentRow.Cells[0].Value != null) 
                {
                    int id = Convert.ToInt32(dgvMaquinas.CurrentRow.Cells[0].Value.ToString());
                    clsMaquinas oMaquinas = new clsMaquinas();
                    oMaquinas.Delete(id);
                    LlenarDgv(dgvMaquinas/*, ""*/);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        private void dgvMaquinas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dgvMaquinas.Columns[e.ColumnIndex].Name == "colEstado")  //NUEVO TODO EL IF
                {
                    if (Convert.ToString(e.Value).Equals("0"))
                    {
                        e.Value = "Activa";
                    }
                    else if (Convert.ToString(e.Value).Equals("1"))
                    {
                        e.Value = "Inactiva";
                    }
                    else if (Convert.ToString(e.Value).Equals("2"))
                    {
                        e.Value = "En Reparacion";
                    }
                }

                if (this.dgvMaquinas.Columns[e.ColumnIndex].Name == "colEstado")
                {
                    if (Convert.ToString(e.Value).Equals("Activa"))
                    {
                        e.CellStyle.BackColor = Color.Green;
                    }
                    else if (Convert.ToString(e.Value).Equals("Inactiva"))
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                    else if (Convert.ToString(e.Value).Equals("En Reparacion"))
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                    }
                    

                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        private void dgvMaquinas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvMaquinas.CurrentRow.Cells[0].Value == null)
                {
                    MessageBox.Show("Seleccione una Maquina", "Maquinas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (frmPadre.Equals("frmABMEjercicio"))
                {
                    frmABMEjercicio frmABMEjercicio = Owner as frmABMEjercicio;
                    frmABMEjercicio.IdMaquina = Convert.ToInt32(dgvMaquinas.CurrentRow.Cells[0].Value.ToString());
                    frmABMEjercicio.NombreMaquina = dgvMaquinas.CurrentRow.Cells[1].Value.ToString();
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
                frmVisor frmVisor = new frmVisor(2, cmbEstado.SelectedIndex);
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
