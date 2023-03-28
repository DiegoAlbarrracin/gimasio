using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsAsistencias
    {
        public Asistencia Obtener(int id) //devuelve un objeto (LeerPorID)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                //return null; /// oBD.Asistencia.Select(id.ToString());


                Asistencia a = oBD.Asistencia.Include("Alumno").Where(x => x.idAsistencia == id).FirstOrDefault();
                return a;

            }



        }
        public List<Asistencia> Listar() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                //return oBD.Asistencia.ToList();
                return oBD.Asistencia.Include("Alumno").ToList();

            }
        }

 

        public List<Asistencia> ListarporDNI(int idAlumno) //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                //return oBD.Asistencia.ToList();
                return oBD.Asistencia.Include("Alumno").Where(x => x.idAlumno == idAlumno).ToList();

            }
        }
        public List<Asistencia> Listar(DateTime datoDesde) 
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                if (datoDesde == Convert.ToDateTime("1/1/1753"))
                {
                    return oBD.Asistencia.Include("Alumno").OrderBy(x => x.fecha).ToList(); 
                }
                else
                {                    
                    DateTime datoHasta = Convert.ToDateTime(datoDesde.ToString("dd/MM/yyyy 23:59"));
                    datoDesde = Convert.ToDateTime(datoDesde.ToString("dd/MM/yyyy 00:00"));

                    return oBD.Asistencia.Include("Alumno").Where(x => x.fecha.Value >= datoDesde && x.fecha.Value <= datoHasta).OrderBy(x => x.fecha).ToList();                                                                             
                }

            }
        }

        //public List<Asistencia> ListarAñoDesdeHasta(DateTime datoDesde, DateTime datoHasta, int idAlumno)
        //{
        //    using (BDGimnasioEntities oBD = new BDGimnasioEntities())
        //    {

        //        if (idAlumno == 0)
        //        {
        //            datoHasta = Convert.ToDateTime(datoHasta.ToString("dd/MM/yyyy 23:59"));
        //            datoDesde = Convert.ToDateTime(datoDesde.ToString("dd/MM/yyyy 00:00"));

        //            return oBD.Asistencia.Include("Alumno").Where(x => x.fecha.Value >= datoDesde && x.fecha.Value <= datoHasta).OrderBy(x => x.fecha).ToList();
        //        }
        //        else
        //        {
        //            datoHasta = Convert.ToDateTime(datoHasta.ToString("dd/MM/yyyy 23:59"));
        //            datoDesde = Convert.ToDateTime(datoDesde.ToString("dd/MM/yyyy 00:00"));

        //            return oBD.Asistencia.Include("Alumno").Where(x => x.fecha.Value >= datoDesde && x.fecha.Value <= datoHasta && x.idAlumno == idAlumno).OrderBy(x => x.fecha).ToList();
        //        }

        //    }
        //}



        public int Guardar(Asistencia oA)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {

                    if (oA.idAsistencia == 0)//Crear
                    {

                        oBD.Asistencia.Add(oA);
                        oBD.SaveChanges();

                        return (int)oA.idAsistencia;
                    }
                    else  //Update
                    {
                        using (var db = new BDGimnasioEntities())
                        {
                            var result = db.Asistencia.SingleOrDefault(b => b.idAsistencia == oA.idAsistencia);
                            if (result != null)
                            {
                                result.idAlumno = oA.idAlumno;
                                result.fecha = oA.fecha;

                                db.SaveChanges();
                                return 0;
                            }
                            return 0;
                        }


                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int Delete(int id)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {
                    Asistencia e = oBD.Asistencia.Where(x => x.idAsistencia == id).FirstOrDefault();
                    oBD.Asistencia.Remove(e);
                    oBD.SaveChanges();
                    return 1;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //Objeto virtual para llenar data set Asistencias
        public class EAsistencias
        {
           
            public string mes { get; set; }
            public string año { get; set; }
            public int cantidad { get; set; }
            public string nombreAlumno { get; set; }
        }

        public List<EAsistencias> ListarEAsistencias(int idAlumno, int añoDesde, int añoHasta)
        {
            IQueryable<EAsistencias> result;

            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                if (idAlumno !=0 ) // Trae lo del alumno
                {
                    //result = from PC in oBD.ProfesorxClase
                    //         join P in oBD.Profesor on PC.idProfesor equals P.idProfesor
                    //         join C in oBD.Clase on PC.idClase equals C.idClase
                    //         where PC.idProfesor == idProfesor && PC.idClase == idClase && PC.fechaHasta == null
                    //         select new EProfesorDiag
                    //         {
                    //             idProfesorxClase = (int)PC.idProfesorxClase,
                    //             idProfesor = (int)PC.idProfesor,
                    //             nombreProfesor = P.nombre + " " + P.apellido,
                    //             idClase = (int)PC.idClase,
                    //             nombreClase = C.nombre,
                    //             dia = PC.dia,
                    //             fechaHastaPxC = PC.fechaHasta,
                    //             horaInicio = PC.horaInicio

                    //         };

                    result = from A in oBD.Asistencia
                             join Al in oBD.Alumno on A.idAlumno equals Al.idAlumno
                             where A.idAlumno == idAlumno && A.fecha.Value.Year >= añoDesde && A.fecha.Value.Year <= añoHasta                            
                             group A by new   // group A by A.variable en caso de ser solo un parametro de agrupamiento
                             {
                                 Year = A.fecha.Value.Year,
                                 Month = A.fecha.Value.Month
                             } into g
                             orderby new { g.Key.Year, g.Key.Month } //orderby variable 
                             select new EAsistencias
                             {
                                 año = g.Key.Year.ToString(),
                                 mes = g.Key.Month.ToString(),
                                 cantidad = g.Count()                                 

                             };

                    //idAlumno = (int)A.idAlumno,
                    //mes = A.fecha.Value.Month.ToString(),
                    //año = A.fecha.Value.Year.ToString(),
                    //nombreAlumno = A.Alumno.nombre + " " + A.Alumno.apellido

                }
                else //trae todas
                {
                    result = from A in oBD.Asistencia
                             join Al in oBD.Alumno on A.idAlumno equals Al.idAlumno
                             where A.fecha.Value.Year >= añoDesde && A.fecha.Value.Year <= añoHasta                            
                             group A by new
                             {
                                 Year = A.fecha.Value.Year,
                                 Month = A.fecha.Value.Month
                             } into g
                             orderby new { g.Key.Year, g.Key.Month }
                             select new EAsistencias
                             {
                                 año = g.Key.Year.ToString(),
                                 mes = g.Key.Month.ToString(),
                                 cantidad = g.Count()


                             };

                }

                return result.ToList();

            }

        }
    }
}
