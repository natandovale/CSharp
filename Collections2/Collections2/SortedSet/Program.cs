using System;
using System.Collections.Generic;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            ISet<string> Alunos = new SortedSet<string>(new ComparadorMinusculo()) 
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Silva",
                "RAFAEL SILVA"
            };

            ISet<string> outroConjunto = new HashSet<string>();
            //este conjunto é subconjunto do outro?
            Alunos.IsSubsetOf(outroConjunto);

            //este conjunto é superconjunto do outro?
            Alunos.IsSupersetOf(outroConjunto);

            //Os conjuntos contêm o mesmo elementos?
            Alunos.SetEquals(outroConjunto);

            //subtrai os elementos da outra coleção que também estão nesse? ExceptWith
            Alunos.ExceptWith(outroConjunto);

            //intersecção dos conjuntos - IntersectWith
            Alunos.IntersectWith(outroConjunto);

            //somente em um ou outro conjunto - SymmetricExceptWith
            Alunos.SymmetricExceptWith(outroConjunto);

            //união de conjuntos - UnionWith
            Alunos.UnionWith(outroConjunto);

            foreach (var item in Alunos)
            {
                Console.WriteLine(item);
            }
        }
    }
}
