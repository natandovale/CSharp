﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace csharp7.R07.antes
{
    class MenuItem : csharp7.MenuItem
    {
        public override void Main()
        {
            Console.WriteLine("Calculadora Para Somar Qualquer Tipo");
            Console.WriteLine("====================================");
            Console.WriteLine();

            var calculadora = new Calculadora();
            calculadora.Somar(2); //int
            calculadora.Somar(3.0m); //decimal
            calculadora.Somar(3.0); //double
            calculadora.Somar(new int[] { 4, 5, 6 });
            calculadora.Somar(new decimal[] { 4.1m, 5.2m, 6.3m });
            calculadora.Somar(new double[] { 4.1, 5.2, 6.3 });
            calculadora.Somar("20");
            calculadora.Somar("R$ 20");
            calculadora.Somar("[20]");
            calculadora.Somar(new object[] { "20", 100, 150m, 24.0, "R$ 12,34" });
        }
    }

    class Calculadora
    {
        private const string NUMERO_ENTRE_COLCHETES = @"\[(\d+)\]";

        public double Soma { get; private set; } = 0d;

        public void Somar(object parametro)
        {
            var cultura = CultureInfo.CurrentCulture;

            
            if (double.TryParse(parametro.ToString(), out var valorDouble))
            {
                Console.WriteLine($"Total anterior: {Soma}");
                Console.WriteLine($"Somando: {valorDouble}");
                Soma += valorDouble;
                Console.WriteLine($"Total atual: {Soma}");
                Console.WriteLine();
                return;
            }

            if (int.TryParse(parametro.ToString(), out var valorInt))
            {
                Somar((double)valorInt);
                return;
            }

            if (decimal.TryParse(parametro.ToString(), out var valorDecimal))
            {
                Somar((double)valorDecimal);
                return;
            }

            if (parametro is string)
            {
                var str = parametro as string;
                if (Regex.Match(str, NUMERO_ENTRE_COLCHETES).Success)
                {
                    Somar(Regex.Match(str, NUMERO_ENTRE_COLCHETES).Groups[1].Value);
                    return;
                }

                if (double.TryParse(parametro.ToString(), NumberStyles.Currency, cultura.NumberFormat, out valorDouble))
                {
                    Somar(valorDouble);
                    return;
                }
            }

            if (parametro is IEnumerable<object> colecao)
            {
                foreach (var item in colecao)
                {
                    Somar(item);
                }
                return;
            }

            if (parametro is IEnumerable<int> colecaoInt)
            {
                foreach (var item in colecaoInt)
                {
                    Somar(item);
                }
                return;
            }

            if (parametro is IEnumerable<decimal> colecaoDecimal)
            {
                foreach (var item in colecaoDecimal)
                {
                    Somar(item);
                }
                return;
            }

            if (parametro is IEnumerable<double> colecaoDouble)
            {
                foreach (var item in colecaoDouble)
                {
                    Somar(item);
                }
                return;
            }
        }
    }
}
