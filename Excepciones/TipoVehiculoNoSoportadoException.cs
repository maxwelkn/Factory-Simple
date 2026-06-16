namespace FactoryProblema.Excepciones;
public class TipoVehiculoNoSoportadoException : Exception
{
    public TipoVehiculoNoSoportadoException () {}
    public TipoVehiculoNoSoportadoException (string mensaje) : base (mensaje){}
}