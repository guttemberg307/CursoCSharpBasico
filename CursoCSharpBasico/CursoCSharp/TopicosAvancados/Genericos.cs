using System;
using CursoCSharp.Colecoes; // importado de outro projeto para puxar a classe produto 
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{

    public class Caixa<T> // dentro do generics vai ser colocado a letra T ou qualquer outra letra ou quantas quizer 
    {
        T valorPrivado;// esse T tem que ser substituido por um int, string , objeto.. etc // uma substituido ele é trocado automaticamente a todos dentro do codigo 
        public T Coisa { get; set; } // nome da propriedade Coisa do tipo T 

        public Caixa(T coisa) // construtor do tipo coisa 
        {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T metodoGenerico(T valor)// T valor vai receber 33 como valor 
        {
            return new Random().Next(0, 2) == 0 ? Coisa : valor; // random se entre  zero e um , se for igual a zero vai ser Coisa se for igual a 1 vai retornar o valor 
        }

        public T GetValor()
        {
            return valorPrivado;
        }

    }

    class CaixaInt : Caixa<int>
    {//CaixaInt herda de Caixa<int> que ja é difinido como genericos inteiro 
        public CaixaInt() : base(0)
        {



        }
    }

    class CaixaProduto : Caixa<Produto>
    {
        public CaixaProduto() : base(new Produto())
        {

        }
    }

    class Genericos
    {
        public static void Executar()
        {
            var caixa1 = new Caixa<int>(1000); // insntacia de caixa passando como um parametro inteiro como 1000
            Console.WriteLine(caixa1.metodoGenerico(33)); // com esse parametro vai variar entre 1000 e 33 // 33 foi o valor passado para linha 19 do codigo 
            Console.WriteLine(caixa1.Coisa.GetType()); // vai imprimir o tipo inteiro 

            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.metodoGenerico("Metodo")); // obrigatoriamente tem que dizer qual tipo generico sera no caso aqui é "Metodo"
            Console.WriteLine(caixa2.Coisa.GetType());// vai imprimir o tipo string



            CaixaProduto caixa3 = new CaixaProduto();// Instanacia de uma nova caixa 
            Console.WriteLine(caixa3.Coisa.GetType().Name);// agora a variavel caixa tem um produto 




        } 
    }
}