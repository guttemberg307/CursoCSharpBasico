using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
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
            // operador == como o método Equals() atuam da mesma forma; ambos comparam os dois objetos por valor:
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro")); // Single retorna somente um resultado // usando essa expressao  "aluno.Nome.Equals("Pedro")" e ela for verdadeira 
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano")); // SingleOrDefault manipula valores nulos evitando erros abrindo margem para uma excessao no caso abaixo para um if 

            if (fulano == null) // se fulano for igual a null 
            {

                Console.WriteLine("Aluno Inexistente");
            }

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));// a primeira Ana da lista alunos 
            Console.WriteLine(ana.Nota); // nota da Ana 

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nota.Equals("Sicrano"));//FirstOrDefault manipula valores nulos evitando erros abrindo margem para uma excessao no caso abaixo para um if 
            if ( sicrano == null) // se sicrano for igual a null 
            {
                Console.WriteLine("Aluno Inexistente");
            }

            var OutraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));// a ultima Ana da lista alunos 
            Console.WriteLine(OutraAna.Nota); // nota da ultima ana Ana 

            var exemploSkip = alunos.Skip(1).Take(3);// SKIP pula um aluno na lista // TAKE imprime o 3 alunos da lista 
           
            foreach( var item in exemploSkip)
                Console.WriteLine(item.Nome);

            var maiorNota = alunos.Max(aluno => aluno.Nota);// MAX faz a seleção da maior nota  da lista alunos 
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);// MIN faz a seleção da menor nota  da lista alunos 
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);// SUM vai fazer a soma de todas as notas da lista 
            Console.WriteLine(somatorioNotas);

            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);// AVERAGE faz a media da lista da turma 
            Console.WriteLine(mediaDaTurma);

            var MediaDosAprovavos = alunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota); // todos os alunos filtrados "WHERE" pela nota >=7 e logo apos fazendo a media com Average das notas remanescentes 
            Console.WriteLine(MediaDosAprovavos);

        }
    }
}
