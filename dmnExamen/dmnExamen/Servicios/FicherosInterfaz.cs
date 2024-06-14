using dmnExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmnExamen.Servicios
{
    internal interface FicherosInterfaz
    {
        /// <summary>
        /// Metodo encargado de recoger los datos del fichero inicial, y cargarlos en las listas de los clientes.
        /// </summary>
        public void cargaFicheros(List<VehiculosDtos> listaVehiulos, List<PropietariosDtos> listaPropietarios);


        /// <summary>
        /// Metodo encargado de realizar la escritura en fichero, del historico de los movimientos del usuario por la aplicacion.
        /// Recibira como parametro un string, el cual sera el mensaje escrito en fichero.
        /// </summary>
        //public void ficheroLog();

    }
}
