using System;
using System.Collections; // Queue que nao usa Generics 
using System.Collections.Generic;// Queue que  usa Generics 
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue 
    {

        public static void Executar() //Queue --->>> FILA  
        {
            var fila = new Queue<string>();// o tipo da fila armazena valores do tipo string 

            fila.Enqueue("Fulano"); // Enqueue -->> enfileira os itens 
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek()); // Peek --->>> apresenta o primeiro elemento na fila, sem excluilo
            Console.WriteLine(fila.Count); // Count --->> conta os elementos da fila 

            Console.WriteLine(fila.Dequeue()); //Dequeue -->> retira o primeiro elemento na fila 
            Console.WriteLine(fila.Count);

            foreach( var pessoa in fila)
            {
                Console.WriteLine(pessoa); // apresenta os integrantes da fila 
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item")); //Contains ---->> apresenta se é True ou False dentro da lista 
            Console.WriteLine(salada.Contains("Item"));
           

        }
    }
}
