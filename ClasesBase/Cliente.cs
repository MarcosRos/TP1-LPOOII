using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private string dni, apellido, nombre, dirección;

        public Cliente()
        {

        }

        public string Dni { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Dirección { get; set; }
    }
}
