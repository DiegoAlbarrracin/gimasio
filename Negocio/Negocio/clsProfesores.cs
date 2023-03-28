using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsProfesores
    {

        public Profesor Obtener(int id) //devuelve un objeto (LeerPorID)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                //return null; /// oBD.Profesor.Select(id.ToString());


                Profesor a = oBD.Profesor.Where(x => x.idProfesor == id).FirstOrDefault();
                return a;

            }



        }
        public List<Profesor> Listar() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                //return oBD.Profesor.ToList();
                return oBD.Profesor.Include("Ciudad").OrderBy(x => x.estado).ToList(); //borrar

            }
        }

        public List<Profesor> Listar(string stDato, string stEstado) //trae todo con filtro busqueda por Nombre O Apellido O DNI Y Estado
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                if (stDato.Equals(""))
                {
                    return oBD.Profesor.Include("Ciudad").Where(x => x.estado == stEstado).ToList(); //borrar
                }
                else
                {
                    return oBD.Profesor.Include("Ciudad").Where(x => ( x.nombre.StartsWith(stDato) || x.apellido.StartsWith(stDato) || x.dni.StartsWith(stDato)) && x.estado == stEstado).ToList(); //borrar
                }



            }
        }

    
        public int Guardar(Profesor oP)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {

                    if (oP.idProfesor == 0)//Crear
                    {

                        oBD.Profesor.Add(oP);
                        oBD.SaveChanges();

                        return oP.idProfesor;
                    }
                    else  //Update
                    {
                        oBD.Profesor.Attach(oP);

                        oBD.Entry(oP).State = System.Data.Entity.EntityState.Modified;// Agregado
                        oBD.SaveChanges();
                        //return oP.idProfesor;
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
                Profesor oP = Obtener(idP);
                if (oP != null)
                {
                    oP.estado = "1";
                    oBD.Profesor.Attach(oP);
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
}
