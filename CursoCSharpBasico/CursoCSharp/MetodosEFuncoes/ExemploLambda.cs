using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {

            // todo Action é uma funçao que nao tem retorno 
            Action algoNoConsole = () => // () = > --->> esta função anonima que é um lambda 
            {
                Console.WriteLine("Lambda com c#");
            };

            algoNoConsole();

            Func<int> jogarDado = () => // <int> é o tipo que retorno que a função vai retornar 
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            // a função recebe inteiro e string como parametro de retorno 
            Func<int, string> conversorHex = numero => numero.ToString("X");//numero.ToString("X"); o retorno é implicito 
            Console.WriteLine(conversorHex(1234));//conversorHex coversor de Hexadecimal 

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>// funcao eron 
               string.Format("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);
            Console.WriteLine(formatarData(05,02,2021));
        }
    }
}
