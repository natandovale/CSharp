using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsultandoCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROBLEMA: obter os nomes dos meses do ano, que tem 31 dias, em maiúsculo e em ordem alfabética
            //Janeiro 31
            //Fevereiro 28
            //Março 31
            //Abril 30
            //Maio 31
            //Junho 30
            //Julho 31
            //Agosto 31
            //Setembro 30
            //Outubro 31
            //Novembro 30
            //Dezembro 31

            List<Mes> meses = new List<Mes>
            {
               new Mes("Janeiro ",31),
               new Mes("Fevereiro",28),
               new Mes("Março    ",31),
               new Mes("Abril    ",30),
               new Mes("Maio     ",31),
               new Mes("Junho    ",30),
               new Mes("Julho    ",31),
               new Mes("Agosto   ",31),
               new Mes("Setembro ",30),
               new Mes("Outubro  ",31),
               new Mes("Novembro ",30),
               new Mes("Dezembro ",31)
            };

            //meses.Sort();
            //foreach (var mes in meses)
            //{
            //    if (mes.Dias == 31)
            //    {
            //        Console.WriteLine(mes.Nome.ToUpper());
            //    }
            //}

            IEnumerable<string>
            consulta = meses
                            .Where(m => m.Dias == 31)
                            .OrderBy(m => m.Nome)
                            .Select(m => m.Nome.ToUpper());

            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Mes : IComparable
    {
        public string Nome { get; private set; }
        public int Dias { get; private set; }

        public Mes(string nome, int dias)
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
            Mes outro = obj as Mes;

            return this.Nome.CompareTo(outro.Nome);
        }
    }
}
