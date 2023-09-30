using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3_Prom1_Examen_CesarCadillo
{
    class Program
    {
        static void Main(string[] args)
        {
            CarritoCompras carrito = new CarritoCompras();

            while (true)
            {
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("1. Mostrar productos disponibles");
                Console.WriteLine("2. Ver contenido del carrito");
                Console.WriteLine("3. Finalizar compra");
                Console.WriteLine("4. Salir del sistema");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Productos disponibles:");
                        Console.WriteLine("Productos de tela:");
                        ProductoTela productoTela1 = new ProductoTela("Camisa", "M", "Algodón", "Azul", 29.99f);
                        ProductoTela productoTela2 = new ProductoTela("Vestido", "L", "Seda", "Rojo", 49.99f);
                        Console.WriteLine("1. " + productoTela1.ObtenerCaracteristicas());
                        Console.WriteLine("2. " + productoTela2.ObtenerCaracteristicas());

                        Console.WriteLine("Productos de arcilla:");
                        ProductoArcilla productoArcilla1 = new ProductoArcilla("Maceta", 1.5f, "Grande", "Terracota", 19.99f);
                        ProductoArcilla productoArcilla2 = new ProductoArcilla("Jarrón", 2.0f, "Mediano", "Blanco", 24.99f);
                        Console.WriteLine("3. " + productoArcilla1.ObtenerCaracteristicas());
                        Console.WriteLine("4. " + productoArcilla2.ObtenerCaracteristicas());

                        Console.Write("Seleccione un producto (1-4): ");
                        string seleccion = Console.ReadLine();
                        if (seleccion == "1") carrito.AgregarProducto(productoTela1);
                        else if (seleccion == "2") carrito.AgregarProducto(productoTela2);
                        else if (seleccion == "3") carrito.AgregarProducto(productoArcilla1);
                        else if (seleccion == "4") carrito.AgregarProducto(productoArcilla2);
                        break;
                    case "2":
                        Console.WriteLine("Contenido del carrito de compras:");
                        carrito.MostrarContenido();
                        break;
                    case "3":
                        Console.WriteLine("Compra finalizada. Detalles de la compra:");
                        carrito.MostrarContenido();
                        Console.WriteLine("¡Gracias por su compra!");
                        carrito = new CarritoCompras();  // Crear un nuevo carrito vacío
                        break;
                    case "4":
                        Console.WriteLine("Saliendo del sistema.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}
