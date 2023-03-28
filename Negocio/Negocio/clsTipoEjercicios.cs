using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsTipoEjercicios
    {                
            public TipoEjercicio Obtener(int id) //devuelve un objeto (LeerPorID)
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {
                    //return null; /// oBD.TipoEjercicio.Select(id.ToString());


                    TipoEjercicio a = oBD.TipoEjercicio.Where(x => x.idTipoEjercicio == id).FirstOrDefault();
                    return a;

                }



            }
            public List<TipoEjercicio> Listar() //trae todo
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {

                    return oBD.TipoEjercicio.ToList();



                }
            }

            public int Guardar(TipoEjercicio oA)
            {
                try
                {
                    using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                    {

                        if (oA.idTipoEjercicio == 0)//Crear
                        {

                            oBD.TipoEjercicio.Add(oA);
                            oBD.SaveChanges();

                            return oA.idTipoEjercicio;
                        }
                        else  //Update
                        {
                            oBD.TipoEjercicio.Attach(oA);

                            oBD.Entry(oA).State = System.Data.Entity.EntityState.Modified;// Agregado
                            oBD.SaveChanges();
                            //return oA.idTipoEjercicio;
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
