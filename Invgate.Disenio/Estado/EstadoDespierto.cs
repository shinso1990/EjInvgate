using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invgate.Disenio.Estado
{
    public class EstadoDespierto : IEstadoMascota
    {

        public string Estado { get{ return "Despierto"; } }

        public void HacerRuido(Mascota m)
        {
            m.comoGruñir.EmitirSonido(); 
        }

        public void Moverse(Mascota m)
        {
            m.comoMoverse.Moverse();
        }
    }
}
