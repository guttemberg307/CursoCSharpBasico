using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class UsandoDelegates
    {
        delegate double Soma(double a, double b);// retorna double 
        delegate void imprimirSoma(double a, double b);// retorna void 

        static double MinhaSoma(double x, double y) // funcões que nao esta ligadas ao delegate 
        {
            return x + y;
        }

        static void MeuImprimirSoma(double a, double b)// funcões que nao esta ligadas ao delegate 
        {
            Console.WriteLine(a + b);
        }

        public static void Executar()
        {

            Soma op1 = MinhaSoma; // delegate associado a uma funcão // fazendo sempre com os parametros que recebo com o tipo de retorno 
            Console.WriteLine(op1(3,4));

            imprimirSoma op2 = MeuImprimirSoma;
            op2(3.4,8); // 

            // essa funcao esta em um delegate 
            Func<double, double, double> op3 = MinhaSoma; // são 3 dobles na funcao, sendo que sempre o ultimo é o tipo de retorno 
            Console.WriteLine(op3(9.5, 4));

            // esse action tambem esta em delegate porem nao tem retorno por isso só tem DOIS double 
           Action<double, double> op4 = MeuImprimirSoma;
           op4(2.5, 4);
        }
    }

}

