using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3_Prom1_Examen_CesarCadillo
{
    class ProductoArcilla :Producto
    {
        public float Peso { get; set; }

        public ProductoArcilla(string nombre, float peso, string tamaño, string color, float precio)
        : base(nombre, tamaño, color, precio)
        {
            Peso = peso;
        }

        public override string ObtenerCaracteristicas()
        {
            return base.ObtenerCaracteristicas() + $", Peso: {Peso}";
        }
    }
}
