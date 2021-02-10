using System;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    class ColecoesArrayList
    {
        public static void Executar()
        {
            var arraylist = new ArrayList
            {
                "Palavra", // string 
                3, // int
                true // booleano

            };

            arraylist.Add(3.14); // adiciona um valor double na lista 

            foreach (var item in arraylist) // faz uma varredura na arraylist 
            {
                Console.WriteLine("{0} => {1}", item, item.GetType());// GetType Retorna informação sobre a classe do objeto
            }
        }
    }
}
