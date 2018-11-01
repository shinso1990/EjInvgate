using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invgate.Disenio.Estado
{
    public class EstadoFeliz : IEstadoMascota
    {
        public string Estado
        {
            get
            {
                return "Feliz";
            }
        }

        public void HacerRuido(Mascota m)
        {
            Console.WriteLine("Se rie");
        }

        public void Moverse(Mascota m)
        {
            m.MoverMascota();
        }
    }
}
