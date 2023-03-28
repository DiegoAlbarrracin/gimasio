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
    public partial class frmABMMaquina : Form
    {
        int idMq = 0;
        bool boAccionModificar = false;
        public frmABMMaquina()
        {
            InitializeComponent();
            lblFechaBaja.Visible = false;
            dtpFechaBaja.Visible = false;
            dtpFechaAlta.Value = DateTime.Now;
           
        }

       
        public frmABMMaquina(int idMaquina) 
        {
            try
            {
                InitializeComponent();
                idMq = idMaquina;
                clsMaquinas oMaquinas = new clsMaquinas();
                Maquina oM = new Maquina();
               
                if (idMq != 0)
                {
                    boAccionModificar = true;
                    oM = oMaquinas.Obtener(idMq);
                    txtNombre.Text = oM.nombre;
                    txtDescripcion.Text = oM.descripcion;
                    dtpFechaAlta.Text = oM.fechaAlta.ToString();
                    lblFechaBaja.Visible = false;
                    dtpFechaBaja.Visible = false;

                    if (oM.fechaBaja != null)
                    {
                        dtpFechaBaja.Text = oM.fechaBaja.ToString();
                        lblFechaBaja.Visible = true;
                        dtpFechaBaja.Visible = true;
                    }


                    if (oM.estado.ToString().Equals("0"))
                    {
                        //NUEVO
                        cmbEstado.SelectedIndex = (int)EstadoMaquina.Activa;
                    }
                    else if(oM.estado.ToString().Equals("1"))
                    {
                        
                        cmbEstado.SelectedIndex = (int)EstadoMaquina.Inactiva;
                    }
                    else if (oM.estado.ToString().Equals("2"))
                    {
                        cmbEstado.SelectedIndex = (int)EstadoMaquina.Reparacion ;
                    }
                   
                    

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
                clsMaquinas oMaquinas = new clsMaquinas();
                Maquina oM = new Maquina();
                if (boAccionModificar == true)
                {
                    oM = oMaquinas.Obtener(idMq);                    
                }
               
                //MessageBox.Show(boAccionModificar.ToString());
                //MessageBox.Show(idMq.ToString());
                oM.nombre = txtNombre.Text.Trim();
                oM.descripcion = txtDescripcion.Text.Trim();
                oM.fechaAlta = dtpFechaAlta.Value;

                if (dtpFechaBaja.Text != " " && dtpFechaBaja.Text != "")
                {
                    oM.fechaBaja = dtpFechaBaja.Value;
                }
                else
                {
                    oM.fechaBaja = null;
                }
                


                if (txtNombre.Text.Trim().Equals("") || dtpFechaAlta.Value.Equals(""))
                {
                    lblNombre.Text = "*Nombre:";
                    lblFechaAlta.Text = "*Fecha Alta:";
                    MessageBox.Show("RELLENE LOS CAMPOS OBLIGATORIOS(*)");
                    return;
                }

                if (cmbEstado.SelectedItem != null)
                {
                    oM.estado = cmbEstado.SelectedIndex.ToString(); //NUEVO
                    if (cmbEstado.SelectedIndex == 1)
                    {
                        oM.fechaBaja = DateTime.Now;
                    }
                }
                else
                {
                    MessageBox.Show("Estado por defecto: Activa");
                    oM.estado = "0"; //NUEVO
                }
                

                int Dev = oMaquinas.Guardar(oM);

                    if (Dev > 0)
                    {
                        MessageBox.Show("Maquina REGISTRADA");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Maquina ACTUALIZADA");
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

        private void dtpFechaBaja_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaBaja.CustomFormat = "dd/MM/yyyy";
        }

        private void dtpFechaBaja_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                dtpFechaBaja.CustomFormat = " ";
            }
        }
    }
}
