using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class DelegateFunAnonima
    {
        delegate string StringOperacao(string s); // delegate retorna uma string 
        public static void Executar()
        {
            StringOperacao inverter = delegate (string s)
            {
                char[] charArray = s.ToCharArray();// lista de char, convertendo s com ToCharArray() "cadeia de caracteres"
                Array.Reverse(charArray); // Array.Reverse inverte todos os caracteres 
                return new string(charArray); // retorna os caracteres invertidos 
            };

            Console.WriteLine(inverter("C# é Show!!!"));  
        }

    }
}
