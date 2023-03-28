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
    public partial class frmABMAlumno : Form
    {
        //Prueba para hacer buscador
        private int idCiudad;
        private string nombreCiudad;
        public int IdCiudad { get => idCiudad; set => idCiudad = value; }
        public string NombreCiudad { get => nombreCiudad; set => nombreCiudad = value; }

        private void btnBuscarCiudad_Click(object sender, EventArgs e)
        {            
            frmCiudades frmCiudades = new frmCiudades("frmABMAlumno");
            AddOwnedForm(frmCiudades);

            frmCiudades.StartPosition = FormStartPosition.CenterScreen;
            frmCiudades.FormBorderStyle = FormBorderStyle.Sizable;
            frmCiudades.MinimumSize = new Size(1160, 500);
            frmCiudades.ShowDialog();
            txtCiudad.Text = NombreCiudad;
        }
        // Fin prueba para hacer buscador



        int idAl = 0;
        bool boAccionModificar = false;

        

        public frmABMAlumno()
        {
            InitializeComponent();

            
            //cmbProvincia.SelectedValue = 0;
            //cmbCiudad.SelectedValue = 0;
            
        }

       
        public frmABMAlumno(int idAlumno) 
        {
            try
            {
                InitializeComponent();
                idAl = idAlumno;
                clsAlumnos oAlumnos = new clsAlumnos();
                Alumno oA = new Alumno();

                //LlenarComboPcia(cmbProvincia);
                //LlenarCombo(cmbCiudad, idAl);

                if (idAl != 0)
                {
                    boAccionModificar = true;
                    oA = oAlumnos.Obtener(idAl);
                    txtNombre.Text = oA.nombre;
                    txtApellido.Text = oA.apellido;
                    txtDNI.Text = oA.dni.ToString();
                    dtpFechaNac.Text = oA.fechaNac.ToString();
                    txtTelefono.Text = oA.telefono.ToString();
                    txtDireccion.Text = oA.direccion;
                    txtEmail.Text = oA.email;
                    txtObservaciones.Text = oA.observaciones;


                    clsCiudades oCiudades = new clsCiudades();
                    Ciudad oC = new Ciudad();
                    oC = oCiudades.Obtener(Convert.ToInt32(oA.idCiudad));
                    //cmbProvincia.SelectedValue = Convert.ToInt32(oC.idProvincia);
                    //cmbCiudad.SelectedValue = Convert.ToInt32(oA.idCiudad);
                    txtCiudad.Text = oC.nombre;
                    IdCiudad = oC.idCiudad;
                    //txtCiudad.Text = oA.idCiudad.ToString(); //VER

                    //MessageBox.Show(oA.estado.ToString());
                    if (oA.estado.ToString().Equals("0"))
                    {
                        //NUEVO
                        cmbEstado.SelectedIndex = (int)enmEstado.Activo;
                    }
                    else
                    {
                        
                        cmbEstado.SelectedIndex = (int)enmEstado.Inactivo;
                    }
                   
                    

                    //if (dgvAlumnos.CurrentRow.Cells[9].Value == null) { dgvAlumnos.CurrentRow.Cells[8].Value = ""; } else { frmABMAlumno.txtCiudad.Text = dgvAlumnos.CurrentRow.Cells[9].Value.ToString(); }
                    //if (dgvAlumnos.SelectedRows[0].Cells[10].Value == null){frmABMAlumno.cmbEstado.DisplayMember = "";}else{frmABMAlumno.cmbEstado.DisplayMember = dgvAlumnos.SelectedRows[0].Cells[10].Value.ToString();}

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
                clsAlumnos oAlumnos = new clsAlumnos();
                Alumno oA = new Alumno();
                if (boAccionModificar == true)
                {
                    oA = oAlumnos.Obtener(idAl);
                }
                //MessageBox.Show(boAccionModificar.ToString());
                //MessageBox.Show(idAl.ToString());
                oA.nombre = txtNombre.Text.Trim();
                oA.apellido = txtApellido.Text.Trim();
                oA.dni = txtDNI.Text.Trim();
                oA.fechaNac = dtpFechaNac.Value;
                oA.telefono = txtTelefono.Text.Trim();
                oA.direccion = txtDireccion.Text.Trim();
                oA.email = txtEmail.Text.Trim();
                oA.observaciones = txtObservaciones.Text.Trim();

                if (Convert.ToInt32(IdCiudad)>0)
                {
                    oA.idCiudad = Convert.ToInt32(IdCiudad);
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

                if (Convert.ToInt32(IdCiudad) < 1 || txtNombre.Text.Trim().Equals("") || txtApellido.Text.Trim().Equals("") || txtDNI.Text.Trim().Equals("") || txtEmail.Text.Trim().Equals("") || txtTelefono.Text.Trim().Length < 10 )
                {
                    
                    lblNombre.Text = "*Nombre:";
                    lblApellido.Text = "*Apellido:";
                    lblDNI.Text = "*DNI:";
                    lblEmail.Text = "*Email";
                    lblCiudad.Text = "*Ciudad:";
                    lblTelefono.Text = "*Telefono";
                    MessageBox.Show("RELLENE LOS CAMPOS OBLIGATORIOS(*)");
                    return;
                }

                if (cmbEstado.SelectedItem != null)
                {
                    oA.estado = cmbEstado.SelectedIndex.ToString(); //NUEVO
                }
                else
                {
                    MessageBox.Show("Estado por defecto: Activo");
                    oA.estado = "0"; //NUEVO
                }
                

                int Dev = oAlumnos.Guardar(oA);

                    if (Dev > 0)
                    {
                        MessageBox.Show("Alumno REGISTRADO");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Alumno ACTUALIZADO");
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
              

       
    }
}
