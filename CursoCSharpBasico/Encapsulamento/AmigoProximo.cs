using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
   public class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade(); // acessa os atributos atraves de composição

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoProximo...");

            Console.WriteLine(amiga.InfoPublica);// todos veem 
            //Console.WriteLine(amiga.CorDoOlho);// por ter sido marcado como protect e ser transmetido por herança 
            Console.WriteLine(amiga.NumeroCelular); // acessa pois ser algo interno
            Console.WriteLine(amiga.JeitoDeFalar);// é transmitido por herança ou quem esta no mesmo projeto 
            //Console.WriteLine(amiga.SegredoDeFamilia); // é transmitido somente por herança 
          //  Console.WriteLine(amiga.UsaMuitoPhotoshop); // apenas a classe te acesso 
        }

    }
}
