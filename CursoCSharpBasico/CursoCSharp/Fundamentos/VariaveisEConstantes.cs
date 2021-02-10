using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {   // area da circuferencia
            double raio = 4.5;
            const double PI = 3.14; // por ser uma constante ela nao altera o seu valor de 3.14

            raio = 5.5;

            // PI = 3.1453;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Area é de: " + area);
            Console.WriteLine("Area é de: " + (area + 1000));

            // tipos internos 

            bool estaChovendo = true; // bool = boleano --> verdadeiro ou falso 

            Console.WriteLine("Esta chovendo  " + estaChovendo);

            byte idade = 45; // valores positivos de ate i64 bytes
            Console.WriteLine("idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;  // menor valor é - 128 bytes
            sbyte saldoDeGol = sbyte.MaxValue;  // maior valor é  127 bytes

            Console.WriteLine(" menor saldo de gols: " + saldoDeGols);
            Console.WriteLine(" maior saldo de gols: " + saldoDeGol);

            short salario = short.MaxValue; // short maior valor 32767 short 
            Console.WriteLine("salario: " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("menor int: " + menorValorInt);

            int maiorValorInt = int.MaxValue;
            Console.WriteLine("menor int: " + maiorValorInt);

            float precoComputador = 129.99f; // valores escritos sem o f no fina é atribuido com double
            Console.WriteLine(" o preco do computador é: " + precoComputador);


            double valorDeMercadoDaApple = 1_000_000_000_000.00;//  mais usado dos reais 
            Console.WriteLine("valor aplle de mercado: " + valorDeMercadoDaApple);

            char letra = 'b';
            Console.WriteLine("letra " + letra);

            string texto = " Seja bem vindo ao curso de C#";
            Console.WriteLine(texto);

        }

    }
}