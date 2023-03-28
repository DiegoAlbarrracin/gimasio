using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsPlanes
    {
        public Planes Obtener(int id) //devuelve un objeto (LeerPorID)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                //return null; /// oBD.Planes.Select(id.ToString());


                Planes a = oBD.Planes.Include("EjercicioxPlan").Where(x => x.idPlan == id).FirstOrDefault();
                return a;

            }

        }
        public List<Planes> Listar() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                //return oBD.Planes.ToList();
                return oBD.Planes.Include("TipoPlan").Include("EjercicioxPlan").OrderBy(x => x.estado).ToList(); //borrar


            }
        }

        public List<Planes> Listar(string stDato, string stEstado , string stNomTipoPlan) 
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                //if (stDato.Equals(""))
                //{
                //    return oBD.Planes.Include("TipoPlan").Include("EjercicioxPlan").Where(x => x.estado == stEstado).ToList(); 
                //}
                //else
                //{
                //    return oBD.Planes.Include("TipoPlan").Include("EjercicioxPlan").Where(x => (x.nombre.StartsWith(stDato)) && x.estado == stEstado).ToList(); 
                //}


                if (stDato.Equals("") && stNomTipoPlan.Equals(""))
                {
                    return oBD.Planes.Include("TipoPlan").Include("EjercicioxPlan").Where(x => x.estado == stEstado).ToList();
                }
                else if (stDato.Equals(""))
                {
                    return oBD.Planes.Include("TipoPlan").Include("EjercicioxPlan").Where(x => x.TipoPlan.nombre.StartsWith(stNomTipoPlan) && x.estado == stEstado).ToList();
                }
                else if (stNomTipoPlan != "")
                {
                    return oBD.Planes.Include("TipoPlan").Include("EjercicioxPlan").Where(x => x.TipoPlan.nombre.StartsWith(stNomTipoPlan) && x.nombre.StartsWith(stDato) && x.estado == stEstado).ToList();
                }
                else
                {
                    return oBD.Planes.Include("TipoPlan").Include("EjercicioxPlan").Where(x => x.nombre.StartsWith(stDato) && x.estado == stEstado).ToList();
                }
            }
        }
        public List<TipoPlan> ListarTipoPlan() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                return oBD.TipoPlan.ToList(); 
            }
        }


        public int Guardar(Planes oP)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {

                    if (oP.idPlan == 0)//Crear
                    {

                        oBD.Planes.Add(oP);
                        oBD.SaveChanges();

                        return oP.idPlan;
                    }
                    else  //Update
                    {
                        oBD.Planes.Attach(oP);
                        oBD.Entry(oP).State = System.Data.Entity.EntityState.Modified;
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

        public int Delete(int idP)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                Planes oP = Obtener(idP);
                if (oP != null)
                {
                    oP.estado = "1";
                    oBD.Planes.Attach(oP);
                    oBD.Entry(oP).State = System.Data.Entity.EntityState.Modified;

                    return oBD.SaveChanges();
                }
                else
                {
                    return -1;
                }

            }
        }
    }


   
    public class clsEjercicioxPlan
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

        public EjercicioxPlan Obtener(int id) //devuelve un objeto (LeerPorID)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                //return null; /// oBD.EjercicioxPlan.Select(id.ToString());


                EjercicioxPlan a = oBD.EjercicioxPlan.Include("Ejercicio").Include("Planes").Where(x => x.idEjercicioxPlan == id).FirstOrDefault(); 
                return a;

            }

        }
        public List<EjercicioxPlan> Listar() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                //return oBD.EjercicioxPlan.ToList();
                return oBD.EjercicioxPlan.Include("Ejercicio").Include("Planes").OrderBy(x=>x.dia).ToList(); //borrar


            }
        }

        public List<EjercicioxPlan> Listar(int id) //trae todo con filtro busqueda por Nombre O Apellido O DNI Y Estado
        {
            using (BDGimnasioEntities/* var*/ oBD = new BDGimnasioEntities())
            {
                
                //var result = (from
                //             ExP in oBD.EjercicioxPlan
                //             join P in oBD.Planes on ExP.idPlan equals P.idPlan
                //             join E in oBD.Ejercicio on ExP.idEjercicio equals E.idEjercicio
                //             join M in oBD.Maquina on E.idMaquina equals M.idMaquina

                //             where P.idPlan == id
                //             select new
                //             {
                //                 ExP.idEjercicioxPlan,
                //                 E.nombre,
                //                 ExP.series,
                //                 ExP.repeticiones,
                //                 nomMaquina = (M.nombre == null) ? string.Empty : M.nombre
                //                 //(i.Maquina==null) ? string.Empty  : i.Maquina.nombre
                //             }).ToList();

                return oBD.EjercicioxPlan.Include("Planes").Include("Ejercicio")/*.Include("Maquina")*/.Where(x => x.idPlan == id).OrderBy(x => x.dia).ToList();



                //return result;
                




            }
        }



        public int Guardar(EjercicioxPlan oExP)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {

                    if (oExP.idEjercicioxPlan == 0)//Crear antes estaba oExP.idPlan == 0
                    {

                        oBD.EjercicioxPlan.Add(oExP);
                        oBD.SaveChanges();

                        return oExP.idPlan;
                    }
                    //else  //Update
                    //{

                    return oExP.idPlan;//BORRAR ESTO DESPUES PARA DEJARLO COMO ANTES



                    //    LO QUE ME SIRVE:
                    //    oBD.EjercicioxPlan.Attach(oExP);
                    //    oBD.Entry(oExP).State = System.Data.Entity.EntityState.Modified;
                    //    oBD.SaveChanges();
                    //    return 0;

                    //    //oBD.EjercicioxPlan.Attach(oExP);
                    //    //return oBD.SaveChanges();



                    //}
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int Modificar(EjercicioxPlan oExP) 
        {
            using (var db= new BDGimnasioEntities()) 
            {
                var result = db.EjercicioxPlan.SingleOrDefault(b => b.idEjercicioxPlan == oExP.idEjercicioxPlan);
                if(result!=null)
                {
                    result.idPlan = oExP.idPlan;
                    result.idEjercicio = oExP.idEjercicio;
                    result.series = oExP.series;
                    result.repeticiones = oExP.repeticiones;
                    result.observaciones = oExP.observaciones;
                    result.dia = oExP.dia;
                    db.SaveChanges();
                    return oExP.idEjercicioxPlan;
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
                    EjercicioxPlan e = oBD.EjercicioxPlan.Where(x => x.idEjercicioxPlan == id).FirstOrDefault();
                    oBD.EjercicioxPlan.Remove(e);                    
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
