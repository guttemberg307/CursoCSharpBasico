using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {

        public static void Executar()
        {
            // preço com desconto

            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é " + totalComDesconto);

            //IMC

            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2); // Math.Pow --> para elevar um numero a uma potencia, no caso ao lado esta 2 , 
            Console.WriteLine($"IMC é {imc}.");                                        // altura * altura // potenciação

            // Número par/impar

            int par = 24; ;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2); // ZERO e UM é representando por PAR e PAR % 2 respectivamente
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

        }

    }
}