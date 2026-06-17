using FactoryProblema.Excepciones;
using FactoryProblema.Factory;
using FactoryProblema.Modelos;
namespace FactoryProblema
{    
    internal class Program
    {    
        static void Main(string[] args)
        {
            while (true) 
            {
            Console.Clear();
            Console.WriteLine("[1]Sedan [2]Compacto [3]Suv [4] Salir");
            Console.Write("Elija cual tipo de vehiculo desea: ");
            string opcionNumero = Console.ReadLine()!;

            if (int.TryParse(opcionNumero, out int entrada))
            {   
                if (entrada == 4)
                {
                System.Console.WriteLine("Estas seguro que quieres salir? s/n");
                string respuesta = Console.ReadLine()!.Trim().ToLower();

                if (respuesta == "s")
                {
                    System.Console.WriteLine("Gracias por usar el programa, vuelva pronto!");
                    break;
                }
                System.Console.WriteLine("Programa en ejecucion, presione cualquier letra para continuar...");
                Console.ReadKey();
                continue;
                }
            } 
            else
            {
                System.Console.WriteLine("Opcion invalida, no ingresaste ningun numero ");
                Console.ReadKey();
                continue;
            }

                VehiculoTipo opcionElegida = (VehiculoTipo) entrada;

                Vehiculo v;
                
                try
                {
                  v = VehiculoFactory.CrearVehiculo(opcionElegida);  
                }
                catch (TipoVehiculoNoSoportadoException ex)
                {
                    System.Console.WriteLine($"\n [Error de fabrica]: {ex.Message}");
                    System.Console.WriteLine("Programa en ejecucion, presione cualquier letra para continuar...");
                    Console.ReadKey();
                    continue;   
                }
                
                System.Console.WriteLine("\nIngrese los datos del vehiculo:");

                while (true)
                    {
                        System.Console.Write("\nMarca: ");
                        string marcaIngresada = Console.ReadLine()!;

                        if (string.IsNullOrWhiteSpace(marcaIngresada))
                        {
                            System.Console.WriteLine("[Error] la marca ingresada no puede estar vacia, escriba la marca.");
                            continue;
                        }
                        v.Marca = marcaIngresada;
                        break;
                    }
                decimal precioValido;
                
                while (true)
                    {
                        System.Console.Write("\nPrecio: ");
                        string precioIngresado = Console.ReadLine()!;   

                        if (!decimal.TryParse(precioIngresado, out decimal precioConvertido))
                        {
                            System.Console.WriteLine("[Error] el precio que debes ingresar debe ser un numero, decimal o entero");
                            continue;
                        }
                        if (precioConvertido < 0)
                        {
                            System.Console.WriteLine("[Error] El precio no puede ser negativo");
                            continue;
                        }
                        precioValido = precioConvertido;
                        break;
                    }
                    v.Precio = precioValido;

                System.Console.WriteLine("\nResultado:");
                System.Console.WriteLine(v.ToString());
                Console.ReadKey();
            }
        }
    }
}