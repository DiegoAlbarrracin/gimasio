using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsCiudades
    {
        public Ciudad Obtener(int id) //devuelve un objeto (LeerPorID)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                //return null; /// oBD.Ciudad.Select(id.ToString());


                Ciudad a = oBD.Ciudad.Where(x => x.idCiudad == id).FirstOrDefault();
                return a;

            }

        }
       

        public List<Ciudad> Listar(int idPcia) //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                
                return oBD.Ciudad.Include("Provincia").Where(x=>x.idProvincia == idPcia).ToList();

            }
        }

        public List<Ciudad> Listar(string dato) //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                return oBD.Ciudad.Include("Provincia").Where(x => x.nombre.Contains(dato)).ToList();

            }
        }

        public List<Ciudad> Listar() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                return oBD.Ciudad.Include("Provincia").OrderBy(x=> x.idProvincia).ToList();

            }
        }


        public int Guardar(Ciudad oA)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {

                    if (oA.idCiudad == 0)//Crear
                    {

                        oBD.Ciudad.Add(oA);
                        oBD.SaveChanges();

                        return oA.idCiudad;
                    }
                    else  //Update
                    {
                        oBD.Ciudad.Attach(oA);

                        oBD.Entry(oA).State = System.Data.Entity.EntityState.Modified;// Agregado
                        oBD.SaveChanges();
                        //return oA.idCiudad;
                        return 0;

                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
