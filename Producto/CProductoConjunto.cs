using System;
using System.Collections.Generic;

namespace GESTION.Producto
{
    public class CProductoConjunto
    {
        private List<CProducto> productos = new List<CProducto>();

        public void AgregarProducto(CProducto p)
        {
            productos.Add(p);
        }

        public List<CProducto> ObtenerTodos()
        {
            return productos;
        }

        public CProducto BuscarPorNombre(string nombre)
        {
            CProducto productoBuscado = productos.FirstOrDefault(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
            return productoBuscado;
        }
    }

}
