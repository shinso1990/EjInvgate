using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invgate.Disenio.Estado
{
    public class EstadoTriste : IEstadoMascota
    {
        public void HacerRuido(Mascota m)
        {
            Console.WriteLine("Llora");
        }
        public string Estado
        {
            get
            {
                return "Triste";
            }
        }
        public void Moverse(Mascota m)
        {
            m.MoverMascota();
        }
    }
}
