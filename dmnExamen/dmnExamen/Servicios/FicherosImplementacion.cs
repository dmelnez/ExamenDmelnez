using dmnExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmnExamen.Servicios
{
    internal class FicherosImplementacion : FicherosInterfaz
    {
        public void cargaFicheros(List<VehiculosDtos> listaVehiulos, List<PropietariosDtos> listaPropietarios)
        {
            try
            {
          
                string rutaFicheroCarga = "C:\\Users\\dmelnez\\Desktop\\datosIniciales.txt";

                string[] arrayLineas = File.ReadAllLines(rutaFicheroCarga);

                for (int i = 0; i < arrayLineas.Length; i++)
                {
                    PropietariosDtos propietario = new PropietariosDtos();

                    VehiculosDtos vehiculosDtos = new VehiculosDtos();

                    vehiculosDtos.Id = idAutoIncremental(listaVehiulos);

                    propietario.Id = idAutoIncrementalPropietarios(listaPropietarios);

                    string[] lineasDivididas = arrayLineas[i].Split(':');

                    vehiculosDtos.Matricula = lineasDivididas[0];

                    propietario.Matricula = lineasDivididas[0];

                    vehiculosDtos.FechaMatriculacio = Convert.ToDateTime(lineasDivididas[1]);

                    propietario.Dni = lineasDivididas[2];


                    propietario.FechaCompra = Convert.ToDateTime(lineasDivididas[3]);


                    listaPropietarios.Add(propietario);

                    listaVehiulos.Add(vehiculosDtos);



                }


            }

        
        catch (Exception ex)
        {
            Console.WriteLine("[ALERTA] -> Se ha producido un error. Intententelo mas tarde.");
            Console.Clear();
        }


        }

        /// <summary>
        /// Metodo encargado de acceder a la ultima posicion de la lista, y verificar el ultimo id que ha sido añadido.
        /// Realizara una suma a la cantidad, y lo devolvera al metodo encargado de la carga de los vehiculos.
        /// </summary>
        /// <param name="listaVehiculos"></param>
        /// <returns></returns>

        private long idAutoIncremental(List<VehiculosDtos>listaVehiculos) 
        {
   

            long id = 0;

            int tamanioLista = listaVehiculos.Count;

           if (tamanioLista == 0)
            {

                id = 1;

            }

            else
            {
                id = listaVehiculos[tamanioLista -1].Id + 1;

            }


            return id;



        }



        /// <summary>
        /// Metodo encargado de acceder a la ultima posicion de la lista, y verificar el ultimo id que ha sido añadido.
        /// Realizara una suma a la cantidad, y lo devolvera al metodo encargado de la carga de los vehiculos.
        /// </summary>
        /// <param name="listaVehiculos"></param>
        /// <returns></returns>

        private long idAutoIncrementalPropietarios(List<PropietariosDtos> listaPropietarios)
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



 


    }
}
