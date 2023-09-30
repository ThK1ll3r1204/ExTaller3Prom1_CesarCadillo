using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3_Prom1_Examen_CesarCadillo
{
    class CarritoCompras
    {
        private List<Producto> productos = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public float CalcularPrecioTotal()
        {
            float precioTotal = 0;
            foreach (Producto producto in productos)
            {
                precioTotal += producto.ObtenerPrecio();
            }
            return precioTotal;
        }

        public void MostrarContenido()
        {
            foreach (Producto producto in productos)
            {
                Console.WriteLine(producto.ObtenerCaracteristicas());
            }
            Console.WriteLine($"Precio total: ${CalcularPrecioTotal()}");
        }
    }
}
