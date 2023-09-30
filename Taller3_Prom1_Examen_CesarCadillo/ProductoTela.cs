using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3_Prom1_Examen_CesarCadillo
{
    class ProductoTela : Producto
    {
        public string Material { get; set; }

        public ProductoTela(string nombre, string tamaño, string material, string color, float precio)
            : base(nombre, tamaño, color, precio)
        {
            Material = material;
        }

        public override string ObtenerCaracteristicas()
        {
            return base.ObtenerCaracteristicas() + $", Material: {Material}";
        }
    }
}
