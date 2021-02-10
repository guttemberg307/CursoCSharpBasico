using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }

    class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero; // atribuição feita por valor 
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++; // acrescenta 1
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente // instanciação  de dependente
            {
                Nome = "Beto",
                Idade = 20
           
            
            };

            Dependente copiaDep = dep;// atribuição por referencia 

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");


            copiaDep.Nome = "Renato"; 
            dep.Idade = 21;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

        }

    }
}
