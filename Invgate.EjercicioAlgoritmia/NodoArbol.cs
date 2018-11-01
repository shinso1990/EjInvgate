using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invgate.EjercicioAlgoritmia
{
    public class NodoArbol
    {
        public string valor { get; private set; }
        public List<string> hijos { get; private set; }

        public NodoArbol(string valor, List<string> hijos)
        {
            this.valor = valor;
            this.hijos = hijos;
        }
        public bool EsHoja
        {
            get {
                return hijos.Count == 0;
            }
        }


        


    }
}
