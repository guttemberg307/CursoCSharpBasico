using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);// conversao implicita 

            double nota = 9.7;
            int notaTruncada = (int)nota; // convertendo double para inteiro 
            Console.WriteLine("Nota truncada: {0}", notaTruncada);// houve uma parda de informaçao 0.7

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString); // converte o numero para string 
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);// convert o string para valor inteiro usando o Convert.ToInt32
            Console.WriteLine("resultado: {0}", idadeInteiro);

            Console.Write("Digite o primeiro numero: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero); // converte PALAVRA e jogue dentro de NUMERO, caso nao consiga retorna o valor ZERO
            Console.WriteLine("Resultado 1:{0}", numero);


            Console.Write("Digite o segundo numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2:{0}", numero2);

        }

    }
}
