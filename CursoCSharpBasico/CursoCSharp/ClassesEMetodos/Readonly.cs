using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp
{

    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento; // Datetime é um formato de data 
        // readonly no momento da construçao do objeto setar um valor imutavel de somente leitura 

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }
   
        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);// apresenta dia mes é ano

        }
    
    }
    class Readonly
    {
          public static void Executar()
        {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());


        }
    }
}
