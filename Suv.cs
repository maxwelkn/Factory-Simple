using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryProblema
{
    internal class Suv
    {
        public string Marca { get; set; } = string.Empty;
        public decimal Precio { get; set; }

        public override string ToString()
        {
            return $"Marca: {Marca}. Precio: {Precio}";
        }
    }
}
