using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invgate.Disenio.Gruñidos;

namespace Invgate.Disenio.Estado
{
    public interface IEstadoMascota
    {
        string Estado { get;  }
        void Moverse(Mascota m);
        void HacerRuido(Mascota m);
    }
}
