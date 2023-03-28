using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsPlanxAlumno
    {
        public PlanxAlumno Obtener(int id) //devuelve un objeto (LeerPorID)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                PlanxAlumno a = oBD.PlanxAlumno.Include("Planes").Include("EjercicioPlanAlumno").Include("Alumno").Include("Profesor").Where(x => x.idPlanxAlumno == id).FirstOrDefault();
                return a;

            }

        }
        public List<PlanxAlumno> Listar() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                //return oBD.EjercicioxPlan.ToList();
                return oBD.PlanxAlumno.Include("Planes").Include("EjercicioPlanAlumno").Include("Alumno").Include("Profesor").ToList();


            }
        }

        public List<PlanxAlumno> Listar(string stDato)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
               

                if (stDato.Equals(""))
                {
                    return oBD.PlanxAlumno.Include("Planes").Include("EjercicioPlanAlumno").Include("Alumno").Include("Profesor").ToList();
                }
                else
                {
                    return oBD.PlanxAlumno.Include("Planes").Include("EjercicioPlanAlumno").Include("Alumno").Include("Profesor").Where(x => x.Alumno.nombre.StartsWith(stDato) || x.Alumno.apellido.StartsWith(stDato)).ToList();
                }
            }
        }



        public int Guardar(PlanxAlumno oPxA)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {

                    if (oPxA.idPlanxAlumno == 0)
                    {

                        oBD.PlanxAlumno.Add(oPxA);
                        try
                        {
                            oBD.SaveChanges();
                        }
                        catch (System.Data.Entity.Validation.DbEntityValidationException e)
                        {

                            Console.WriteLine(e);
                        }


                        return oPxA.idPlanxAlumno; 
                    }


                    return oPxA.idPlanxAlumno;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int Modificar(PlanxAlumno oPxA)
        {
            using (var db = new BDGimnasioEntities())
            {
                var result = db.PlanxAlumno.SingleOrDefault(b => b.idPlanxAlumno == oPxA.idPlanxAlumno);
                if (result != null)
                {                   
                    
                    result.idPlan = oPxA.idPlan;
                    result.idAlumno = oPxA.idAlumno;    
                    result.fechaDesde = oPxA.fechaDesde;
                    result.fechaHasta = oPxA.fechaHasta;
                    result.idProfesor = oPxA.idProfesor;

                    db.SaveChanges();
                    return 0;
                }
                return 0;
            }
        }
        public int Delete(int idPxC)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                PlanxAlumno oPxA = Obtener(idPxC);
                if (oPxA != null)
                {
                    oPxA.fechaHasta = DateTime.Now;
                    oBD.PlanxAlumno.Attach(oPxA);
                    oBD.Entry(oPxA).State = System.Data.Entity.EntityState.Modified;
                    return oBD.SaveChanges();

                }
                else
                {
                    return -1;
                }

            }
        }
    }

    public class clsEjercicioPlanAlumno
    {
        //Objeto virtual
        //public class EDiagramacion
        //{
        //    public int idEjercicioxPlan { get; set; }
        //    public int idEjercicio { get; set; }
        //    public string nomEjercicio { get; set; }
        //    public int idPlan { get; set; }
        //    public string nomPlan { get; set; }
        //    public int? repeticiones { get; set; }
        //    public int? series { get; set; }

        //}

        //public List<EDiagramacion> Listar(int idPlan) //trae todo
        //{
        //    IQueryable<EDiagramacion> result;

        //    using (BDGimnasioEntities oBD = new BDGimnasioEntities())
        //    {

        //        result = from EP in oBD.EjercicioxPlan
        //                 join E in oBD.Ejercicio on EP.idEjercicio equals E.idEjercicio
        //                 join PL in oBD.Planes on EP.idPlan equals PL.idPlan
        //                 where EP.idPlan == idPlan
        //                 //Ahora armo el objeto que quiero que me devuelva
        //                 select new EDiagramacion
        //                 {
        //                     idEjercicioxPlan = EP.idEjercicioxPlan,
        //                     idEjercicio = EP.idEjercicio,
        //                     nomEjercicio = E.nombre,
        //                     idPlan = EP.idPlan,
        //                     nomPlan = PL.nombre,
        //                     repeticiones = EP.repeticiones,
        //                     series = EP.series

        //                 };
        //        return result.ToList();
        //    }
        //}

        public EjercicioPlanAlumno Obtener(int id) //devuelve un objeto (LeerPorID)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                //return null; /// oBD.clsEjercicioPlanAlumno.Select(id.ToString());


                EjercicioPlanAlumno a = oBD.EjercicioPlanAlumno.Include("Ejercicio").Include("PlanxAlumno").Where(x => x.idEjercicioPlanAlumno == id).FirstOrDefault();
                return a;

            }

        }
        public List<EjercicioPlanAlumno> Listar() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                //return oBD.EjercicioPlanAlumno.ToList();
                return oBD.EjercicioPlanAlumno.Include("Ejercicio").Include("PlanxAlumno").OrderBy(x=>x.dia).ToList(); //borrar


            }
        }

        public List<EjercicioPlanAlumno> Listar(int id) //trae todo con filtro busqueda por Nombre O Apellido O DNI Y Estado
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {


                return oBD.EjercicioPlanAlumno.Include("Ejercicio").Include("PlanxAlumno").Where(x => x.idPlanxAlumno == id).OrderBy(x=> x.dia).ToList();



            }
        }



        public int Guardar(EjercicioPlanAlumno oEPA)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {

                    if (oEPA.idEjercicioPlanAlumno == 0)//Crear antes estaba oEPA.idPlan == 0
                    {

                        oBD.EjercicioPlanAlumno.Add(oEPA);
                        oBD.SaveChanges();

                        return oEPA.idEjercicioPlanAlumno;
                    }
                    //else  //Update
                    //{

                    return oEPA.idEjercicioPlanAlumno;//BORRAR ESTO DESPUES PARA DEJARLO COMO ANTES



                    //    LO QUE ME SIRVE:
                    //    oBD.EjercicioPlanAlumno.Attach(oEPA);
                    //    oBD.Entry(oEPA).State = System.Data.Entity.EntityState.Modified;
                    //    oBD.SaveChanges();
                    //    return 0;

                    //    //oBD.EjercicioPlanAlumno.Attach(oEPA);
                    //    //return oBD.SaveChanges();



                    //}
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int Modificar(EjercicioPlanAlumno oEPA)
        {
            using (var db = new BDGimnasioEntities())
            {
                var result = db.EjercicioPlanAlumno.SingleOrDefault(b => b.idEjercicioPlanAlumno == oEPA.idEjercicioPlanAlumno);
                if (result != null)
                {

                    result.idEjercicio = oEPA.idEjercicio;
                    //result.idPlanxAlumno = oEPA.idPlanxAlumno;
                    result.series = oEPA.series;
                    result.repeticiones = oEPA.repeticiones;
                    result.observaciones = oEPA.observaciones;
                    result.dia = oEPA.dia;
                    //result.intensidadCarga = oEPA.intensidadCarga;
                    db.SaveChanges();
                    return oEPA.idEjercicioPlanAlumno;
                }
                return 0;
            }
        }

        public int Delete(int id)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {
                    EjercicioPlanAlumno e = oBD.EjercicioPlanAlumno.Where(x => x.idEjercicioPlanAlumno == id).FirstOrDefault();
                    oBD.EjercicioPlanAlumno.Remove(e);
                    oBD.SaveChanges();
                    return 1;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
