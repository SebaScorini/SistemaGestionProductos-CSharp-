using System;
using System.Collections.Generic;

namespace GESTION.Producto
{
    public class CProducto
    {
        public string Nombre { get; private set; }
        public decimal Precio { get; private set; }

        public CProducto(string nombre, decimal precio)
        {
            //if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("Nombre inválido.");
            //if (precio <= 0) throw new ArgumentException("Precio debe ser mayor que cero.");

            Nombre = nombre;
            Precio = precio;
        }

        public void AplicarDescuento(decimal porcentaje)
        {
            //if (porcentaje < 0 || porcentaje > 100) throw new ArgumentException("Porcentaje inválido.");
            Precio -= Precio * (porcentaje / 100);
        }
    }

}
