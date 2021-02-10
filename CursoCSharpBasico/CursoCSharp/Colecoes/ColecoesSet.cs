using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
 

    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("  Game Of Thrones", 49.9);

            var carrinho = new HashSet<Produto>(); // Set é uma estrutura não é indexado e nao aceita duplicação 
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("  Camisa", 29.9),
                new Produto("  8 Temporada Game Of Thrones", 99.9),
                new Produto("  Poster", 10),
                new Produto("  Poster", 10)
            };

            carrinho.UnionWith(combo);//
            Console.WriteLine(carrinho.Count);
          //  carrinho.RemoveAt(3);


            foreach (var item in carrinho)
            {
              //  Console.Write(carrinho.IndexOf(item)); 
                Console.WriteLine($"{item.Nome} {item.Preco}"); 
            }

            Console.WriteLine(carrinho.Count);// antes de colocar o livro
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);// apos add o livro , continua a mesma quantidade pois nao aceita dublicação
            // Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
