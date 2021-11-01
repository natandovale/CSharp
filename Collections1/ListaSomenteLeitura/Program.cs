using System;
using System.Collections.Generic;

namespace ListaSomenteLeitura
{
    class Program
    {
        static void Main(string[] args)
        {
            var cSharpColecoes = new Curso("C# Collections", "Natan");
            cSharpColecoes.Adiciona(new Aula("Trabalhando com listas", 21));
            cSharpColecoes.Adiciona(new Aula("Modelando com colecoes", 19));

            //Copiando lista para outra lista
            List<Aula> aulasCopiadas = new List<Aula>(cSharpColecoes.Aulas);
            //Ordenando a copia
            aulasCopiadas.Sort();
            //Totalizar o tempo de curso
            Console.WriteLine(cSharpColecoes.TempoTotal);

            //Imprimir(aulasCopiadas);
            Console.WriteLine(cSharpColecoes);
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
            //aulas.ForEach(aula =>
            //{
            //    Console.WriteLine(aula);
            //}
        }
    }
}
