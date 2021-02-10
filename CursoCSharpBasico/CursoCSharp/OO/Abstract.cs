using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{

    public abstract class Celular // celular nao pode ser instanciado por ser uma classe abstrata
    { // um metodo abstrado nao tem corpo 

        public abstract string Assistente();// pode ser Siri/ Google assistente ... etc 

        public string Tocar(){

            return "Trim trim trim ...";
        }
   
    }

    public class Sansung : Celular // samsug é uma classe concreta e precisa ser implemtada
    {
        public override string Assistente() // foi feito uma sobscrita em Assistente 
        {
            return "Ola Meu nome é Bixby!"; 
        }
    }

    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Ola meu nome é Siri";
        }
    }

    class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular> // instanciado uma nova lista de celular 
            {
                new Iphone(),
                new Sansung()
            };

            foreach (var celular in celulares) // 
            {
                Console.WriteLine(celular.Assistente()); 
            }

        }


    }


}