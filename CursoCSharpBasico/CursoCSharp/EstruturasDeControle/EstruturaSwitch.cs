using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie meu atendimento com a nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota); // pegou um tryparse do que leu no console e jogou na variavel nota 

            switch (nota)
            {
                case 0:
                    Console.WriteLine("pessimo");
                    break; // Csharp nao é suportado sem o Break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Parabens!!");
                    Console.WriteLine("Otimo");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    break;
            }
            Console.WriteLine("Obrigado por responder !!");
        }

    }
}
