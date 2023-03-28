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
    public partial class frmABMCiudad : Form
    {
        int idProv = 0;
        bool boCccionModificar = false;
        public frmABMCiudad()
        {
            InitializeComponent();
            LlenarCombo(cmbProvincia, idProv);
        }

       
        public frmABMCiudad(int idProvad)
        {
            try
            {
                InitializeComponent();
                idProv = idProvad;
                clsCiudades oCiudades = new clsCiudades();
                Ciudad oC = new Ciudad();
                LlenarCombo(cmbProvincia, idProv);
                if (idProv != 0)
                {
                    boCccionModificar = true;
                    oC = oCiudades.Obtener(idProv);
                    txtNombre.Text = oC.nombre;
                    cmbProvincia.SelectedValue = Convert.ToInt32(oC.idProvincia);
                    
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




        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                clsCiudades oCiudades = new clsCiudades();
                Ciudad oC = new Ciudad();
                if (boCccionModificar == true)
                {
                    oC = oCiudades.Obtener(idProv);
                }
                
                oC.nombre = txtNombre.Text.Trim();
                
                if (Convert.ToInt32(cmbProvincia.SelectedValue)>0)
                {
                    oC.idProvincia = Convert.ToInt32(cmbProvincia.SelectedValue.ToString().Trim());
                }
                else
                {
                    MessageBox.Show("SELECCIONE UNA PROVINCIA");
                    return;
                }

                if (txtNombre.Text.Trim().Equals(""))
                {
                    lblNombre.Text = "*Nombre Ciudad:";
                    MessageBox.Show("Inserte el nombre de la ciudad");
                    return;
                }
               
                int Dev = oCiudades.Guardar(oC);

                    if (Dev > 0)
                    {
                        MessageBox.Show("Ciudad REGISTRADA");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ciudad ACTUALIZADA");
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

        
        

        public void LlenarCombo(ComboBox cmb,int idProv) 
        {
            try
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

                if (idProv != 0)
                {
                    clsCiudades oCiudades = new clsCiudades();
                    Ciudad oC = new Ciudad();
                    oC = oCiudades.Obtener(idProv);
                    cmb.SelectedValue = oC.idProvincia;


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
