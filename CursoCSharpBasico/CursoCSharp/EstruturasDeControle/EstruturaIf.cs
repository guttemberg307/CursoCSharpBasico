using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIf

    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("digite a nota do aluno: ");
            entrada = Console.ReadLine(); // entrada recebe o que foi digitado 
            Double.TryParse(entrada, out double nota); // TryParse caso nao seja digitado nada ou algo difernte de numero sera retornado ZERO

            Console.Write("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            // if (entrada == "S" || entrada == "s") // se entrada com S maiusculo ou s minusculo = true
            //   bomComportamento = true;

            // bomComoportamento = entrada == "S" || entrada == "s";

            bomComportamento = entrada.ToLower() == "s"; // ToLower converte maiuscula para minuscula

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");

            }

        }

    }
}