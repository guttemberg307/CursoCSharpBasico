using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class DelegateComoParametros
    {
        public delegate int Operacao(int x, int y);//

        public static int Soma(int x, int y)// função soma 
        {
            return x + y;
        }

        public static string Calculadora(Operacao op, int x, int y)// funcao que recebe outra funcao Operacao
        {
            var resultado = op(x, y);// variavel resultado recebe OP 
            return "  resultado  " + resultado;
        }

        public static void Executar()
        {
            Operacao subtracao = (int x, int y) => x - y; // usando lambda outra função que recebe dois inteiro e retorna um valor 
            Console.WriteLine(Calculadora(subtracao,3,2));
            
            Console.WriteLine(Calculadora(Soma,3,2)); // resultado da função soma 
        }

    }
}
