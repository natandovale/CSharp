using System;
using System.Collections.Generic;
using System.Text;

namespace Dicionario
{
    public class Aluno
    {

        private IDictionary<int, Aluno> alunos = new Dictionary<int, Aluno>();

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int numeroMatricula;
        public int NumeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }

        internal void Matricula(Aluno aluno)
        {
            // cria a relação no Dictionary
            alunos.Add(aluno.NumeroMatricula, aluno);
        }

        //internal Aluno BuscaMatriculado(int numero)
        //{
        //    return alunos[numero];
        //}
        internal Aluno BuscaMatriculado(int numero)
        {
            Aluno result = null;
            this.alunos.TryGetValue(numero, out result);
            return result;
        }
    }
}
