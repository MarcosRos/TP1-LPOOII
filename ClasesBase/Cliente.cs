using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private string dni, apellido, nombre, direccion;

        public Cliente()
        {

        }

        public string Dni { get { return dni; } set { dni = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}",
                                  dni, apellido, nombre, direccion);
        }
    }
}
