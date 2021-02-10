using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var nome = "Gutemberg"; // o csharp atribui a variavel nome como string por causa das aspas duplas
            //nome = 1234;
            Console.WriteLine(nome);

            // int idade;
            int idade = 32;
            Console.WriteLine(idade);

            int a;

            a = 3;

            int b = 2;

            Console.WriteLine(a + b);



        }


    }
}