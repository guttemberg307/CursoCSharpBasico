using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class MetodosEstaticos
    {
        public class CalculadoraEstatica
        {
            public static int Somar(int a, int b) // quando colocamos STATIC o metodos não pertece mais ao objeto e sim a classe
            {
                return a + b;                   // um atributo estatico tem somente uma unica copia sendo compartilhada com todos os objetos 
            }

            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }

        }

        public static void Executar()
        {
            // Metodo de Classe ou Métodos  Estaticos
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);// nao precisa usar uma instaciação 
            Console.WriteLine("Resultado: {0}", resultado);


            Console.WriteLine(CalculadoraEstatica.Somar(2, 13));
        }
    }

}
