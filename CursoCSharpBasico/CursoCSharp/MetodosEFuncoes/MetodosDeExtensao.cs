using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro// classe estatica 
    { 
    
        public static int Soma(this int num, int outroNumero)// this quer dizer a instancia atual quando for trabalhar com soma 
        { 
                                    // This associado com o tipo quer dizer que é uma função de extenção 
            return num + outroNumero;

        }

        public static int Subtracao(this int num, int outroNumero)// this quer dizer a instancia atual quando for trabalhar com subtração
        { 

            return num - outroNumero;
        }
    }
     class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;

            Console.WriteLine(numero.Soma(3));// 5 + 3
            Console.WriteLine(numero.Subtracao(10));// 5 - 10

            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.Subtracao(4));
        }

    }

}
