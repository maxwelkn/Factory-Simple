using System;

namespace FactoryProblema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("[1]Sedan [2]Compacto [3]Suv");
            Console.Write("Elija cual tipo de vehiculo desea: ");
            int opcion = int.Parse(Console.ReadLine()!);


            if (opcion == 1)
            {
                Sedan sedan = new Sedan();
                Console.Write("Diga la marca: ");
                sedan.Marca = Console.ReadLine()!;
                Console.Write("Diga el precio: ");
                sedan.Precio = decimal.Parse(Console.ReadLine()!);

                Console.WriteLine(sedan);
            }
            else if (opcion == 2)
            {
                Compacto compacto = new Compacto();
                Console.Write("Diga la marca: ");
                compacto.Marca = Console.ReadLine()!;
                Console.Write("Diga el precio: ");
                compacto.Precio = decimal.Parse(Console.ReadLine()!);

                Console.WriteLine(compacto);
            }
            else
            {
                Suv suv = new Suv();
                Console.Write("Diga la marca: ");
                suv.Marca = Console.ReadLine()!;
                Console.Write("Diga el precio: ");
                suv.Precio = decimal.Parse(Console.ReadLine()!);

                Console.WriteLine(suv);
            }
            Console.ReadKey();
            Main(args);

        }
    }
}
