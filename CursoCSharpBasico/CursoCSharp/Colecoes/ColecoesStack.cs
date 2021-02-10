using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);

            foreach( var item in pilha)
            {
                Console.Write($"{item} ");

            }
            Console.WriteLine($"\nPop: {pilha.Pop()}");// vai saca da pilha o ultimo elemento adicionado  

            foreach( var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}");// vai pegar o proximo valor no topo da pilha mais nao vai remover  
            Console.Write(pilha.Count);// mostra que  ele nao foi removido 
        }
    }
}
