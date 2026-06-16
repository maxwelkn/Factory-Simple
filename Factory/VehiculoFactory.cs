using FactoryProblema.Modelos;

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
            throw new ArgumentOutOfRangeException(nameof(tipo),$"el tipo de vehiculo {tipo}, no esta en se sistema");
            
        }
    }
}