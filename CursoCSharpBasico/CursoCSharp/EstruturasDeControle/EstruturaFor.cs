using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($" O valor de i é {i}.");

            //}

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);//

            for (int i = 1; i <= tamanhoTurma; i++) // a quantidade de repetição vai ser determinado pelo tamanho da turma
            {
                Console.Write("Informe a nota do aluno {0}: ", i); // usuario digitou nota aluno
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);// nota inserida dentro da variavel notaAtual

                somatorio += notaAtual; // faz um somatorio das notas digitadas
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0; // tamanho da turma maior que 0 ? caso seja faça a media ou imprima 0 se nao houver nota 
            Console.WriteLine("Media da turma: {0}", media);

        }
    }
}
