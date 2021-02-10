using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos acessam 
        public string InfoPublica = "Tenho um instagram";

        //transmitido por Herança 
        protected string CorDoOlho = "Verde";

        // mesmo projeto ( mesmo assembly) // quem esta no mesmo projeto vai ter acesso ao celular desta pessoa 
        internal ulong NumeroCelular = 991354721; // ulong nao tem sinal 

        // herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas girias";

        //mesma class ou herança no mesmo projeto 
        private protected string SegredoFamilia = "bla bla ";

        // private é padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade....");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
        




    }
}
;