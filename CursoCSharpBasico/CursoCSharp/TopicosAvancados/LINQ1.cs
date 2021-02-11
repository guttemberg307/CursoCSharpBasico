using System;
using System.Collections.Generic;
using System.Linq; 

namespace CursoCSharp.TopicosAvancados
{

    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;




    }
    class LINQ1 // Linguage INtegrade Quare // linguagem de consulta integrada 
    {
        public static void Executar()
        {
            var alunos = new List<Aluno> // instancia de uma lista de alunos 
            {
                new Aluno() {Nome ="Pedro",Idade =24, Nota = 8.0},
                new Aluno() {Nome ="Andre", Idade =21, Nota = 4.3},
                new Aluno() {Nome ="Ana", Idade =25, Nota = 9.5},
                new Aluno() {Nome ="Jorge",Idade =20, Nota = 8.5},
                new Aluno() {Nome ="Ana",Idade =21, Nota = 7.7},
                new Aluno() {Nome ="Julia",Idade =22, Nota =7.5},
                new Aluno() {Nome ="Marcio",Idade =18, Nota =6.8}


            };

            Console.WriteLine("======== Aprovados===============");
            // a == alunos 
            //var aprovados = alunos.Where(a => true); // lista de alunos que tem 7 elementos // onde o WHERE recebe uma função lanbda de verdadeiro onde todos estarao na lista de aprovados 
            //var aprovados = alunos.Where(a => false); //WHERE recebe uma função lanbda de falso onde não estarao na lista de aprovados 
            //var aprovados = alunos.Where(a => a.Idade > 24 ); // se idade for maior que 24 entra na lista  
           //var aprovados = alunos.Where(a => a.Nota > 7).OrderBy(a => a.Nome); // lista de aprovados ordenada por nome 
          //var aprovados = alunos.Where(a => a.Nota > 7).OrderBy(a => -a.Nota); // lista de aprovados ordenada por nota menor para maior
            var aprovados = alunos.Where(a => a.Nota > 7).OrderBy(a => -a.Nota); // lista de aprovados ordenada por nota maior para menor usando o SINAL  de subtração antes da letra "a"
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);

            }
            Console.WriteLine("\n=========Chamada ============");

            var chamada =  alunos.OrderBy(a => a.Nome).Select(a => a.Nome); // chamada recebe os alunos ordenados por uma lista alfabetica usando Orderby onde o SELECT retornara somente o nome 
            foreach( var aluno in chamada)
            {
                Console.WriteLine(aluno); // nao precisou usar aluno.nome pq esta acessando uma string e nao mais um objeto aluno 
            }

            Console.WriteLine("\n======================Aprovados ( POR IDADE ) ================");

            var alunosAprovados = // variavel criada 
                from aluno in alunos // filtro de aluno
                where aluno.Nota >= 7 // onde nota de aluno é maior que ou igual  7 
                orderby aluno.Idade // ordenado por idade 
                select aluno.Nome; // selecionando somente o nome do aluno // lista de strings 

            foreach ( var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }

        }

    }
}
