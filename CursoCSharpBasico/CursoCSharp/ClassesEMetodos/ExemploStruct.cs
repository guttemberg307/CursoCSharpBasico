using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{

    interface Ponto // por padrao o metodo da interface é publico //
    {
        void MoverNaDiagonal(int delta); // função sem corpo 
    }

    struct Coordenada : Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y) // contrutor cheio 
        {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta)
        {
            X += delta; // atribuição aditiva , esta somando o delta a variavel x 
            Y += delta; // atribuição aditiva , esta somando o delta a variavel x 
        }

    }

    class ExemploStruct
    {
        public static void Executar()
        {

            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10); // delta vale 10 somando X e Y, Resultado 19 e 11

            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("x = {0}", coordenadaFinal.X);
            Console.WriteLine("y = {0}", coordenadaFinal.Y);

        }
    }
}
