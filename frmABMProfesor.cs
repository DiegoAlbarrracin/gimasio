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
    public partial class frmABMProfesor : Form
    {
        //Prueba para hacer buscador
        private int idCiudad;
        private string nombreCiudad;
        public int IdCiudad { get => idCiudad; set => idCiudad = value; }
        public string NombreCiudad { get => nombreCiudad; set => nombreCiudad = value; }

        private void btnBuscarCiudad_Click(object sender, EventArgs e)
        {
            frmCiudades frmCiudades = new frmCiudades("frmABMProfesor");
            AddOwnedForm(frmCiudades);

            frmCiudades.StartPosition = FormStartPosition.CenterScreen;
            frmCiudades.FormBorderStyle = FormBorderStyle.Sizable;
            frmCiudades.MinimumSize = new Size(1160, 500);
            frmCiudades.ShowDialog();
            txtCiudad.Text = NombreCiudad;
        }
        // Fin prueba para hacer buscador



        int idPr = 0;
        bool boAccionModificar = false;

        public frmABMProfesor()
        {
            InitializeComponent();
            //LlenarComboPcia(cmbProvincia);
            //LlenarCombo(cmbCiudad, idPr);

            //cmbProvincia.SelectedValue = 0;
            //cmbCiudad.SelectedValue = 0;
        }

       
        public frmABMProfesor(int idProfesor) 
        {
            try
            {
                InitializeComponent();
                idPr = idProfesor;
                clsProfesores oProfesores = new clsProfesores();
                Profesor oP = new Profesor();
                //LlenarComboPcia(cmbProvincia);
                //LlenarCombo(cmbCiudad, idPr);
                if (idPr != 0)
                {
                    boAccionModificar = true;
                    oP = oProfesores.Obtener(idPr);
                    txtNombre.Text = oP.nombre;
                    txtApellido.Text = oP.apellido;
                    txtDNI.Text = oP.dni.ToString();
                    dtpFechaNac.Text = oP.fechaNac.ToString();
                    txtTelefono.Text = oP.telefono.ToString();
                    txtDireccion.Text = oP.direccion;
                    txtEmail.Text = oP.email;
                    txtObservaciones.Text = oP.observaciones;


                    clsCiudades oCiudades = new clsCiudades();
                    Ciudad oC = new Ciudad();
                    oC = oCiudades.Obtener(Convert.ToInt32(oP.idCiudad));
                    //cmbProvincia.SelectedValue = Convert.ToInt32(oC.idProvincia);
                    txtCiudad.Text = oC.nombre;
                    IdCiudad = oC.idCiudad;

                    //cmbCiudad.SelectedValue = Convert.ToInt32(oP.idCiudad);
                    
                    //txtCiudad.Text = oP.idCiudad.ToString(); //VER

                    //MessageBox.Show(oP.estado.ToString());
                    if (oP.estado.ToString().Equals("0"))
                    {
                        //NUEVO
                        cmbEstado.SelectedIndex = (int)enmEstado.Activo;
                    }
                    else
                    {

                        cmbEstado.SelectedIndex = (int)enmEstado.Inactivo;
                    }





                    //if (dgvProfesors.CurrentRow.Cells[9].Value == null) { dgvProfesors.CurrentRow.Cells[8].Value = ""; } else { frmABMProfesor.txtCiudad.Text = dgvProfesors.CurrentRow.Cells[9].Value.ToString(); }
                    //if (dgvProfesors.SelectedRows[0].Cells[10].Value == null){frmABMProfesor.cmbEstado.DisplayMember = "";}else{frmABMProfesor.cmbEstado.DisplayMember = dgvProfesors.SelectedRows[0].Cells[10].Value.ToString();}

                }
               
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
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
                clsProfesores oProfesores = new clsProfesores();
                Profesor oP = new Profesor();
                if (boAccionModificar == true)
                {
                    oP = oProfesores.Obtener(idPr);
                }
                //MessageBox.Show(boAccionModificar.ToString());
                //MessageBox.Show(idPr.ToString());
                oP.nombre = txtNombre.Text.Trim();
                oP.apellido = txtApellido.Text.Trim();
                oP.dni = txtDNI.Text.Trim();
                oP.fechaNac = dtpFechaNac.Value;
                oP.telefono = txtTelefono.Text.Trim();
                oP.direccion = txtDireccion.Text.Trim();
                oP.email = txtEmail.Text.Trim();
                oP.observaciones = txtObservaciones.Text.Trim();

                if (Convert.ToInt32(IdCiudad) > 0)
                {
                    oP.idCiudad = Convert.ToInt32(IdCiudad);
                }
                else
                {
                    MessageBox.Show("SELECCIONE UNA CIUDAD");
                    return;
                }

                if (txtTelefono.Text.Trim().Length < 10 || txtTelefono.Text.Trim().Substring(0, 2).Equals("54"))
                {
                    MessageBox.Show("El telefono solo debe incluir codigo de area y numero local sin 15, ni 549.", "Alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Convert.ToInt32(IdCiudad) < 1 || txtNombre.Text.Trim().Equals("") || txtApellido.Text.Trim().Equals("") || txtDNI.Text.Trim().Equals("") || txtEmail.Text.Trim().Equals("") || txtTelefono.Text.Trim().Length < 10)
                {
                    lblNombre.Text = "*Nombre:";
                    lblApellido.Text = "*Apellido:";
                    lblDNI.Text = "*DNI:";
                    lblEmail.Text = "*Email";
                    lblCiudad.Text = "*Ciudad:";
                    lblCiudad.Text = "*Ciudad:";
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


                int Dev = oProfesores.Guardar(oP);

                    if (Dev > 0)
                    {
                        MessageBox.Show("Profesor REGISTRADO");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Profesor ACTUALIZADO");
                        this.Close();
                    }
                  
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese SOLO NÚMEROS en DNI y Telefono");
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
            



        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
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

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
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

        

        private void pnlLupa_Click(object sender, EventArgs e)
        {
           
            frmABMCiudad frmABMCiudad = new frmABMCiudad();
            string stEleccion = frmABMCiudad.ShowDialog().ToString();
            //MessageBox.Show(stEleccion);
            //LlenarCombo(cmbCiudad, idPr);
            

        }



        public void LlenarCombo(ComboBox cmb, int idPcia)
        {

            clsCiudades oCiudades = new clsCiudades();
            cmb.ValueMember = "idCiudad";
            cmb.DisplayMember = "nombre";
            cmb.DataSource = oCiudades.Listar(idPcia);

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            List<Ciudad> lista = oCiudades.Listar(idPcia);
            foreach (Ciudad i in lista)
            {
                coleccion.Add(Convert.ToString(i.nombre));
            }
            cmb.AutoCompleteCustomSource = coleccion;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        public void LlenarComboPcia(ComboBox cmb)
        {

            clsProvincias oProvincias = new clsProvincias();
            cmb.ValueMember = "idProvincia";
            cmb.DisplayMember = "nombre";
            cmb.DataSource = oProvincias.Listar();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            List<Provincia> lista = oProvincias.Listar();
            foreach (Provincia i in lista)
            {
                coleccion.Add(Convert.ToString(i.nombre));
            }
            cmb.AutoCompleteCustomSource = coleccion;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void frmABMProfesor_Load(object sender, EventArgs e)
        {
            //LlenarCombo(cmbCiudad);
        }

        
    }
}
