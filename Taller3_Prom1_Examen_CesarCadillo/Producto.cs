using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3_Prom1_Examen_CesarCadillo
{
    class Producto
    {
        public string Nombre { get; set; }
        public string Tamaño { get; set; }
        public string Color { get; set; }
        public float Precio { get; set; }

        public Producto(string nombre, string tamaño, string color, float precio)
        {
            Nombre = nombre;
            Tamaño = tamaño;
            Color = color;
            Precio = precio;
        }

        public virtual string ObtenerCaracteristicas()
        {
            return $"Nombre: {Nombre}, Tamaño: {Tamaño}, Color: {Color}";
        }

        public float ObtenerPrecio()
        {
            return Precio;
        }
    }
}
