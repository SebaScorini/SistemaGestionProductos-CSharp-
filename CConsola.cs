using System;
using System.Collections.Generic;

namespace GestionDeProductos
{
    public class CConsola
    {
        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public string PedirTexto(string prompt)
        {
            Console.Write($"{prompt}: ");
            string texto = Console.ReadLine();
            return texto;
        }
        public decimal PedirDecimal(string prompt)
        {
            decimal valor;
            while (true)
            {
                Console.Write($"{prompt}: ");
                if (decimal.TryParse(Console.ReadLine(), out valor)) return valor;
                Console.WriteLine("Valor inválido. Intente de nuevo.");
            }
        }
    }

}
