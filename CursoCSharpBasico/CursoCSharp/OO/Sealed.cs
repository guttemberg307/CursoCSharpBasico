using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    sealed class SemFilho // classe selada nao permite herança 
    {
        public double ValorDaFortuna()
        {
            return 1_407_033.65;

        }
    }

    // class SouFilho : SemFilho {
    //}

    class Avo
    {
        public virtual bool HonrarNomeFamilia() // o metodo virutal permite a subscrita 
        {
            return true;
        }
    }

    class pai : Avo
    {
        public sealed override bool HonrarNomeFamilia()
        { // todos que estao abaixo de pai vai herdar esse metodo            

            return true;
        }

    }

    class FilhoRebelde : pai // nao vai sobscrever esse metodo pra falso , pois o metodo esta SELADO
    {
        //public override bool HonrarNomeFamilia()
        // {
        //     return false;
        // }
    }


    class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }

    }

}