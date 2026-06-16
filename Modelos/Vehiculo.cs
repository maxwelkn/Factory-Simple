using FactoryProblema.Modelos;
public abstract class Vehiculo // cree una clase y no una interfaz ya que siento que al trabajar con propiedades es mas comodo con
                                //cuna clase abstracta en lugar que con una interfaz.
{
    public string Marca { get; set; } = string.Empty;
    public decimal Precio { get; set; }

    public override string ToString()
        {
            return $"Marca: {Marca}. Precio: {Precio}";
        }
}