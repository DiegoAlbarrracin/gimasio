using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;

namespace TPI_1
{
    public partial class frmVisor : Form
    {
        //Prueba para hacer buscador
        private int idAlumno;
        private string nombreAlumno;
        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public int IdAlumno { get => idAlumno; set => idAlumno = value; }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            frmAlumnos frmAlumno = new frmAlumnos("frmVisor");
            AddOwnedForm(frmAlumno);

            frmAlumno.StartPosition = FormStartPosition.CenterScreen;
            frmAlumno.FormBorderStyle = FormBorderStyle.Sizable;
            frmAlumno.MinimumSize = new Size(1160, 500);
            frmAlumno.ShowDialog();

            
            txtNombreAlumno.Text = NombreAlumno;            
        }
        // Fin prueba para hacer buscador
        
        bool boTodos = false;


        public frmVisor()
        {
            InitializeComponent();
        }
        public frmVisor(int idReporte, int idEstado)
        {
            InitializeComponent();
            
            cmbReporte.SelectedIndex = idReporte;
            if(idReporte != 5)
            {
                cmbEstado.SelectedIndex = idEstado;
            }
            else
            {
                txtDNI.Text = idEstado.ToString();
            }
            
        }


        private void frmVisor_Load(object sender, EventArgs e)
        {


            cmbEstado.Visible = false;
            cmbClase.Visible = false;
            lblClase.Visible = false;
            cmbProfesor.Visible = false;
            lblProfesor.Visible = false;
            lblAlumno.Visible = false;
            lblFormato.Visible = false;
            cmbFormato.Visible = false;
            chkTodos.Visible = false;
            lblIncluirA.Visible = false;
            lblIncluirC.Visible = false;

            txtNombreAlumno.Visible = false;
            btnBuscarAlumno.Visible = false;
            btnBorrarAlumno.Visible = false;

            nudFechaDesde.Visible = false;
            nudFechaHasta.Visible = false;


            if (cmbReporte.SelectedIndex == 5)
            {
                lblFiltro.Visible = true;
                txtDNI.Visible = true;
                cmbEstado.Visible = false;
            }
            else
            {
                lblFiltro.Visible = false;
                txtDNI.Visible = false;
               
            }
            this.rpvVisor.RefreshReport();
            this.rpvVisor.RefreshReport();
            this.rpvVisor.RefreshReport();
        }
        private void CargarSubReporte(object sender, SubreportProcessingEventArgs e) 
        {
            int idPxC = Convert.ToInt32(e.Parameters["idPxC"].Values[0]); //Toma este valor por cada linea


            List<clsAlumnoxClases.EAlumnoDiag> lstD;
            if (boTodos)
            {
                lstD = new clsAlumnoxClases().ListarEAlumnoDiag(idPxC, chkTodos.Checked); //trae todos los alumnos ya que es el reporte generico
            }
            else
            {
                 lstD = new clsAlumnoxClases().ListarEAlumnoDiag(idPxC, !chkTodos.Checked); // solo activos o todos, segun se seleccione
            }
           

            ReportDataSource rdsDetalle = new ReportDataSource("DataSetAlumnosxClase", lstD);
            e.DataSources.Add(rdsDetalle); //el "e" es el subreporte de esa linea, cada vez que ejecuta la linea carga el subreporte y asi sucesivamente
        }
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            

