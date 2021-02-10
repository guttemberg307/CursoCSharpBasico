using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do aluno:");

            string entrada = Console.ReadLine(); // entrada recebe o que o usuario digitou
            Double.TryParse(entrada, out double nota); // entrada faz um tryparse jogando para a variavel nota 



            if (nota >= 9.0)
            {
                Console.WriteLine("Quadro de honra!");
            }
            else
               if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
                if (nota >= 5.0)
            {
                Console.WriteLine("Recuperação");

            }
            else
            {
                Console.WriteLine("Te vejo na proxima....");
            }
            Console.WriteLine("Fim!!");
        }
    }
}