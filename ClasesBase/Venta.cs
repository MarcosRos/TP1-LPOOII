using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Venta
    {
        private int nroFactura, cantidad;
        private decimal precio, importe;
        private string legajo, dni, codProducto;
        private DateTime fechaFactura;

        public Venta()
        {

        }

        public int NroFactura { get; set; }
        public int Cantidad { get; set; }

        public decimal Precio { get; set; }
        public decimal Importe { get; set; }

        public string Legajo { get; set; }
        public string Dni { get; set; }
        public string CodProducto { get; set; }

        public DateTime FechaFactura { get; set; }
    }
}
