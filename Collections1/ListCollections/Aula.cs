using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollections
{
    public class Aula : IComparable
    {
        private string titulo;
        private int tempo;

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Tempo { get => tempo; set => tempo = value; }

        public int CompareTo(object obj)
        {
            Aula aulaObj = obj as Aula;
            return titulo.CompareTo(aulaObj.titulo);        
        }

        public override string ToString()
        {
            return $"Titulo: {titulo}, Tempo: {tempo}";
        }

    }
}
