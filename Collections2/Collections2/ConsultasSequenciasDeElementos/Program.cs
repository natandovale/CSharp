using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsultasSequenciasDeElementos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mounth> meses = new List<Mounth>
            {
               new Mounth("Janeiro ",31),
               new Mounth("Fevereiro",28),
               new Mounth("Março    ",31),
               new Mounth("Abril    ",30),
               new Mounth("Maio     ",31),
               new Mounth("Junho    ",30),
               new Mounth("Julho    ",31),
               new Mounth("Agosto   ",31),
               new Mounth("Setembro ",30),
               new Mounth("Outubro  ",31),
               new Mounth("Novembro ",30),
               new Mounth("Dezembro ",31)
            };

            //Pegar o primeiro trimestre
            var consulta = meses.Take(3);
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }

            //Pegar os meses depois do primeiro trimestre
            var consulta2 = meses.Skip(3);

            //Pegar os 3 primeiros meses do terceiro trimestre
            var consulta3 = meses.Skip(6).Take(3);

            //Pegar os meses até que o mês comece com a letra 's'
            var consulta4 = meses.TakeWhile(m => !m.Nome.StartsWith("S"));

            //Pular os meses até que o mês comece com a letra 's'
            var consulta5 = meses.SkipWhile(m => !m.Nome.StartsWith("S"));

            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };

            Console.WriteLine("concatenando duas sequências");
            seq1.Concat(seq2);

            Console.WriteLine("união de duas sequências");
            seq1.Union(seq2);

            Console.WriteLine("união de duas sequências com comparador IgnoreCase");
            seq1.Union(seq2, StringComparer.InvariantCultureIgnoreCase);

        }

        public class Mounth : IComparable
        {
            public string Nome { get; private set; }
            public int Dias { get; private set; }

            public Mounth(string nome, int dias)
            {
                Nome = nome;
                Dias = dias;
            }
            public override string ToString()
            {
                return $"{Nome} -{Dias}";
            }

            public int CompareTo(object obj)
            {
                Mounth outro = obj as Mounth;

                return this.Nome.CompareTo(outro.Nome);
            }
        }
    }
}
