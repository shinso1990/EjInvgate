using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invgate.EjercicioAlgoritmia
{
    public class ImpresorArbol
    {
        public Dictionary<string, NodoArbol> nodos { get { return arbol.nodos; } }
        public string raiz { get { return arbol.raiz; } }
        public Arbol arbol { get; private set; }
        public ImpresorArbol(Arbol arbol)
        {
            this.arbol = arbol;
        }

        public List<List<string>> ObtenerImpresion()
        {
            return Imprimir(nodos[raiz]);
        }
        private List<List<string>> Imprimir(NodoArbol nodo)
        {
            List<List<string>> resImpresion = new List<List<string>>();
            if(nodo.EsHoja)
                resImpresion.Add( new List<string> { nodo.valor } );
            else
            { 
                foreach (var hijo in nodo.hijos)
                {
                    var impresionHijo = Imprimir(nodos[hijo] );
                    foreach (var ih in impresionHijo)
                        ih.Add(nodo.valor);
                    resImpresion= resImpresion.Union(impresionHijo).ToList();
                }
            }
            return resImpresion;
        }
    }
}
