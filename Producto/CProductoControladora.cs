using GestionDeProductos;
using System;
using System.Collections.Generic;

namespace GESTION.Producto
{
    public class CProductoControladora
    {
        private CConsola vista;
        private CProductoConjunto conjunto;

        public CProductoControladora(CConsola vista, CProductoConjunto conjunto)
        {
            this.vista = vista;
            this.conjunto = conjunto;
        }

        public void CrearProducto()
        {
            string nombre = vista.PedirTexto("Ingrese el nombre del producto");
            decimal precio = vista.PedirDecimal("Ingrese el precio del producto");

            //try
            //{
                CProducto p = new CProducto(nombre, precio);
                conjunto.AgregarProducto(p);
                vista.MostrarMensaje("Producto agregado con éxito.");
            /*}
            catch (Exception ex)
            {
                this.vista.MostrarMensaje($"Error: {ex.Message}");
            }
            */
        }

        public void ListarProductos()
        {
            List<CProducto> lista = conjunto.ObtenerTodos();
            if (lista.Count == 0)
            {
                vista.MostrarMensaje("No hay productos cargados.");
                return;
            }

            foreach (var p in lista)
            {
                vista.MostrarMensaje($"- {p.Nombre} : ${p.Precio:F2}");
            }
        }

        public void BuscarProducto()
        {
            string nombre = vista.PedirTexto("Ingrese el nombre a buscar");
            CProducto prod = conjunto.BuscarPorNombre(nombre);

            if (prod != null)
            {
                vista.MostrarMensaje($"Producto encontrado: {prod.Nombre} - ${prod.Precio:F2}");
            }
            else
            {
                vista.MostrarMensaje("Producto no encontrado.");
            }
        }

        public void AplicarDescuento()
        {
            string nombre = vista.PedirTexto("Ingrese el nombre del producto a descontar");
            CProducto prod = conjunto.BuscarPorNombre(nombre);

            if (prod != null)
            {
                decimal porc = vista.PedirDecimal("Ingrese el porcentaje de descuento");
                
                //try
                //{
                    prod.AplicarDescuento(porc);
                    vista.MostrarMensaje($"Descuento aplicado. Nuevo precio: ${prod.Precio:F2}");
                /*}
                catch (Exception ex)
                {
                    this.vista.MostrarMensaje($"Error: {ex.Message}");
                }
                */
            }
            else
            {
                vista.MostrarMensaje("Producto no encontrado.");
            }
        }
    }
}
