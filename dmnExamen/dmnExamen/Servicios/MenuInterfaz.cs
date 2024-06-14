using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmnExamen.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Menu encargado de mostrar al usuario las opciones. 
        /// Recogera la seleccion del usuario, y lo devolvera al main.
        /// </summary>
        /// <returns></returns>
        public int menuPrincipal();

    }
}
