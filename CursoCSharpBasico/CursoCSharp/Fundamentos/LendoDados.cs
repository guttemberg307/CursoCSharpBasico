using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome ? ");
            string nome = Console.ReadLine(); // le o que se escreve 

            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine()); // Int.parse transforma valores inteiros em string 

            Console.WriteLine("Qual é a seu salario? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // CultureInfo.InvariantCulture ignora os simbolos da cultura como virulas e pontos

            Console.WriteLine($"{nome} {idade} R${salario}"); // o sibolo de cifrao foi colocado antes das chaves para interpolar as variaveis


        }

    }
}
