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
    
    public partial class frmProfesores : Form
    {
        public frmProfesores()
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
                Form frmABMProfesor = new frmABMProfesor();

                frmABMProfesor.ShowDialog(); //Agregar el Dialog a todos los ABMnombre

                LlenarDgv(dgvProfesores/*,""*/); //borrar comillas
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }

        

        void LlenarDgv(DataGridView dgvProfesores/*,string dato*/) 
        {
            try
            {
               
                    this.dgvProfesores.Rows.Clear();
                    clsProfesores oProfesores = new clsProfesores();
                    List<Profesor> lista = oProfesores.Listar(txtBuscador.Text.Trim(), cmbEstado.SelectedIndex.ToString());
                    foreach (Profesor i in lista)
                    {
                        this.dgvProfesores.Rows.Add(i.idProfesor.ToString(), i.nombre, i.apellido, i.dni.ToString(), i.fechaNac.ToString(), i.telefono.ToString(), i.direccion, i.email, i.observaciones, i.Ciudad.nombre.ToString(), i.estado);
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
                if (dgvProfesores.SelectedRows.Count > 0 && dgvProfesores.CurrentRow.Cells[0].Value != null)
                {
                    

                    int id = Convert.ToInt32(dgvProfesores.CurrentRow.Cells[0].Value.ToString());
                    //MessageBox.Show(id.ToString());
                    frmABMProfesor frmABMProfesor = new frmABMProfesor(id); //sacar idciudad
                    frmABMProfesor.ShowDialog();
                    LlenarDgv(dgvProfesores/*,""*/); //borrar comillas
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una fila");


                }
            }
            catch (NullReferenceException) 
            {
                MessageBox.Show("Seleccione un Profesor");
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
                LlenarDgv(dgvProfesores/*, txtBuscador.Text.Trim()*/);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        private void frmProfesores_Load(object sender, EventArgs e)
        {
            cmbEstado.DataSource = Enum.GetValues(typeof(enmEstado));
            cmbEstado.SelectedIndex = (int)enmEstado.Activo;

            //MessageBox.Show(cmbEstado.SelectedIndex.ToString());

            LlenarDgv(dgvProfesores/*, ""*/);
        }

        

        private void tsbBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProfesores.SelectedRows.Count > 0 && dgvProfesores.CurrentRow.Cells[0].Value != null)
                {
                    int id = Convert.ToInt32(dgvProfesores.CurrentRow.Cells[0].Value.ToString());
                    clsProfesores oProfesores = new clsProfesores();
                    oProfesores.Delete(id);
                    LlenarDgv(dgvProfesores/*, ""*/);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        private void dgvProfesores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dgvProfesores.Columns[e.ColumnIndex].Name == "colEstado")  //NUEVO TODO EL IF
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

                if (this.dgvProfesores.Columns[e.ColumnIndex].Name == "colEstado")
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                

                frmVisor frmVisor = new frmVisor(1, cmbEstado.SelectedIndex);
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
