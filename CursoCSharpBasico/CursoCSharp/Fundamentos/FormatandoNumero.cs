using System;
using System.Globalization;


namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()

        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // arredonda o valor para 15,20
            Console.WriteLine(valor.ToString("C")); // transforma o valor em um valor monetario R$
            Console.WriteLine(valor.ToString("P")); // coloca como percentual e multiplica por 100
            Console.WriteLine(valor.ToString("#.##")); // delimita a quantidade de casas decimais 


            CultureInfo cultura = new CultureInfo("pt-BR"); // faz uma instanciação de uma nova cultura para portugues do Brasil 
            Console.WriteLine(valor.ToString("C0", cultura)); // passa o um valor em dinheiro sem nenhuma casa decimal

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // D10 --> acrescenta zeros a esquerda 


        }
    }
}