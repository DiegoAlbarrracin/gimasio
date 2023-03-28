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


    public partial class frmNotificaciones : Form
    {
        string nombreDia = "";
        
        public frmNotificaciones()
        {
            InitializeComponent();
        }


        

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Form frmABMClase = new frmABMClase();

            //    frmABMClase.ShowDialog(); //Agregar el Dialog a todos los ABMnombre

            //    LlenarDgv(dgvClases/*,""*/); //borrar comillas
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message.ToString());
            //    throw ex;
            //}

        }

        private void frmNotificaciones_Load(object sender, EventArgs e) //NUEVO
        {
            

            //cmbEstado.DataSource = Enum.GetValues(typeof(enmEstado));
            //cmbEstado.SelectedIndex = (int)enmEstado.Activo;

            //MessageBox.Show(cmbEstado.SelectedIndex.ToString());

            LlenarDGVPxC(dgvProfesorxClase/*,""*/);


            
        }


        void LlenarDGVPxC(DataGridView dgvClases) 
        {
            try
            {
                string datoDia = "";
                DateTime diaHoy = DateTime.Now;
                if (diaHoy.DayOfWeek.ToString().Equals("Monday"))
                {
                    datoDia = "0";
                }
                else if (diaHoy.DayOfWeek.ToString().Equals("Tuesday"))
                {
                    datoDia = "1";
                }
                else if (diaHoy.DayOfWeek.ToString().Equals("Wednesday"))
                {
                    datoDia = "2";
                }
                else if (diaHoy.DayOfWeek.ToString().Equals("Thursday"))
                {
                    datoDia = "3";
                }
                else if (diaHoy.DayOfWeek.ToString().Equals("Friday"))
                {
                    datoDia = "4";
                }
                else if (diaHoy.DayOfWeek.ToString().Equals("Saturday"))
                {
                    datoDia = "5";
                }
                else if (diaHoy.DayOfWeek.ToString().Equals("Sunday")) //Domingo agregado
                {
                    datoDia = "6";
                }


                this.dgvProfesorxClase.Rows.Clear();
                clsProfesorxClases oProfesorxClases = new clsProfesorxClases();
                ProfesorxClase oPxC = new ProfesorxClase();
                List<ProfesorxClase> lista = oProfesorxClases.ListarClasesHoy(datoDia,txtProfesor.Text.Trim());

                foreach (ProfesorxClase item in lista)
                {
                    this.dgvProfesorxClase.Rows.Add(item.idProfesorxClase.ToString(), item.Profesor.nombre + " " + item.Profesor.apellido, item.Clase.nombre, item.fechaDesde.ToString(), (item.fechaHasta == null) ? string.Empty : item.fechaHasta.ToString(), item.dia, item.horaInicio.ToString());
                }
                dgvProfesorxClase.ClearSelection();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
            
        }

        

        private void tsbNotificar_Click(object sender, EventArgs e)
        {
            try
            {
                



                if (dgvAlumnoxClase.SelectedRows.Count > 0 && dgvAlumnoxClase.CurrentRow.Cells[0].Value != null)
                {
                    int  idAxC = Convert.ToInt32(dgvAlumnoxClase.CurrentRow.Cells[0].Value.ToString());
                    clsAlumnoxClases oAlumnosxClases = new clsAlumnoxClases();
                    AlumnoxClase oAxC = oAlumnosxClases.Obtener(idAxC);
                    clsProfesorxClases oProfesorxClase = new clsProfesorxClases();
                    ProfesorxClase oPxC = oProfesorxClase.Obtener(Convert.ToInt32(oAxC.idProfesorxClase));
                    int idPxC = oPxC.idProfesorxClase;
                    nombreDia = oPxC.dia;
                    ConvertirDia();

                    

                    frmMensaje frmMensaje = new frmMensaje(idPxC,idAxC, "Alumno", nombreDia);
                    frmMensaje.ShowDialog();                    

                }
                else if (dgvProfesorxClase.SelectedRows.Count > 0 && dgvProfesorxClase.CurrentRow.Cells[0].Value != null)
                {
                    int idPxC = Convert.ToInt32(dgvProfesorxClase.CurrentRow.Cells[0].Value.ToString());
                    nombreDia = dgvProfesorxClase.CurrentRow.Cells[5].Value.ToString();
                    ConvertirDia();

                    frmMensaje frmMensaje = new frmMensaje(idPxC,0, "Grupo", nombreDia);
                    frmMensaje.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una Clase o un Alumno", "Notificaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }

        }
        private string ConvertirDia() 
        {
            
            if (nombreDia.Equals("0"))
            {
                nombreDia = "Lunes";
            }
            else if (nombreDia.Equals("1"))
            {
                nombreDia = "Martes";
            }
            else if (nombreDia.Equals("2"))
            {
                nombreDia = "Miercoles";
            }
            else if (nombreDia.Equals("3"))
            {
                nombreDia = "Jueves";
            }
            else if (nombreDia.Equals("4"))
            {
                nombreDia = "Viernes";
            }
            else if (nombreDia.Equals("5"))
            {
                nombreDia = "Sabado";
            }
            return nombreDia;
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtAlumno.Text.Trim().Equals(""))
                {
                    LlenarDGVAlumnoxClase(dgvAlumnoxClase);
                }
                else
                {
                    LlenarDGVAlumnoxClase(dgvAlumnoxClase);
                }
                dgvAlumnoxClase.ClearSelection();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        
        private void tsbBaja_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (dgvClases.SelectedRows.Count > 0 && dgvClases.CurrentRow.Cells[0].Value != null) 
            //    {
            //        int id = Convert.ToInt32(dgvClases.CurrentRow.Cells[0].Value.ToString());
            //        clsClases oClases = new clsClases();
            //        oClases.Delete(id);
            //        LlenarDgv(dgvClases/*, ""*/);
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message.ToString());
            //    throw ex;
            //}

        }

        //private void dgvClases_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    try
        //    {
        //        if (this.dgvClases.Columns[e.ColumnIndex].Name == "colEstado")  //NUEVO TODO EL IF
        //        {
        //            if (Convert.ToString(e.Value).Equals("0"))
        //            {
        //                e.Value = "Activo";
        //            }
        //            else if (Convert.ToString(e.Value).Equals("1"))
        //            {
        //                e.Value = "Inactivo";
        //            }
        //        }

        //        if (this.dgvClases.Columns[e.ColumnIndex].Name == "colEstado")
        //        {
        //            if (Convert.ToString(e.Value).Equals("Activo"))
        //            {
        //                e.CellStyle.BackColor = Color.Green;
        //            }
        //            else if (Convert.ToString(e.Value).Equals("Inactivo"))
        //            {
        //                e.CellStyle.BackColor = Color.Red;
        //            }

        //        }

                
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message.ToString());
        //        throw ex;
        //    }

        //}

        

        //public void LlenarDGVProfesorxClase (DataGridView dgv) 
        //{
        //    int id = 0;
        //    if (dgvClases.CurrentRow != null)
        //    {
        //         id = Convert.ToInt32(dgvClases.CurrentRow.Cells[0].Value.ToString());
        //    }
            
        //    this.dgvProfesorxClase.Rows.Clear();
        //    clsProfesorxClases oProfesorxClases = new clsProfesorxClases();
        //    ProfesorxClase oPxC = new ProfesorxClase();
        //    List<ProfesorxClase> lista = oProfesorxClases.Listar(id);

        //    foreach (ProfesorxClase item in lista)
        //    {
        //        this.dgvProfesorxClase.Rows.Add(item.idProfesorxClase.ToString(), item.Profesor.nombre +" "+item.Profesor.apellido, item.Clase.nombre, item.fechaDesde.ToString(), (item.fechaHasta == null) ? string.Empty : item.fechaHasta.ToString(), item.dia, item.horaInicio.ToString());
        //    }
        //}

       

        private void dgvProfesorxClase_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (this.dgvProfesorxClase.Columns[e.ColumnIndex].Name == "colDia")
                {
                    //Color fila por dia de notificacion                  
                    int datoDiaPC = 0;
                    DateTime diaHoy = DateTime.Now;
                    if (diaHoy.DayOfWeek.ToString().Equals("Monday"))
                    {
                        datoDiaPC = 0;
                    }
                    else if (diaHoy.DayOfWeek.ToString().Equals("Tuesday"))
                    {
                        datoDiaPC = 1;
                    }
                    else if (diaHoy.DayOfWeek.ToString().Equals("Wednesday"))
                    {
                        datoDiaPC = 2;
                    }
                    else if (diaHoy.DayOfWeek.ToString().Equals("Thursday"))
                    {
                        datoDiaPC = 3;
                    }
                    else if (diaHoy.DayOfWeek.ToString().Equals("Friday"))
                    {
                        datoDiaPC = 4;
                    }
                    else if (diaHoy.DayOfWeek.ToString().Equals("Saturday"))
                    {
                        datoDiaPC = 5;
                    }
                    else if (diaHoy.DayOfWeek.ToString().Equals("Sunday")) //Domingo agregado
                    {
                        datoDiaPC = 6;
                    }

                    int hoy = datoDiaPC;
                    int mañana=0;
                    int pasado=0;

                    if (!hoy.ToString().Equals("5") && !hoy.ToString().Equals("6")) //Si no es sabado ni domingo a la hora de entrar en la seccion notificaciones
                    {
                        mañana = Convert.ToInt32(hoy) + 1;
                        pasado = Convert.ToInt32(hoy) + 2;

                    }
                    else if (hoy.ToString().Equals("5")) // sabado
                    {
                        mañana = Convert.ToInt32(hoy) + 1; //dia 6 domingo
                        pasado = 0; // 0 lunes
                    }
                    else if (hoy.ToString().Equals("6")) // domingo
                    {
                        mañana = 0; //dia 0 lunes
                        pasado = 1; // 1 MARTES
                    }




                    foreach (DataGridViewRow row in dgvProfesorxClase.Rows)
                    {
                        if (Convert.ToInt32(e.Value) == hoy)
                        {
                            row.DefaultCellStyle.BackColor = Color.Blue;
                            
                        }
                        else if (Convert.ToInt32(e.Value) == mañana)
                        {
                            row.DefaultCellStyle.BackColor = Color.DodgerBlue;
                            
                        }
                        else if (Convert.ToInt32(e.Value) == pasado)
                        {
                            row.DefaultCellStyle.BackColor = Color.SkyBlue;
                            
                        }                        

                    }
                    //Color fila por dia de notificacion




                    if (Convert.ToString(e.Value).Equals("0"))
                    {
                        e.Value = "Lunes";
                    }
                    else if (Convert.ToString(e.Value).Equals("1"))
                    {
                        e.Value = "Martes";
                    }
                    else if (Convert.ToString(e.Value).Equals("2"))
                    {
                        e.Value = "Miercoles";
                    }
                    else if (Convert.ToString(e.Value).Equals("3"))
                    {
                        e.Value = "Jueves";
                    }
                    else if (Convert.ToString(e.Value).Equals("4"))
                    {
                        e.Value = "Viernes";
                    }
                    else if (Convert.ToString(e.Value).Equals("5"))
                    {
                        e.Value = "Sabado";
                    }
                    else if (Convert.ToString(e.Value).Equals("6")) //Domingo agregado
                    {
                        e.Value = "Domingo";
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }
             
                
        private void dgvProfesorxClase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProfesorxClase.SelectedRows.Count > 0 && dgvProfesorxClase.CurrentRow.Cells[0].Value != null)
            {

                LlenarDGVAlumnoxClase(dgvAlumnoxClase);
                dgvAlumnoxClase.ClearSelection();

                
                
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila");

            }
        }

        public void LlenarDGVAlumnoxClase(DataGridView dgv)
        {
            int idPxC = 0;
            if (dgvProfesorxClase.CurrentRow != null && dgvProfesorxClase.CurrentRow.Cells[0].Value != null)
            {
                idPxC = Convert.ToInt32(dgvProfesorxClase.CurrentRow.Cells[0].Value.ToString());
            }

            this.dgvAlumnoxClase.Rows.Clear();
            clsAlumnoxClases oAlumnoxClases = new clsAlumnoxClases();
            AlumnoxClase oAxC = new AlumnoxClase();
            List<AlumnoxClase> lista = oAlumnoxClases.Listar(idPxC, txtAlumno.Text.Trim());

            clsClases oC = new clsClases();
            clsProfesorxClases oPxC = new clsProfesorxClases();
            foreach (AlumnoxClase item in lista)
            {
                this.dgvAlumnoxClase.Rows.Add(item.idAlumnoxClase.ToString(), item.idAlumno.ToString(), item.Alumno.nombre + " " + item.Alumno.apellido, (item.idProfesorxClase == null) ? string.Empty : oC.Obtener((int)oPxC.Obtener((int)item.idProfesorxClase).idClase).nombre /*item.ProfesorxClase.Clase.nombre*/, item.fechaDesde.ToString(), (item.fechaHasta == null) ? string.Empty : item.fechaHasta.ToString());
            }
            
        }

      

        private void btnBuscarClase_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtProfesor.Text.Trim().Equals(""))
                {
                    LlenarDGVPxC(dgvProfesorxClase);
                }
                else
                {
                    LlenarDGVPxC(dgvProfesorxClase);
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
