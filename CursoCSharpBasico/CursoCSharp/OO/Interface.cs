using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    interface OperacaoBinaria // membros de interface nao podem ser implementados por padrao são publicos e abstratos 
    {
        int Operacao(int a, int b);
    }

    class Soma : OperacaoBinaria
    {
        public int Operacao( int a, int b)
        { 
            return a + b;
        }   
    }

    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }

    class Multiplicacao: OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calculadora
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> { // cria uma lista chamada operacoes 
            new Soma(), // instancias das operacoes aritmeticas 
            new Subtracao(),
            new Multiplicacao()

         };

        public string ExecutarOperacoes(int a, int b)// pega dois valores 
        {

            string resultado = "";

            foreach( var op in operacoes) // percorre todas as instancias aritmeticas 
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n"; // {op.GetType().Name} ---->>> pega o nome da classe soma , multiplicacao e subtração
            }

            return resultado; // retorna todos os resultados 
        }
    }

    class Interface
    {
            public static void Executar()
        {
            var calc = new Calculadora();// instancia de um nova calculadora 
            var resultado = calc.ExecutarOperacoes(20, 5);// faz o calculado de todas as operações atribuindo a resultado 
            Console.WriteLine(resultado);// apresenta todos os resultados 

        }


    }
}
