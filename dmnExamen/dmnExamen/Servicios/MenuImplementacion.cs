using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmnExamen.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuPrincipal()
        {
            Console.WriteLine("SELECCIONE UNA OPCION: ");
            Console.WriteLine("0. Cerrar aplicacion.");
            Console.WriteLine("1. Numero de historicos.");
            Console.WriteLine("2. Alta nuevo propietario.");

            int seleccionUsuario = Convert.ToInt32(Console.ReadLine());
            return seleccionUsuario;

        }
    }
}
