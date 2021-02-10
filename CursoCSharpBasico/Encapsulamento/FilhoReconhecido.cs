using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
  public class FilhoReconhecido : SubCelebridade // -->> filhoReconhecido herda de subcelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoReconhecido......");

            Console.WriteLine(InfoPublica); //consegue acessar 
            Console.WriteLine(CorDoOlho); // consegue receber por estar no mesmo projeto e por ser herança 
            Console.WriteLine(NumeroCelular); // consegue por estar proximo e estar no mesmo projeto 
            Console.WriteLine(JeitoDeFalar);//  
            Console.WriteLine(SegredoFamilia);// é transmitido por herança e estar no mesmo projeto
          //Console.WriteLine(UsaMuitoPhotoshop); nao tem acesso por ser um atributo privado 
        }

    }
}
