using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsProvincias
    {
        public Provincia Obtener(int id) //devuelve un objeto (LeerPorID)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                //return null; /// oBD.Provincia.Select(id.ToString());


                Provincia a = oBD.Provincia.Where(x => x.idProvincia == id).FirstOrDefault();
                return a;

            }
        }

        

        public List<Provincia> Listar() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                return oBD.Provincia.ToList();



            }
        }

        public int Guardar(Provincia oA)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {

                    if (oA.idProvincia == 0)//Crear
                    {

                        oBD.Provincia.Add(oA);
                        oBD.SaveChanges();

                        return oA.idProvincia;
                    }
                    else  //Update
                    {
                        oBD.Provincia.Attach(oA);

                        oBD.Entry(oA).State = System.Data.Entity.EntityState.Modified;// Agregado
                        oBD.SaveChanges();
                        //return oA.idProvincia;
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
