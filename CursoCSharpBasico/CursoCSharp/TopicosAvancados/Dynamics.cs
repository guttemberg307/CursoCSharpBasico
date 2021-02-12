using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste"; // inicializou com um string // variavel dynamic 
          //string meuObjeto = "teste";   vai dar um erro na compilação pois o compilador nao da certo com a string 
          //var meuObjeto = "teste";  mesma coisa com var 
           
            meuObjeto = 3; // incrementou um numero inteiro 
            meuObjeto++; // incrementa mais um numero 
            Console.WriteLine(meuObjeto);

            

            dynamic aluno = new System.Dynamic.ExpandoObject();// cria objetos com atributos de forma dinamica 
            aluno.nome = "Maria Julia";
            aluno.nota = 8.9;
            aluno.idade = 24;

            Console.WriteLine($"{aluno.nome} {aluno.nota} {aluno.idade}");
        }

    }
}
