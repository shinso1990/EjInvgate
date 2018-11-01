using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invgate.EjercicioAlgoritmia
{
    public class Arbol
    {
        public Dictionary<string, NodoArbol> nodos { get; private set; }
        public string raiz { get; private set; }

        public Arbol(string root, Dictionary<string, NodoArbol> nodos)
        {
            this.nodos = nodos;
            this.raiz = root;
        }
    }
}
