using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;// atribuição por referencia 

            Console.WriteLine(p1 == p2);// eles nao sao iguais porque apontam espaços de memorias diferentes 
            Console.WriteLine(p3 == p2);// eles sao iguais porque apontam espaços de memorias iguais

            Console.WriteLine(p1.Equals(p2)); // produto 1 é igual a produto 2 ? Equals compara o endereço de memoria 
        }
    }
}
