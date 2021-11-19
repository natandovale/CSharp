using System;
using System.Collections.Generic;

namespace Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            //SETS = Conjuntos
            //1.Não permite valores permitidos
            //2.Os elementos não são mantidos em ordem específica 

            //ISet<string> alunos = new HashSet<string>();
            //alunos.Add("Vanessa Tonini");
            //alunos.Add("Ana Losnak");
            //alunos.Add("Rafael Nercessian");

            //Console.WriteLine(string.Join(",", alunos));

            ////Copiando Sets para Lists
            //List<string> alunosEmLista = new List<string>(alunos);
            //alunosEmLista.Sort();
            //Console.WriteLine(string.Join(",", alunos));

            //-------------------------------------------------------

            Curso csharpColecoes = new Curso("C# coleções", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com lista", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com coleções", 24));

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 56173);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));
        }
    }
}
