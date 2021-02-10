using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {    // ToUpper deixa todoas o texto em caixa alta , Replace substitui a palavra por outra
            var saudadacao = "olá".ToUpper().Insert(3, "world!").Replace("world!", " Mundo!");

            Console.WriteLine(saudadacao);

            Console.WriteLine("Testeee".Length); // mostrara a contagem de 5 caracteres 

            string valorImportante = null;

            Console.WriteLine(valorImportante?.Length); // a interrogação fara que nao haja problema mesmo a variavel estando vazia.
        }

    }
}