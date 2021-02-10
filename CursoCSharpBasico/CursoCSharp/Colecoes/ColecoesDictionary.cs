using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();//aceita repetição no valor mais nao aceita repetição na chave 

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004: " + filmes[2004]);//-->>se voce tentar acessar um vahve que ano existe vai gerar um erro 
                Console.WriteLine("2006: " + filmes.GetValueOrDefault(2006));//GetValueOrDefault-->>> retorna o valor que voce passar ou retorna nulo caso nao exista  
                Console.WriteLine("2008: " + filmes.GetValueOrDefault(2008));//GetValueOrDefault-->>> vai retornar um valor nulo pois nao esta na lista 

            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));// ContainsValue--> apresenta verdadeiro ou falso , esta ou nao contido na lista 
            
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}"); // remove o intem da lista, caso tenha removido retorna true, caso nao retorna falso 

            filmes.TryGetValue(2006, out string filme2006);//out passa um parametro por referencia // a chave 2006 vai jogar o valor associado em filme2006
            Console.WriteLine($"filme {filme2006}!");


            foreach ( var chave in filmes.Keys) // percorre as chaves da lista 
            {
                Console.WriteLine(chave); 
            }

            foreach ( var valor in filmes.Values)// percorre o valor no caso as strings de cada chave 
            {
                Console.WriteLine(valor);
            }
                    
            foreach (KeyValuePair<int, string> filme in filmes) // percorre o valor e chaves ao mesmo tempo
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

            foreach( var filme in filmes) // o proprio compilador infere a função KeyValuePair
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");

            }

        }
    }
}


