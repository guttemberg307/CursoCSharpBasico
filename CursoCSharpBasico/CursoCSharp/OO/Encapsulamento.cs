using System;
using Encapsulamento; /// <summary>
/// este projeto depende do projeto encapsulamento 
/// </summary>
namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("FilhoNaoReconhecido....");

            Console.WriteLine(InfoPublica);// recebe as informçaoes por ser public 
            Console.WriteLine(CorDoOlho);// recebe independente de estar ou nao no mesmo projeto pois é transmitido por herança 
            // Console.WriteLine(NumeroCelular); só recebe quem esta no mesmo projeto 
            Console.WriteLine(JeitoDeFalar);//atributo interno ou transmitido por herança 
                                            //Console.WriteLine(SegredodeFamilia);// é transmitido por herança apenas no proprio projeto
                                            // Console.WriteLine(UsaMuitoPhotoshop) ; // privado ninguem acessa 


        }

    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(CorDoOlho);
            //Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredodeFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);

        }

    }

    class Encapsulamento
    {

        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();


        }


    }
}
