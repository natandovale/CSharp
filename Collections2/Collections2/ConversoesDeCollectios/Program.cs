using System;

namespace ConversoesDeCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //No C#, a covariância e a contravariância habilitam a conversão de referência implícita para tipos de matriz, 
            //tipos de delegados e argumentos de tipo genérico. A covariância preserva a compatibilidade de atribuição, e 
            //a contravariância reverte.
            Console.WriteLine("string para object");
            string titulo = "meses";
            object obj = titulo;
            Console.WriteLine(obj);
           
            //IList<object> listaObj = listaMeses;
            Console.WriteLine();

            Console.WriteLine("strin[] para object[]?");
            string[] arrayMeses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            object[] arrayObj = arrayMeses;
            Console.WriteLine(arrayObj);
        }
    }
}
