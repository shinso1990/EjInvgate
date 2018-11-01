using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invgate.Disenio.Movimiento
{
    public class MovimientoNulo : IMovimiento
    {
        public void Moverse()
        {
            Console.WriteLine("No se mueve");
        }
    }
}
