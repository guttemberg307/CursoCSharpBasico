using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Opa!";


            foreach (var letra in palavra) // cada letra " OPA " sera atribuida a variavel LETRA
            {
                Console.WriteLine(letra);

            }
            var alunos = new string[] { "Ana", "Bia", "Carlos" }; // aqui foi feita uma lista "Array"
            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);

                // foreach = percorre do primeiro ate o ultimo elemento 
            }
        }

    }
}