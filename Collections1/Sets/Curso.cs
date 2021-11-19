using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
    public class Curso
    {
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        private IList<Aula> aulas;
        private string nome;
        private string instrutor;

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public int TempoTotal 
        {
            get
            {
                int total = 0;
                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}
                //return total;

                //LINK = Language Integrated Query
                //Consulta de integração a linguagem
                return aulas.Sum(aula => aula.Tempo);
            } 
        }

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            aulas = new List<Aula>();
        }

        internal void Adiciona(Aula aula)
        {
            aulas.Add(aula);
        }

        public void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(",", aulas)}";
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }
    }
}
