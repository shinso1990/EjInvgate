using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invgate.Disenio.Gruñidos
{
    public class GruñidoMelodioso : Gruñido
    {
        public GruñidoMelodioso(TimeSpan duracion) : base(duracion)
        {
        }
        public override void EmitirSonido()
        {
            Console.WriteLine("Melodía de duración de " + duracion.TotalSeconds.ToString() + " segundos" );
        }
    }
}
