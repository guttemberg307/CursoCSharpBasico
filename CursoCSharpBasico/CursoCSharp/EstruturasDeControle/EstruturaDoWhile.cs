﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;

            do // do pelo menos uma vez é executada
            {
                Console.WriteLine("Qual o seu nome?");
                entrada = Console.ReadLine(); // armazena tudo o nome digitado no console 

                Console.WriteLine("Seja bem vindo!! {0}", entrada);
                Console.WriteLine("Deseja continuar? (S/N)");
                entrada = Console.ReadLine();

            } while (entrada.ToLower() == "s");// ToLower() transforma caracters maiusculos em minusculos


        }

    }
}