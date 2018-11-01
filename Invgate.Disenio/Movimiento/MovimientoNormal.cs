using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invgate.Disenio.Movimiento
{
    public class MovimientoNormal : IMovimiento
    {
        public void Moverse()
        {
            Console.WriteLine("Movimiento normal");
        }
    }
}
