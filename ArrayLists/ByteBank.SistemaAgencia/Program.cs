using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679754));
            lista.Adicionar(new ContaCorrente(874, 5679745));
            lista.Adicionar(new ContaCorrente(874, 5679745));
            lista.Adicionar(new ContaCorrente(874, 5679745));
            lista.Adicionar(new ContaCorrente(874, 5679745));
            lista.Adicionar(new ContaCorrente(874, 5679745));
            lista.Adicionar(new ContaCorrente(874, 5679745));
            lista.Adicionar(new ContaCorrente(874, 5679745));
            lista.Adicionar(new ContaCorrente(874, 5679745));
            //e assim por diante
            Console.ReadLine();
        }
        static void Arrays()
        {
            //Arrays
            int[] idades = new int[5];
            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];
                Console.WriteLine($"Valor no índice {indice}: {idade}");
            }
        }

        static void TestaArraydeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4456668),
                    new ContaCorrente(874, 7781438),
                };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }

            Console.ReadLine();
        }
    }
}
