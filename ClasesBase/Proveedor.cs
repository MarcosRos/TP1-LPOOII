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

        public string Cuit { get { return cuit; } set { cuit = value; } }
        public string RazonSocial { get { return razonSocial; } set { razonSocial = value; } }
        public string Domicilio { get { return domicilio; } set { domicilio = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",
                                  cuit, razonSocial, domicilio, telefono);
        }
    }
}
