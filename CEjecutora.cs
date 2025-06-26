using GESTION.Producto;
using System;
using System.Collections.Generic;

namespace GestionDeProductos
{
    public class Program
    {
        static void Main()
        {
            CConsola vista = new CConsola();
            CProductoConjunto conjunto = new CProductoConjunto();
            CProductoControladora controlador = new CProductoControladora(vista, conjunto);
            string opcion;

            do
            {
                Console.Clear();
                vista.MostrarMensaje("=== SISTEMA DE PRODUCTOS ===");
                vista.MostrarMensaje("1. Agregar producto");
                vista.MostrarMensaje("2. Listar productos");
                vista.MostrarMensaje("3. Buscar producto");
                vista.MostrarMensaje("4. Aplicar descuento");
                vista.MostrarMensaje("5. Salir");

                opcion = vista.PedirTexto("Seleccione una opción");

                switch (opcion)
                {
                    case "1":
                        controlador.CrearProducto();
                        break;
                    case "2":
                        controlador.ListarProductos();
                        break;
                    case "3":
                        controlador.BuscarProducto();
                        break;
                    case "4":
                        controlador.AplicarDescuento();
                        break;
                    case "5":
                        vista.MostrarMensaje("¡Gracias por usar el sistema!");
                        return;
                    default:
                        vista.MostrarMensaje("Opción inválida.");
                        break;
                }

                vista.MostrarMensaje("Presione ENTER para continuar...");
                Console.ReadLine();

            } while (opcion != "5");
        }
    }
}
