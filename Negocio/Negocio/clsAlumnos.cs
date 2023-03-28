using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsAlumnos
    {
       


        public Alumno Obtener(int id) //devuelve un objeto (LeerPorID)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
               //return null; /// oBD.Alumno.Select(id.ToString());
              

               Alumno a = oBD.Alumno.Where(x => x.idAlumno == id).FirstOrDefault();
               return a;

            }

        }

        public Alumno ObtenerPorDNI(string DNI) //devuelve un objeto (LeerPorID)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                //return null; /// oBD.Alumno.Select(id.ToString());


                Alumno a = oBD.Alumno.Where(x => x.dni == DNI).FirstOrDefault();
                return a;

            }

        }

       

        public List<Alumno> Listar() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                                
                return oBD.Alumno.Include("Ciudad").OrderBy(x=>x.estado).ToList(); //borrar

            }
        }

        public List<Alumno> Listar(string stDato, string stEstado) //trae todo con filtro busqueda por Nombre O Apellido O DNI Y Estado
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                
                if (stDato.Equals(""))
                {
                    return oBD.Alumno.Include("Ciudad").Where(x => x.estado == stEstado).ToList(); //borrar
                }
                else 
                {
                    return oBD.Alumno.Include("Ciudad").Where(x => ( x.nombre.StartsWith(stDato)  || x.apellido.StartsWith(stDato) || x.dni.StartsWith(stDato) ) && x.estado == stEstado).ToList(); //borrar
                }
                
            }
        }



        public int Guardar(Alumno oA)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {

                    if (oA.idAlumno == 0)//Crear
                    {

                        oBD.Alumno.Add(oA);
                        oBD.SaveChanges();

                        return oA.idAlumno;
                    }
                    else  //Update
                    {
                        oBD.Alumno.Attach(oA);
                        oBD.Entry(oA).State = System.Data.Entity.EntityState.Modified;// Agregado
                        oBD.SaveChanges();
                        return 0;

                        //oBD.Alumno.Attach(oA);
                        //return oBD.SaveChanges();



                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int Delete(int idA) 
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                Alumno oA = Obtener(idA);
                if (oA != null)
                {
                    oA.estado = "1";
                    oBD.Alumno.Attach(oA);
                    oBD.Entry(oA).State = System.Data.Entity.EntityState.Modified;

                    return oBD.SaveChanges();
                }
                else
                {
                    return -1;
                }
               
            }
        }
    }
}
