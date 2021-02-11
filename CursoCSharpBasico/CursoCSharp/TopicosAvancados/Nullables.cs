using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Nullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null; // Nullable vai fazer que um numero inteiro recebe o valor Nulo 
            int? num2 = null; // um tipo que tem uma interrogação pode tambem associar a um valor nulo 

            if (num1.HasValue) // num tem valor? ele vai retornar falso 
            {
                Console.WriteLine("Valor de num: {0}", num1);
            }
            else
            {
                Console.WriteLine("A variavel não possui valor");
            }

            // int valor = num1 // no caso não int nao é Nullable e nao vai haver atribuição de num1 
            int valor = num1 ?? 1000; // aqui os dois ?? atribui a num1 o numero 1000 burlando a regra do Nullable 
            Console.WriteLine(valor);

            bool? booleana = null; // bool? é usando para aceitar o valor numero, ja que bool só apresentaro valor false ou true
            bool resultado = booleana.GetValueOrDefault();//GetValueOrDefault() essa função retorna um valor ou se nao houver valor vai retornar um valor falso que é o valor padrao booleano 

            Console.WriteLine(resultado);

            try
            {
                int x = num1.Value; // num nao pegou o valor padrao e sim o Velue 
                int y = num2.Value;
                Console.WriteLine(x + y);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
             
        }

    }
}
