using System;
using System.Collections.Generic;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            idades.Remove(5);

            idades.AdicionarVarios(2, 6, 15, 26, 39, 62);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }
    }
}
