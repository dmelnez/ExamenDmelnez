using dmnExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmnExamen.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo encargado de solicitar el DNI al usuario, y dar de alta a un nuevo usuario.
        /// </summary>
        /// <param name="listaPropietarios"></param>
        public void altaPropietario(List<PropietariosDtos> listaPropietarios);

        /// <summary>
        /// Metodo encargado de mostrar al usuario, el numero de coches considerados historicos en el sistema.
        /// </summary>
        public void numeroHistoricos(List<VehiculosDtos>listaVehiculos);

    }
}
