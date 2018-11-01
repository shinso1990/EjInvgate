using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invgate.EjercicioAlgoritmia
{
    public class GeneradorArbol
    {

        public static Arbol ArmarArbol(List<KeyValuePair<string, string>> relaciones)
        {
            var elementos = relaciones.Select(x => x.Key).Union(relaciones.Select(y=> y.Value)).Distinct();
            var dic = new Dictionary<string, NodoArbol>();
            foreach(var padre in elementos)
            {
                var hijos = relaciones.Where(x => x.Key == padre).Select(x=> x.Value).ToList();
                var nodo = new NodoArbol(padre, hijos);
                dic.Add(padre, nodo);
            }

            return new Arbol(relaciones[0].Key, dic);
        }


    }
}
