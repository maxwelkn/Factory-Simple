using FactoryProblema.Modelos;
using FactoryProblema.Excepciones;
namespace FactoryProblema.Factory;
public class VehiculoFactory
{
    public static Vehiculo CrearVehiculo (VehiculoTipo tipo)
    {
        switch (tipo)
        {
            case VehiculoTipo.Sedan: 
            return new Sedan();

            case VehiculoTipo.Compacto: 
            return new Compacto();

            case VehiculoTipo.Suv: 
            return new Suv();

            default:
            throw new TipoVehiculoNoSoportadoException ($"el tipo de vehiculo {(int)tipo}, no esta registardo en el sistema");   
        }
    }
}