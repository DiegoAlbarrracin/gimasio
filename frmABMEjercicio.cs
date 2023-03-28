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
    public partial class frmABMEjercicio : Form
    {
        int idEj = 0;
        bool boAccionModificar = false;
        public frmABMEjercicio()
        {
            InitializeComponent();
            LlenarComboTipoEj(cmbTipoEjercicio, idEj);
            //LlenarComboMaquina(cmbMaquina, idEj);
            cmbTipoEjercicio.SelectedValue = 0;
            //cmbMaquina.SelectedValue = 0;           
            //cmbMaquina.Text = "";
        }

       
        public frmABMEjercicio(int idEjercicio) 
        {
            try
            {
                InitializeComponent();
                idEj = idEjercicio;
                clsEjercicios oEjercicios = new clsEjercicios();
                Ejercicio oE = new Ejercicio();
                              


                if (idEj != 0)
                {
                    LlenarComboTipoEj(cmbTipoEjercicio, idEj);
                   

                    boAccionModificar = true;
                    oE = oEjercicios.Obtener(idEj);
                    txtNombre.Text = oE.nombre;
                    txtDescripcion.Text = oE.descripcion;                                                
                    cmbTipoEjercicio.SelectedValue = Convert.ToInt32(oE.idTipoEjercicio);

                    //if (idEj != 0)
                    //{
                    //clsEjercicios oEjercicios = new clsEjercicios();
                    //Ejercicio oE = new Ejercicio();
                    //oE = oEjercicios.Obtener(idEj);
                    //LlenarComboMaquina(cmbMaquina, idEj);
                    if (oE.idMaquina != null)
                    {
                        //cmbMaquina.SelectedValue = oE.idMaquina;
                        clsMaquinas oMaquinas = new clsMaquinas();
                        Maquina oM = new Maquina();
                        oM = oMaquinas.Obtener(Convert.ToInt32(oE.idMaquina));
                        txtMaquina.Text = oM.nombre;
                        IdMaquina = oM.idMaquina;
                    }
                    else
                    {
                      oE.idMaquina = null;
                        //cmbMaquina.SelectedValue = 0;
                        //cmbMaquina.Text = "";
                        txtMaquina.Text = "";
                    }

                    if (oE.estado.ToString().Equals("0"))
                    {
                        //NUEVO
                        cmbEstado.SelectedIndex = (int)enmEstado.Activo;
                    }
                    else
                    {

                        cmbEstado.SelectedIndex = (int)enmEstado.Inactivo;
                    }
                    //}
                    //else
                    //{                        
                    //}

                    //if (oE.idMaquina!=null)
                    //{
                    //    cmbMaquina.SelectedValue = Convert.ToInt32(oE.idMaquina);
                    //}                  



                    //if (dgvEjercicios.CurrentRow.Cells[9].Value == null) { dgvEjercicios.CurrentRow.Cells[8].Value = ""; } else { frmABMEjercicio.txtCiudad.Text = dgvEjercicios.CurrentRow.Cells[9].Value.ToString(); }
                    //if (dgvEjercicios.SelectedRows[0].Cells[10].Value == null){frmABMEjercicio.cmbEstado.DisplayMember = "";}else{frmABMEjercicio.cmbEstado.DisplayMember = dgvEjercicios.SelectedRows[0].Cells[10].Value.ToString();}

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
                clsEjercicios oEjercicios = new clsEjercicios();
                Ejercicio oE = new Ejercicio();
                if (boAccionModificar == true)
                {
                    oE = oEjercicios.Obtener(idEj);
                }
                
                oE.nombre = txtNombre.Text.Trim();
                oE.descripcion = txtDescripcion.Text.Trim();
               

                if (Convert.ToInt32(cmbTipoEjercicio.SelectedValue)>0)
                {
                    oE.idTipoEjercicio = Convert.ToInt32(cmbTipoEjercicio.SelectedValue.ToString());
                }
                else
                {
                    lblTipoEjercicio.Text = "*Tipo Ejercicio:";
                    MessageBox.Show("Rellene los campos requeridos (*)");
                    return;
                }

                if (IdMaquina > 0 && txtMaquina.Text != "")
                {
                    oE.idMaquina = IdMaquina;
                }
                else
                {
                    oE.idMaquina = null;
                   
                }

                if (cmbEstado.SelectedItem != null)
                {
                    oE.estado = cmbEstado.SelectedIndex.ToString(); //NUEVO
                }
                else
                {
                    MessageBox.Show("Estado por defecto: Activo");
                    oE.estado = "0"; //NUEVO
                }


                if (Convert.ToInt32(cmbTipoEjercicio.SelectedValue) < 1 || txtNombre.Text.Trim().Equals(""))
                {
                    lblNombre.Text = "*Nombre:";                   
                    lblTipoEjercicio.Text = "*Tipo Ejercicio:";
                    MessageBox.Show("RELLENE LOS CAMPOS OBLIGATORIOS(*)");
                    return;
                }                             
                

                int Dev = oEjercicios.Guardar(oE);

                    if (Dev > 0)
                    {
                        MessageBox.Show("Ejercicio REGISTRADO");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ejercicio ACTUALIZADO");
                        this.Close();
                    }
                  
                
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

        
        public void LlenarComboTipoEj(ComboBox cmb,int idEj) 
        {
            clsTipoEjercicios oTipoEjercicios = new clsTipoEjercicios();
            cmb.ValueMember = "idTipoEjercicio";
            cmb.DisplayMember = "nombre";
            cmb.DataSource = oTipoEjercicios.Listar();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            List<TipoEjercicio> lista = oTipoEjercicios.Listar();
            foreach (TipoEjercicio i in lista)
            {
                coleccion.Add(Convert.ToString(i.nombre));
            }
            cmb.AutoCompleteCustomSource = coleccion;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //if (idEj != 0)
            //{
            //    clsEjercicios oEjercicios = new clsEjercicios();
            //    Ejercicio oE = new Ejercicio();
            //    oE = oEjercicios.Obtener(idEj);
            //    cmb.SelectedValue = oE.idTipoEjercicio;
            //}

        }


        

        public void LlenarComboMaquina(ComboBox cmb, int idEj)
        {
            clsMaquinas oMaquinas = new clsMaquinas();
            cmb.ValueMember = "idMaquina";
            cmb.DisplayMember = "nombre";
            cmb.DataSource = oMaquinas.Listar();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            List<Maquina> lista = oMaquinas.Listar();
            foreach (Maquina i in lista)
            {
                coleccion.Add(Convert.ToString(i.nombre));
            }
            cmb.AutoCompleteCustomSource = coleccion;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;


            //if (idEj != 0)
            //{
            //    clsEjercicios oEjercicios = new clsEjercicios();
            //    Ejercicio oE = new Ejercicio();
            //    oE = oEjercicios.Obtener(idEj);


            //    if (oE.idMaquina != null)
            //    {
            //        cmb.SelectedValue = oE.idMaquina;
            //    }
            //    else
            //    {
            //        oE.idMaquina = null;
            //        cmb.SelectedValue = 0;
            //        cmb.Text = "";
            //    }
            //}
            //else
            //{
            //    cmb.SelectedValue = 0;
            //    cmb.Text = "";
            //}


        }

        //Prueba para hacer buscador de Maquinas
        private int idMaquina;
        private string nombreMaquina;

        public int IdMaquina { get => idMaquina; set => idMaquina = value; }
        public string NombreMaquina { get => nombreMaquina; set => nombreMaquina = value; }

        private void btnBuscarMaquina_Click(object sender, EventArgs e)
        {
            frmMaquinas frmMaquinas = new frmMaquinas("frmABMEjercicio");
            AddOwnedForm(frmMaquinas);

            frmMaquinas.StartPosition = FormStartPosition.CenterScreen;
            frmMaquinas.FormBorderStyle = FormBorderStyle.Sizable;
            frmMaquinas.MinimumSize = new Size(1160, 500);
            frmMaquinas.ShowDialog();
            txtMaquina.Text = NombreMaquina;
        }

        // Fin prueba para hacer buscador de Maquinas

        private void btnSinMaquina_Click(object sender, EventArgs e)
        {
            try
            {
                txtMaquina.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }
    }
}
