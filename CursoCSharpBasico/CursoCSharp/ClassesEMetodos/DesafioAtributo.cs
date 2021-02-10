using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {

        int a = 10;

        public static void Executar()
        {


            // acessar variavel 'a' dentro do método executar 
            //Console.WriteLine(a);
            DesafioAtributo desafio = new DesafioAtributo();// criar uma instanciação 
            Console.WriteLine(desafio.a); // acessar o atributo atravez da instacia usando anotação '.' PONTO

        }
    }
}
