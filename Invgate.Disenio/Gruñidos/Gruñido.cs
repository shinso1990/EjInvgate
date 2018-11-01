using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invgate.Disenio.Gruñidos
{
    public abstract class Gruñido
    {
        public Gruñido(TimeSpan duracion)
        {
            this.duracion = duracion;
        }
        public TimeSpan duracion { get; private set; }
        
        public abstract void EmitirSonido();
    }
}
