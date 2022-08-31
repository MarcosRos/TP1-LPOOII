using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Producto
    {
        private string codProducto, categoría, color, descripcion;
        private decimal precio;

        public Producto()
        {

        }

        public string CodProducto { get; set; }
        public string Categoría { get; set; }
        public string Color { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
    }
}
