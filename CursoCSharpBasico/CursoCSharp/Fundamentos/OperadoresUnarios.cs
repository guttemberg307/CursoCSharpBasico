using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {

        public static void Executar()

        {

            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // mudou de -5 para 5 
            Console.WriteLine(!booleano); // "!"  inverte de true para false

            numero1++; // adiciona mais 1 
            Console.WriteLine(numero1);

            numero1--; // retira 1
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2); // ++ na frente tem menos prioridade // -- atras tem mais prioridade
            Console.WriteLine($"{numero1} {numero2}");
        }


    }
}

