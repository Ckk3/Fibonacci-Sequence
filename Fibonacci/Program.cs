using System;
using System.Collections.Generic;

namespace Fibonacci {
    class Program {
        static void Main(string[] args) {
            //Declarando Variáveis
            List<int>  fibonacci;
            int anterior, anterior2, primeiro, segundo, quant;

            //Iniciando Variáveis
            fibonacci = new List<int> { };
            anterior = 0;
            anterior = 0;
            primeiro = 0;
            segundo = 0;
            quant = 0;

            Console.Write("Digite o primeiro número: ");
            primeiro = int.Parse(Console.ReadLine().ToString());
            fibonacci.Add(primeiro);

            Console.Write("Digite o segundo número: ");
            segundo = int.Parse(Console.ReadLine().ToString());
            fibonacci.Add(segundo);

            Console.Write("Digite quantos números você quer na sequência: ");
            quant = int.Parse(Console.ReadLine().ToString());


            for(int num = 0;num != quant;num++) {
                fibonacci.Add(fibonacci[(fibonacci.Count - 1)] + fibonacci[(fibonacci.Count - 2)]);
            }

            Console.WriteLine($"Os próximos números na sequência são:");
            foreach(var numero in fibonacci) {
                Console.WriteLine(numero);
            }

            Console.ReadKey();
        }
    }
}
