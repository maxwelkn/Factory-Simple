using FactoryProblema.Factory;
using FactoryProblema.Modelos;
namespace FactoryProblema
{    
    internal class Program
    {    
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("[1]Sedan [2]Compacto [3]Suv");
            Console.Write("Elija cual tipo de vehiculo desea: ");
            int opcionNumero = int.Parse(Console.ReadLine()!);
        
            VehiculoTipo opcionElegida = (VehiculoTipo) opcionNumero;

            Vehiculo v = VehiculoFactory.CrearVehiculo(opcionElegida);
            System.Console.WriteLine("\nIngrese los datos del vehiculo:");
            System.Console.WriteLine("\nMarca:");
            v.Marca = Console.ReadLine()!;
            
            System.Console.WriteLine("\nPrecio:");
            v.Precio = decimal.Parse(Console.ReadLine()!);

            System.Console.WriteLine("\nResultado:");
            System.Console.WriteLine(v.ToString());

            System.Console.WriteLine("\nPresione cualquier letra para continuar..");
            Console.ReadKey();

            Main(args);
        }
    }
}
