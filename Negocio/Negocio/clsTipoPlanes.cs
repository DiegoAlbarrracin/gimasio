using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsTipoPlanes
    {
        public TipoPlan Obtener(int id) //devuelve un objeto (LeerPorID)
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                //return null; /// oBD.TipoPlan.Select(id.ToString());


                TipoPlan a = oBD.TipoPlan.Where(x => x.idTipoPlan == id).FirstOrDefault();
                return a;

            }



        }
        public List<TipoPlan> Listar() //trae todo
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {

                return oBD.TipoPlan.ToList();



            }
        }

        public int Guardar(TipoPlan oA)
        {
            try
            {
                using (BDGimnasioEntities oBD = new BDGimnasioEntities())
                {

                    if (oA.idTipoPlan == 0)//Crear
                    {

                        oBD.TipoPlan.Add(oA);
                        oBD.SaveChanges();

                        return oA.idTipoPlan;
                    }
                    else  //Update
                    {
                        oBD.TipoPlan.Attach(oA);

                        oBD.Entry(oA).State = System.Data.Entity.EntityState.Modified;// Agregado
                        oBD.SaveChanges();
                        //return oA.idTipoPlan;
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
