using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {

        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            // true                 
            bool comprouTv50 = executouTrabalho1 && executouTrabalho2;   // E
            Console.WriteLine("Comprou a tv 50? {0}", comprouTv50);


            var comprouSorvete = executouTrabalho1 || executouTrabalho2; // OU
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; // OU Exclusivo
            Console.WriteLine("Comprou a Tv de 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudavel? {0}", !comprouSorvete); // negação --> inverte o valor 

        }


    }
}
