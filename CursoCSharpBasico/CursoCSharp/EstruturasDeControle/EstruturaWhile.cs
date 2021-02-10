using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random(); // foi feita uma instanciação do Random 

            int numeroSecreto = random.Next(1, 16); // vai ser contado de 1 ate 15 , 16 nao é contado
            bool numeroEncontrado = false;          // gera um numero secreto entre 1 e 15
            int tentativasRestantes = 5; // começa com 5
            int tentativas = 0; // termina com 0

            //enquanto                //5                        //true
            while (tentativasRestantes > 0 && !numeroEncontrado)// enquanto houver tentativas e o numero nao tiver sido encontrado continue executando
            {
                Console.WriteLine("insira o seu palpite");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite); // entrada recebe e tryparse joga em palpite

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) // usuario acertou o palpite
                {
                    numeroEncontrado = true; // numero encontrado verdadeiro
                    var corAnterior = Console.BackgroundColor; // cor atual do console alocando na variavel
                    Console.BackgroundColor = ConsoleColor.Green; // alterou a cor para verde
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior; // volta a cor original

                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor .... tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
            }

        }
    }
}