            try
            {
               
                if (txtDNI.Text.Equals("") && cmbReporte.SelectedIndex != 7 ) //validacion para evitar que pida formato al seleccionar reporte de Asistencias
                {
                    if (cmbFormato.SelectedIndex == -1 && cmbEstado.SelectedItem.Equals("Personalizado"))
                    {
                        MessageBox.Show("Seleccione un tipo de Formato", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    }
                }


                

                switch (cmbReporte.SelectedItem)
                {

                    case "Asistencias":

                       

                        if (nudFechaDesde.Value <= nudFechaHasta.Value)
                        {
                            if (!txtNombreAlumno.Text.Trim().Equals("")) //Si hay alumno seleccionado
                            {
                                if (txtNombreAlumno.Text.Trim().Equals(""))
                                {
                                    IdAlumno = 0;
                                }
                                rpvVisor.LocalReport.DataSources.Clear();
                                //DataSetProfesorxClase dsPxC = LlenaDataset(0, 0, 0); //cambiar parametro
                                DataSetAsistencias dsAsis = LlenaDataSetAsis(IdAlumno, Convert.ToInt32(nudFechaDesde.Value), Convert.ToInt32(nudFechaHasta.Value));
                                //ReportDataSource rdsPxC = new ReportDataSource("DataSetProfesorxClase", (DataTable)dsPxC.EProfesorxClase);
                                ReportDataSource rdsA = new ReportDataSource("DataSetEAsistencias",(DataTable)dsAsis.EAsistencia);
                                //rpvVisor.LocalReport.ReportPath = @"..\..\Reportes\RDLCDiagramacionClases.rdlc";
                                rpvVisor.LocalReport.ReportPath = @"..\..\Reportes\RDLCAsistencias.rdlc";
                                //rpvVisor.LocalReport.DataSources.Add(rdsPxC);
                                rpvVisor.LocalReport.DataSources.Add(rdsA);

                                

                                ReportParameter rpNombreAlumno = new ReportParameter("ReportParameterNombreAlumno", txtNombreAlumno.Text);
                                rpvVisor.LocalReport.SetParameters(rpNombreAlumno);

                                ReportParameter rpAñoDesde = new ReportParameter("ReportParameterAñoDesde", nudFechaDesde.Value.ToString());
                                rpvVisor.LocalReport.SetParameters(rpAñoDesde);
                                ReportParameter rpAñoHasta = new ReportParameter("ReportParameterAñoHasta", nudFechaHasta.Value.ToString());
                                rpvVisor.LocalReport.SetParameters(rpAñoHasta);
                                

                                rpvVisor.RefreshReport();


                                

                            }
                            else //No hay alumno seleccionado CONTAMOS TODO
                            {
                                rpvVisor.LocalReport.DataSources.Clear();
                                //DataSetProfesorxClase dsPxC = LlenaDataset(0, 0, 0); //cambiar parametro
                                DataSetAsistencias dsAsis = LlenaDataSetAsis(0, Convert.ToInt32(nudFechaDesde.Value), Convert.ToInt32(nudFechaHasta.Value));
                                //ReportDataSource rdsPxC = new ReportDataSource("DataSetProfesorxClase", (DataTable)dsPxC.EProfesorxClase);
                                ReportDataSource rdsA = new ReportDataSource("DataSetEAsistencias", (DataTable)dsAsis.EAsistencia);
                                //rpvVisor.LocalReport.ReportPath = @"..\..\Reportes\RDLCDiagramacionClases.rdlc";
                                rpvVisor.LocalReport.ReportPath = @"..\..\Reportes\RDLCAsistencias.rdlc";
                                //rpvVisor.LocalReport.DataSources.Add(rdsPxC);
                                rpvVisor.LocalReport.DataSources.Add(rdsA);

                                

                                ReportParameter rpNombreAlumno = new ReportParameter("ReportParameterNombreAlumno", txtNombreAlumno.Text);
                                rpvVisor.LocalReport.SetParameters(rpNombreAlumno);
                                rpvVisor.RefreshReport();

                                ReportParameter rpAñoDesde = new ReportParameter("ReportParameterAñoDesde", nudFechaDesde.Value.ToString());
                                rpvVisor.LocalReport.SetParameters(rpAñoDesde);
                                ReportParameter rpAñoHasta = new ReportParameter("ReportParameterAñoHasta", nudFechaHasta.Value.ToString());
                                rpvVisor.LocalReport.SetParameters(rpAñoHasta);
                            }

                            this.rpvVisor.RefreshReport();
                        }
                        else
                        {
                            MessageBox.Show("La fecha desde no puede ser mayor a la fecha hasta");
                        }

                        

                        break;
                    /////////
                    case "Alumnos":

                        this.rpvVisor.LocalReport.ReportPath = @"..\..\Reportes\RDLCAlumnos.rdlc";
                        


                        if (cmbEstado.SelectedIndex == 0 || cmbEstado.SelectedIndex == 1)
                        {
                            rpvVisor.LocalReport.DataSources.Clear();
                            List<Alumno> lstA = new List<Alumno>();
                            lstA = new clsAlumnos().Listar("", cmbEstado.SelectedIndex.ToString());
                            ReportDataSource rdsA = new ReportDataSource("DataSetAlumno", lstA);
                            rpvVisor.LocalReport.DataSources.Add(rdsA);

                            List<Ciudad> lstC = new clsCiudades().Listar();
                            ReportDataSource rdsC = new ReportDataSource("DataSetCiudad", lstC);
                            rpvVisor.LocalReport.DataSources.Add(rdsC);

                            this.rpvVisor.RefreshReport();
                        }
                        else
                        {
                            rpvVisor.LocalReport.DataSources.Clear();
                            List<Alumno> lstA = new List<Alumno>();
                            lstA = new clsAlumnos().Listar();
                            ReportDataSource rdsA = new ReportDataSource("DataSetAlumno", lstA);
                            rpvVisor.LocalReport.DataSources.Add(rdsA);

                            List<Ciudad> lstC = new clsCiudades().Listar();
                            ReportDataSource rdsC = new ReportDataSource("DataSetCiudad", lstC);
                            rpvVisor.LocalReport.DataSources.Add(rdsC);

                            this.rpvVisor.RefreshReport();
                        }
                                              


                        this.rpvVisor.RefreshReport();

                        break;
                    case "Clases":
                        
                        if (cmbEstado.SelectedIndex != 0) //Reporte Generico
                        {
                            boTodos = true;
                            rpvVisor.LocalReport.DataSources.Clear();
                            DataSetProfesorxClase dsPxC = LlenaDataset(0,0,0); //cambiar parametro
                            ReportDataSource rdsPxC = new ReportDataSource("DataSetProfesorxClase", (DataTable)dsPxC.EProfesorxClase);
                            rpvVisor.LocalReport.ReportPath = @"..\..\Reportes\RDLCDiagramacionClases.rdlc";
                            rpvVisor.LocalReport.DataSources.Add(rdsPxC);

                            DataSetProfesorxClase dsAxC = LlenaDataset(0,0,0); ////////////////////////////////                               
                            ReportDataSource rdsAxC = new ReportDataSource("DataSetAlumnoxClase", (DataTable)dsAxC.EAlumnoxClase);
                            rpvVisor.LocalReport.ReportPath = @"..\..\Reportes\RDLCDiagramacionClases.rdlc";
                            rpvVisor.LocalReport.DataSources.Add(rdsAxC);

                            rpvVisor.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(CargarSubReporte); //va a tener subreporte y va a tener que procesarlo
                            rpvVisor.RefreshReport();
                        }
                        else // Reporte individualizado
                        {
                            boTodos = false;

                            if (txtNombreAlumno.Text.Trim().Equals(""))
                            {
                                IdAlumno = 0;
                            }


                                                        
                                rpvVisor.LocalReport.DataSources.Clear();
                                DataSetProfesorxClase dsPxC = LlenaDataset(Convert.ToInt32(cmbProfesor.SelectedValue), Convert.ToInt32(cmbClase.SelectedValue),IdAlumno ); //cambie cmbAlumno.selectedValue por IdAlumno
                                ReportDataSource rdsPxC = new ReportDataSource("DataSetProfesorxClase", (DataTable)dsPxC.EProfesorxClase);
                                rpvVisor.LocalReport.ReportPath = @"..\..\Reportes\RDLCDiagramacionClases.rdlc";
                                rpvVisor.LocalReport.DataSources.Add(rdsPxC);
                            
                                //rpvVisor.LocalReport.DataSources.Clear();
                                DataSetProfesorxClase dsAxC = LlenaDataset(Convert.ToInt32(cmbProfesor.SelectedValue), Convert.ToInt32(cmbClase.SelectedValue),IdAlumno); //cambie cmbAlumno.selectedValue por IdAlumno                              
                                ReportDataSource rdsAxC = new ReportDataSource("DataSetAlumnoxClase", (DataTable)dsAxC.EAlumnoxClase);
                                rpvVisor.LocalReport.ReportPath = @"..\..\Reportes\RDLCDiagramacionClases.rdlc";
                                rpvVisor.LocalReport.DataSources.Add(rdsAxC);
                                                                                                         
                                                                                  

                            

                            if (cmbFormato.SelectedIndex == 0) //detallado
                            {
                                ReportParameter rpDetalle = new ReportParameter("ReportParameterDetallado", "true");
                                rpvVisor.LocalReport.SetParameters(rpDetalle);
                            }
                            else
                            {
                                ReportParameter rpDetalle = new ReportParameter("ReportParameterDetallado", "false");
                                rpvVisor.LocalReport.SetParameters(rpDetalle);
                            }
                            rpvVisor.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(CargarSubReporte); //va a tener subreporte y va a tener que procesarlo
                            rpvVisor.RefreshReport();

                           

                        }
                        
                        





                        break;
                    case "Profesores":


                        this.rpvVisor.LocalReport.ReportPath = @"..\..\Reportes\RDLCProfesores.rdlc";

                        if (cmbEstado.SelectedIndex == 0 || cmbEstado.SelectedIndex == 1)
                        {
                            rpvVisor.LocalReport.DataSources.Clear();
                            List<Profesor> lstP = new clsProfesores().Listar("",cmbEstado.SelectedIndex.ToString());
                            ReportDataSource rdsP = new ReportDataSource("DataSetProfesor", lstP);
                            rpvVisor.LocalReport.DataSources.Add(rdsP);

                            List<Ciudad> lstC = new clsCiudades().Listar();
                            ReportDataSource rdsC = new ReportDataSource("DataSetCiudad", lstC);
                            rpvVisor.LocalReport.DataSources.Add(rdsC);

                            this.rpvVisor.RefreshReport();
                        }
                        else
                        {
                            rpvVisor.LocalReport.DataSources.Clear();
                            List<Profesor> lstP = new clsProfesores().Listar();
                            ReportDataSource rdsP = new ReportDataSource("DataSetProfesor", lstP);
                            rpvVisor.LocalReport.DataSources.Add(rdsP);

                            List<Ciudad> lstC = new clsCiudades().Listar();
                            ReportDataSource rdsC = new ReportDataSource("DataSetCiudad", lstC);
                            rpvVisor.LocalReport.DataSources.Add(rdsC);

                            this.rpvVisor.RefreshReport();
                        }
                        
                        this.rpvVisor.RefreshReport();

                        break;
                    case "Maquinas":

                        rpvVisor.LocalReport.ReportPath = @"..\..\Reportes\RDLCMaquinas.rdlc";
                                               

                        if (cmbEstado.SelectedIndex == 0 || cmbEstado.SelectedIndex == 1 || cmbEstado.SelectedIndex == 2)
                        {
                            rpvVisor.LocalReport.DataSources.Clear();
                            List<Maquina> lstM = new clsMaquinas().Listar("",cmbEstado.SelectedIndex.ToString()) ;
                            ReportDataSource rdsM = new ReportDataSource("DataSetMaquina", lstM);
                            rpvVisor.LocalReport.DataSources.Add(rdsM);


                            this.rpvVisor.RefreshReport();
                        }
                        else
                        {
                            rpvVisor.LocalReport.DataSources.Clear();
                            List<Maquina> lstM = new clsMaquinas().Listar();
                            ReportDataSource rdsM= new ReportDataSource("DataSetMaquina", lstM);
                            rpvVisor.LocalReport.DataSources.Add(rdsM);
                            

                            this.rpvVisor.RefreshReport();
                        }

                        this.rpvVisor.RefreshReport();

                        break;
                    case "Ejercicios":

                        rpvVisor.LocalReport.ReportPath = @"..\..\Reportes\RDLCEjercicios.rdlc";                       
                       

                        
                        if (cmbEstado.SelectedIndex == 0 || cmbEstado.SelectedIndex == 1)
                        {
                            rpvVisor.LocalReport.DataSources.Clear();
                            List<Ejercicio> lstE = new clsEjercicios().Listar("","",cmbEstado.SelectedIndex.ToString());                            
                            ReportDataSource rdsE = new ReportDataSource("DataSetEjercicioE", lstE);
                            rpvVisor.LocalReport.DataSources.Add(rdsE);


                            List<TipoEjercicio> lstTE = new clsTipoEjercicios().Listar();
                            ReportDataSource rdsTE = new ReportDataSource("DataSetTipoEjercicio", lstTE);
                            rpvVisor.LocalReport.DataSources.Add(rdsTE);

                            List<Maquina> lstM = new clsMaquinas().Listar();
                            ReportDataSource rdsM = new ReportDataSource("DataSetMaquinaE", lstM);
                            rpvVisor.LocalReport.DataSources.Add(rdsM);

                            this.rpvVisor.RefreshReport();
                        }
                        else
                        {
                            rpvVisor.LocalReport.DataSources.Clear();
                            List<Ejercicio> lstE = new clsEjercicios().Listar();
                            ReportDataSource rdsE = new ReportDataSource("DataSetEjercicioE", lstE);
                            rpvVisor.LocalReport.DataSources.Add(rdsE);


                            List<TipoEjercicio> lstTE = new clsTipoEjercicios().Listar();
                            ReportDataSource rdsTE = new ReportDataSource("DataSetTipoEjercicio", lstTE);
                            rpvVisor.LocalReport.DataSources.Add(rdsTE);

                            List<Maquina> lstM = new clsMaquinas().Listar();
                            ReportDataSource rdsM = new ReportDataSource("DataSetMaquinaE", lstM);
                            rpvVisor.LocalReport.DataSources.Add(rdsM);

                            this.rpvVisor.RefreshReport();
                        }

                        this.rpvVisor.RefreshReport();

                        break;
                    case "Planes":
                        rpvVisor.LocalReport.ReportPath = @"..\..\Reportes\RDLCPlanes.rdlc";

                        

                        if (cmbEstado.SelectedIndex == 0 || cmbEstado.SelectedIndex == 1)
                        {
                            rpvVisor.LocalReport.DataSources.Clear();
                            List<EjercicioxPlan> lstExP = new clsEjercicioxPlan().Listar();
                            ReportDataSource rdsExP = new ReportDataSource("DataSetEjercicioxPlan", lstExP);
                            rpvVisor.LocalReport.DataSources.Add(rdsExP);


                            List<Planes> lstP = new clsPlanes().Listar("",cmbEstado.SelectedIndex.ToString(),"");
                            ReportDataSource rdsP = new ReportDataSource("DataSetPlan", lstP);
                            rpvVisor.LocalReport.DataSources.Add(rdsP);


                            List<Ejercicio> lstE = new clsEjercicios().Listar();
                            ReportDataSource rdsE = new ReportDataSource("DataSetEjercicio", lstE);
                            rpvVisor.LocalReport.DataSources.Add(rdsE);

                            List<Maquina> lstM = new clsMaquinas().Listar();
                            ReportDataSource rdsM = new ReportDataSource("DataSetMaquina", lstM);
                            rpvVisor.LocalReport.DataSources.Add(rdsM);


                            List<TipoPlan> lstTE = new clsTipoPlanes().Listar();
                            ReportDataSource rdsTE = new ReportDataSource("DataSetTipoPlan", lstTE);
                            rpvVisor.LocalReport.DataSources.Add(rdsTE);

                            this.rpvVisor.RefreshReport();
                        }
                        else
                        {
                            rpvVisor.LocalReport.DataSources.Clear();
                            List<EjercicioxPlan> lstExP = new clsEjercicioxPlan().Listar();
                            ReportDataSource rdsExP = new ReportDataSource("DataSetEjercicioxPlan", lstExP);
                            rpvVisor.LocalReport.DataSources.Add(rdsExP);


                            List<Planes> lstP = new clsPlanes().Listar();
                            ReportDataSource rdsP = new ReportDataSource("DataSetPlan", lstP);
                            rpvVisor.LocalReport.DataSources.Add(rdsP);


                            List<Ejercicio> lstE = new clsEjercicios().Listar();
                            ReportDataSource rdsE = new ReportDataSource("DataSetEjercicio", lstE);
                            rpvVisor.LocalReport.DataSources.Add(rdsE);

                            List<Maquina> lstM = new clsMaquinas().Listar();
                            ReportDataSource rdsM = new ReportDataSource("DataSetMaquina", lstM);
                            rpvVisor.LocalReport.DataSources.Add(rdsM);


                            List<TipoPlan> lstTP = new clsTipoPlanes().Listar();
                            ReportDataSource rdsTP = new ReportDataSource("DataSetTipoPlan", lstTP);
                            rpvVisor.LocalReport.DataSources.Add(rdsTP);

                            this.rpvVisor.RefreshReport();
                        }

                        this.rpvVisor.RefreshReport();

                        break;

                    case "Plan de Alumno":

                        int idAlumno = 0;
                        clsAlumnos oAlumnos = new clsAlumnos();
                        Alumno oA = oAlumnos.ObtenerPorDNI(txtDNI.Text.Trim());
                        if (oA != null)
                        {
                            idAlumno = oA.idAlumno;
                        }
                        else
                        {
                            MessageBox.Show("Alumno no existente. Ingrese otro DNI","Reportes",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                           
                        }
                   

                        rpvVisor.LocalReport.ReportPath = @"..\..\Reportes\RDLCPlanPersonalizado.rdlc";

                        // TODO: esta línea de código carga datos en la tabla 'DataSetPlanPersonalizado.vPlanPersonalizado' Puede moverla o quitarla según sea necesario.
                        ReportDataSource rdsPlAl = new ReportDataSource("DataSetPlanPersonalizado", vPlanPersonalizadoBindingSource);
                        rpvVisor.LocalReport.DataSources.Add(rdsPlAl);
                        this.DataSetPlanPersonalizado.EnforceConstraints = false;
                        this.vPlanPersonalizadoTableAdapter.Fill(this.DataSetPlanPersonalizado.vPlanPersonalizado, idAlumno);
                        this.rpvVisor.RefreshReport();
                        
                        break;

                    default:
                        this.rpvVisor.Clear();
                        break;
                }
               


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            throw new NotImplementedException();
        }

    

        private DataSetAsistencias LlenaDataSetAsis(int idAl, int añoDesde, int AñoHasta) 
        {
            DataSetAsistencias dsAsis = new DataSetAsistencias();
            clsAsistencias.EAsistencias oAsis = new clsAsistencias.EAsistencias();
            List<clsAsistencias.EAsistencias> lstAsis;

           
            lstAsis = new clsAsistencias().ListarEAsistencias(idAl,añoDesde,AñoHasta);

            foreach (clsAsistencias.EAsistencias item in lstAsis)
            {
                dsAsis.EAsistencia.AddEAsistenciaRow( item.mes, item.año, item.cantidad, item.nombreAlumno);
            }

            return dsAsis;
        }

        private DataSetProfesorxClase LlenaDataset(int idP, int idC, int idA)
        {
            DataSetProfesorxClase dsPxC = new DataSetProfesorxClase();
            clsProfesorxClases.EProfesorDiag oProfDiag = new clsProfesorxClases.EProfesorDiag();
            List<clsProfesorxClases.EProfesorDiag> lstPC;

            List<clsAlumnoxClases.EAlumnoDiag> lstAC;

            if (cmbEstado.SelectedItem.Equals("Generico")) //Generico
            {
                lstPC = new clsProfesorxClases().ListarEProfesorDiag();
            }
            else if(cmbEstado.SelectedItem.Equals("Personalizado")) //Personalizadoizado
            {
                if (Convert.ToInt32(cmbProfesor.SelectedValue) != 0 && Convert.ToInt32(cmbClase.SelectedValue) != 0 && idA != 0) //Si selecciono alumno,profesor y clase
                {
                    if (!chkTodos.Checked) //Trae solo registros activos
                    {
                        lstAC = new clsAlumnoxClases().ListarEAlumnoDiagramacionAlPrCl(idA, idP, idC, true);
                    }
                    else //Trae todos los registros
                    {
                        lstAC = new clsAlumnoxClases().ListarEAlumnoDiagramacionAlPrCl(idA, idP, idC, false);
                    }

                    foreach (clsAlumnoxClases.EAlumnoDiag item in lstAC)
                    {
                        dsPxC.EAlumnoxClase.AddEAlumnoxClaseRow(item.idProfesorxClase, item.idAlumno, item.nombreAlumno, item.nombreClase, item.nombreProfesor, item.dia, item.horaInicio, (DateTime)(item.fechaHastaAxC ?? Convert.ToDateTime("1/1/1753")), (DateTime)(item.fechaHastaPxC ?? Convert.ToDateTime("1/1/1753"))); //a
                    }
                    RegistrosDevueltosAC(lstAC);
                    return dsPxC;
                }
                else if (Convert.ToInt32(cmbProfesor.SelectedValue) != 0 && Convert.ToInt32(cmbClase.SelectedValue) != 0) //Si selecciono profesor y clase
                {
                    if (!chkTodos.Checked) //Trae solo registros activos
                    {
                        lstPC = new clsProfesorxClases().ListarEProfesorDiag(idP, idC, true);
                    }
                    else //Trae todos los registros
                    {
                        lstPC = new clsProfesorxClases().ListarEProfesorDiag(idP, idC, false);
                    }

                  
                }
                else if (idA != 0 && Convert.ToInt32(cmbClase.SelectedValue) != 0) //Si selecciono alumno y clase. Cambie cmbAlumno.SelectedValue por IdAlumno
                {
                    if (!chkTodos.Checked) //Trae solo registros activos
                    {
                        lstAC = new clsAlumnoxClases().ListarEAlumnoDiagramacion(idA,idC, true);
                    }
                    else //Trae todos los registros
                    {
                        lstAC = new clsAlumnoxClases().ListarEAlumnoDiagramacion(idA,idC, false);
                    }

                    foreach (clsAlumnoxClases.EAlumnoDiag item in lstAC)
                    {
                        dsPxC.EAlumnoxClase.AddEAlumnoxClaseRow(item.idProfesorxClase, item.idAlumno, item.nombreAlumno, item.nombreClase, item.nombreProfesor, item.dia, item.horaInicio, (DateTime)(item.fechaHastaAxC ?? Convert.ToDateTime("1/1/1753")),(DateTime)(item.fechaHastaPxC ?? Convert.ToDateTime("1/1/1753")));//a
                    }
                    RegistrosDevueltosAC(lstAC);
                    return dsPxC;
                }
                else if (idA != 0 && Convert.ToInt32(cmbProfesor.SelectedValue) != 0) //Si selecciono alumno y profesor
                {
                    if (!chkTodos.Checked) //Trae solo registros activos
                    {
                        lstAC = new clsAlumnoxClases().ListarEAlumnoDiagramacionAlPr(idA, idP, true);
                    }
                    else //Trae todos los registros
                    {
                        lstAC = new clsAlumnoxClases().ListarEAlumnoDiagramacionAlPr(idA, idP, false);
                    }

                    foreach (clsAlumnoxClases.EAlumnoDiag item in lstAC)
                    {
                        dsPxC.EAlumnoxClase.AddEAlumnoxClaseRow(item.idProfesorxClase, item.idAlumno, item.nombreAlumno, item.nombreClase, item.nombreProfesor, item.dia, item.horaInicio, (DateTime)(item.fechaHastaAxC ?? Convert.ToDateTime("1/1/1753")), (DateTime)(item.fechaHastaPxC ?? Convert.ToDateTime("1/1/1753")));//a
                    }
                    RegistrosDevueltosAC(lstAC);
                    return dsPxC;
                }
                else if (Convert.ToInt32(cmbProfesor.SelectedValue) != 0) //solo profesor
                {                   
                        if (!chkTodos.Checked) //Trae solo registros activos
                        {
                            lstPC = new clsProfesorxClases().ListarEProfesorClases(idP, idC, true);
                        }
                        else //Trae todos los registros
                        {
                            lstPC = new clsProfesorxClases().ListarEProfesorClases(idP, idC,false);
                        }                    

                }
                else if (Convert.ToInt32(cmbClase.SelectedValue) != 0) //solo clase 
                {
                    if (!chkTodos.Checked) //Trae solo registros activos
                    {
                        lstPC = new clsProfesorxClases().ListarEProfesorClases(idP, idC, true);
                    }
                    else //Trae todos los registros
                    {
                        lstPC = new clsProfesorxClases().ListarEProfesorClases(idP, idC, false);
                    }
                }
                else if (idA != 0 ) // solo alumno
                {
                    if (!chkTodos.Checked) //Trae solo registros activos
                    {
                        lstAC = new clsAlumnoxClases().ListarEAlumnoDiagramacion(idA,true);
                    }
                    else //Trae todos los registros
                    {
                        lstAC = new clsAlumnoxClases().ListarEAlumnoDiagramacion(idA,false);
                    }

                    //LlenarDataSetAxC(dsPxC,lstAC);
                    foreach (clsAlumnoxClases.EAlumnoDiag item in lstAC)
                    {
                        dsPxC.EAlumnoxClase.AddEAlumnoxClaseRow(item.idProfesorxClase, item.idAlumno, item.nombreAlumno, item.nombreClase, item.nombreProfesor, item.dia, item.horaInicio, (DateTime)(item.fechaHastaAxC ?? Convert.ToDateTime("1/1/1753")), (DateTime)(item.fechaHastaPxC ?? Convert.ToDateTime("1/1/1753")));//a
                    }
                    RegistrosDevueltosAC(lstAC);
                    return dsPxC;
                }
                else // Para que no tire ese error provisional
                {
                    lstPC = new clsProfesorxClases().ListarEProfesorDiag();
                }

            }          
            else // Para que no tire ese error provisional
            {
                lstPC = new clsProfesorxClases().ListarEProfesorDiag();
            }
            

            foreach (clsProfesorxClases.EProfesorDiag item in lstPC)
            {
                dsPxC.EProfesorxClase.AddEProfesorxClaseRow(item.idProfesor, item.nombreProfesor, item.idClase, item.nombreClase, item.dia, item.horaInicio,item.idProfesorxClase, (DateTime)(item.fechaHastaPxC ?? Convert.ToDateTime("1/1/1753")));
            }


            RegistrosDevueltosPC(lstPC);
            return dsPxC;
           
        }

        private void RegistrosDevueltosPC( List<clsProfesorxClases.EProfesorDiag> lstPC)
        {
            if (lstPC.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidendias con los filtros aplicados.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void RegistrosDevueltosAC(List<clsAlumnoxClases.EAlumnoDiag> lstAC)
        {
            if (lstAC.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidendias con los filtros aplicados.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        //private DataSetProfesorxClase LlenarDataSetAxC(DataSetProfesorxClase dsPxC, List<clsAlumnoxClases.EAlumnoDiag> lstAC)
        //{
        //    foreach (clsAlumnoxClases.EAlumnoDiag item in lstAC)
        //    {
        //        dsPxC.EAlumnoxClase.AddEAlumnoxClaseRow(item.idProfesorxClase, item.idAlumno, item.nombreAlumno, item.nombreClase, item.nombreProfesor, item.dia, item.horaInicio, (DateTime)(item.fechaHastaAxC ?? Convert.ToDateTime("1/1/1753")), (DateTime)(item.fechaHastaPxC ?? Convert.ToDateTime("1/1/1753")));//a
        //    }

        //    return dsPxC;
        //}

        private void cmbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbReporte.SelectedIndex == 7)
                {
                    nudFechaDesde.Visible = true;
                    nudFechaHasta.Visible = true;
                    lblClase.Visible = true;
                    lblProfesor.Visible = true;

                    lblClase.Text = "Año Desde:";
                    lblProfesor.Text = "Año Hasta:";

                    cmbClase.Visible = false;
                    cmbProfesor.Visible = false;
                    lblFiltro.Visible = false;
                    cmbEstado.Visible = false;
                    txtDNI.Visible = false;

                    lblFormato.Visible = false;
                    cmbFormato.Visible = false;

                    chkTodos.Visible = false;
                    lblIncluirA.Visible = false;
                    lblIncluirC.Visible = false;

                    lblAlumno.Visible = true;
                    txtNombreAlumno.Visible = true;
                    btnBorrarAlumno.Visible = true;
                    btnBuscarAlumno.Visible = true;
                }

                if (cmbReporte.SelectedIndex == 5)
                {
                    lblFiltro.Location = new Point(530, 10);
                    lblFiltro.Visible = true;
                    txtDNI.Visible = true;
                    lblFiltro.Text = "Ingrese DNI:";
                    cmbEstado.Visible = false;
                    cmbClase.Visible = false;
                    lblClase.Visible = false;
                    cmbProfesor.Visible = false;
                    lblProfesor.Visible = false;

                    lblAlumno.Visible = false;
                    lblFormato.Visible = false;
                    cmbFormato.Visible = false;
                    chkTodos.Visible = false;
                    lblIncluirA.Visible = false;
                    lblIncluirC.Visible = false;

                    txtNombreAlumno.Visible = false;
                    btnBuscarAlumno.Visible = false;
                    btnBorrarAlumno.Visible = false;

                    nudFechaDesde.Visible = false;
                    nudFechaHasta.Visible = false;

                }
                else
                {
                    lblFiltro.Visible = false;
                    txtDNI.Visible = false;
                }

                if (cmbReporte.SelectedIndex == 0 || cmbReporte.SelectedIndex == 1 || cmbReporte.SelectedIndex == 3 || cmbReporte.SelectedIndex == 4 )
                {
                    cmbEstado.Items.Clear();
                    lblFiltro.Location = new Point(570, 10);
                    lblFiltro.Visible = true;
                    lblFiltro.Text = "Estado:";
                    cmbEstado.Visible = true;
                    cmbEstado.Items.Add("Activo");
                    cmbEstado.Items.Add("Inactivo");
                    cmbEstado.Items.Add("Generico");
                    cmbClase.Visible = false;
                    lblClase.Visible = false;
                    cmbProfesor.Visible = false;
                    lblProfesor.Visible = false;

                    lblAlumno.Visible = false;
                    lblFormato.Visible = false;
                    cmbFormato.Visible = false;
                    chkTodos.Visible = false;
                    lblIncluirA.Visible = false;
                    lblIncluirC.Visible = false;

                    txtNombreAlumno.Visible = false;
                    btnBuscarAlumno.Visible = false;
                    btnBorrarAlumno.Visible = false;

                    nudFechaDesde.Visible = false;
                    nudFechaHasta.Visible = false;
                }
                else if (cmbReporte.SelectedIndex == 2)
                {
                    lblFiltro.Location = new Point(570, 10);
                    cmbEstado.Items.Clear();
                    lblFiltro.Visible = true;
                    lblFiltro.Text = "Estado:";
                    cmbEstado.Visible = true;
                    cmbEstado.Items.Add("Activo");
                    cmbEstado.Items.Add("Inactivo");
                    cmbEstado.Items.Add("Reparacion");
                    cmbEstado.Items.Add("Todas");
                    cmbClase.Visible = false;
                    lblClase.Visible = false;
                    cmbProfesor.Visible = false;
                    lblProfesor.Visible = false;

                    lblAlumno.Visible = false;
                    lblFormato.Visible = false;
                    cmbFormato.Visible = false;
                    chkTodos.Visible = false;
                    lblIncluirA.Visible = false;
                    lblIncluirC.Visible = false;

                    txtNombreAlumno.Visible = false;
                    btnBuscarAlumno.Visible = false;
                    btnBorrarAlumno.Visible = false;

                    nudFechaDesde.Visible = false;
                    nudFechaHasta.Visible = false;
                }

                if (cmbReporte.SelectedIndex == 6)
                {
                    cmbEstado.Items.Clear();
                    lblFiltro.Location = new Point(563, 10);
                    lblFiltro.Visible = true;
                    lblFiltro.Text = "Traer:";
                    cmbEstado.Visible = true;
                    cmbEstado.Items.Add("Personalizado");
                    cmbEstado.Items.Add("Generico");
                    cmbEstado.SelectedIndex = 1; //Cuidado

                    nudFechaDesde.Visible = false;
                    nudFechaHasta.Visible = false;
                    lblClase.Text = "Seleccione Clase:";
                    lblProfesor.Text = "Profesor:";

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void tsbCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbReporte.SelectedIndex == 6 && cmbEstado.SelectedIndex == 0)
                {
                    lblClase.Visible = true;
                    cmbClase.Visible = true;
                    cmbProfesor.Visible = true;
                    lblProfesor.Visible = true;
                    LlenarComboProfesor(cmbProfesor);
                    LlenarComboClase(cmbClase);
                    cmbClase.SelectedValue = 0;
                    cmbProfesor.SelectedValue = 0;

                    lblAlumno.Visible = true;
                    lblFormato.Visible = true;
                    cmbFormato.Visible = true;
                    chkTodos.Visible = true;
                    lblIncluirA.Visible = true;
                    lblIncluirC.Visible = true;

                    txtNombreAlumno.Visible = true;
                    btnBuscarAlumno.Visible = true;
                    btnBorrarAlumno.Visible = true;
                }
                else
                {
                    lblClase.Visible = false;
                    cmbClase.Visible = false;
                    cmbProfesor.Visible = false;
                    lblProfesor.Visible = false;

                    lblAlumno.Visible = false;
                    lblFormato.Visible = false;
                    cmbFormato.Visible = false;
                    chkTodos.Visible = false;
                    lblIncluirA.Visible = false;
                    lblIncluirC.Visible = false;

                    txtNombreAlumno.Visible = false;
                    btnBuscarAlumno.Visible = false;
                    btnBorrarAlumno.Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        public void LlenarComboProfesor(ComboBox cmb)
        {
            clsProfesores oProfesores = new clsProfesores();

            cmb.ValueMember = "idProfesor";
            //cmb.DisplayMember = "nombre";            
            cmb.DataSource = oProfesores.Listar();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            List<Profesor> lista = oProfesores.Listar();
            foreach (Profesor i in lista)
            {
                coleccion.Add(Convert.ToString(i.nombre + " " + i.apellido));
            }
            cmb.AutoCompleteCustomSource = coleccion;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
        }
        public void LlenarComboClase(ComboBox cmb)
        {
            //clsProfesores oProfesores = new clsProfesores();
            clsClases oClases = new clsClases();

            cmb.ValueMember = "idClase";
            cmb.DisplayMember = "nombre";            
            cmb.DataSource = oClases.Listar();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            List<Clase> lista = oClases.Listar();
            foreach (Clase i in lista)
            {
                coleccion.Add(Convert.ToString(i.nombre));
            }
            cmb.AutoCompleteCustomSource = coleccion;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
        }
        public void LlenarComboAlumno(ComboBox cmb)
        {
            //clsProfesores oProfesores = new clsProfesores();
            clsAlumnos oAlumnos = new clsAlumnos();

            cmb.ValueMember = "idAlumno";
            //cmb.DisplayMember = "nombre";            
            cmb.DataSource = oAlumnos.Listar();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            List<Alumno> lista = oAlumnos.Listar();
            foreach (Alumno i in lista)
            {
                coleccion.Add(Convert.ToString(i.nombre + " " + i.apellido));
            }
            cmb.AutoCompleteCustomSource = coleccion;
            cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void cmbProfesor_Format(object sender, ListControlConvertEventArgs e)
        {
            // Codigo para que aparezca tanto nombre como apellido en el displaymember del cmbProfesor
            string nombre = ((Profesor)e.ListItem).nombre;
            string apellido = ((Profesor)e.ListItem).apellido;
            e.Value = nombre + " " + apellido;
        }

        private void cmbAlumno_Format(object sender, ListControlConvertEventArgs e)
        {
            // Codigo para que aparezca tanto nombre como apellido en el displaymember del cmbProfesor
            string nombre = ((Alumno)e.ListItem).nombre;
            string apellido = ((Alumno)e.ListItem).apellido;
            e.Value = nombre + " " + apellido;
        }

        private void btnBorrarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                txtNombreAlumno.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                throw ex;
            }
        }

        
    }
}
