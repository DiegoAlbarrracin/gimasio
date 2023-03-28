using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsMaquinas
    {
        public Maquina Obtener(int id) //devuelve un objeto (LeerPorID)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                //return null; /// oBD.Maquina.Select(id.ToString());


                Maquina m = oBD.Maquina.Where(x => x.idMaquina == id).FirstOrDefault();
                return m;

            }



        }
        public List<Maquina> Listar() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                return oBD.Maquina.OrderBy(x => x.estado).ToList();
                /*return oBD.Maquina.Include("Ciudad").ToList();*/ //borrar

            }
        }

        public List<Maquina> Listar(string stDato, string stEstado) //trae todo con filtro busqueda por Nombre O Apellido O DNI Y Estado
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                if (stDato.Equals(""))
                {
                    return oBD.Maquina.Where(x => x.estado == stEstado).ToList(); //borrar
                }
                else
                {
                    return oBD.Maquina.Where(x => (x.nombre.StartsWith(stDato)) && x.estado == stEstado).ToList(); //borrar
                }

            }
        }



        public int Guardar(Maquina oM)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {

                    if (oM.idMaquina == 0)//Crear
                    {

                        oBD.Maquina.Add(oM);
                        oBD.SaveChanges();

                        return oM.idMaquina;
                    }
                    else  //Update
                    {
                        oBD.Maquina.Attach(oM);
                        oBD.Entry(oM).State = System.Data.Entity.EntityState.Modified;// Agregado
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

        public int Delete(int idM)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                Maquina oM = Obtener(idM);
                if (oM != null)
                {
                    oM.estado = "1";
                    oM.fechaBaja = DateTime.Now;
                    oBD.Maquina.Attach(oM);
                    oBD.Entry(oM).State = System.Data.Entity.EntityState.Modified;

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
