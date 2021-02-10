using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a * b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            return a / b;
        }

    }

    class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;// instacia atual que voce esta trabalhanho 
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;

        }

        public CalculadoraCadeia Subtrair(int a)
        {
            memoria -= a;
            return this;

        }

        public CalculadoraCadeia Dividir(int a)
        {
            memoria /= a;
            return this;

        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;

        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;

        }

        public int Resultado()
        {
            return memoria;
        }


    }

    class MetodosComRetorno
    {

        public static void Executar()
        {

            var CalculadoraComum = new CalculadoraComum();// separado um novo espaço de memoria 

            var resultado = CalculadoraComum.Somar(5, 5); // somar 
            Console.WriteLine(resultado);// apresenta a soma 

            Console.WriteLine(CalculadoraComum.Subtrair(2, 7));
            Console.WriteLine(CalculadoraComum.Multiplicar(4, 4));


            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir(); // zero resultato

            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();// 3 x 2
            Console.WriteLine(resultado);


        }


    }
}
