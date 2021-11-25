using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            //entrou: van
            Enfileirar("van");
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);
            Console.WriteLine("FILA:");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("guincho está fazendo o pagamento.");
                }

                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}");
            }
        }
    }
}