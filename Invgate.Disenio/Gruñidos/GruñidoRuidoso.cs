using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invgate.Disenio.Gruñidos
{
    public class GruñidoRuidoso : Gruñido
    {
        public GruñidoRuidoso(TimeSpan duracion, int decibeles) : base(duracion)
        {
            this.decibeles = decibeles;
        }
        public int decibeles { get; set; }
        public override void EmitirSonido()
        {
            Console.WriteLine("Gruñido ruidoso de " + duracion.TotalSeconds.ToString() + " segundos y decibeles: " + decibeles.ToString() );
        }
    }
}
