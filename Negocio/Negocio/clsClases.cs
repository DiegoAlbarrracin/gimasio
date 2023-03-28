using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsClases
    {
        public Clase Obtener(int id) //devuelve un objeto (LeerPorID)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                //return null; /// oBD.Clase.Select(id.ToString());


                Clase c = oBD.Clase.Where(x => x.idClase == id).FirstOrDefault();
                return c;

            }



        }
        public List<Clase> Listar() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                //return oBD.Clase.ToList();
                return oBD.Clase.Include("ProfesorxClase").ToList(); 

            }
        }

        public List<Clase> Listar(string stDato, string stEstado)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                if (stDato.Equals(""))
                {
                    return oBD.Clase.Include("ProfesorxClase").Where(x => x.estado == stEstado).ToList(); 
                }
                else
                {
                    return oBD.Clase.Include("ProfesorxClase").Where(x => (x.nombre.StartsWith(stDato)) && x.estado == stEstado).ToList(); 
                }

            }
        }



        public int Guardar(Clase oC)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {

                    if (oC.idClase == 0)//Crear
                    {

                        oBD.Clase.Add(oC);
                        oBD.SaveChanges();

                        return oC.idClase;
                    }
                    else  //Update
                    {
                        oBD.Clase.Attach(oC);
                        oBD.Entry(oC).State = System.Data.Entity.EntityState.Modified;
                        oBD.SaveChanges();
                        return 0;

                       



                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int Delete(int idC)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                Clase oC = Obtener(idC);
                if (oC != null)
                {
                    oC.estado = "1";
                    oC.fechaHasta = DateTime.Now;
                    oBD.Clase.Attach(oC);
                    oBD.Entry(oC).State = System.Data.Entity.EntityState.Modified;

                    return oBD.SaveChanges();
                }
                else
                {
                    return -1;
                }

            }
        }
    }

    public class clsProfesorxClases 
    {
       

        public ProfesorxClase Obtener(int id) //devuelve un objeto (LeerPorID)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                


                ProfesorxClase a = oBD.ProfesorxClase.Include("Profesor").Include("Clase").Where(x => x.idProfesorxClase == id).FirstOrDefault();
                return a;

            }

        }
        public List<ProfesorxClase> Listar() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                //return oBD.EjercicioxPlan.ToList();
                return oBD.ProfesorxClase.Include("Profesor").Include("Clase").ToList(); 


            }
        }

        public List<ProfesorxClase> Listar(int id) 
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {


                return oBD.ProfesorxClase.Include("Profesor").Include("Clase").Where(x => x.idClase == id).ToList();



            }
        }

        public List<ProfesorxClase> ListarClasesHoy(string diaHoy, string dato)
        {
           
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                int mañana = 0;
                int pasadoMañana= 0;
                if (!diaHoy.Equals("5") && !diaHoy.Equals("6")) //Si no es sabado ni domingo a la hora de entrar en la seccion notificaciones
                {
                    mañana = Convert.ToInt32(diaHoy) + 1;
                    pasadoMañana = Convert.ToInt32(diaHoy) + 2;

                }
                else if (diaHoy.Equals("5")) // sabado
                {
                    mañana = Convert.ToInt32(diaHoy) + 1; //dia 6 domingo
                    pasadoMañana = 0; // 0 lunes
                }
                else if (diaHoy.Equals("6")) // domingo
                {
                    mañana = 0; //dia 0 lunes
                    pasadoMañana = 1; // 1 MARTES
                }


                if (dato.Equals(""))
                {
                    
                    return oBD.ProfesorxClase.Include("Profesor").Include("Clase").Where(x => (x.dia == diaHoy || x.dia == mañana.ToString() || x.dia == pasadoMañana.ToString()) && x.fechaHasta == null).OrderBy(x => x.dia).ThenBy(x=>x.horaInicio).ToList();
                }
                else
                {
                    return oBD.ProfesorxClase.Include("Profesor").Include("Clase").Where(x => (x.dia == diaHoy || x.dia == mañana.ToString() || x.dia == pasadoMañana.ToString()) && x.fechaHasta == null && x.Clase.nombre.Contains(dato)).OrderBy(x => x.dia).ThenBy(x => x.horaInicio).ToList();
                }
                

            }
        }

        public int Guardar(ProfesorxClase oExP)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {

                    if (oExP.idProfesorxClase == 0)
                    {

                        oBD.ProfesorxClase.Add(oExP);
                        try
                        {
                            oBD.SaveChanges();
                        }
                        catch (System.Data.Entity.Validation.DbEntityValidationException e)
                        {

                            Console.WriteLine(e);
                        }
                        

                        return oExP.idClase;
                    }
                   

                    return oExP.idClase;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int Modificar(ProfesorxClase oPxC)
        {
            using (var db = new BDGimnasioEntities())
            {
                var result = db.ProfesorxClase.SingleOrDefault(b => b.idProfesorxClase == oPxC.idProfesorxClase);
                if (result != null)
                {
                    result.idProfesor = oPxC.idProfesor;
                    //result.idClase = oPxC.idClase;

                    result.horaInicio = oPxC.horaInicio;

                    result.fechaDesde = oPxC.fechaDesde;
                    result.fechaHasta = oPxC.fechaHasta;
                    result.dia = oPxC.dia;
                  


                    db.SaveChanges();
                    return oPxC.idProfesorxClase;
                }
                return 0;
            }
        }
        public int Delete(int idPxC)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                ProfesorxClase oPxC = Obtener(idPxC);
                if (oPxC != null)
                {
                    oPxC.fechaHasta = DateTime.Now;
                    oBD.ProfesorxClase.Attach(oPxC);
                    oBD.Entry(oPxC).State = System.Data.Entity.EntityState.Modified;
                    return oBD.SaveChanges();                    
              
                }
                else
                {
                    return -1;
                }

            }
        }

        //Objeto virtual para llenar data set
        public class EProfesorDiag
        {
            public int idProfesorxClase { get; set; }
            public int idProfesor { get; set; }
            public string nombreProfesor { get; set; }
            public int idClase { get; set; }
            public string nombreClase { get; set; }
            public string dia { get; set; }
            public string horaInicio { get; set; }
            public DateTime? fechaHastaPxC { get; set; }

        }
        public List<EProfesorDiag> ListarEProfesorDiag()
        {
            IQueryable<EProfesorDiag> result;

            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                result = from PC in oBD.ProfesorxClase
                         join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                         join C in oBD.Clase on PC.idClase equals C.idClase                         
                         select new EProfesorDiag
                         {
                             idProfesorxClase = (int)PC.idProfesorxClase,
                             idProfesor = (int)PC.idProfesor,
                             nombreProfesor = P.nombre + " " + P.apellido,
                             idClase = (int)PC.idClase,
                             nombreClase = C.nombre,
                             dia = PC.dia,
                             fechaHastaPxC = PC.fechaHasta,
                             horaInicio = PC.horaInicio

                         };
                return result.ToList();
            }

        }
        public List<EProfesorDiag> ListarEProfesorDiag(int idProfesor, int idClase, bool soloActivos)
        {
            IQueryable<EProfesorDiag> result;

            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                if (soloActivos) //trae solo diagramaciones activas
                {
                    result = from PC in oBD.ProfesorxClase
                             join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                             join C in oBD.Clase on PC.idClase equals C.idClase
                             where PC.idProfesor == idProfesor && PC.idClase == idClase && PC.fechaHasta == null
                             select new EProfesorDiag
                             {
                                 idProfesorxClase = (int)PC.idProfesorxClase,
                                 idProfesor = (int)PC.idProfesor,
                                 nombreProfesor = P.nombre + " " + P.apellido,
                                 idClase = (int)PC.idClase,
                                 nombreClase = C.nombre,
                                 dia = PC.dia,
                                 fechaHastaPxC = PC.fechaHasta,
                                 horaInicio = PC.horaInicio

                             };
                }
                else //trae todas
                {
                    result = from PC in oBD.ProfesorxClase
                             join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                             join C in oBD.Clase on PC.idClase equals C.idClase
                             where PC.idProfesor == idProfesor && PC.idClase == idClase
                             select new EProfesorDiag
                             {
                                 idProfesorxClase = (int)PC.idProfesorxClase,
                                 idProfesor = (int)PC.idProfesor,
                                 nombreProfesor = P.nombre + " " + P.apellido,
                                 idClase = (int)PC.idClase,
                                 nombreClase = C.nombre,
                                 dia = PC.dia,
                                 fechaHastaPxC = PC.fechaHasta,
                                 horaInicio = PC.horaInicio

                             };
                }
               
                return result.ToList();
            }

        }

       
        public List<EProfesorDiag> ListarEProfesorClases(int idProfesor, int idClase, bool soloActivos)
        {
            IQueryable<EProfesorDiag> result;

            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                if (idProfesor == 0)
                {
                    if (soloActivos) //trae solo diagramaciones activas
                    {
                        result = from PC in oBD.ProfesorxClase
                                 join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                                 join C in oBD.Clase on PC.idClase equals C.idClase
                                 where  PC.fechaHasta == null && PC.idClase == idClase
                                 select new EProfesorDiag
                                 {
                                     idProfesorxClase = (int)PC.idProfesorxClase,
                                     idProfesor = (int)PC.idProfesor,
                                     nombreProfesor = P.nombre + " " + P.apellido,
                                     idClase = (int)PC.idClase,
                                     nombreClase = C.nombre,
                                     dia = PC.dia,
                                     fechaHastaPxC = PC.fechaHasta,
                                     horaInicio = PC.horaInicio

                                 };
                    }
                    else //trae todas
                    {
                        result = from PC in oBD.ProfesorxClase
                                 join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                                 join C in oBD.Clase on PC.idClase equals C.idClase
                                 where  PC.idClase == idClase
                                 select new EProfesorDiag
                                 {
                                     idProfesorxClase = (int)PC.idProfesorxClase,
                                     idProfesor = (int)PC.idProfesor,
                                     nombreProfesor = P.nombre + " " + P.apellido,
                                     idClase = (int)PC.idClase,
                                     nombreClase = C.nombre,
                                     dia = PC.dia,
                                     fechaHastaPxC = PC.fechaHasta,
                                     horaInicio = PC.horaInicio

                                 };
                    }
                }
                else
                {
                    if (soloActivos) //trae solo diagramaciones activas
                    {
                        result = from PC in oBD.ProfesorxClase
                                 join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                                 join C in oBD.Clase on PC.idClase equals C.idClase
                                 where (PC.idProfesor == idProfesor && PC.fechaHasta == null) || (PC.idClase == idClase)
                                 select new EProfesorDiag
                                 {
                                     idProfesorxClase = (int)PC.idProfesorxClase,
                                     idProfesor = (int)PC.idProfesor,
                                     nombreProfesor = P.nombre + " " + P.apellido,
                                     idClase = (int)PC.idClase,
                                     nombreClase = C.nombre,
                                     dia = PC.dia,
                                     fechaHastaPxC = PC.fechaHasta,
                                     horaInicio = PC.horaInicio

                                 };
                    }
                    else //trae todas
                    {
                        result = from PC in oBD.ProfesorxClase
                                 join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                                 join C in oBD.Clase on PC.idClase equals C.idClase
                                 where PC.idProfesor == idProfesor || PC.idClase == idClase
                                 select new EProfesorDiag
                                 {
                                     idProfesorxClase = (int)PC.idProfesorxClase,
                                     idProfesor = (int)PC.idProfesor,
                                     nombreProfesor = P.nombre + " " + P.apellido,
                                     idClase = (int)PC.idClase,
                                     nombreClase = C.nombre,
                                     dia = PC.dia,
                                     fechaHastaPxC = PC.fechaHasta,
                                     horaInicio = PC.horaInicio

                                 };
                    }
                }

                
               
                return result.ToList();
            }

        }

    }

    public class clsAlumnoxClases
    {


        public AlumnoxClase Obtener(int id) //devuelve un objeto (LeerPorID)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {



                AlumnoxClase a = oBD.AlumnoxClase.Include("Alumno").Include("ProfesorxClase").Where(x => x.idAlumnoxClase == id).FirstOrDefault();
                return a;

            }

        }
        public List<AlumnoxClase> Listar() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                //return oBD.EjercicioxPlan.ToList();
                return oBD.AlumnoxClase.Include("Alumno").Include("ProfesorxClase").ToList();


            }
        }

        public List<AlumnoxClase> Listar(int id)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {


                return oBD.AlumnoxClase.Include("Alumno").Include("ProfesorxClase").Where(x => x.idProfesorxClase == id && x.fechaHasta == null).ToList(); //cuiado con segunda condicion



            }
        }

        public List<AlumnoxClase> Listar(int id, string dato)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                if (dato.Equals(""))
                {
                    return oBD.AlumnoxClase.Include("Alumno").Include("ProfesorxClase").Where(x => x.idProfesorxClase == id && x.fechaHasta == null).ToList();

                }
                else
                {
                    return oBD.AlumnoxClase.Include("Alumno").Include("ProfesorxClase").Where(x => x.idProfesorxClase == id && x.fechaHasta == null && (x.Alumno.nombre.StartsWith(dato) || x.Alumno.apellido.StartsWith(dato))).ToList();
                }




            }
        }

        public int Guardar(AlumnoxClase oExP)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {

                    if (oExP.idAlumnoxClase == 0)
                    {

                        oBD.AlumnoxClase.Add(oExP);
                        try
                        {
                            oBD.SaveChanges();
                        }
                        catch (System.Data.Entity.Validation.DbEntityValidationException e)
                        {

                            Console.WriteLine(e);
                        }


                        return oExP.idAlumnoxClase;
                    }


                    return oExP.idAlumnoxClase;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int Modificar(AlumnoxClase oAxC)
        {
            using (var db = new BDGimnasioEntities())
            {
                var result = db.AlumnoxClase.SingleOrDefault(b => b.idAlumnoxClase == oAxC.idAlumnoxClase);
                if (result != null)
                {
                    result.idAlumno = oAxC.idAlumno;
                    //result.idClase = oAxC.idClase;                   

                    result.fechaDesde = oAxC.fechaDesde;
                    result.fechaHasta = oAxC.fechaHasta;
                    result.idProfesorxClase = oAxC.idProfesorxClase;



                    db.SaveChanges();
                    return oAxC.idAlumnoxClase;
                }
                return 0;
            }
        }
        public int Delete(int idAxC)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                AlumnoxClase oAxC = Obtener(idAxC);
                if (oAxC != null)
                {
                    oAxC.fechaHasta = DateTime.Now;
                    oBD.AlumnoxClase.Attach(oAxC);
                    oBD.Entry(oAxC).State = System.Data.Entity.EntityState.Modified;
                    return oBD.SaveChanges();

                }
                else
                {
                    return -1;
                }

            }
        }

        //Objeto virtual para llenar data set
        public class EAlumnoDiag 
        {
            public int idProfesorxClase { get; set; }
            public int idAlumno { get; set; }
            public string nombreAlumno { get; set; }                     
            
            public DateTime? fechaHastaAxC { get; set; }
            public DateTime? fechaHastaPxC { get; set; }
            //cuidado de aca para abajo

            public string nombreClase { get; set; }
            public string nombreProfesor { get; set; }
            public string dia { get; set; }
            public string horaInicio { get; set; }

            

        }
        public List<EAlumnoDiag> ListarEAlumnoDiagramacion(int idA, bool soloActivos)  
        {
            IQueryable<EAlumnoDiag> result;

            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                if (soloActivos) //Trae solo los registros activos
                {
                    result = from AC in oBD.AlumnoxClase
                             join A in oBD.Alumno on AC.idAlumno equals A.idAlumno
                             join PC in oBD.ProfesorxClase on AC.idProfesorxClase equals PC.idProfesorxClase //cuiado de aca hacia abajo
                             join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                             join C in oBD.Clase on PC.idClase equals C.idClase
                             where AC.idAlumno == idA && AC.fechaHasta == null
                             select new EAlumnoDiag
                             {
                                 idProfesorxClase = (int)AC.idProfesorxClase,
                                 idAlumno = (int)AC.idAlumno,
                                 nombreAlumno = A.nombre + " " + A.apellido,

                                 //fechaDesde = AC.fechaDesde,
                                 fechaHastaAxC = AC.fechaHasta, //cuidado
                                 fechaHastaPxC = PC.fechaHasta,

                                 nombreClase = C.nombre,
                                 nombreProfesor = P.nombre + " " + P.apellido,
                                 dia = PC.dia,
                                 horaInicio = PC.horaInicio

                             };
                }
                else //Trae todos
                {
                    result = from AC in oBD.AlumnoxClase
                             join A in oBD.Alumno on AC.idAlumno equals A.idAlumno
                             join PC in oBD.ProfesorxClase on AC.idProfesorxClase equals PC.idProfesorxClase //cuiado de aca hacia abajo
                             join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                             join C in oBD.Clase on PC.idClase equals C.idClase
                             where AC.idAlumno == idA
                             select new EAlumnoDiag
                             {
                                 idProfesorxClase = (int)AC.idProfesorxClase,
                                 idAlumno = (int)AC.idAlumno,
                                 nombreAlumno = A.nombre + " " + A.apellido,
                                 //fechaDesde = AC.fechaDesde,
                                 fechaHastaAxC = AC.fechaHasta, //cuidado
                                 fechaHastaPxC = PC.fechaHasta,

                                 nombreClase = C.nombre,
                                 nombreProfesor = P.nombre + " " + P.apellido,
                                 dia = PC.dia,
                                 horaInicio = PC.horaInicio

                             };
                }
                
                return result.ToList();
            }

        }

        public List<EAlumnoDiag> ListarEAlumnoDiagramacion(int idA, int idC , bool soloActivos) //Para la seleccion de Alumno y Clase
        {
            IQueryable<EAlumnoDiag> result;

            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                if (soloActivos) //Trae solo los registros activos
                {
                    result = from AC in oBD.AlumnoxClase
                             join A in oBD.Alumno on AC.idAlumno equals A.idAlumno
                             join PC in oBD.ProfesorxClase on AC.idProfesorxClase equals PC.idProfesorxClase //cuiado de aca hacia abajo
                             join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                             join C in oBD.Clase on PC.idClase equals C.idClase
                             where AC.idAlumno == idA && AC.fechaHasta == null && PC.idClase == idC && PC.fechaHasta == null
                             select new EAlumnoDiag
                             {
                                 idProfesorxClase = (int)AC.idProfesorxClase,
                                 idAlumno = (int)AC.idAlumno,
                                 nombreAlumno = A.nombre + " " + A.apellido,

                                 //fechaDesde = AC.fechaDesde,
                                 fechaHastaAxC = AC.fechaHasta, //cuidado
                                 fechaHastaPxC = PC.fechaHasta,

                                 nombreClase = C.nombre,
                                 nombreProfesor = P.nombre + " " + P.apellido,
                                 dia = PC.dia,
                                 horaInicio = PC.horaInicio

                             };
                }
                else //Trae todos
                {
                    result = from AC in oBD.AlumnoxClase
                             join A in oBD.Alumno on AC.idAlumno equals A.idAlumno
                             join PC in oBD.ProfesorxClase on AC.idProfesorxClase equals PC.idProfesorxClase //cuiado de aca hacia abajo
                             join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                             join C in oBD.Clase on PC.idClase equals C.idClase
                             where AC.idAlumno == idA && PC.idClase == idC
                             select new EAlumnoDiag
                             {
                                 idProfesorxClase = (int)AC.idProfesorxClase,
                                 idAlumno = (int)AC.idAlumno,
                                 nombreAlumno = A.nombre + " " + A.apellido,

                                 //fechaDesde = AC.fechaDesde,
                                 fechaHastaAxC = AC.fechaHasta, //cuidado
                                 fechaHastaPxC = PC.fechaHasta,

                                 nombreClase = C.nombre,
                                 nombreProfesor = P.nombre + " " + P.apellido,
                                 dia = PC.dia,
                                 horaInicio = PC.horaInicio

                             };
                }

                return result.ToList();
            }

        }

        public List<EAlumnoDiag> ListarEAlumnoDiagramacionAlPr(int idA, int idP, bool soloActivos) //Para la seleccion de Alumno y Profesor
        {
            IQueryable<EAlumnoDiag> result;

            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                if (soloActivos) //Trae solo los registros activos
                {
                    result = from AC in oBD.AlumnoxClase
                             join A in oBD.Alumno on AC.idAlumno equals A.idAlumno
                             join PC in oBD.ProfesorxClase on AC.idProfesorxClase equals PC.idProfesorxClase //cuiado de aca hacia abajo
                             join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                             join C in oBD.Clase on PC.idClase equals C.idClase
                             where AC.idAlumno == idA && AC.fechaHasta == null && PC.idProfesor == idP && PC.fechaHasta == null
                             select new EAlumnoDiag
                             {
                                 idProfesorxClase = (int)AC.idProfesorxClase,
                                 idAlumno = (int)AC.idAlumno,
                                 nombreAlumno = A.nombre + " " + A.apellido,

                                 //fechaDesde = AC.fechaDesde,
                                 fechaHastaAxC = AC.fechaHasta, //cuidado
                                 fechaHastaPxC = PC.fechaHasta,

                                 nombreClase = C.nombre,
                                 nombreProfesor = P.nombre + " " + P.apellido,
                                 dia = PC.dia,
                                 horaInicio = PC.horaInicio

                             };
                }
                else //Trae todos
                {
                    result = from AC in oBD.AlumnoxClase
                             join A in oBD.Alumno on AC.idAlumno equals A.idAlumno
                             join PC in oBD.ProfesorxClase on AC.idProfesorxClase equals PC.idProfesorxClase //cuiado de aca hacia abajo
                             join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                             join C in oBD.Clase on PC.idClase equals C.idClase
                             where AC.idAlumno == idA && PC.idProfesor == idP
                             select new EAlumnoDiag
                             {
                                 idProfesorxClase = (int)AC.idProfesorxClase,
                                 idAlumno = (int)AC.idAlumno,
                                 nombreAlumno = A.nombre + " " + A.apellido,

                                 //fechaDesde = AC.fechaDesde,
                                 fechaHastaAxC = AC.fechaHasta, //cuidado
                                 fechaHastaPxC = PC.fechaHasta,

                                 nombreClase = C.nombre,
                                 nombreProfesor = P.nombre + " " + P.apellido,
                                 dia = PC.dia,
                                 horaInicio = PC.horaInicio

                             };
                }

                return result.ToList();
            }

        }

        public List<EAlumnoDiag> ListarEAlumnoDiagramacionAlPrCl(int idA, int idP, int idC , bool soloActivos) //Para la seleccion de Alumno y Profesor
        {
            IQueryable<EAlumnoDiag> result;

            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                if (soloActivos) //Trae solo los registros activos
                {
                    result = from AC in oBD.AlumnoxClase
                             join A in oBD.Alumno on AC.idAlumno equals A.idAlumno
                             join PC in oBD.ProfesorxClase on AC.idProfesorxClase equals PC.idProfesorxClase //cuiado de aca hacia abajo
                             join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                             join C in oBD.Clase on PC.idClase equals C.idClase
                             where AC.idAlumno == idA && AC.fechaHasta == null && PC.idProfesor == idP && PC.fechaHasta == null && PC.idClase == idC 
                             select new EAlumnoDiag
                             {
                                 idProfesorxClase = (int)AC.idProfesorxClase,
                                 idAlumno = (int)AC.idAlumno,
                                 nombreAlumno = A.nombre + " " + A.apellido,

                                 //fechaDesde = AC.fechaDesde,
                                 fechaHastaAxC = AC.fechaHasta, //cuidado
                                 fechaHastaPxC = PC.fechaHasta,

                                 nombreClase = C.nombre,
                                 nombreProfesor = P.nombre + " " + P.apellido,
                                 dia = PC.dia,
                                 horaInicio = PC.horaInicio

                             };
                }
                else //Trae todos
                {
                    result = from AC in oBD.AlumnoxClase
                             join A in oBD.Alumno on AC.idAlumno equals A.idAlumno
                             join PC in oBD.ProfesorxClase on AC.idProfesorxClase equals PC.idProfesorxClase //cuiado de aca hacia abajo
                             join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                             join C in oBD.Clase on PC.idClase equals C.idClase
                             where AC.idAlumno == idA && PC.idProfesor == idP && PC.idClase == idC
                             select new EAlumnoDiag
                             {
                                 idProfesorxClase = (int)AC.idProfesorxClase,
                                 idAlumno = (int)AC.idAlumno,
                                 nombreAlumno = A.nombre + " " + A.apellido,

                                 //fechaDesde = AC.fechaDesde,
                                 fechaHastaAxC = AC.fechaHasta, //cuidado
                                 fechaHastaPxC = PC.fechaHasta,

                                 nombreClase = C.nombre,
                                 nombreProfesor = P.nombre + " " + P.apellido,
                                 dia = PC.dia,
                                 horaInicio = PC.horaInicio

                             };
                }

                return result.ToList();
            }

        }

        public List<EAlumnoDiag> ListarEAlumnoDiag(int idPxC, bool soloActivos)  //Devuelve todos los alumnos de determinada diagramacion de clase
        {
            IQueryable<EAlumnoDiag> result;

            using (BDGimnasioEntities oBD = new BDGimnasioEntities()) 
            {
                if (soloActivos) //trae solo los alumnos activos de dicha diagramacion clase
                {
                    result = from AC in oBD.AlumnoxClase
                             join A in oBD.Alumno on AC.idAlumno equals A.idAlumno
                             join PC in oBD.ProfesorxClase on AC.idProfesorxClase equals PC.idProfesorxClase //cuiado de aca hacia abajo
                             join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                             join C in oBD.Clase on PC.idClase equals C.idClase
                             where AC.idProfesorxClase == idPxC && AC.fechaHasta == null //Cuidado con la segunda condicion
                             select new EAlumnoDiag
                             {
                                 idProfesorxClase = (int)AC.idProfesorxClase,
                                 idAlumno = (int)AC.idAlumno,
                                 nombreAlumno = A.nombre + " " + A.apellido,

                                 //fechaDesde = AC.fechaDesde,
                                 fechaHastaAxC = AC.fechaHasta, //cuidado
                                 fechaHastaPxC = PC.fechaHasta

                             };
                }
                else //trae todos los alumnos que asistieron alguna vez a esa diagramacion de clase
                {
                    result = from AC in oBD.AlumnoxClase
                             join A in oBD.Alumno on AC.idAlumno equals A.idAlumno
                             join PC in oBD.ProfesorxClase on AC.idProfesorxClase equals PC.idProfesorxClase //cuiado de aca hacia abajo
                             join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                             join C in oBD.Clase on PC.idClase equals C.idClase
                             where AC.idProfesorxClase == idPxC 
                             select new EAlumnoDiag
                             {
                                 idProfesorxClase = (int)AC.idProfesorxClase,
                                 idAlumno = (int)AC.idAlumno,
                                 nombreAlumno = A.nombre + " " + A.apellido,

                                 //fechaDesde = AC.fechaDesde,
                                 fechaHastaAxC = AC.fechaHasta, //cuidado
                                 fechaHastaPxC = PC.fechaHasta

                             };
                }
               
                return result.ToList();
            }

        }
        //Objeto virtual para llenar data set
    }
}
