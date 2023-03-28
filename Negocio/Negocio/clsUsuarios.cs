using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsUsuarios
    {
        public Usuario Obtener(string usuario, string contraseña) 
        {
            using (BDGimnasioEntities oBD = new BDGimnasioEntities())
            {
                Usuario u = oBD.Usuario.Where(x => x.usuario1 == usuario && x.contraseña == contraseña).FirstOrDefault();

                return u;
               
            }

        }

       

        
    }
}
