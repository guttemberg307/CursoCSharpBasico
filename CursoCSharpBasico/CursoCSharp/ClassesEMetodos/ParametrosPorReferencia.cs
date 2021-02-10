using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosPorReferencia
    {
        // REF duas direçoes , OUT uma unica direção 
        public static void AlterarRef(ref int numero) // ref passa o numero 3 como referencia resultado sera 1003
        {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero)//out é UNIDIRECIONAL , o metodo devolde o valor que foi passado, nao recebendo nenhum valor  
        {
            numero = 0;// o numero tem que receber um valor qualquer  para poder inicializar com OUT
            numero = numero + 15;
        }

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a); // ref tambem na hora de chamar o metodo , ficando mais claro do que de fato esta acontecendo uma referencia 
            Console.WriteLine(a);

            // int b;
            AlterarOut(out int b);
            Console.WriteLine(b);

        }


    }
}