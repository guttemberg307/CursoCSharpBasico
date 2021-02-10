using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.01;

            // uma forma de concatenar as variaveis 
            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            // uma outra forma de concatenar 
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);

            // colocar o sifrao na frente para referenciar a variavel dentro das chaves 
            Console.WriteLine($"A marca {marca} é muito boa.");
            Console.WriteLine($"1 + 1 = {1 + 1} !!.");

        }

    }
}
