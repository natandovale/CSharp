using System;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();
            sorted.Add("VT", new Aluno("Vanessa", 234232));
            sorted.Add("AL", new Aluno("Ana", 4545554));
            sorted.Add("RN", new Aluno("Rafael", 654354));
            sorted.Add("WM", new Aluno("Wanderson", 764455));

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
