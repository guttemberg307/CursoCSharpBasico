using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{

    delegate double Operacao(double x, double y); // o tipo do parametro é Double  

    class LambdasDelegate  
    {
        public static void Executar()
        {
            Operacao soma = (x, y) => x + y;  // Soma recebe X e Y que é atribuito a funcao soma X + Y 
            Operacao subtracao = (x, y) => x - y;
            Operacao multiplicacao = (x, y) => x * y;
            Operacao divisao = (x, y) => x / y;

            Console.WriteLine(soma(3,3)); // soma recebe os valores do calculo 
            Console.WriteLine(subtracao(5,2));
            Console.WriteLine(multiplicacao(12,8));
            Console.WriteLine(divisao(6,3));
        }
    }
}
