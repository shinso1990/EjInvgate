using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invgate.Disenio.Estado
{
    public class EstadoDormido : IEstadoMascota
    {
        public void HacerRuido(Mascota m)
        {
            Console.WriteLine("Ronca");
        }
        public string Estado { get { return "Dormido"; } }

        public void Moverse(Mascota m)
        {
        }
    }
}
