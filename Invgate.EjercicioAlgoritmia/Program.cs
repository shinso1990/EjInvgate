using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invgate.EjercicioAlgoritmia
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
                Console.WriteLine("Debe indicar un path");
            else
            {
                var path = args[0];
                if (!File.Exists(path))
                    Console.WriteLine("No se encuentra el archivo");
                else
                {
                    var lineas = File.ReadLines(path);
                    List<KeyValuePair<string, string>> listadoRelaciones = new List<KeyValuePair<string, string>>();
                    foreach(var linea in lineas)
                    {
                        var relacion = linea.Split(' ');
                        var padre = relacion[0];
                        var hijo = relacion[1];

                        listadoRelaciones.Add(new KeyValuePair<string, string>(padre, hijo));
                    }

                    var arbol =  GeneradorArbol.ArmarArbol(listadoRelaciones);

                    var impresor = new ImpresorArbol(arbol);

                    var res = impresor.ObtenerImpresion();

                    var lineasRes = new List<string>();
                    foreach(var valores in res)
                    {
                        var linea = "";
                        foreach (var valor in valores)
                            linea += valor + " ";
                        Console.WriteLine(linea);
                        lineasRes.Add(linea);
                    }
                    //validación resultado
                    var lineasOutput = File.ReadLines(args[0] + "_expected_output");

                    var esIgual = true;
                    for(int i = 0; i< lineasOutput.Count(); i++ )
                        esIgual = esIgual && (lineasOutput.ElementAt(i) == lineasRes[i]);

                    Console.WriteLine("EsIgual: " + esIgual.ToString());

                }
            }
        }
    }
}
