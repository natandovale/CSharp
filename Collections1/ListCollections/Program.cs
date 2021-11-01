using System;
using System.Collections.Generic;
using System.Linq;

namespace ListCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var aulaIntro = new Aula("Introdução às Coleções", 20);
            var aulaModelando = new Aula("Modelando a Classe Aula", 18);
            var aulaSets = new Aula("Trabalhando com Conjuntos", 16);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            //aulas.Sort();g1
            //Imprimir(aulas);

            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            Imprimir(aulas);
            //List<string> aulas = new List<string>
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            //List<string> aulas = new List<string>();
            //aulas.Add(aulaIntro);
            //aulas.Add(aulaModelando);
            //aulas.Add(aulaSets);
            //Imprimir(aulas);

            //Console.WriteLine("A primeira aula 'Trabalhando' é: " + aulas.First(aula => aula.Contains("Trabalhando")));
            //Console.WriteLine("A ultima aula 'Trabalhando' é: " + aulas.Last(aula => aula.Contains("Trabalhando")));

            //List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            //Imprimir(copia);
            //List<string> clone = new List<string>(aulas);

        }

        private static void Imprimir(List<Aula> aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}
            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            }
            );
        }
    }

}
