using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Proveedor
    {
        private string cuit, razonSocial, domicilio, telefono;

        public Proveedor()
        {

        }

        public string Cuit { get; set; }
        public string RazonSocial { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
    }
}
