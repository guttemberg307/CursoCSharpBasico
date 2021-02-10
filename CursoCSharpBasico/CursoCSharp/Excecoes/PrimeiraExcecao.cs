using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{
    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)// se valor for maior que salda faça 
            {
                throw new ArgumentException("Saldo insuficiente.");//  throw para de forma abrupta e retorna ao metodo que chamou 
            }

            Saldo -= valor; // caso saldo for maior que valor, subtrai do saldo 
        }

    }

        class PrimeiraExcecao
        {
            public static void Executar()
            {
                var conta = new Conta(1_223.45);// instancia de uma nova conta 

                try// caso der algum erro 
                {
                    conta.Sacar(1600);
                    Console.WriteLine("Retirada com sucesso!");
                }
                catch (Exception ex) // faz uma chamada para a linha 20
                {
                    Console.WriteLine(ex.Message); // apresenta a menssagem saldo insufiencite da linha 20

                }
                finally // finaliza idependendte de haver saque ou nao 
                {
                    Console.WriteLine("Obrigado!");
                }
            }
        }
    
}