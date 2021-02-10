using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploTimeSpan // time span ------>>>>>>>>>> espaço de tempo 
    {
        public static void Executar()
        {
            var intervalo = new TimeSpan (days:10,hours:20, minutes: 30, seconds: 40); // mostra quantidade de dias , horas, minutos e seconds 
            Console.WriteLine(intervalo);

            Console.WriteLine("Minutos: " + intervalo.Minutes); // imprime os minutos 
            Console.WriteLine("Intervalo em minutos: " + intervalo.TotalMinutes); // dias , horas e minutos , transformando em um total de minutos 
           

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);// adiciona 15 minutos a ao tempo atual 

            var tempo = chegada - largada;

            Console.WriteLine("Duração: " + tempo);
            Console.WriteLine("Duração: " + tempo.GetType().Name);//  tipo é o  time span 

            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8)));// vai gerar um espaço de tempo de 8 minutos // acrescenta 8 minutos // esse linha gera um novo timespan sem alterar o original
            Console.WriteLine(intervalo);
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(8)));// subtrai 8 minutos do original semm alterar o antecessor 

            Console.WriteLine("ToString 1: " + intervalo.ToString("g"));// hora, minutos e segundos 
            Console.WriteLine("ToString 2: " + intervalo.ToString("G"));// alem dos segundos vai ter os milisegundos 
            Console.WriteLine("ToString 3 " + intervalo.ToString("c"));//sepada com um ponto o dia da hora 


            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03").TotalMilliseconds);// a string hora foi convertida para timespan 


        }


    }
}
