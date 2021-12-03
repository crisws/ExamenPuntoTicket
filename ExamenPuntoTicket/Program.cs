using System;
using System.Collections;
using System.IO;
using System.Linq;

namespace ExamenPuntoTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string ArchivoArbol = @"C:\Examen\arbol.txt";
            string ArchivoNodo = @"C:\Examen\nodo.txt";

            string[] ListadoArbol = File.ReadAllLines(ArchivoArbol);
            string Nodo = File.ReadAllLines(ArchivoNodo)[0];
            string[] PosicionesNodo = Nodo.Split('.');
            ArrayList Resultado = new ArrayList();

           
            foreach (var item in ListadoArbol)
            {
                if (item.Split('.').Length-1 == PosicionesNodo.Length)
                {
                    var Rasgos = item.Split('.').Take(item.Split('.').Length-1);
                    var Herencia = string.Join(".", Rasgos);
                    if (Nodo.Equals(Herencia))
                    {
                        Resultado.Add(item);
                    }
                }
            }

            string[] SalidaLineas = (string[])Resultado.ToArray(typeof(string));

            File.WriteAllLines(@"C:\Examen\resultado.txt", SalidaLineas);


        }
    }
}
