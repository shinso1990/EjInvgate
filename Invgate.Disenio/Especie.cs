using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invgate.Disenio
{
    public class Especie : IEquatable<Especie>
    {
        public string nombre { get; set; }

        public Especie(string nombre)
        {
            this.nombre = nombre;
        }
        public bool Equals(Especie other)
        {
            return this.nombre == other.nombre;
        }
    }
}
