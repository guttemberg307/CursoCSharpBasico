using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var datetime = new DateTime(year: 2021, month: 2,day: 6) ; // instanciando uma data usando parametros nomeados


            Console.WriteLine(datetime.Day);// apresentado o dia 
            Console.WriteLine(datetime.Month);// apresenta o mes 
            Console.WriteLine(datetime.Year);// apresenta o ano 

            // sem horas 
            var hoje = DateTime.Today;// apresenta a data atual com horas zeradas 
            Console.WriteLine(hoje);// 

            // com horas 
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour); // apresenta a hora atual 
            Console.WriteLine("Minutos: " + diaAtual.Minute);// apresenta o minuto atual 

            var amanha = diaAtual.AddDays(1); // dia atual mais 1
            Console.WriteLine(amanha);


            var ontem = diaAtual.AddDays(-1);// dia atual  menos 1 
            Console.WriteLine(ontem );

            Console.WriteLine(diaAtual.ToString("dd"));//vai imprimir so o dia atual 
            Console.WriteLine(diaAtual.ToString("ddd"));//vai imprimir a dia da semana , exemplo quarta-feira 
            Console.WriteLine(diaAtual.ToString("D"));//vai imprimir dia mes ano e dia da semana por extenso 
            Console.WriteLine(diaAtual.ToString("g"));//imprimir dia mes e ano com hora sem os segundos 
            Console.WriteLine(diaAtual.ToString("G"));//imprimir dia mes e ano com hora e segundo 
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));// vai imprimir no formado que você preferir 








        }

    }
}
