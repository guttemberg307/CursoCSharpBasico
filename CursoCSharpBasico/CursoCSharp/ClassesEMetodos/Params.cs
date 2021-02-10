using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{

    class Params
    {
        //foi criado um metrodo estatico para nao precisar criar uma instacia 
        public static void Recepcionar(params string[] pessoas)// o parametro pessoas agrupa qualquer quantidade 1,2,3,4....dentro do Array de strings nomeados por pessoas
        {
            foreach (var pessoa in pessoas)// passa por cada um dos elementos usando o foreach
                Console.WriteLine("Olá {0}", pessoa);

        }
        public static void Executar()
        {

            Recepcionar("Pedro", "Manu", "Roger", "Ana", "Bia");// podemos colocar quantos parametros quizermos dentro da função recepcionar

        }
    }
}
