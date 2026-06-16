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
            int opcionNumero = int.Parse(Console.ReadLine()!);
        
            VehiculoTipo opcionElegida = (VehiculoTipo) opcionNumero;

            Vehiculo v = VehiculoFactory.CrearVehiculo(opcionElegida);
            System.Console.WriteLine("\nIngrese los datos del vehiculo:");
            System.Console.Write("\nMarca:");
            v.Marca = Console.ReadLine()!;
            
            System.Console.Write("\nPrecio:");
            v.Precio = decimal.Parse(Console.ReadLine()!);

            System.Console.WriteLine("\nResultado:");
            System.Console.WriteLine(v.ToString());

            if (opcionNumero == 4)
            {
            System.Console.WriteLine("Estas seguro que quieres salir?");
            string respuesta = Console.ReadLine()!;

            if (respuesta == "s")
            {
                System.Console.WriteLine("Gracias por usar el programa, vuelva pronto!");
            }
            System.Console.WriteLine("Programa en ejecucion, presione cualquier letra para continuar...");
            Console.ReadKey();
            }

            System.Console.WriteLine("\nPresione cualquier letra para continuar...");
            Console.ReadKey();
            }
        }
    }
}
