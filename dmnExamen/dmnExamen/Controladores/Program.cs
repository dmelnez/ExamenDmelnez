using dmnExamen.Dtos;
using dmnExamen.Servicios;

class program
{

    public static void Main(string[] args)
    {

        List<VehiculosDtos> listaVehiculos = new List<VehiculosDtos>();

        List<PropietariosDtos> listaPropietarios = new List<PropietariosDtos>();

        FicherosInterfaz fi = new FicherosImplementacion();

        OperativaInterfaz op = new OperativaImplementacion();

        fi.cargaFicheros(listaVehiculos, listaPropietarios);

        MenuInterfaz me = new MenuImplementacion();

        bool esCerrarAplicacion = false;

        try
        {




        do
        {
            switch(me.menuPrincipal()) 
            
                              
            {

                case 0:
                    Console.WriteLine("[INFO] -> Se cerrara la aplicacion.");
                    Console.Clear();
                    esCerrarAplicacion = true;
                break;

                case 1:
                    Console.WriteLine("[INFO] -> Se mostraran el numero de historicos.");
                    Console.Clear();

                    op.numeroHistoricos(listaVehiculos);

                break;

                case 2:
                    Console.WriteLine("[INFO] -> Se realizara un alta de nuevo usuario.");
                    Console.Clear();

                    op.altaPropietario(listaPropietarios);

                break;

            
            }

        }


        while (!esCerrarAplicacion);

        }

        catch (Exception ex)
        {
            Console.WriteLine("[ALERTA] -> Se ha producido un error. Intententelo mas tarde.");
            Console.Clear();
        }


    }


}