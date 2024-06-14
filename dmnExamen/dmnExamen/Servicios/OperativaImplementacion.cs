using dmnExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmnExamen.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void altaPropietario(List<PropietariosDtos>listaPropietarios)
        {

            bool esIncorrecto = false;



            do
            {

                PropietariosDtos nuevoPropietario = new PropietariosDtos();

                nuevoPropietario.Id = idAutoIncremental(listaPropietarios);


                Console.WriteLine("DNI: ");
                string dniUsuario = Console.ReadLine();
                
                int tamanioDni = dniUsuario.Count();

                if (tamanioDni == 9)
                {
                    nuevoPropietario.Dni = dniUsuario;
                   
                   Console.WriteLine( nuevoPropietario.ToString());

                   listaPropietarios.Add(nuevoPropietario);
                   esIncorrecto = true;

                }

                else
                {

                    Console.WriteLine("[INFO] -> El dni es incorrecto.");

                }


            }

            while (!esIncorrecto);


        }


        /// <summary>
        /// Metodo encargado de acceder a la ultima posicion de la lista, y verificar el ultimo id que ha sido añadido.
        /// Realizara una suma a la cantidad, y lo devolvera al metodo encargado de la carga de los vehiculos.
        /// </summary>
        /// <param name="listaVehiculos"></param>
        /// <returns></returns>

        private long idAutoIncremental(List<PropietariosDtos> listaPropietarios)
        {
            long id = 0;

            int tamanioLista = listaPropietarios.Count;

            if (tamanioLista == 0)
            {

                id = 1;

            }

            else
            {
                id = listaPropietarios[tamanioLista - 1].Id + 1;

            }


            return id;


        }


        public void numeroHistoricos(List<VehiculosDtos> listaVehiculos)
        {


            foreach(var vehiculos in listaVehiculos)
            {

                if((vehiculos.FechaMatriculacio.Year - DateTime.Today.Year) > 25)
                {
                    Console.WriteLine("N. Historicos ");


                }


            }


        }

    }
}
