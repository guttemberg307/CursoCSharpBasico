using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome; // compara um produto com outro em valores 
            bool mesmoPreco = Preco == outroProduto.Preco;// Equals nao compara um produto com outro em relação a endereço de memoria 
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode() // GetHashCode() como se fosse um indice de banco de dados, tem a capacidade de juntar um conjunto de dados  
        {
            return Nome.Length; // so vai apresentar somente um poster 10
        }
    }

        class ColecoesList
        {
            public static void Executar()
            {
                var livro = new Produto("  Game Of Thrones", 49.9);

                var carrinho = new List<Produto>();// a lista vai ter produtos com seus respctivos dados, sendo dinamico sem ter um tamanho fixo 
                carrinho.Add(livro);

                var combo = new List<Produto>
            {
                new Produto("  Camisa", 29.9),
                new Produto("  8 Temporada Game Of Thrones", 99.9),
                new Produto("  Poster", 10)
            };

                carrinho.AddRange(combo);// AddRange adiciona um conteudo de uma lista dentro de outra 
                Console.WriteLine(carrinho.Count);// vai dizer quantos elementos possui dentro do carrinho
                carrinho.RemoveAt(3);// remove o item 3 da listagem // 0,1,2,3 ->>> total de 4 itens 


                foreach (var item in carrinho)
                {
                    Console.Write(carrinho.IndexOf(item)); // enumera todos os itens da lista 
                    Console.WriteLine($"{item.Nome} {item.Preco}"); // imprime todos os itens da lista 
                }

                Console.WriteLine(carrinho.Count);
                carrinho.Add(livro);
                Console.WriteLine(carrinho.LastIndexOf(livro));// diz qual o ultimo incide da lista 
            }
        }
    }
