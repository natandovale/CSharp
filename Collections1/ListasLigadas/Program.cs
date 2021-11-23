using System;
using System.Collections.Generic;

namespace ListasLigadas
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> dias = new LinkedList<string>();
            var d4 = dias.AddFirst("quarta");

            //Adicionando primeiro nó
            //Adicionando segundo nó
            //Adicionando antes de um nó conhecido
            var d2 = dias.AddBefore(d4, "segunda");
            //Adicionando depois de um nó conhecido
            var d3 = dias.AddAfter(d2, "terça");

            var d6 = dias.AddAfter(d4, "sexta");
            var d7 = dias.AddAfter(d6, "sabado");
            var d5 = dias.AddBefore(d6, "quinta");
            var d1 = dias.AddBefore(d2, "domingo");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

            //Removendo 
            dias.Remove(d1);
            dias.Remove("terça");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }

        }
    }
}
