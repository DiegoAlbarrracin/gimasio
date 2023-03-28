using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace TPI_1
{
    public partial class frmCiudades : Form
    {
        string frmAP;
        public frmCiudades()
        {
            InitializeComponent();

        }

        public frmCiudades(string frmAlPr)
        {
            InitializeComponent();
            frmAP = frmAlPr;

        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void tsbAgregar_Click(object sender, EventArgs e)
        {////Boton ciudades
            try
            {
                Form frmABMCiudad = new frmABMCiudad();
                frmABMCiudad.ShowDialog();

                LlenarDgv(dgvCiudades,"");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
           
        }

        private void frmCiudades_Load(object sender, EventArgs e)
        {
            LlenarDgv(dgvCiudades,"");
        }
        

        void LlenarDgv(DataGridView dgvCiudades, string dato)
        {
            try
            {
                this.dgvCiudades.Rows.Clear();
                clsCiudades oCiudades = new clsCiudades();
                List<Ciudad> lista = oCiudades.Listar(txtBuscador.Text.Trim());
                foreach (Ciudad i in lista)
                {
                    this.dgvCiudades.Rows.Add(i.idCiudad.ToString(), i.nombre, i.Provincia.nombre.ToString());
                }

                //dgvCiudades.AutoGenerateColumns = false;
                //dgvCiudades.Columns["colIDCiudad"].DataPropertyName = "idCiudad";
                //dgvCiudades.Columns["colNombre"].DataPropertyName = "nombre";
                //dgvCiudades.Columns["colProvincia"].DataPropertyName = "idProvincia";
                //clsCiudades oCiudades = new clsCiudades();
                //dgvCiudades.DataSource = oCiudades.Listar();
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
                if (dgvCiudades.SelectedRows.Count > 0 && dgvCiudades.CurrentRow.Cells[0].Value != null)
                {
                    int id = Convert.ToInt32(dgvCiudades.CurrentRow.Cells[0].Value.ToString());
                    Form frmABMCiudad = new frmABMCiudad(id);
                    frmABMCiudad.ShowDialog();
                    LlenarDgv(dgvCiudades,"");
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una fila");


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LlenarDgv(dgvCiudades,txtBuscador.Text.Trim());
        }

        private void dgvCiudades_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvCiudades.CurrentRow.Cells[0].Value == null)
                {
                    MessageBox.Show("Seleccione una Ciudad", "Ciudades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (frmAP.Equals("frmABMAlumno"))
                {
                    frmABMAlumno frmABMAlumno = Owner as frmABMAlumno;
                    frmABMAlumno.IdCiudad = Convert.ToInt32(dgvCiudades.CurrentRow.Cells[0].Value.ToString());
                    frmABMAlumno.NombreCiudad = dgvCiudades.CurrentRow.Cells[1].Value.ToString();
                }
                else if (frmAP.Equals("frmABMProfesor"))
                {
                    frmABMProfesor frmABMProfesor = Owner as frmABMProfesor;
                    frmABMProfesor.IdCiudad = Convert.ToInt32(dgvCiudades.CurrentRow.Cells[0].Value.ToString());
                    frmABMProfesor.NombreCiudad = dgvCiudades.CurrentRow.Cells[1].Value.ToString();
                }


                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }
    }
}
