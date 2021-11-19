using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sets
{
    public class Aluno
    {
        private string nome;
        private int matricula;
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public Aluno(string nome, int matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;
            if(outro == null)
            {
                return false;
            }
            return nome.Equals(outro.nome);
        }

        public override string ToString()
        {
            return $"Nome: {nome}\nMatricula: {matricula}\n";
        }

        public override int GetHashCode()
        {
            return nome.GetHashCode();
        }
    }
}
