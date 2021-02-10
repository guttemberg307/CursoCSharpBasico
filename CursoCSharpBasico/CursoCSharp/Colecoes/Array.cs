using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {

        public static void Executar()
        {
            string[] alunos = new string[5]; // Alunos é o  identificador que armazena 5 valores 
                                             // Array é uma estrutura homonegeneo e estatico 
                                             // Array é uma estrututa que funciona a partir de um Indice (indexado)
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emmanuel";


            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };// array double de notas com 5 elementos 

            foreach (var nota in notas)// faz uma varredura de todas as notas 
            {
                somatorio += nota; // faz o somatorio de todas elas 
            }

            double media = somatorio / notas.Length;// numeros de eleme
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };// array char  de notas com 5 elementos 
            string palavra = new string(letras);
            Console.WriteLine(palavra);
            
        }

    }
}