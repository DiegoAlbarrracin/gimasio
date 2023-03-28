using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsEjercicios
    {

        public Ejercicio Obtener(int id) //devuelve un objeto (LeerPorID)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                //return null; /// oBD.Ejercicio.Select(id.ToString());


                Ejercicio e = oBD.Ejercicio.Where(x => x.idEjercicio == id).FirstOrDefault();
                return e;

            }



        }

       

        public List<Ejercicio> Listar() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                return oBD.Ejercicio.Include("Maquina").Include("TipoEjercicio").OrderBy(x => x.estado).ToList();

            }
        }

        public List<Ejercicio> Listar(string stDato, string nomTipoEj, string stEstado) //trae todo con filtro busqueda por Nombre O Apellido O DNI Y Estado
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                if (stDato.Equals("") && nomTipoEj.Equals(""))
                {
                    return oBD.Ejercicio.Include("Maquina").Include("TipoEjercicio").Where(x => x.estado == stEstado).ToList();
                }
                else if (stDato.Equals(""))
                {
                    return oBD.Ejercicio.Include("Maquina").Include("TipoEjercicio").Where(x => x.TipoEjercicio.nombre == nomTipoEj && x.estado == stEstado).ToList();
                }
                else if(nomTipoEj != "")
                {
                    return oBD.Ejercicio.Include("Maquina").Include("TipoEjercicio").Where(x => x.nombre.StartsWith(stDato) && x.TipoEjercicio.nombre == nomTipoEj && x.estado == stEstado).ToList(); //borrar
                }
                else
                {
                    return oBD.Ejercicio.Include("Maquina").Include("TipoEjercicio").Where(x => x.nombre.StartsWith(stDato) && x.estado == stEstado).ToList(); //borrar
                }

            }
        }
        public List<TipoEjercicio> ListarTipoEjercicio() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                return oBD.TipoEjercicio.ToList();

            }
        }

        public int Guardar(Ejercicio oE)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {

                    if (oE.idEjercicio == 0)//Crear
                    {

                        oBD.Ejercicio.Add(oE);
                        oBD.SaveChanges();

                        return oE.idEjercicio;
                    }
                    else  //Update
                    {
                        oBD.Ejercicio.Attach(oE);

                        oBD.Entry(oE).State = System.Data.Entity.EntityState.Modified;// Agregado
                        oBD.SaveChanges();
                        //return oE.idEjercicio;
                        return 0;

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
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                Ejercicio oE = Obtener(id);
                if (oE != null)
                {
                    oE.estado = "1";
                    oBD.Ejercicio.Attach(oE);
                    oBD.Entry(oE).State = System.Data.Entity.EntityState.Modified;

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
