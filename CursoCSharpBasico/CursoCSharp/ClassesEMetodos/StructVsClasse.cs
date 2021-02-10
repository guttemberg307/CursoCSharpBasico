using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{

    public struct SPonto
    {
        public int X;
        public int Y;
    }
    public class CPonto
    {
        public int X;
        public int Y;
    }

    class StructVsClasse
    {
        public static void Executar() // tipo STRUCT é sempre passado por valor e nao por referencia 
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; // atribuição feita por VALOR!!! 
            ponto1.X = 3; // atribuição feita por referencia 

            Console.WriteLine("Ponto 1 x:{0}", ponto1.X); // passado por valor 
            Console.WriteLine("Copia Ponto 1 x:{0}", copiaPonto1.X); // passado por referencia 


            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto2 = ponto2; //atribuição feita por referencia,
            ponto2.X = 5;


            Console.WriteLine("Ponto 2 X:{0}", ponto2.X);
            Console.WriteLine("Copia do Ponto 2 X:{0}", copiaPonto2.X);

        }

    }
}
