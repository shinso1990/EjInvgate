using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invgate.Disenio.Gruñidos
{
    public class Silencio : Gruñido
    {
        public Silencio() : base(new TimeSpan(0,0,0))
        {
        }

        public override void EmitirSonido()
        {
            Console.WriteLine("silencio");
        }
    }
}
