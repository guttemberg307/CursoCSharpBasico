using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class AtributosEstaticos
    {

        public class produto
        {
            public string Nome;
            public double Preco;
            public static double Desconto = 0.1;

            public produto()
            {
            }

            public produto(string nome, double preco, double desconto)
            {
                Nome = nome;
                Preco = preco;
                Desconto = desconto;
            }

            public double CalcularDesconto()
            {
                return Preco - Preco * Desconto;
            }

        }


        public static void Executar()
        {
            var produto1 = new produto("Caneta", 3.2, 0.1);


            var produto2 = new produto()
            {

                Nome = "Borracha",
                Preco = 5.3,

            };


            // podemos modificar os descontos sem mechear na classe , podendo ser alterados indivitualmente usando o STATIC


            produto.Desconto = 0.5; // acessando diretamente o nome da classe podmos alterar o desconto
            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());

            produto.Desconto = 0.02;
            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());

        }
    }
}