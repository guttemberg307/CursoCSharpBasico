using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{
    public class NegativoException : Exception // NegativoException é uma exeção, entao herda de Exception
    {
        public NegativoException() { } // construtor vazio 

        public NegativoException(string message) : base(message) { } // contrutor chama menssagem e o contrutor base tambem 

        public NegativoException(string message, Exception inner) // contrutor alem da menssagem recebe outra excessao interna 
            : base(message, inner) { }
    }

    public class ImparException : Exception
    {
        public ImparException(string message) : base(message) { }// construtor que recebe menssagem 
    }

    class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random(); // instancia um novo randon 
            int valor = random.Next(-30, 30);// numero aleatorio entro -30 e 30

            Console.WriteLine(valor);

            if (valor < 0) // valor menor que zero 
            {
                throw new NegativoException("Número negativo... :(");
            }

            if (valor % 2 == 1)// valor com resto igual a 1     
            {
                throw new ImparException("Valor impar... :(");
            }

           return valor; // valor par e valor positivo 
        }

        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            }
            catch (NegativoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ImparException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}